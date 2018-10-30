using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EN = upb.mape.entity;
using CT = upb.mape.controller;

public class UsersController : ApiController
{

    private CT.Users controller = new CT.Users();

    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5

    public EN.User Get(decimal? id)
    {
        EN.User result = controller.authenticateUser(id);

        return result;
    }

    public EN.User Get(String username, String password)
    {
        EN.User result = controller.getUser(username, password);

        return result;
    }

    // POST api/<controller>
    public void Post(EN.User user)
    {

        bool result=controller.createUser(user);

    }

    // PUT api/<controller>/5
    public void Put(EN.User user)
    {
        bool result = controller.editUser(user);
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
