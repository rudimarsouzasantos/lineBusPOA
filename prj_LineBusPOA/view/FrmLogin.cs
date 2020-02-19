using LineBusPOA.controller;
using LineBusPOA.model;
using LineBusPOA.view;
using MaterialSkin;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LineBusPOA
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        ServiceBusPOA.ServiceBusPOAClient serviceBusPOA = new ServiceBusPOA.ServiceBusPOAClient();
        ControllerLogin controllerLogin = new ControllerLogin();
        User user = new User();

        public FrmLogin()
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

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void materialSingleLineTextField1_Click(object sender, EventArgs e)
        {
        }

        private void materialSingleLineTextField1_Click_1(object sender, EventArgs e)
        {
        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (controllerLogin.validation(txtNome.Text, txtSenha.Text) == false)
                {
                    FrmMessageBox message = new FrmMessageBox();
                    message.message("PREENCHA O LOGIN!!!");
                    message.Show();
                }

                if (controllerLogin.validation(txtNome.Text, txtSenha.Text))
                {

                    if (serviceBusPOA.searchUserNamePass(txtNome.Text, txtSenha.Text))
                    {
                        FrmSearchLineBus frmSearchBusPOA = new FrmSearchLineBus();
                        frmSearchBusPOA.Show();
                        this.Hide();
                    }
                    else
                    {
                        FrmCadastro frmCadastro = new FrmCadastro();
                        frmCadastro.Show();
                        this.Hide();
                    }
                }

            }
            catch (Exception msgError)
            {
                if (msgError.ToString().Contains("Não havia um ponto de extremidade em escuta"))
                {
                    FrmMessageBox message = new FrmMessageBox();
                    message.message("WEBSERVICE SEM CONEXÃO");
                    message.Show();
                }
            }
        }
    }
}