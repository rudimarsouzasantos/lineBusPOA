namespace LineBusPOA.view
{
    partial class FrmMessageBox
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
            this.lblMessage = new MaterialSkin.Controls.MaterialLabel();
            this.btnOK = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Depth = 0;
            this.lblMessage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.Location = new System.Drawing.Point(56, 34);
            this.lblMessage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(41, 19);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "eeee";
            this.lblMessage.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btnOK
            // 
            this.btnOK.Depth = 0;
            this.btnOK.ForeColor = System.Drawing.Color.Transparent;
            this.btnOK.Location = new System.Drawing.Point(85, 81);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(123, 57);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // FrmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lblMessage);
            this.Name = "FrmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMessageBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblMessage;
        private MaterialSkin.Controls.MaterialRaisedButton btnOK;
    }
}