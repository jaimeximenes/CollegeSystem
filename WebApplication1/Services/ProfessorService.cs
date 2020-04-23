using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Services
{
    public class ProfessorService : ContextDefault
    {
        public void DeleteTeacher(int techarId)
        {
            var professor = Context.Teachers.Where(p => p.TecharId == techarId).First();
            Context.Teachers.Remove(professor);
            Context.SaveChanges();
        }

        public void UpdateTeacher(int id, string name, string age, string cpf)
        {
            var professor = Context.Teachers.Where(p => p.TecharId == id).FirstOrDefault();
            professor.Name = name;
            professor.Age = age;
            professor.CPF = cpf;
            Context.SaveChanges();
        }
        public int totalProfessors { get; set; }
        public bool TeacherAdd(string name, string CPF, string age)
        {

            var teacherTemp = new Teachers();
            teacherTemp.TecharId = Context.Teachers.OrderByDescending(t => t.TecharId).FirstOrDefault().TecharId + 1;
            teacherTemp.Name = name;
            teacherTemp.CPF = CPF;
            teacherTemp.Age = age;
            var teacher = Context.Teachers.Where(i => i.CPF == CPF).FirstOrDefault();

            if (teacher == null)
            {
                Context.Teachers.Add(teacherTemp);
                Context.SaveChanges();
                return true;
            }
            return false;

        }

        public Teachers GetRegistrerProfessor(int teacherId)
        {
            var teacherTemp = Context.Teachers.FirstOrDefault(i => i.TecharId == teacherId);
            return teacherTemp;
        }

        public List<Teachers> GetProfessor()
        {
            return Context.Teachers.ToList();
        }

    }
}