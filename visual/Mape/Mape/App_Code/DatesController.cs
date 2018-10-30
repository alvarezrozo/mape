using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EN = upb.mape.entity;
using CT = upb.mape.controller;

public class DatesController : ApiController
{
    CT.Dates controller = new CT.Dates();
    // GET api/<controller>
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<controller>/5
    public List<EN.AcceptedDate> Get(decimal userID)
    {
        return controller.getRequest(userID);
    }

    public EN.Date Get(decimal dateID, String dateT)
    {
        return controller.getDate(dateID);
    }

    // POST api/<controller>
    public void Post(EN.Date date)
    {
        bool result = controller.createDate(date);
    }

    // PUT api/<controller>/5
    public void Put(EN.Date date)
    {
        bool result = controller.changeStatus(date);
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
    }
}
