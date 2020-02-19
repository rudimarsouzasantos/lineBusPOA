using LineBusPOA.util;
using MaterialSkin;
using System;
using System.Windows.Forms;

namespace LineBusPOA.view
{
    public partial class FrmSearchLineBus : MaterialSkin.Controls.MaterialForm
    {
        ServiceBusPOA.ServiceBusPOAClient serviceBusPOA = new ServiceBusPOA.ServiceBusPOAClient();
        FormatString format = new FormatString();
        String nome = String.Empty;
        String codigo = String.Empty;

        public FrmSearchLineBus()
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

        private void FrmSearchLineBuscs_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (var lineBusPOA in serviceBusPOA.searchAll())
                {
                    nome = format.formatString(lineBusPOA.nome);
                    codigo = format.formatString(lineBusPOA.codigo);

                    cbxLineBusName.Items.Add(nome);
                    cbxLineBusCod.Items.Add(codigo);
                }
            }
            catch(Exception errorMsg)
            {
                if(serviceBusPOA.State.Equals(null))
                {

                }
            }
        }

        private void cbxLineBusName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewLineBus.Items.Clear();
            String name = format.formatString(cbxLineBusName.SelectedItem.ToString());
            
            foreach (var lineBusPOA in serviceBusPOA.searchAll())
            { 
                if (format.formatString(lineBusPOA.nome.Replace("\\", "")).StartsWith(name))
                {
                    lstViewLineBus.View = View.Details;
                    lstViewLineBus.Items.Add(format.formatString(lineBusPOA.nome)).SubItems.Add(format.formatString(lineBusPOA.codigo));
                }
            }
        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void cbxLineBusCod_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstViewLineBus.Items.Clear();
            String codigo = cbxLineBusCod.SelectedItem.ToString();
            foreach (var lineBusPOA in serviceBusPOA.searchAll())
            {
                if (lineBusPOA.codigo.Equals(codigo))
                {
                    lstViewLineBus.View = View.Details;
                    lstViewLineBus.Items.Add(lineBusPOA.nome).SubItems.Add(lineBusPOA.codigo);
                }
            }
        }
    }
}
