namespace RegistroArreglado
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuRegIstroSLT = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroUsuariosSLT = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultasSLT = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRegIstroSLT,
            this.MenuConsultasSLT});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(307, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuRegIstroSLT
            // 
            this.MenuRegIstroSLT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistroUsuariosSLT});
            this.MenuRegIstroSLT.Name = "MenuRegIstroSLT";
            this.MenuRegIstroSLT.Size = new System.Drawing.Size(88, 24);
            this.MenuRegIstroSLT.Text = "REGISTRO";
            // 
            // RegistroUsuariosSLT
            // 
            this.RegistroUsuariosSLT.Name = "RegistroUsuariosSLT";
            this.RegistroUsuariosSLT.Size = new System.Drawing.Size(216, 26);
            this.RegistroUsuariosSLT.Text = "Usuarios";
            this.RegistroUsuariosSLT.Click += new System.EventHandler(this.RegistroUsuariosSLT_Click);
            // 
            // MenuConsultasSLT
            // 
            this.MenuConsultasSLT.Name = "MenuConsultasSLT";
            this.MenuConsultasSLT.Size = new System.Drawing.Size(101, 24);
            this.MenuConsultasSLT.Text = "CONSULTAS";
            this.MenuConsultasSLT.Click += new System.EventHandler(this.MenuConsultasSLT_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 69);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Magneto", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VentanaPrincipal";
            this.Text = "REGISTRO USUARIOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuRegIstroSLT;
        private System.Windows.Forms.ToolStripMenuItem RegistroUsuariosSLT;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultasSLT;
    }
}

