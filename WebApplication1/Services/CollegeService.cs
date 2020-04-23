using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Services;

namespace WebApplication1
{
    public class CollegeService : ContextDefault
    {
        public bool StudentRegister(string name, int age, int idSubject)
        {
            var id = Context.Students.OrderByDescending(i => i.IdStudent).FirstOrDefault().IdStudent + 1;
            var studentTemp = new Students();
            studentTemp.IdStudent = id;
            studentTemp.Name = name;
            studentTemp.Age = Convert.ToInt16(age);
            studentTemp.IdSubject = idSubject;
            var student = Context.Students.Where(s => s.Name == name).FirstOrDefault();
            if (student == null)
            {
                Context.Students.Add(studentTemp);
                Context.SaveChanges();
                return true;
            }
            return false;

        }
        public void DeleteStudent(string idStudent)
        {
            var student = Context.Students.Where(s => s.IdStudent == idStudent).First();
            Context.Students.Remove(student);
            Context.SaveChanges();
        }

        public List<Students> ShowStudent()
        {
            return Context.Students.ToList();

        }
        public Students ShowStudents(string studentId)
        {
            var studentTemp = Context.Students.FirstOrDefault(i => i.IdStudent == studentId);
            return studentTemp;
        }

        public void UpdateStudent(string id, string name, short age, int IdSubject)
        {
            var subjectTemp = Context.Students.Where(p => p.IdStudent == id).FirstOrDefault();
            subjectTemp.Name = name;
            subjectTemp.Age = age;
            subjectTemp.IdSubject = IdSubject;
            Context.SaveChanges();

        }
        public void getStudentsPerSubject()
        {
            var result = from s in Context.Students.ToList()
                         join n in Context.Scores.ToList() on s.IdSubject equals n.IdSubject
                         orderby s.Name
                         select new
                         {
                             s = s.Name
                         ,
                             n.Note1
                         };
        }
    }
}