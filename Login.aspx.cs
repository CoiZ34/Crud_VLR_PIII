using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Entity.Infrastructure;
using Proyecto_Web_VLR.Models;

namespace Proyecto_Web_VLR
{
    public partial class Login : System.Web.UI.Page
    {
        DbModels db = new DbModels();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] != null )
                    {
                Response.Redirect("/Login.aspx"); // CAMBIAR A ("/Login.aspx")
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                LabelMSJ.Text = "Has dejado campos vacios, vuelve a intentarlo";
                return;
            }
            var UserEncontrad = db.login.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (UserEncontrad != null)
            {
                Session["Usuario"] = UserEncontrad.Username;
                Response.Redirect("/vlr/Index");

            }
            else{
                LabelMSJ.Text = "El usuario o la contrase;a estan incorrectos.";

            }
        }
    }
}