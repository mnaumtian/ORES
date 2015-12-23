using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AnswerTypeDAL
    {
        private ORESEntities db;
        public AnswerTypeDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<AnswerType> GetAllAnswerTypes()
        {
            return db.AnswerTypes.ToList();
        }
        public AnswerType GetById(int Id)
        {
            return db.AnswerTypes.Find(Id);
        }
        public void Create(AnswerType answertype)
        {
            db.AnswerTypes.Add(answertype);
            Save();
        }
        public void Update(AnswerType answertype)
        {
            db.Entry(answertype).State = EntityState.Modified;
            Save();
        }
        public void Delete(AnswerType answertype)
        {
            db.Entry(answertype).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
