using LineBusPOA.controller;
using LineBusPOA.model;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineBusPOA.view
{
    public partial class FrmCadastro : MaterialSkin.Controls.MaterialForm
    {
        ControllerLogin controllerLogin = new ControllerLogin();
        ServiceBusPOA.ServiceBusPOAClient serviceBusPOA = new ServiceBusPOA.ServiceBusPOAClient();
        User user = new User();
        public FrmCadastro()
        {
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;



            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            if (controllerLogin.validation(txtNome.Text, txtSenha.Text)==false)
            {
                FrmMessageBox message = new FrmMessageBox();
                message.message("PREENCHA O CADASTRO");
                message.Show();
            }

            if(controllerLogin.validation(txtNome.Text, txtSenha.Text))
            {
                controllerLogin.CheckLogin(txtNome.Text, txtSenha.Text);
                
                ServiceBusPOA.user user = new ServiceBusPOA.user();
                user.id = user.id;
                user.nome = txtNome.Text;
                user.senha = txtSenha.Text;

                serviceBusPOA.registerUser(user);
                this.Hide();

                FrmSearchLineBus frmSearchLineBus = new FrmSearchLineBus();
                frmSearchLineBus.Show();
            }
        }
    }
}
