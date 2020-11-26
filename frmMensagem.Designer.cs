
namespace Oficina
{
    partial class frmMensagem
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblMensagem2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(12, 20);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(548, 23);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "label1";
            this.lblMensagem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMensagem2
            // 
            this.lblMensagem2.Location = new System.Drawing.Point(15, 67);
            this.lblMensagem2.Name = "lblMensagem2";
            this.lblMensagem2.Size = new System.Drawing.Size(545, 68);
            this.lblMensagem2.TabIndex = 1;
            this.lblMensagem2.Text = "label2";
            this.lblMensagem2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frmMensagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 178);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMensagem2);
            this.Controls.Add(this.lblMensagem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMensagem";
            this.Text = "frmMensagem";
            this.Load += new System.EventHandler(this.frmMensagem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMensagem2;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Timer timer1;
    }
}