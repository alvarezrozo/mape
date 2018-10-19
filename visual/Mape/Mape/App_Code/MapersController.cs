using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EN = upb.mape.entity;
using CT = upb.mape.controller;

public class MapersController : ApiController
{
    CT.Mapers controller = new CT.Mapers();

    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public EN.Maper Get(String username)
    {

        EN.Maper maper = controller.getMaper(username);

        return maper;
    }

    public EN.Result Get(String username, String password)
    {
        bool result = controller.authenticateMaper(username, password);

        var answer = new EN.Result()
        {
            Answer = result
        };

        return answer;
    }

    // POST api/<controller>
    public void Post(EN.Maper maper)
    {
        bool result = controller.createMaper(maper);
    }

    // PUT api/<controller>/5
    public void Put(EN.Maper maper)
    {
        bool result = controller.editMaper(maper);
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
