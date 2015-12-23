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
    public class EvaluationManagementBLL
    {
        private EvaluationManagementDAL evaluationManagementDb;
        private HttpContext context;
        public EvaluationManagementBLL()
        {
            evaluationManagementDb = new EvaluationManagementDAL();
            context = HttpContext.Current;
        }
        public IEnumerable<EvaluationManagement> GetAllEvaluationManagements()
        {
            return evaluationManagementDb.GetAllEvaluationManagements().Where(r => r.IsDelete == "0");
        }
        public EvaluationManagement GetById(int Id)
        {
            return evaluationManagementDb.GetById(Id);
        }
        public void Create(EvaluationManagement evaluationManagement)
        {
            evaluationManagement.CreatedOn = System.DateTime.Now;
            evaluationManagement.CreatedBy = context.Session["USERNAME"].ToString();
            evaluationManagement.IsDelete = "0";
            evaluationManagementDb.Create(evaluationManagement);
        }
        public void Update(EvaluationManagement evaluationManagement)
        {
            evaluationManagement.ModifiedOn = System.DateTime.Now;
            evaluationManagement.ModifiedBy = context.Session["USERNAME"].ToString();
            evaluationManagement.IsDelete = "0";
            evaluationManagementDb.Update(evaluationManagement);
        }
        public void Delete(EvaluationManagement evaluationManagement)
        {
            evaluationManagement.IsDelete = "1";
            evaluationManagementDb.Delete(evaluationManagement);
        }
    }
}
