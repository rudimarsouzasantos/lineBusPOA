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
    public partial class FrmMessageBox : MaterialSkin.Controls.MaterialForm
    {
        
        public FrmMessageBox()
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

            lblMessage.BackColor = Color.CornflowerBlue;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void FrmMessageBox_Load(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void message(String message)
        {
            lblMessage.Text = message;
        }
    }
}
