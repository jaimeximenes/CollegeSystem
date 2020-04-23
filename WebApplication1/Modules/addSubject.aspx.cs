using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Services;

namespace WebApplication1
{
    public partial class AddSubject : System.Web.UI.Page
    {
        SubjectService service = new SubjectService();
        protected void Page_Load(object sender, EventArgs e)
        {
            BindDataTable();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            bool succes = service.SubjectRegister(txtSubject.Text, Convert.ToInt32(txtIdProfessor.Text));
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
        public void BindDataTable()
        {
            RepeaterSubject.DataSource = service.ShowSubjects();
            RepeaterSubject.DataBind();

        }
        protected void RepeaterSubject_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case ("delet"):
                    {
                        service.DeleteSubject(e.CommandArgument.ToString());
                        BindDataTable();
                        break;
                    }
                case ("edit"):
                    {
                        break;
                    }
            }
        }


        protected void Button2_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "Save")
            {
                var subject = service.ShowRegistredSubject(Convert.ToInt32(e.CommandArgument));
                TextBox1.Text = subject.Name;
                TextBox2.Text = subject.TecharId;
                BindDataTable();
            }

        }


        //protected void delet_Click(object sender, RepeaterCommandEventArgs e)
        //{
        //    switch (e.CommandName)
        //    {
        //        case ("delet"):
        //            {
        //                break;
        //            }
        //    }
        //}
    }
}