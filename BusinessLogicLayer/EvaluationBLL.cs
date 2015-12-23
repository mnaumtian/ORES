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
    public class EvaluationBLL
    {
        private EvaluationDAL evaluationDb;
        private HttpContext context;
        public EvaluationBLL()
        {
            evaluationDb = new EvaluationDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<Evaluation> GetAllEvaluations()
        {
            return evaluationDb.GetAllEvaluations().Where(r => r.IsDelete == "0");
        }
        public Evaluation GetById(int Id)
        {
            return evaluationDb.GetById(Id);
        }
        public void Create(Evaluation evaluation)
        {
            evaluation.CreatedOn = System.DateTime.Now;
            evaluation.CreatedBy = context.Session["USERNAME"].ToString();
            evaluation.IsDelete = "0";
            evaluationDb.Create(evaluation);
        }
        public void Update(Evaluation evaluation)
        {
            evaluation.ModifiedOn = System.DateTime.Now;
            evaluation.ModifiedBy = context.Session["USERNAME"].ToString();
            evaluation.IsDelete = "0";
            evaluationDb.Update(evaluation);
        }
        public void Delete(Evaluation evaluation)
        {
            evaluation.IsDelete = "1";
            evaluationDb.Delete(evaluation);
        }
    }
}
