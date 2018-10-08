using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using RestApp1.Models;

namespace RestApp1.Controllers
{
  public class ValuesController : ApiController
  {
    List<Account> _values = new List<Account>();


    ValuesController()
    {
      string jsonStr = @"
            [
                {
                  'Email': 'james@example.com',
                  'Active': true,
                  'CreatedDate': '2013-01-20T00:00:00Z',
                  'Roles': ['User','Admin']
                },
{
                  'Email': 'mike@example.com',
                  'Active': false,
                  'CreatedDate': '2013-11-12T00:00:00Z',
                  'Roles': ['User']
                }
            ]
            ";

      _values = JsonConvert.DeserializeObject<List<Account>>(jsonStr);


    }

    // GET api/values
    public IEnumerable<Account> Get()
    {
      return _values;

    }

    // GET api/values/5
    public Account Get(int position)
    {
      return _values.ElementAt(position);
    }

    // POST api/values
    public void Post([FromBody]string value)
    {
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
