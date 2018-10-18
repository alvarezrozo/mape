using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = upb.mape.broker;
using EN = upb.mape.entity;

namespace upb.mape.controller
{
    public class UsersComments
    {

        private DA.mapeEntities db = new DA.mapeEntities();

        public bool createComment(EN.UserComment comments)
        {
            bool result = false;

            try
            {
                var datos = new DA.comments_users
                {
                    idClient=comments.IDClient,
                    message=comments.Comment,
                    value=comments.Value,
                    date=comments.DateD
                };

                db.comments_users.Add(datos);

                db.SaveChanges();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<EN.UserComment> getComments(int userID) {

            List<EN.UserComment> list = new List<EN.UserComment>();

            try
            {

                var l2query = db.comments_users.Where(x => x.idClient == userID );

                foreach (var item in l2query)
                {
                    EN.UserComment itemEN = new EN.UserComment();
                    itemEN.IDComment = item.id;
                    itemEN.IDClient = item.idClient;
                    itemEN.DateD = item.date;
                    itemEN.Comment = item.message;
                    itemEN.Value = item.value;
                    list.Add(itemEN);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }


            return list;

        }

    }
}
