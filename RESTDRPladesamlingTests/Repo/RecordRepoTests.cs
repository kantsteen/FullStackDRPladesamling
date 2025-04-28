using Microsoft.VisualStudio.TestTools.UnitTesting;
using RESTDRPladesamling.Model;
using RESTDRPladesamling.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace RESTDRPladesamling.Repo.Tests
{
   

    [TestClass()]

    
    public class RecordRepoTests
    {
        private RecordRepo _repo;

        [TestInitialize]
        public void Setup()
        {
            _repo = new RecordRepo();
            //Add to repo
            
        }

        [TestMethod()]
        public void GetAllTest()
        {
            IEnumerable<Record> record = _repo.GetAll();
            //Test for records
            Assert.AreEqual(0, record.Count());
        }
    }
}