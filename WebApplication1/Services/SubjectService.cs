using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Services
{
    public class SubjectService : ContextDefault
    {
        public void UpdateSubject(string id, string name, string techarId)
        {
            var subjectTemp = Context.Subjects.Where(p => p.IdSubject == id).FirstOrDefault();
            subjectTemp.Name = name;
            subjectTemp.TecharId = techarId;
            Context.SaveChanges();

        }

        public bool SubjectRegister(string name, int idProfessor)
        {

            var subjectTemp = new Subjects();

            var id = Context.Subjects.OrderByDescending(i => i.IdSubject).FirstOrDefault().IdSubject + 1;
            subjectTemp.IdSubject = id.ToString();
            subjectTemp.Name = name;
            subjectTemp.TecharId = idProfessor.ToString();
            var subject = Context.Subjects.Where(i => i.Name == name).FirstOrDefault();
            if (subject == null)
            {
                Context.Subjects.Add(subjectTemp);
                Context.SaveChanges();
                return true;
            }
            return false;

        }

        public void DeleteSubject(string idSubject)
        {
            var subject = Context.Subjects.Where(i => i.IdSubject == idSubject).First();
            Context.Subjects.Remove(subject);
            Context.SaveChanges();
        }

        public List<Subjects> ShowSubjects()
        {
            return Context.Subjects.ToList();

        }

        public Subjects ShowRegistredSubject(int subjectID)
        {
            var subjectTemp = Context.Subjects.FirstOrDefault(i => i.IdSubject == subjectID.ToString());
            return subjectTemp;
        }
    }
}