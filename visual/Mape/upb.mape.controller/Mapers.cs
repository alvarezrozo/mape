using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = upb.mape.broker;
using EN = upb.mape.entity;

namespace upb.mape.controller
{
    public class Mapers
    {

        private DA.mapeEntities db = new DA.mapeEntities();

        public bool createMaper(EN.Maper maper)
        {


            bool result = false;

            try
            {

                var datos = new DA.maper
                {
                    username = maper.Username,
                    name = maper.Name,
                    last_name = maper.Fullname,
                    implements = maper.Items,
                    city = maper.City,
                    address = maper.Address,
                    mail = maper.Email,
                    cell = maper.Phone,
                    password = maper.Password,
                    rate=3,
                    cost=maper.Cost
                };

                db.mapers.Add(datos);

                db.SaveChanges();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public EN.Maper getMaper(decimal? id)
        {
            try
            {
                DA.maper maper = db.mapers.Where(x => x.id == id).First();

                EN.Maper finded_maper = new EN.Maper();

                finded_maper.IDUser = maper.id;
                finded_maper.Username = maper.username;
                finded_maper.Name = maper.name;
                finded_maper.Fullname = maper.last_name;
                finded_maper.Address = maper.address;
                finded_maper.Email = maper.mail;
                finded_maper.Phone = maper.cell;
                finded_maper.Items = maper.implements;
                finded_maper.City = maper.city;
                finded_maper.Cost = maper.cost;
                finded_maper.Rate = maper.rate;

                return finded_maper;

            }
            catch (InvalidOperationException ex)
            {
                EN.User finded_user = new EN.User();

                finded_user.IDUser = 0;
                finded_user.Username = null;
                finded_user.Name = null;
                finded_user.Fullname = null;
                finded_user.Password = null;
                finded_user.Address = null;
                finded_user.Email = null;
                finded_user.Phone = null;
                finded_user.Items = null;
                finded_user.City = null;

                throw ex;
            }
        }

        public EN.Maper authenticateMaper(String username, String password)
        {
            EN.Maper finded_maper = new EN.Maper();
            try
            {
                DA.maper maper = db.mapers.Where(x => x.username == username && x.password == password).First();

                

                finded_maper.IDUser = maper.id;
                finded_maper.Username = maper.username;
                finded_maper.Name = maper.name;
                finded_maper.Fullname = maper.last_name;
                finded_maper.Password = maper.password;
                finded_maper.Address = maper.address;
                finded_maper.Email = maper.mail;
                finded_maper.Phone = maper.cell;
                finded_maper.Items = maper.implements;
                finded_maper.City = maper.city;
                finded_maper.Cost = maper.cost;
                finded_maper.Rate = maper.rate;

                return finded_maper;

            }
            catch (InvalidOperationException ex)
            {
                EN.Maper finded_user = new EN.Maper();

                finded_user.IDUser = 0;
                finded_user.Username = null;
                finded_user.Name = null;
                finded_user.Fullname = null;
                finded_user.Password = null;
                finded_user.Address = null;
                finded_user.Email = null;
                finded_user.Phone = null;
                finded_user.Items = null;
                finded_user.City = null;
                return finded_user;
                throw ex;
            }
        }

        public List<EN.Maper> allMapers()
        {
            List<EN.Maper> list = new List<EN.Maper>();

            try
            {

                foreach (var item in db.mapers)
                {
                    EN.Maper itemEN = new EN.Maper();
                    itemEN.IDUser = item.id;
                    itemEN.Name = item.name;
                    itemEN.Fullname = item.last_name;
                    itemEN.City = item.city;
                    itemEN.Cost = item.cost;
                    itemEN.Email = item.mail;
                    itemEN.Address = item.address;
                    itemEN.Phone = item.cell;
                    itemEN.Items = item.implements;
                    itemEN.Rate = item.rate;
                    list.Add(itemEN);
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }

            return list;

        }

        public bool editMaper(EN.Maper maper)
        {
            bool result = false;

            try
            {
                DA.maper edited_maper = db.mapers.Where(x => x.username == maper.Username).First();

                edited_maper.name = maper.Name;
                edited_maper.last_name = maper.Fullname;
                edited_maper.address = maper.Address;
                edited_maper.mail = maper.Email;
                edited_maper.implements = maper.Items;
                edited_maper.cell = maper.Phone;
                edited_maper.password = maper.Password;
                edited_maper.city = maper.City;
                edited_maper.rate = maper.Rate;
                edited_maper.cost = maper.Cost;

                db.SaveChanges();

                result = true;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }

            return result;
        }

    }
}
