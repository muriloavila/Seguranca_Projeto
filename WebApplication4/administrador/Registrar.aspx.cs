using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebMatrix.WebData;

namespace WebApplication4.administrador
{
    public partial class Registrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!WebSecurity.UserExists(txtNome.Text))
            {
                WebSecurity.CreateUserAndAccount(txtNome.Text, txtSenha.Text, new { Email = txtEmail.Text });
                Roles.AddUserToRole(txtNome.Text, "administrador");
                Response.Redirect("../Login.aspx");
            }
            else
            {
                lblAlerta.Text = "Não foi Possivel criar o Usuario Acima!!! :(";
            }
        }

        protected void lbtnDelete_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[4];
            nomes[0] = "Murilo";
            nomes[1] = "Giovanna";
            nomes[2] = "Bijuzinha";
            nomes[3] = "Helena";
            Roles.AddUsersToRole(nomes, "administrador");
        }
    }
}