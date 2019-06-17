
using ClassLibrary1.Context;
using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using System.Data.Entity;
using ClassLibrary1.CreationDemande;
using AutoFixture;
using ClassLibrary1.Dto;
using ClassLibrary1.Mappeur;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private IOracleContext _dbContextOracle;
        private IContext _dbContext;
        private IDbSet<utilisateur> _dbSet;
        private ICreationDemande creerDemande;
        private Fixture fixture;
        private Mappeur mappeur;

        [TestInitialize]
        public void TestMethod1()
        {
            
            _dbContextOracle = Substitute.For<IOracleContext>();
            _dbSet = Substitute.For<IDbSet<utilisateur>>();
            _dbContext = Substitute.For<IContext>();
            _dbContextOracle.OracleContext.Returns(_dbContext);
            _dbContextOracle.OracleContext.utilisateur.Returns(_dbSet);
            mappeur = Substitute.For<Mappeur>();
            creerDemande = new CreationDemande(_dbContextOracle, mappeur);
            fixture = new Fixture();
        }


        [TestMethod]
        public void IndexShouldNotIncludeDiscontinuedProducts()
        {
            UserDto userDto = fixture.Create<UserDto>();         
            int i= creerDemande.CreerDemande(userDto);
            Assert.AreEqual(i, userDto.id);

        }

    }
}
