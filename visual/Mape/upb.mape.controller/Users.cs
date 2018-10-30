using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = upb.mape.broker;
using EN = upb.mape.entity;

namespace upb.mape.controller
{
    public class Users
    {

        private DA.mapeEntities db = new DA.mapeEntities();

        public bool createUser(EN.User user)
        {

            bool result = false;

            try
            {

                var datos = new DA.user
                {
                    username = user.Username,
                    name = user.Name,
                    last_name=user.Fullname,
                    implements=user.Items,
                    city=user.City,
                    address=user.Address,
                    mail=user.Email,
                    cell=user.Phone,
                    password=user.Password
                };

                db.users.Add(datos);
                db.SaveChanges();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public EN.User getUser(String username, String password)
        {
            try
            {
                DA.user user = db.users.Where(x => x.username == username && x.password == password).First();

                EN.User finded_user = new EN.User();

                finded_user.IDUser = (int)user.id;
                finded_user.Username = user.username;
                finded_user.Password = user.password;
                finded_user.Name = user.name;
                finded_user.Fullname = user.last_name;
                finded_user.Address = user.address;
                finded_user.Email = user.mail;
                finded_user.Phone = user.cell;
                finded_user.Items = user.implements;
                finded_user.City = user.city;

                return finded_user;

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

                return finded_user;
                throw ex;
            }
        }

        public EN.User authenticateUser(decimal? id)
        {
            try
            {
                DA.user user = db.users.Where(x => x.id == id).First();

                EN.User finded_user = new EN.User();

                finded_user.IDUser = (int)user.id;
                finded_user.Username = user.username;
                finded_user.Name = user.name;
                finded_user.Fullname = user.last_name;
                finded_user.Address = user.address;
                finded_user.Email = user.mail;
                finded_user.Phone = user.cell;
                finded_user.Items = user.implements;
                finded_user.City = user.city;

                return finded_user;

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

                return finded_user;
                throw ex;
            }
        }

        public bool editUser(EN.User user)
        {
            bool result = false;

            try
            {
                DA.user edited_user = db.users.Where(x => x.username == user.Username).First();

                edited_user.name = user.Name;
                edited_user.last_name = user.Fullname;
                edited_user.address = user.Address;
                edited_user.mail = user.Email;
                edited_user.implements = user.Items;
                edited_user.cell = user.Phone;
                edited_user.password = user.Password;
                edited_user.city = user.City;

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
