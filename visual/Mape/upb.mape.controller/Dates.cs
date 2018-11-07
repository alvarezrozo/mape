using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = upb.mape.broker;
using EN = upb.mape.entity;

namespace upb.mape.controller
{
    public class Dates
    {
        private DA.mapeEntities db = new DA.mapeEntities();

        public bool createDate(EN.Date date)
        {
            bool result = false;

            try
            {
                var datos = new DA.date()
                {
                    idClient = date.IDClient,
                    idMaper = date.IDMaper,
                    date1 = date.DateD,
                    hour = date.DateT,
                    status = "En espera"
                };

                db.dates.Add(datos);
                db.SaveChanges();

                result = true;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public bool changeStatus(EN.Date date)
        {
            bool result = false; ;

            try
            {
                DA.date finded_date = db.dates.Where(x => x.id == date.IDDate).FirstOrDefault();

                finded_date.status = date.Status;

                db.SaveChanges();

            }catch(Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<EN.AcceptedDate> getDatesWait(decimal? id)
        {
            List<EN.AcceptedDate> list = new List<EN.AcceptedDate>();

            try
            {

                var l2query = from dates in db.dates
                              join mapers in db.mapers on dates.idMaper equals mapers.id
                              join users in db.users on dates.idClient equals users.id
                              where dates.idMaper == id && dates.status == "En espera"
                              select new { Maper = mapers, Date = dates, User=users };

                foreach (var item in l2query)
                {
                    EN.AcceptedDate itemEN = new EN.AcceptedDate();
                    itemEN.IDDate = item.Date.id;
                    itemEN.IDMaper = item.User.id;
                    itemEN.MaperName = item.User.name + " " + item.User.last_name;
                    itemEN.Cost = item.Maper.cost;
                    itemEN.DateD = item.Date.date1;
                    itemEN.DateT = item.Date.hour;
                    list.Add(itemEN);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public List<EN.AcceptedDate> getDatesAccept(decimal? id)
        {
            List<EN.AcceptedDate> list = new List<EN.AcceptedDate>();

            try
            {

                var l2query = from dates in db.dates
                              join mapers in db.mapers on dates.idMaper equals mapers.id
                              join users in db.users on dates.idClient equals users.id
                              where dates.idMaper == id && dates.status == "Aceptada" && dates.date1 >= System.DateTime.Now
                              select new { Maper = mapers, Date = dates, User=users };

                foreach (var item in l2query)
                {
                    EN.AcceptedDate itemEN = new EN.AcceptedDate();
                    itemEN.IDDate = item.Date.id;
                    itemEN.IDMaper = item.User.id;
                    itemEN.MaperName = item.User.name + " " + item.User.last_name;
                    itemEN.Cost = item.Maper.cost;
                    itemEN.DateD = item.Date.date1;
                    itemEN.DateT = item.Date.hour;
                    list.Add(itemEN);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public List<EN.AcceptedDate> getDatesAcceptPast(decimal? id)
        {
            List<EN.AcceptedDate> list = new List<EN.AcceptedDate>();

            try
            {

                var l2query = from dates in db.dates
                              join mapers in db.mapers on dates.idMaper equals mapers.id
                              join users in db.users on dates.idClient equals users.id
                              where dates.idMaper == id && dates.status == "Aceptada" && dates.date1 < System.DateTime.Now
                              select new { Maper = mapers, Date = dates, User=users };

                foreach (var item in l2query)
                {
                    EN.AcceptedDate itemEN = new EN.AcceptedDate();
                    itemEN.IDDate = item.Date.id;
                    itemEN.IDMaper = item.User.id;
                    itemEN.MaperName = item.User.name + " " + item.User.last_name;
                    itemEN.Cost = item.Maper.cost;
                    itemEN.DateD = item.Date.date1;
                    itemEN.DateT = item.Date.hour;
                    list.Add(itemEN);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public List<EN.AcceptedDate> getRequest(decimal id)
        {
            List<EN.AcceptedDate> list = new List<EN.AcceptedDate>();

            try
            {

                var l2query = from dates in db.dates
                              join mapers in db.mapers on dates.idMaper equals mapers.id
                              join users in db.users on dates.idClient equals users.id
                              where dates.idClient == id && dates.status=="Aceptada" && dates.date1 >= System.DateTime.Now
                              select new {Maper=mapers, Date=dates, User=users};

                foreach(var item in l2query)
                {
                    EN.AcceptedDate itemEN = new EN.AcceptedDate();
                    itemEN.IDDate = item.Date.id;
                    itemEN.IDMaper = item.Maper.id;
                    itemEN.MaperName = item.Maper.name + " " + item.Maper.last_name;
                    itemEN.Cost = item.Maper.cost;
                    itemEN.DateD = item.Date.date1;
                    itemEN.DateT = item.Date.hour;
                    list.Add(itemEN);
                }

            }catch(Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public List<EN.AcceptedDate> getRequestPast(decimal id)
        {
            List<EN.AcceptedDate> list = new List<EN.AcceptedDate>();

            try
            {

                var l2query = from dates in db.dates
                              join mapers in db.mapers on dates.idMaper equals mapers.id
                              join users in db.users on dates.idClient equals users.id
                              where dates.idClient == id && dates.status == "Aceptada" && dates.date1 < System.DateTime.Now
                              select new { Maper = mapers, Date = dates, User=users };

                foreach (var item in l2query)
                {
                    EN.AcceptedDate itemEN = new EN.AcceptedDate();
                    itemEN.IDDate = item.Date.id;
                    itemEN.IDMaper = item.Maper.id;
                    itemEN.MaperName = item.Maper.name + " " + item.Maper.last_name;
                    itemEN.Cost = item.Maper.cost;
                    itemEN.DateD = item.Date.date1;
                    itemEN.DateT = item.Date.hour;
                    list.Add(itemEN);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;
        }

        public EN.Date getDate(decimal id)
        {
            EN.Date date = new EN.Date();

            try
            {
                var item = db.dates.Where(x => x.id == id).FirstOrDefault();

                date.IDDate = item.id;
                date.IDClient = item.idClient;
                date.IDMaper = item.idMaper;
                date.DateD = item.date1;
                date.DateT = item.hour;
                date.Status = item.status;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return date;
        }
    }
}
