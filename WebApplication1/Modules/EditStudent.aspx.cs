using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class EditStudent : System.Web.UI.Page
    {
        public string Id { get; set; }

        CollegeService service = new CollegeService();
        protected void Page_Load(object sender, EventArgs e)
        {
            Id = Request.QueryString["id"];
            if (!IsPostBack)
            {
                BindData(Id);
            }

        }
        private void BindData(string id)
        {
            var studentTemp = service.ShowStudents(id);
            TxtName.Text = studentTemp.Name;
            TxtAge.Text = studentTemp.Age.ToString();
            TxtIdSubject.Text = studentTemp.IdSubject.ToString();
        }

        protected void SaveStudent_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string age = TxtAge.Text;
            string idSubject = TxtIdSubject.Text;
            service.UpdateStudent(Id, name, Convert.ToInt16(age), Convert.ToInt32(idSubject));
            Response.Redirect("/AddStudent");
        }
    }
}
