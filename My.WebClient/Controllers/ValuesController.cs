using My.Models;
using My.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using My.BusinessLayer;

namespace My.WebClient.Controllers
{
    public class ValuesController : ApiController
    {
        private ICustomerIdentifyStrategy _repoStrategy;
        public ValuesController(ICustomerIdentifyStrategy repo)
        {
            _repoStrategy = repo;
        }

       //private ITestClass _testClass;
        //public ValuesController(ITestClass testclass)
        //{
        //    _testClass = testclass;

        //   // _repoStrategy = new CustomerIdentifyStrategy(new Repository<DataAccess.Customer>(new DbContext()));
        //}
        //// GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }


        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]Customer value)
        {

            _repoStrategy.AddCustomer(value);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
