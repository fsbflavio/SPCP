using SPCP.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace teste
{
    
    
    /// <summary>
    ///This is a test class for FichaProdutoTest and is intended
    ///to contain all FichaProdutoTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FichaProdutoTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Alterar
        ///</summary>
        [TestMethod()]
        public void AlterarTest()
        {
            FichaProduto target = new FichaProduto(); // TODO: Initialize to an appropriate value
            int id = 50; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Alterar(id);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetFichaProduto
        ///</summary>
        [TestMethod()]
        public void GetFichaProdutoTest()
        {
            int id = 0; // TODO: Initialize to an appropriate value
            
            ArrayList actual;
            actual = FichaProduto.GetFichaProduto(id);
            Assert.IsNull(actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
