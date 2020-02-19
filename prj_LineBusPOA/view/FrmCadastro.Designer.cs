namespace LineBusPOA.view
{
    partial class FrmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCadastro = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "Senha";
            this.txtSenha.Location = new System.Drawing.Point(73, 243);
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(348, 23);
            this.txtSenha.TabIndex = 5;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "Nome";
            this.txtNome.Location = new System.Drawing.Point(73, 165);
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(348, 23);
            this.txtNome.TabIndex = 4;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCadastro.Depth = 0;
            this.btnCadastro.Location = new System.Drawing.Point(168, 328);
            this.btnCadastro.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Primary = true;
            this.btnCadastro.Size = new System.Drawing.Size(146, 50);
            this.btnCadastro.TabIndex = 6;
            this.btnCadastro.Text = "CADASTRO";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialRaisedButton btnCadastro;
    }
}