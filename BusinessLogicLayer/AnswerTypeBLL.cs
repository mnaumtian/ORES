using BusinessObjectLayer;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BusinessLogicLayer
{
    public class AnswerTypeBLL
    {
        private AnswerTypeDAL answertypedb;
        private HttpContext context;
        public AnswerTypeBLL()
        {
            answertypedb = new AnswerTypeDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<AnswerType> GetAllAnswerTypes()
        {
            return answertypedb.GetAllAnswerTypes().Where(r => r.IsDelete == "0");
        }
        public AnswerType GetById(int Id)
        {
            return answertypedb.GetById(Id);
        }
        public void Create(AnswerType answertype)
        {
            answertype.CreatedOn = System.DateTime.Now;
            answertype.CreatedBy = context.Session["USERNAME"].ToString();
            answertype.IsDelete = "0";
            answertypedb.Create(answertype);
        }
        public void Update(AnswerType answertype)
        {
            answertype.ModifiedOn = System.DateTime.Now;
            answertype.ModifiedBy = context.Session["USERNAME"].ToString();
            answertype.IsDelete = "0";
            answertypedb.Update(answertype);
        }
        public void Delete(AnswerType answertype)
        {
            answertype.IsDelete = "1";
            answertypedb.Delete(answertype);
        }
    }
}
