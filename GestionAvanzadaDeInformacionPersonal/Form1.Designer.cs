namespace GestionAvanzadaDeInformacionPersonal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tbxDirección = new System.Windows.Forms.TextBox();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.mcalFechaNac = new System.Windows.Forms.MonthCalendar();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbFechaNAc = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabDatos.SuspendLayout();
            this.pnlGenero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabDatos);
            this.tabControlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(776, 357);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabDatos
            // 
            this.tabDatos.Controls.Add(this.lbCorreo);
            this.tabDatos.Controls.Add(this.lbFechaNAc);
            this.tabDatos.Controls.Add(this.lbGenero);
            this.tabDatos.Controls.Add(this.lbEdad);
            this.tabDatos.Controls.Add(this.mcalFechaNac);
            this.tabDatos.Controls.Add(this.lbDireccion);
            this.tabDatos.Controls.Add(this.lbNombre);
            this.tabDatos.Controls.Add(this.nudEdad);
            this.tabDatos.Controls.Add(this.pnlGenero);
            this.tabDatos.Controls.Add(this.tbxCorreo);
            this.tabDatos.Controls.Add(this.tbxDirección);
            this.tabDatos.Controls.Add(this.tbxNombre);
            this.tabDatos.Location = new System.Drawing.Point(4, 25);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabDatos.Size = new System.Drawing.Size(768, 328);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Datos personales";
            this.tabDatos.UseVisualStyleBackColor = true;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(167, 49);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 22);
            this.tbxNombre.TabIndex = 0;
            // 
            // tbxDirección
            // 
            this.tbxDirección.Location = new System.Drawing.Point(167, 149);
            this.tbxDirección.Name = "tbxDirección";
            this.tbxDirección.Size = new System.Drawing.Size(100, 22);
            this.tbxDirección.TabIndex = 1;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(167, 249);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(100, 22);
            this.tbxCorreo.TabIndex = 2;
            // 
            // pnlGenero
            // 
            this.pnlGenero.Controls.Add(this.rbtOtro);
            this.pnlGenero.Controls.Add(this.rbtFem);
            this.pnlGenero.Controls.Add(this.rbtMasc);
            this.pnlGenero.Location = new System.Drawing.Point(313, 77);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(162, 129);
            this.pnlGenero.TabIndex = 3;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(36, 19);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(89, 20);
            this.rbtMasc.TabIndex = 0;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(36, 58);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(88, 20);
            this.rbtFem.TabIndex = 1;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(36, 97);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(53, 20);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // mcalFechaNac
            // 
            this.mcalFechaNac.Location = new System.Drawing.Point(525, 77);
            this.mcalFechaNac.Name = "mcalFechaNac";
            this.mcalFechaNac.TabIndex = 4;
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(393, 250);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 5;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(43, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(43, 152);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(67, 16);
            this.lbDireccion.TabIndex = 7;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(310, 256);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 16);
            this.lbEdad.TabIndex = 8;
            this.lbEdad.Text = "Edad";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(321, 49);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(55, 16);
            this.lbGenero.TabIndex = 9;
            this.lbGenero.Text = "Género:";
            // 
            // lbFechaNAc
            // 
            this.lbFechaNAc.AutoSize = true;
            this.lbFechaNAc.Location = new System.Drawing.Point(531, 43);
            this.lbFechaNAc.Name = "lbFechaNAc";
            this.lbFechaNAc.Size = new System.Drawing.Size(140, 16);
            this.lbFechaNAc.TabIndex = 10;
            this.lbFechaNAc.Text = "Fecha de nacimiendo:";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(43, 252);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(120, 16);
            this.lbCorreo.TabIndex = 11;
            this.lbCorreo.Text = "Correo electronico:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabDatos.PerformLayout();
            this.pnlGenero.ResumeLayout(false);
            this.pnlGenero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPrincipal;
        private System.Windows.Forms.TabPage tabDatos;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.Label lbFechaNAc;
        private System.Windows.Forms.Label lbGenero;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.MonthCalendar mcalFechaNac;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.Panel pnlGenero;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtFem;
        private System.Windows.Forms.RadioButton rbtMasc;
        private System.Windows.Forms.TextBox tbxCorreo;
        private System.Windows.Forms.TextBox tbxDirección;
        private System.Windows.Forms.TextBox tbxNombre;
    }
}

