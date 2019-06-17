using Microsoft.VisualStudio.TestTools.UnitTesting;

using ClassLibrary1.Context;

using NSubstitute;
using System.Data.Entity;
using AutoFixture;
using ClassLibrary1.Dto;
using ClassLibrary1.Mappeur;
using System.Linq;
using System.Collections.Generic;

namespace ClassLibrary1.ObtentionDemande.Tests
{
    [TestClass()]
    public class ObtentionDemandeTests
    {
        private IOracleContext _dbContextOracle;
        private IContext _dbContext;
        private IDbSet<utilisateur> _dbSet;
        private IObtentionDemande obtenirDemande;
        private Fixture fixture;
        private IMappeur mappeur;

        [TestInitialize]
        public void TestMethod1()
        {

            IQueryable<utilisateur> customers =
                        new List<utilisateur>
                        {
                            new utilisateur { id = 0 },
                            new utilisateur { id = 5 },
                            new utilisateur { id = 5 },
                            new utilisateur { id = 0 },
                            new utilisateur { id = 5 }
                        }.AsQueryable();

            _dbContextOracle = Substitute.For<IOracleContext>();
            _dbSet = Substitute.For<IDbSet<utilisateur>>();

            _dbSet.Provider.Returns(customers.Provider);
            _dbSet.Expression.Returns(customers.Expression);
            _dbSet.ElementType.Returns(customers.ElementType);
            _dbSet.GetEnumerator().Returns(customers.GetEnumerator());


            _dbSet.Find(Arg.Any<object[]>()).Returns(callinfo =>
            {
                object[] idValues = callinfo.Arg<object[]>();
                if (idValues != null && idValues.Length == 1)
                {
                    int requestedId = (int)idValues[0];
                    return customers.FirstOrDefault(p => p.id == requestedId);
                }

                return null;
            });


            mappeur = Substitute.For<Mappeur.Mappeur>();

            _dbContext = Substitute.For<IContext>();

            _dbContext.utilisateur.Returns(_dbSet);

            _dbContextOracle.OracleContext.Returns(_dbContext);

            obtenirDemande = new ObtentionDemande(_dbContextOracle, mappeur);
            fixture = new Fixture();
        }

        [TestMethod()]
        public void ObtenirDemandeTest()
        {
                   
             int idUser = 5; 

             UserDto dto = obtenirDemande.ObtenirDemande(idUser);

            Assert.AreEqual(idUser,dto.id);
        }

        [TestMethod()]
        public void ObtenirDemandeTestNull()
        {

            int idUser = 5;

            UserDto dto = obtenirDemande.ObtenirDemande(4352);

            Assert.IsNull(dto);
        }
    }
}