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
    public class QuestionBLL
    {
        private QuestionDAL questiondb;
        private HttpContext context;
        public QuestionBLL()
        {
            questiondb = new QuestionDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<Question> GetAllQuestions()
        {
            return questiondb.GetAllQuestions().Where(r => r.IsDelete == "0");
        }
        public Question GetById(int Id)
        {
            return questiondb.GetById(Id);
        }
        public void Create(Question question)
        {
            question.CreatedOn = System.DateTime.Now;
            question.CreatedBy = context.Session["USERNAME"].ToString();
            question.IsDelete = "0";
            questiondb.Create(question);
        }
        public void Update(Question question)
        {
            question.ModifiedOn = System.DateTime.Now;
            question.ModifiedBy = context.Session["USERNAME"].ToString();
            question.IsDelete = "0";
            questiondb.Update(question);
        }
        public void Delete(Question question)
        {
            question.IsDelete = "1";
            questiondb.Delete(question);
        }
    }
}
