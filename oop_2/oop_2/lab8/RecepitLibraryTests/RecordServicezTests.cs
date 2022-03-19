using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecepitLibrary;
using RecepitLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepitLibrary.Tests
{
    [TestClass()]
    public class RecordServicezTests
    {
        private string PATH_CONNECTION_STRING = @"Data Source=.\SQLEXPRESS;Initial Catalog=Recepit;Integrated Security=True";
        private UnifyingRecepit accounting;
        private RecepitDAO recepitDAO;

        [TestInitialize]
        public void Initialize()
        {
            FactoryDAO factory = FactoryDAO.GetFactory(PATH_CONNECTION_STRING);
            accounting = new UnifyingRecepit(factory);
            recepitDAO = new RecepitDAO() {ReceiptId = 100,ReceiptNumber = 2, ServiceId =1 };
        }

        [TestMethod]
        public void TestInsert()
        {
            accounting.RecepitInterface.Insert(recepitDAO);
            Assert.AreEqual(8, accounting.RecepitInterface.GetAllRecepits().Length);
        }

        [TestMethod]
        public void TestUpdate()
        {
            RecepitDAO tmp = new RecepitDAO() { ReceiptId = 100, ReceiptNumber = 2, ServiceId = 1 };
            accounting.RecepitInterface.Update(recepitDAO, tmp);
            recepitDAO = tmp;
            Assert.AreEqual(8, accounting.RecepitInterface.GetAllRecepits().Length);
        }
        [TestMethod]
        public void TestDelete()
        {
            recepitDAO.ReceiptId = 100;
            accounting.RecepitInterface.Delete(recepitDAO);
            Assert.AreEqual(7, accounting.RecepitInterface.GetAllRecepits().Length);
        }
    }
}