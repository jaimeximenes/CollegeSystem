using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Services;

namespace WebApplication1
{
    public partial class EditProfessor : System.Web.UI.Page
    {
        public string Id { get; set; }

        ProfessorService service = new ProfessorService();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                BindData(Convert.ToInt32(Id));
            }

        }

        private void BindData(int id)
        {
            var professorTemp = service.GetRegistrerProfessor(id);
            TxtName.Text = professorTemp.Name;
            TxtAge.Text = professorTemp.Age;
            TxtCPF.Text = professorTemp.CPF;

        }

        protected void SaveTeacher_Click(object sender, EventArgs e)
        {
            
            string name = TxtName.Text;
            string age = TxtAge.Text;
            string cpf = TxtCPF.Text;
            service.UpdateTeacher(Convert.ToInt32(Id), name, age, cpf);
            Response.Redirect("/AddProfessor");
        }
    }
}