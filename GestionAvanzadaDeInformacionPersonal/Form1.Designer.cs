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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControlPrincipal = new System.Windows.Forms.TabControl();
            this.tabDatos = new System.Windows.Forms.TabPage();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.lbFechaNAc = new System.Windows.Forms.Label();
            this.lbGenero = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.mcalFechaNac = new System.Windows.Forms.MonthCalendar();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.pnlGenero = new System.Windows.Forms.Panel();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rbtFem = new System.Windows.Forms.RadioButton();
            this.rbtMasc = new System.Windows.Forms.RadioButton();
            this.tbxCorreo = new System.Windows.Forms.TextBox();
            this.tbxDirección = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.cbxSuscribir = new System.Windows.Forms.CheckBox();
            this.clbHobbies = new System.Windows.Forms.CheckedListBox();
            this.combPais = new System.Windows.Forms.ComboBox();
            this.trbSatisfaccion = new System.Windows.Forms.TrackBar();
            this.lbSuscribir = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbHobbies = new System.Windows.Forms.Label();
            this.lbSatisfaccion = new System.Windows.Forms.Label();
            this.tabVisualizacion = new System.Windows.Forms.TabPage();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.lbHora = new System.Windows.Forms.Label();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.abrirFotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbDatosNombre = new System.Windows.Forms.Label();
            this.lbDatosDireccion = new System.Windows.Forms.Label();
            this.lbDatosEmail = new System.Windows.Forms.Label();
            this.lbDatosGenero = new System.Windows.Forms.Label();
            this.lbDatosEdad = new System.Windows.Forms.Label();
            this.lbDatosFechaNac = new System.Windows.Forms.Label();
            this.lbDatosPais = new System.Windows.Forms.Label();
            this.lbDatosHobbies = new System.Windows.Forms.Label();
            this.lbDatosSuscripcion = new System.Windows.Forms.Label();
            this.tabControlPrincipal.SuspendLayout();
            this.tabDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.pnlGenero.SuspendLayout();
            this.tabPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSatisfaccion)).BeginInit();
            this.tabVisualizacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPrincipal
            // 
            this.tabControlPrincipal.Controls.Add(this.tabDatos);
            this.tabControlPrincipal.Controls.Add(this.tabPreferencias);
            this.tabControlPrincipal.Controls.Add(this.tabVisualizacion);
            this.tabControlPrincipal.Location = new System.Drawing.Point(12, 12);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(822, 357);
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
            this.tabDatos.Size = new System.Drawing.Size(814, 328);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Datos personales";
            this.tabDatos.UseVisualStyleBackColor = true;
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
            // lbFechaNAc
            // 
            this.lbFechaNAc.AutoSize = true;
            this.lbFechaNAc.Location = new System.Drawing.Point(531, 43);
            this.lbFechaNAc.Name = "lbFechaNAc";
            this.lbFechaNAc.Size = new System.Drawing.Size(140, 16);
            this.lbFechaNAc.TabIndex = 10;
            this.lbFechaNAc.Text = "Fecha de nacimiendo:";
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
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(310, 256);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 16);
            this.lbEdad.TabIndex = 8;
            this.lbEdad.Text = "Edad";
            // 
            // mcalFechaNac
            // 
            this.mcalFechaNac.Location = new System.Drawing.Point(534, 77);
            this.mcalFechaNac.Name = "mcalFechaNac";
            this.mcalFechaNac.TabIndex = 4;
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
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(43, 49);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(59, 16);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(393, 250);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(120, 22);
            this.nudEdad.TabIndex = 5;
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
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(167, 249);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(100, 22);
            this.tbxCorreo.TabIndex = 2;
            // 
            // tbxDirección
            // 
            this.tbxDirección.Location = new System.Drawing.Point(167, 149);
            this.tbxDirección.Name = "tbxDirección";
            this.tbxDirección.Size = new System.Drawing.Size(100, 22);
            this.tbxDirección.TabIndex = 1;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(167, 49);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 22);
            this.tbxNombre.TabIndex = 0;
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.Controls.Add(this.lbSatisfaccion);
            this.tabPreferencias.Controls.Add(this.lbHobbies);
            this.tabPreferencias.Controls.Add(this.lbPais);
            this.tabPreferencias.Controls.Add(this.lbSuscribir);
            this.tabPreferencias.Controls.Add(this.trbSatisfaccion);
            this.tabPreferencias.Controls.Add(this.combPais);
            this.tabPreferencias.Controls.Add(this.clbHobbies);
            this.tabPreferencias.Controls.Add(this.cbxSuscribir);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 25);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(814, 328);
            this.tabPreferencias.TabIndex = 1;
            this.tabPreferencias.Text = "Preferencias";
            this.tabPreferencias.UseVisualStyleBackColor = true;
            // 
            // cbxSuscribir
            // 
            this.cbxSuscribir.AutoSize = true;
            this.cbxSuscribir.Location = new System.Drawing.Point(80, 268);
            this.cbxSuscribir.Name = "cbxSuscribir";
            this.cbxSuscribir.Size = new System.Drawing.Size(232, 20);
            this.cbxSuscribir.TabIndex = 0;
            this.cbxSuscribir.Text = "Si, suscribirse para recibir noticias";
            this.cbxSuscribir.UseVisualStyleBackColor = true;
            // 
            // clbHobbies
            // 
            this.clbHobbies.CheckOnClick = true;
            this.clbHobbies.FormattingEnabled = true;
            this.clbHobbies.Items.AddRange(new object[] {
            "Videojuegos",
            "Pesca",
            "Fútbol",
            "Baloncesto",
            "Lectura",
            "Musica",
            "Cocina",
            "Senderismo"});
            this.clbHobbies.Location = new System.Drawing.Point(440, 78);
            this.clbHobbies.Name = "clbHobbies";
            this.clbHobbies.Size = new System.Drawing.Size(135, 89);
            this.clbHobbies.TabIndex = 1;
            // 
            // combPais
            // 
            this.combPais.FormattingEnabled = true;
            this.combPais.Items.AddRange(new object[] {
            "Alemania",
            "Arabia Saudita",
            "Argentina",
            "Australia",
            "Brasil",
            "Canadá",
            "China",
            "Corea del Sur",
            "Egipto",
            "Emiratos Árabes Unidos",
            "España",
            "Estados Unidos",
            "Francia",
            "India",
            "Italia",
            "Japón",
            "México",
            "Nigeria",
            "Reino Unido",
            "Rusia",
            "Sudáfrica",
            "Turquía"});
            this.combPais.Location = new System.Drawing.Point(80, 100);
            this.combPais.Name = "combPais";
            this.combPais.Size = new System.Drawing.Size(121, 24);
            this.combPais.TabIndex = 2;
            // 
            // trbSatisfaccion
            // 
            this.trbSatisfaccion.Location = new System.Drawing.Point(443, 242);
            this.trbSatisfaccion.Name = "trbSatisfaccion";
            this.trbSatisfaccion.Size = new System.Drawing.Size(298, 56);
            this.trbSatisfaccion.TabIndex = 3;
            // 
            // lbSuscribir
            // 
            this.lbSuscribir.AutoSize = true;
            this.lbSuscribir.Location = new System.Drawing.Point(77, 228);
            this.lbSuscribir.Name = "lbSuscribir";
            this.lbSuscribir.Size = new System.Drawing.Size(233, 16);
            this.lbSuscribir.TabIndex = 4;
            this.lbSuscribir.Text = "¿Quieres suscribirte a nuestro boletín?";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(77, 58);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(165, 16);
            this.lbPais.TabIndex = 5;
            this.lbPais.Text = "Elige tu país de residencia";
            // 
            // lbHobbies
            // 
            this.lbHobbies.AutoSize = true;
            this.lbHobbies.Location = new System.Drawing.Point(437, 38);
            this.lbHobbies.Name = "lbHobbies";
            this.lbHobbies.Size = new System.Drawing.Size(216, 16);
            this.lbHobbies.TabIndex = 6;
            this.lbHobbies.Text = "Selecciona tus hobbies o intereses";
            // 
            // lbSatisfaccion
            // 
            this.lbSatisfaccion.AutoSize = true;
            this.lbSatisfaccion.Location = new System.Drawing.Point(440, 205);
            this.lbSatisfaccion.Name = "lbSatisfaccion";
            this.lbSatisfaccion.Size = new System.Drawing.Size(278, 16);
            this.lbSatisfaccion.TabIndex = 7;
            this.lbSatisfaccion.Text = "Ingresa tu nivel de satisfaccion con el servicio";
            // 
            // tabVisualizacion
            // 
            this.tabVisualizacion.Controls.Add(this.lbDatosSuscripcion);
            this.tabVisualizacion.Controls.Add(this.lbDatosHobbies);
            this.tabVisualizacion.Controls.Add(this.lbDatosPais);
            this.tabVisualizacion.Controls.Add(this.lbDatosFechaNac);
            this.tabVisualizacion.Controls.Add(this.lbDatosEdad);
            this.tabVisualizacion.Controls.Add(this.lbDatosGenero);
            this.tabVisualizacion.Controls.Add(this.lbDatosEmail);
            this.tabVisualizacion.Controls.Add(this.lbDatosDireccion);
            this.tabVisualizacion.Controls.Add(this.lbDatosNombre);
            this.tabVisualizacion.Controls.Add(this.lbFoto);
            this.tabVisualizacion.Controls.Add(this.lbHora);
            this.tabVisualizacion.Controls.Add(this.btnFoto);
            this.tabVisualizacion.Controls.Add(this.pbxFoto);
            this.tabVisualizacion.Location = new System.Drawing.Point(4, 25);
            this.tabVisualizacion.Name = "tabVisualizacion";
            this.tabVisualizacion.Size = new System.Drawing.Size(814, 328);
            this.tabVisualizacion.TabIndex = 2;
            this.tabVisualizacion.Text = "Visualización";
            this.tabVisualizacion.UseVisualStyleBackColor = true;
            // 
            // pbxFoto
            // 
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(37, 44);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(194, 176);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Location = new System.Drawing.Point(74, 226);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(128, 52);
            this.btnFoto.TabIndex = 1;
            this.btnFoto.Text = "Seleccionar Imagen";
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Location = new System.Drawing.Point(88, 292);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(91, 16);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora: 00:00:00";
            // 
            // timerHora
            // 
            this.timerHora.Interval = 1000;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // abrirFotoPerfil
            // 
            this.abrirFotoPerfil.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(34, 25);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(179, 16);
            this.lbFoto.TabIndex = 3;
            this.lbFoto.Text = "Selecciona una foto de perfil:";
            // 
            // lbDatosNombre
            // 
            this.lbDatosNombre.AutoSize = true;
            this.lbDatosNombre.Location = new System.Drawing.Point(330, 65);
            this.lbDatosNombre.Name = "lbDatosNombre";
            this.lbDatosNombre.Size = new System.Drawing.Size(62, 16);
            this.lbDatosNombre.TabIndex = 4;
            this.lbDatosNombre.Text = "Nombre: ";
            // 
            // lbDatosDireccion
            // 
            this.lbDatosDireccion.AutoSize = true;
            this.lbDatosDireccion.Location = new System.Drawing.Point(330, 103);
            this.lbDatosDireccion.Name = "lbDatosDireccion";
            this.lbDatosDireccion.Size = new System.Drawing.Size(67, 16);
            this.lbDatosDireccion.TabIndex = 5;
            this.lbDatosDireccion.Text = "Dirección:";
            // 
            // lbDatosEmail
            // 
            this.lbDatosEmail.AutoSize = true;
            this.lbDatosEmail.Location = new System.Drawing.Point(330, 146);
            this.lbDatosEmail.Name = "lbDatosEmail";
            this.lbDatosEmail.Size = new System.Drawing.Size(48, 16);
            this.lbDatosEmail.TabIndex = 6;
            this.lbDatosEmail.Text = "E-mail:";
            // 
            // lbDatosGenero
            // 
            this.lbDatosGenero.AutoSize = true;
            this.lbDatosGenero.Location = new System.Drawing.Point(330, 188);
            this.lbDatosGenero.Name = "lbDatosGenero";
            this.lbDatosGenero.Size = new System.Drawing.Size(55, 16);
            this.lbDatosGenero.TabIndex = 7;
            this.lbDatosGenero.Text = "Género:";
            // 
            // lbDatosEdad
            // 
            this.lbDatosEdad.AutoSize = true;
            this.lbDatosEdad.Location = new System.Drawing.Point(516, 65);
            this.lbDatosEdad.Name = "lbDatosEdad";
            this.lbDatosEdad.Size = new System.Drawing.Size(43, 16);
            this.lbDatosEdad.TabIndex = 8;
            this.lbDatosEdad.Text = "Edad:";
            // 
            // lbDatosFechaNac
            // 
            this.lbDatosFechaNac.AutoSize = true;
            this.lbDatosFechaNac.Location = new System.Drawing.Point(516, 103);
            this.lbDatosFechaNac.Name = "lbDatosFechaNac";
            this.lbDatosFechaNac.Size = new System.Drawing.Size(134, 16);
            this.lbDatosFechaNac.TabIndex = 9;
            this.lbDatosFechaNac.Text = "FechaDeNacimiento:";
            // 
            // lbDatosPais
            // 
            this.lbDatosPais.AutoSize = true;
            this.lbDatosPais.Location = new System.Drawing.Point(516, 146);
            this.lbDatosPais.Name = "lbDatosPais";
            this.lbDatosPais.Size = new System.Drawing.Size(37, 16);
            this.lbDatosPais.TabIndex = 10;
            this.lbDatosPais.Text = "País:";
            // 
            // lbDatosHobbies
            // 
            this.lbDatosHobbies.Location = new System.Drawing.Point(516, 188);
            this.lbDatosHobbies.Name = "lbDatosHobbies";
            this.lbDatosHobbies.Size = new System.Drawing.Size(197, 90);
            this.lbDatosHobbies.TabIndex = 11;
            this.lbDatosHobbies.Text = "Hobbies:";
            // 
            // lbDatosSuscripcion
            // 
            this.lbDatosSuscripcion.AutoSize = true;
            this.lbDatosSuscripcion.Location = new System.Drawing.Point(516, 282);
            this.lbDatosSuscripcion.Name = "lbDatosSuscripcion";
            this.lbDatosSuscripcion.Size = new System.Drawing.Size(88, 16);
            this.lbDatosSuscripcion.TabIndex = 12;
            this.lbDatosSuscripcion.Text = "Subscripcion:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 450);
            this.Controls.Add(this.tabControlPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPrincipal.ResumeLayout(false);
            this.tabDatos.ResumeLayout(false);
            this.tabDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.pnlGenero.ResumeLayout(false);
            this.pnlGenero.PerformLayout();
            this.tabPreferencias.ResumeLayout(false);
            this.tabPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbSatisfaccion)).EndInit();
            this.tabVisualizacion.ResumeLayout(false);
            this.tabVisualizacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
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
        private System.Windows.Forms.TabPage tabPreferencias;
        private System.Windows.Forms.Label lbSatisfaccion;
        private System.Windows.Forms.Label lbHobbies;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbSuscribir;
        private System.Windows.Forms.TrackBar trbSatisfaccion;
        private System.Windows.Forms.ComboBox combPais;
        private System.Windows.Forms.CheckedListBox clbHobbies;
        private System.Windows.Forms.CheckBox cbxSuscribir;
        private System.Windows.Forms.TabPage tabVisualizacion;
        private System.Windows.Forms.Label lbFoto;
        private System.Windows.Forms.Label lbHora;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.OpenFileDialog abrirFotoPerfil;
        private System.Windows.Forms.Label lbDatosNombre;
        private System.Windows.Forms.Label lbDatosSuscripcion;
        private System.Windows.Forms.Label lbDatosHobbies;
        private System.Windows.Forms.Label lbDatosPais;
        private System.Windows.Forms.Label lbDatosFechaNac;
        private System.Windows.Forms.Label lbDatosEdad;
        private System.Windows.Forms.Label lbDatosGenero;
        private System.Windows.Forms.Label lbDatosEmail;
        private System.Windows.Forms.Label lbDatosDireccion;
    }
}

