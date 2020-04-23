using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Services;

namespace WebApplication1
{
    public partial class Notes : System.Web.UI.Page
    {
        NotesService noteService = new NotesService();

        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataTable();

        }
        protected void BindDataTable()
        {
            RepeaterNotes.DataSource = noteService.getNotesPorMateria();
            RepeaterNotes.DataBind();
        }

        protected void RepeaterNotes_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            noteService.getNotesPorMateria();
        }
    }
}