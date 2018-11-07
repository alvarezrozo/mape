using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EN = upb.mape.entity;
using CT = upb.mape.controller;

public class UsersCommentsController : ApiController
{
    CT.UsersComments controller = new CT.UsersComments();

    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public List<EN.UserComment> Get(int id)
    {
        return controller.getComments(id);
    }

    // POST api/<controller>
    public void Post(EN.UserComment comment)
    {
        controller.createComment(comment);
    }

    // PUT api/<controller>/5
    public void Put(EN.User user)
    {
        CT.Users userAux = new CT.Users();
        userAux.updateRating(user);
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
