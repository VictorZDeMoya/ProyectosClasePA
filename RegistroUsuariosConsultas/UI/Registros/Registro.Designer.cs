namespace RegistroArreglado.UI.Registros
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.NombreTXT = new System.Windows.Forms.TextBox();
            this.LvlUsuarioTXT = new System.Windows.Forms.TextBox();
            this.EmailTXT = new System.Windows.Forms.TextBox();
            this.ContrasenaTXT = new System.Windows.Forms.TextBox();
            this.NombreUsuarioTXT = new System.Windows.Forms.TextBox();
            this.FechaIngresoSLT = new System.Windows.Forms.DateTimePicker();
            this.IdSLT = new System.Windows.Forms.NumericUpDown();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.NuevoBoton = new System.Windows.Forms.Button();
            this.GuardarBoton = new System.Windows.Forms.Button();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.LvlUsuarioLabel = new System.Windows.Forms.Label();
            this.NombreUsuarioLabel = new System.Windows.Forms.Label();
            this.ContrasenaLabel = new System.Windows.Forms.Label();
            this.FechaIngresoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdSLT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NombreTXT
            // 
            this.NombreTXT.Location = new System.Drawing.Point(97, 101);
            this.NombreTXT.Name = "NombreTXT";
            this.NombreTXT.Size = new System.Drawing.Size(207, 22);
            this.NombreTXT.TabIndex = 0;
            // 
            // LvlUsuarioTXT
            // 
            this.LvlUsuarioTXT.Location = new System.Drawing.Point(132, 185);
            this.LvlUsuarioTXT.Name = "LvlUsuarioTXT";
            this.LvlUsuarioTXT.Size = new System.Drawing.Size(172, 22);
            this.LvlUsuarioTXT.TabIndex = 1;
            // 
            // EmailTXT
            // 
            this.EmailTXT.Location = new System.Drawing.Point(97, 144);
            this.EmailTXT.Name = "EmailTXT";
            this.EmailTXT.Size = new System.Drawing.Size(207, 22);
            this.EmailTXT.TabIndex = 2;
            // 
            // ContrasenaTXT
            // 
            this.ContrasenaTXT.Location = new System.Drawing.Point(128, 268);
            this.ContrasenaTXT.Name = "ContrasenaTXT";
            this.ContrasenaTXT.Size = new System.Drawing.Size(176, 22);
            this.ContrasenaTXT.TabIndex = 3;
            // 
            // NombreUsuarioTXT
            // 
            this.NombreUsuarioTXT.Location = new System.Drawing.Point(156, 231);
            this.NombreUsuarioTXT.Name = "NombreUsuarioTXT";
            this.NombreUsuarioTXT.Size = new System.Drawing.Size(148, 22);
            this.NombreUsuarioTXT.TabIndex = 4;
            // 
            // FechaIngresoSLT
            // 
            this.FechaIngresoSLT.Location = new System.Drawing.Point(141, 313);
            this.FechaIngresoSLT.Name = "FechaIngresoSLT";
            this.FechaIngresoSLT.Size = new System.Drawing.Size(163, 22);
            this.FechaIngresoSLT.TabIndex = 5;
            // 
            // IdSLT
            // 
            this.IdSLT.Location = new System.Drawing.Point(127, 52);
            this.IdSLT.Name = "IdSLT";
            this.IdSLT.Size = new System.Drawing.Size(56, 22);
            this.IdSLT.TabIndex = 6;
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(229, 24);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(90, 54);
            this.BuscarBoton.TabIndex = 7;
            this.BuscarBoton.Text = "BUSCAR";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // NuevoBoton
            // 
            this.NuevoBoton.Location = new System.Drawing.Point(12, 372);
            this.NuevoBoton.Name = "NuevoBoton";
            this.NuevoBoton.Size = new System.Drawing.Size(84, 54);
            this.NuevoBoton.TabIndex = 8;
            this.NuevoBoton.Text = "NUEVO";
            this.NuevoBoton.UseVisualStyleBackColor = true;
            this.NuevoBoton.Click += new System.EventHandler(this.NuevoBoton_Click);
            // 
            // GuardarBoton
            // 
            this.GuardarBoton.Location = new System.Drawing.Point(117, 372);
            this.GuardarBoton.Name = "GuardarBoton";
            this.GuardarBoton.Size = new System.Drawing.Size(100, 54);
            this.GuardarBoton.TabIndex = 9;
            this.GuardarBoton.Text = "GUARDAR";
            this.GuardarBoton.UseVisualStyleBackColor = true;
            this.GuardarBoton.Click += new System.EventHandler(this.GuardarBoton_Click);
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(247, 372);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(92, 54);
            this.EliminarBoton.TabIndex = 10;
            this.EliminarBoton.Text = "ELIMINAR";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            this.EliminarBoton.Click += new System.EventHandler(this.EliminarBoton_Click);
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(12, 101);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(72, 17);
            this.NombreLabel.TabIndex = 11;
            this.NombreLabel.Text = "NOMBRE:";
            // 
            // LvlUsuarioLabel
            // 
            this.LvlUsuarioLabel.AutoSize = true;
            this.LvlUsuarioLabel.Location = new System.Drawing.Point(9, 190);
            this.LvlUsuarioLabel.Name = "LvlUsuarioLabel";
            this.LvlUsuarioLabel.Size = new System.Drawing.Size(117, 17);
            this.LvlUsuarioLabel.TabIndex = 12;
            this.LvlUsuarioLabel.Text = "NIVEL USUARIO:";
            // 
            // NombreUsuarioLabel
            // 
            this.NombreUsuarioLabel.AutoSize = true;
            this.NombreUsuarioLabel.Location = new System.Drawing.Point(9, 231);
            this.NombreUsuarioLabel.Name = "NombreUsuarioLabel";
            this.NombreUsuarioLabel.Size = new System.Drawing.Size(138, 17);
            this.NombreUsuarioLabel.TabIndex = 13;
            this.NombreUsuarioLabel.Text = "NOMBRE USUARIO:";
            // 
            // ContrasenaLabel
            // 
            this.ContrasenaLabel.AutoSize = true;
            this.ContrasenaLabel.Location = new System.Drawing.Point(12, 273);
            this.ContrasenaLabel.Name = "ContrasenaLabel";
            this.ContrasenaLabel.Size = new System.Drawing.Size(107, 17);
            this.ContrasenaLabel.TabIndex = 14;
            this.ContrasenaLabel.Text = "CONTRASEÑA:";
            // 
            // FechaIngresoLabel
            // 
            this.FechaIngresoLabel.AutoSize = true;
            this.FechaIngresoLabel.Location = new System.Drawing.Point(12, 318);
            this.FechaIngresoLabel.Name = "FechaIngresoLabel";
            this.FechaIngresoLabel.Size = new System.Drawing.Size(124, 17);
            this.FechaIngresoLabel.TabIndex = 15;
            this.FechaIngresoLabel.Text = "FECHA INGRESO:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(9, 144);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(52, 17);
            this.EmailLabel.TabIndex = 16;
            this.EmailLabel.Text = "EMAIL:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(41, 57);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 17);
            this.IdLabel.TabIndex = 17;
            this.IdLabel.Text = "ID:";
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.FechaIngresoLabel);
            this.Controls.Add(this.ContrasenaLabel);
            this.Controls.Add(this.NombreUsuarioLabel);
            this.Controls.Add(this.LvlUsuarioLabel);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.EliminarBoton);
            this.Controls.Add(this.GuardarBoton);
            this.Controls.Add(this.NuevoBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.IdSLT);
            this.Controls.Add(this.FechaIngresoSLT);
            this.Controls.Add(this.NombreUsuarioTXT);
            this.Controls.Add(this.ContrasenaTXT);
            this.Controls.Add(this.EmailTXT);
            this.Controls.Add(this.LvlUsuarioTXT);
            this.Controls.Add(this.NombreTXT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.Text = "REGISTRO DE USUARIOS";
            ((System.ComponentModel.ISupportInitialize)(this.IdSLT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NombreTXT;
        private System.Windows.Forms.TextBox LvlUsuarioTXT;
        private System.Windows.Forms.TextBox EmailTXT;
        private System.Windows.Forms.TextBox ContrasenaTXT;
        private System.Windows.Forms.TextBox NombreUsuarioTXT;
        private System.Windows.Forms.DateTimePicker FechaIngresoSLT;
        private System.Windows.Forms.NumericUpDown IdSLT;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button NuevoBoton;
        private System.Windows.Forms.Button GuardarBoton;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.Label LvlUsuarioLabel;
        private System.Windows.Forms.Label NombreUsuarioLabel;
        private System.Windows.Forms.Label ContrasenaLabel;
        private System.Windows.Forms.Label FechaIngresoLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
    }
}