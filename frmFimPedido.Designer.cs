namespace Oficina
{
    partial class frmFimPedido
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
            Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFimPedido));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            bunifuGradientPanel1.BackColor = System.Drawing.Color.Teal;
            bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            bunifuGradientPanel1.Quality = 10;
            bunifuGradientPanel1.Size = new System.Drawing.Size(95, 592);
            bunifuGradientPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(116, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "ORÇAMENTO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(116, 125);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 64);
            this.button2.TabIndex = 2;
            this.button2.Text = "IMPRIMIR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Aqua;
            this.button3.Location = new System.Drawing.Point(121, 213);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(240, 64);
            this.button3.TabIndex = 3;
            this.button3.Text = "DINHEIRO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(121, 308);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(240, 64);
            this.button4.TabIndex = 4;
            this.button4.Text = "CARTAO";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frmFimPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 592);
            this.Controls.Add(this.button4);
            this.Controls.Add(bunifuGradientPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFimPedido";
            this.Text = "frmFimPedido";
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}