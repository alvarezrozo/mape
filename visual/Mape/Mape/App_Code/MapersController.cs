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
    public List<EN.Maper> Get()
    {
        return controller.allMapers();
    }

    // GET api/<controller>/5
    public EN.Maper Get(decimal? id)
    {

        EN.Maper maper = controller.getMaper(id);

        return maper;
    }

    public EN.Maper Get(String username, String password)
    {
        EN.Maper result = controller.authenticateMaper(username, password);

        return result;
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
