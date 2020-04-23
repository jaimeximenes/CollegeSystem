using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Services;

namespace WebApplication1
{
    public partial class AddProfessor : System.Web.UI.Page
    {
        private ProfessorService service;
        public ProfessorService Service
        {
            get
            {
                if (service == null)
                    service = new Services.ProfessorService();

                return service;
            }
            set { service = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataTable();
        }

        protected void RepeaterTeacher_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case ("delete"):
                    {
                        Service.DeleteTeacher(Convert.ToInt32(e.CommandArgument));
                        BindDataTable();
                        break;
                    }
                case ("edit"):
                    {
                        var professor = Service.GetRegistrerProfessor(Convert.ToInt32(e.CommandArgument));
                        TxtName.Text = professor.Name;
                        TxtCPF.Text = professor.CPF;
                        TxtAge.Text = professor.Age;

                        break;
                    }
            }
        }
        protected void BindDataTable()
        {
            RepeaterTeacher.DataSource = Service.GetProfessor().ToList();
            RepeaterTeacher.DataBind();
        }

        protected void SaveTeacher_Click(object sender, EventArgs e)
        {
            bool succes = Service.TeacherAdd(TxtName.Text, TxtCPF.Text, TxtAge.Text);

            if (succes == true)
            {
                Label1.Text = "salvo com sucesso";
            }
            else
            {
                Label1.Text = "Is already exist";
            }

            BindDataTable();
        }

    }
}