using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Services;

namespace WebApplication1
{
    public partial class EditSubject : System.Web.UI.Page
    {
        public string Id { get; set; }
        SubjectService service = new SubjectService();
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
            var subjectTemp = service.ShowRegistredSubject(Convert.ToInt32(id));
            TxtName.Text = subjectTemp.Name;
            TxtProId.Text = subjectTemp.TecharId;
        }

        protected void SaveSubject_Click(object sender, EventArgs e)
        {
            string name = TxtName.Text;
            string proId = TxtProId.Text;
            service.UpdateSubject(Id, name, proId);
            Response.Redirect("/addSubject");

        }
    }
}