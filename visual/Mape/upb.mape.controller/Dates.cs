using System;
using System.Collections.Generic;
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
                    idClient=date.IDClient,
                    idMaper=date.IDMaper,
                    date1=date.DateD,
                    hour=date.DateT,
                    status=date.Status
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

        public List<EN.Date> getRequest(decimal id)
        {
            List<EN.Date> list = new List<EN.Date>();

            try
            {

                var l2query = db.dates.Where(x => x.idClient == id && x.status == "Aprobado");

                foreach(var item in l2query)
                {
                    EN.Date itemEN = new EN.Date();
                    itemEN.IDDate = item.id;
                    itemEN.IDClient = item.idClient;
                    itemEN.IDMaper = item.idMaper;
                    itemEN.DateD = item.date1;
                    itemEN.DateT = item.hour;
                    itemEN.Status = item.status;
                    list.Add(itemEN);
                }

            }catch(Exception ex)
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
