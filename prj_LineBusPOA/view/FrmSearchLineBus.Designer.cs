namespace LineBusPOA.view
{
    partial class FrmSearchLineBus
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
            this.cbxLineBusName = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.cbxLineBusCod = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.lstViewLineBus = new System.Windows.Forms.ListView();
            this.collumLine = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.collumCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // cbxLineBusName
            // 
            this.cbxLineBusName.FormattingEnabled = true;
            this.cbxLineBusName.ItemHeight = 13;
            this.cbxLineBusName.Location = new System.Drawing.Point(12, 111);
            this.cbxLineBusName.Name = "cbxLineBusName";
            this.cbxLineBusName.Size = new System.Drawing.Size(311, 21);
            this.cbxLineBusName.TabIndex = 1;
            this.cbxLineBusName.SelectedIndexChanged += new System.EventHandler(this.cbxLineBusName_SelectedIndexChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(106, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Nome da Lnha";
            // 
            // cbxLineBusCod
            // 
            this.cbxLineBusCod.FormattingEnabled = true;
            this.cbxLineBusCod.ItemHeight = 13;
            this.cbxLineBusCod.Location = new System.Drawing.Point(329, 111);
            this.cbxLineBusCod.Name = "cbxLineBusCod";
            this.cbxLineBusCod.Size = new System.Drawing.Size(158, 21);
            this.cbxLineBusCod.TabIndex = 3;
            this.cbxLineBusCod.SelectedIndexChanged += new System.EventHandler(this.cbxLineBusCod_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(329, 89);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Código";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // lstViewLineBus
            // 
            this.lstViewLineBus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.collumLine,
            this.collumCod});
            this.lstViewLineBus.Location = new System.Drawing.Point(12, 210);
            this.lstViewLineBus.Name = "lstViewLineBus";
            this.lstViewLineBus.Size = new System.Drawing.Size(475, 97);
            this.lstViewLineBus.TabIndex = 5;
            this.lstViewLineBus.UseCompatibleStateImageBehavior = false;
            // 
            // collumLine
            // 
            this.collumLine.Text = "LINHA";
            this.collumLine.Width = 200;
            // 
            // collumCod
            // 
            this.collumCod.Text = "CÓDIGO";
            // 
            // FrmSearchLineBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.lstViewLineBus);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.cbxLineBusCod);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cbxLineBusName);
            this.Name = "FrmSearchLineBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procure sua Linha";
            this.Load += new System.EventHandler(this.FrmSearchLineBuscs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLineBusName;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ComboBox cbxLineBusCod;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ListView lstViewLineBus;
        private System.Windows.Forms.ColumnHeader collumLine;
        private System.Windows.Forms.ColumnHeader collumCod;
    }
}