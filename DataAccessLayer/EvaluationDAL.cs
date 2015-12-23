using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class EvaluationDAL
    {
        private ORESEntities db;
        public EvaluationDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<Evaluation> GetAllEvaluations()
        {
            return db.Evaluations.ToList();
        }
        public Evaluation GetById(int Id)
        {
            return db.Evaluations.Find(Id);
        }
        public void Create(Evaluation evaluation)
        {
            db.Evaluations.Add(evaluation);
            Save();
        }
        public void Update(Evaluation evaluation)
        {
            db.Entry(evaluation).State = EntityState.Modified;
            Save();
        }
        public void Delete(Evaluation evaluation)
        {
            db.Entry(evaluation).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
