namespace RegistroArreglado.UI.Registros
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.CIdSLT = new System.Windows.Forms.NumericUpDown();
            this.DescripcionTXT = new System.Windows.Forms.RichTextBox();
            this.CEliminarBoton = new System.Windows.Forms.Button();
            this.CGuardarBoton = new System.Windows.Forms.Button();
            this.CNuevoBoton = new System.Windows.Forms.Button();
            this.CBuscarBoton = new System.Windows.Forms.Button();
            this.CIdLabel = new System.Windows.Forms.Label();
            this.CDescripcion = new System.Windows.Forms.Label();
            this.CSuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CIdSLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CIdSLT
            // 
            this.CIdSLT.Location = new System.Drawing.Point(43, 67);
            this.CIdSLT.Name = "CIdSLT";
            this.CIdSLT.Size = new System.Drawing.Size(80, 22);
            this.CIdSLT.TabIndex = 0;
            // 
            // DescripcionTXT
            // 
            this.DescripcionTXT.Location = new System.Drawing.Point(36, 129);
            this.DescripcionTXT.Name = "DescripcionTXT";
            this.DescripcionTXT.Size = new System.Drawing.Size(284, 148);
            this.DescripcionTXT.TabIndex = 1;
            this.DescripcionTXT.Text = "";
            // 
            // CEliminarBoton
            // 
            this.CEliminarBoton.Location = new System.Drawing.Point(253, 322);
            this.CEliminarBoton.Name = "CEliminarBoton";
            this.CEliminarBoton.Size = new System.Drawing.Size(92, 54);
            this.CEliminarBoton.TabIndex = 13;
            this.CEliminarBoton.Text = "ELIMINAR";
            this.CEliminarBoton.UseVisualStyleBackColor = true;
            // 
            // CGuardarBoton
            // 
            this.CGuardarBoton.Location = new System.Drawing.Point(123, 322);
            this.CGuardarBoton.Name = "CGuardarBoton";
            this.CGuardarBoton.Size = new System.Drawing.Size(100, 54);
            this.CGuardarBoton.TabIndex = 12;
            this.CGuardarBoton.Text = "GUARDAR";
            this.CGuardarBoton.UseVisualStyleBackColor = true;
            // 
            // CNuevoBoton
            // 
            this.CNuevoBoton.Location = new System.Drawing.Point(18, 322);
            this.CNuevoBoton.Name = "CNuevoBoton";
            this.CNuevoBoton.Size = new System.Drawing.Size(84, 54);
            this.CNuevoBoton.TabIndex = 11;
            this.CNuevoBoton.Text = "NUEVO";
            this.CNuevoBoton.UseVisualStyleBackColor = true;
            // 
            // CBuscarBoton
            // 
            this.CBuscarBoton.Location = new System.Drawing.Point(199, 30);
            this.CBuscarBoton.Name = "CBuscarBoton";
            this.CBuscarBoton.Size = new System.Drawing.Size(90, 54);
            this.CBuscarBoton.TabIndex = 14;
            this.CBuscarBoton.Text = "BUSCAR";
            this.CBuscarBoton.UseVisualStyleBackColor = true;
            // 
            // CIdLabel
            // 
            this.CIdLabel.AutoSize = true;
            this.CIdLabel.Location = new System.Drawing.Point(12, 67);
            this.CIdLabel.Name = "CIdLabel";
            this.CIdLabel.Size = new System.Drawing.Size(25, 17);
            this.CIdLabel.TabIndex = 15;
            this.CIdLabel.Text = "ID:";
            // 
            // CDescripcion
            // 
            this.CDescripcion.AutoSize = true;
            this.CDescripcion.Location = new System.Drawing.Point(123, 99);
            this.CDescripcion.Name = "CDescripcion";
            this.CDescripcion.Size = new System.Drawing.Size(100, 17);
            this.CDescripcion.TabIndex = 16;
            this.CDescripcion.Text = "DESCRIPCIÓN";
            // 
            // CSuperErrorProvider
            // 
            this.CSuperErrorProvider.ContainerControl = this;
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 410);
            this.Controls.Add(this.CDescripcion);
            this.Controls.Add(this.CIdLabel);
            this.Controls.Add(this.CBuscarBoton);
            this.Controls.Add(this.CEliminarBoton);
            this.Controls.Add(this.CGuardarBoton);
            this.Controls.Add(this.CNuevoBoton);
            this.Controls.Add(this.DescripcionTXT);
            this.Controls.Add(this.CIdSLT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Consultas";
            this.Text = "CONSULTAS DE USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.CIdSLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CSuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown CIdSLT;
        private System.Windows.Forms.RichTextBox DescripcionTXT;
        private System.Windows.Forms.Button CEliminarBoton;
        private System.Windows.Forms.Button CGuardarBoton;
        private System.Windows.Forms.Button CNuevoBoton;
        private System.Windows.Forms.Button CBuscarBoton;
        private System.Windows.Forms.Label CIdLabel;
        private System.Windows.Forms.Label CDescripcion;
        private System.Windows.Forms.ErrorProvider CSuperErrorProvider;
    }
}