using BusinessObjectLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class QuestionDAL
    {
        private ORESEntities db;
        public QuestionDAL()
        {
            db = new ORESEntities();
        }
        public IEnumerable<Question> GetAllQuestions()
        {
            return db.Questions.ToList();
        }
        public Question GetById(int Id)
        {
            return db.Questions.Find(Id);
        }
        public void Create(Question question)
        {
            db.Questions.Add(question);
            Save();
        }
        public void Update(Question question)
        {
            db.Entry(question).State = EntityState.Modified;
            Save();
        }
        public void Delete(Question question)
        {
            db.Entry(question).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
