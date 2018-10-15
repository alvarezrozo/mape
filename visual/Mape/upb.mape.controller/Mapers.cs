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
                    password = maper.Password
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

        public EN.Maper getMaper(String username)
        {
            try
            {
                DA.maper maper = db.mapers.Where(x => x.username == username).First();

                EN.Maper finded_maper = new EN.Maper();

                finded_maper.IDUser = (int)maper.id;
                finded_maper.Username = maper.username;
                finded_maper.Name = maper.name;
                finded_maper.Fullname = maper.last_name;
                finded_maper.Password = maper.password;
                finded_maper.Address = maper.address;
                finded_maper.Email = maper.mail;
                finded_maper.Phone = maper.cell;
                finded_maper.Items = maper.implements;
                finded_maper.City = maper.city;

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
