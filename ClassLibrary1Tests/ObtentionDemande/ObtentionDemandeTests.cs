using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1.ObtentionDemande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.ObtentionDemande.Tests
{
    [TestClass()]
    public class ObtentionDemandeTests
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

        [TestMethod()]
        public void ObtenirDemandeTest()
        {
            Assert.Fail();
        }
    }
}