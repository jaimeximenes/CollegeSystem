using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AddStudent : System.Web.UI.Page
    {
        CollegeService service = new CollegeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataTable();
        }

        public void BindDataTable()
        {
            RepeaterStudents.DataSource = service.ShowStudent();
            RepeaterStudents.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool succes = service.StudentRegister(TxtName.Text,Convert.ToInt32(TxtAge.Text), Convert.ToInt32(TxtIdSubject.Text));
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

        protected void RepeaterStudents_ItemCommand(object sender, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case ("delete"):
                    {
                        service.DeleteStudent(e.CommandArgument.ToString());
                        BindDataTable();
                        break;
                    }
                case ("edit"):
                    {
                       
                        break;
                    }
            }

        }
    }
}