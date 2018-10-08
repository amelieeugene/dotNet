using RestApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace RestApp1.Controllers
{
  public class CustomerController : ApiController
  {
    sandboxEntities edb;

    public CustomerController()
    {
      edb = new sandboxEntities();
      
    }

    // GET api/<controller>
    public IEnumerable<customer> Get()
    {
      var customesList = (from c in edb.customers
                          select c).ToList< customer>();
        
        //edb.customers.ToList<customer>();
      return customesList;
    }

    // GET api/<controller>/5
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<controller>
    public void Post([FromBody]string value)
    {
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
  }
}