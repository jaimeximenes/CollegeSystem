using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Services
{
    public class NotesService : ContextDefault
    {
        Scores score = new Scores();
        public void getNotes(Scores scores)
        {
            var id = Context.Scores.Count() + 1;
            scores.IdNotes = id;
            Context.Scores.Add(scores);
            Context.SaveChanges();

        }

        
        public object getNotesPorMateria()
        {
          

            var consulta = from s in Context.Students
                           join n in Context.Scores on s.IdSubject equals n.IdSubject
                           //where n.Note4 >= 6
                           select new
                           {
                               Name = s.Name,
                               Nota1 = n.Note1,
                               //note2 = n.Note2,
                               //note3 = n.Note3,
                               //note4 = n.Note4,
                              // avarage = n.Avarage
                           };
            //
            return consulta;
        }
        //public IQueryable<dynamic> getAprovedStudents()
        //{
        //               return;
        //}
    }
}