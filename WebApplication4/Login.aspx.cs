using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace WebApplication4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (WebSecurity.IsAuthenticated)
            {
                lbtnLogout.Visible = true;
            }
            if (Request.QueryString["ReturnUrl"] != null)
            {
                lblAlerta.Text = "Você quis entrar na area sem se Logar! Se Logue Ai!";
            }
        }

        protected void btnLogar_Click(object sender, EventArgs e)
        {
            bool success = WebSecurity.Login(txtLogin.Text, txtSenha.Text, false);
            if (success)
            {
                string ReturnUrl = Request.QueryString["ReturnUrl"];
                if(string.IsNullOrEmpty(ReturnUrl))
                {
                    Response.Redirect("administrador/Index.aspx");
                }
                else
                {
                    Response.Redirect(ReturnUrl);
                    
                }
            }
            else
            {
                txtLogin.Text = "";
                txtSenha.Text = "";
                lblAlerta.Text = "Usuario ou Senha Inválidos";
            }
        }

        protected void lbtnLogout_Click(object sender, EventArgs e)
        {
            WebSecurity.Logout();
            Response.Redirect("/Login.aspx");
        }
    }
}