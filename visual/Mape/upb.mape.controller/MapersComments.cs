using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DA = upb.mape.broker;
using EN = upb.mape.entity;

namespace upb.mape.controller
{
    public class MapersComments
    {
        private DA.mapeEntities db = new DA.mapeEntities();

        public bool createComment(EN.MaperComment comments)
        {
            bool result = false;

            try
            {
                var datos = new DA.comments_mapers
                {
                    idMaper = comments.IDMaper,
                    message = comments.Comment,
                    value = comments.Value,
                    date = comments.DateD
                };

                db.comments_mapers.Add(datos);

                db.SaveChanges();

                result = true;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public List<EN.MaperComment> getComments(int maperID)
        {

            List<EN.MaperComment> list = new List<EN.MaperComment>();

            try
            {

                var l2query = db.comments_mapers.Where(x => x.idMaper == maperID);

                foreach (var item in l2query)
                {
                    EN.MaperComment itemEN = new EN.MaperComment();
                    itemEN.IDComment = item.id;
                    itemEN.IDMaper = item.idMaper;
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
