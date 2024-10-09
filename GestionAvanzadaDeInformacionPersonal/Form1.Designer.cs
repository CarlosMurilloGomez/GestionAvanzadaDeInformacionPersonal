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
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.tabPreferencias = new System.Windows.Forms.TabPage();
            this.lbSatisfaccion = new System.Windows.Forms.Label();
            this.lbHobbies = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbSuscribir = new System.Windows.Forms.Label();
            this.trbSatisfaccion = new System.Windows.Forms.TrackBar();
            this.combPais = new System.Windows.Forms.ComboBox();
            this.clbHobbies = new System.Windows.Forms.CheckedListBox();
            this.cbxSuscribir = new System.Windows.Forms.CheckBox();
            this.tabVisualizacion = new System.Windows.Forms.TabPage();
            this.lbPulsarGuardar = new System.Windows.Forms.Label();
            this.lbDatosSuscripcion = new System.Windows.Forms.Label();
            this.lbDatosHobbies = new System.Windows.Forms.Label();
            this.lbDatosPais = new System.Windows.Forms.Label();
            this.lbDatosFechaNac = new System.Windows.Forms.Label();
            this.lbDatosEdad = new System.Windows.Forms.Label();
            this.lbDatosGenero = new System.Windows.Forms.Label();
            this.lbDatosEmail = new System.Windows.Forms.Label();
            this.lbDatosDireccion = new System.Windows.Forms.Label();
            this.lbDatosNombre = new System.Windows.Forms.Label();
            this.lbFoto = new System.Windows.Forms.Label();
            this.lbHora = new System.Windows.Forms.Label();
            this.btnFoto = new System.Windows.Forms.Button();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.abrirFotoPerfil = new System.Windows.Forms.OpenFileDialog();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.ttAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.lbNumSatisfaccion = new System.Windows.Forms.Label();
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
            this.tabControlPrincipal.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlPrincipal.Location = new System.Drawing.Point(14, 13);
            this.tabControlPrincipal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControlPrincipal.Name = "tabControlPrincipal";
            this.tabControlPrincipal.SelectedIndex = 0;
            this.tabControlPrincipal.Size = new System.Drawing.Size(925, 379);
            this.tabControlPrincipal.TabIndex = 0;
            // 
            // tabDatos
            // 
            this.tabDatos.BackColor = System.Drawing.Color.PapayaWhip;
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
            this.tabDatos.Controls.Add(this.tbxDireccion);
            this.tabDatos.Controls.Add(this.tbxNombre);
            this.tabDatos.Location = new System.Drawing.Point(4, 26);
            this.tabDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabDatos.Size = new System.Drawing.Size(917, 349);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.Text = "Datos personales";
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Location = new System.Drawing.Point(33, 268);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(147, 17);
            this.lbCorreo.TabIndex = 11;
            this.lbCorreo.Text = "Correo electronico:";
            // 
            // lbFechaNAc
            // 
            this.lbFechaNAc.AutoSize = true;
            this.lbFechaNAc.Location = new System.Drawing.Point(598, 46);
            this.lbFechaNAc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFechaNAc.Name = "lbFechaNAc";
            this.lbFechaNAc.Size = new System.Drawing.Size(171, 17);
            this.lbFechaNAc.TabIndex = 10;
            this.lbFechaNAc.Text = "Fecha de nacimiendo:";
            // 
            // lbGenero
            // 
            this.lbGenero.AutoSize = true;
            this.lbGenero.Location = new System.Drawing.Point(361, 52);
            this.lbGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGenero.Name = "lbGenero";
            this.lbGenero.Size = new System.Drawing.Size(63, 17);
            this.lbGenero.TabIndex = 9;
            this.lbGenero.Text = "Género:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(349, 272);
            this.lbEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(46, 17);
            this.lbEdad.TabIndex = 8;
            this.lbEdad.Text = "Edad";
            // 
            // mcalFechaNac
            // 
            this.mcalFechaNac.BackColor = System.Drawing.SystemColors.Info;
            this.mcalFechaNac.Location = new System.Drawing.Point(601, 82);
            this.mcalFechaNac.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.mcalFechaNac.MaxSelectionCount = 1;
            this.mcalFechaNac.Name = "mcalFechaNac";
            this.mcalFechaNac.TabIndex = 4;
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(97, 161);
            this.lbDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(83, 17);
            this.lbDireccion.TabIndex = 7;
            this.lbDireccion.Text = "Dirección:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(110, 55);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(70, 17);
            this.lbNombre.TabIndex = 6;
            this.lbNombre.Text = "Nombre:";
            // 
            // nudEdad
            // 
            this.nudEdad.Location = new System.Drawing.Point(414, 265);
            this.nudEdad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(135, 25);
            this.nudEdad.TabIndex = 5;
            // 
            // pnlGenero
            // 
            this.pnlGenero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGenero.Controls.Add(this.rbtOtro);
            this.pnlGenero.Controls.Add(this.rbtFem);
            this.pnlGenero.Controls.Add(this.rbtMasc);
            this.pnlGenero.Location = new System.Drawing.Point(364, 82);
            this.pnlGenero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlGenero.Name = "pnlGenero";
            this.pnlGenero.Size = new System.Drawing.Size(170, 137);
            this.pnlGenero.TabIndex = 3;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(26, 99);
            this.rbtOtro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(62, 21);
            this.rbtOtro.TabIndex = 2;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Otro";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // rbtFem
            // 
            this.rbtFem.AutoSize = true;
            this.rbtFem.Location = new System.Drawing.Point(26, 60);
            this.rbtFem.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtFem.Name = "rbtFem";
            this.rbtFem.Size = new System.Drawing.Size(102, 21);
            this.rbtFem.TabIndex = 1;
            this.rbtFem.TabStop = true;
            this.rbtFem.Text = "Femenino";
            this.rbtFem.UseVisualStyleBackColor = true;
            // 
            // rbtMasc
            // 
            this.rbtMasc.AutoSize = true;
            this.rbtMasc.Location = new System.Drawing.Point(26, 20);
            this.rbtMasc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtMasc.Name = "rbtMasc";
            this.rbtMasc.Size = new System.Drawing.Size(104, 21);
            this.rbtMasc.TabIndex = 0;
            this.rbtMasc.TabStop = true;
            this.rbtMasc.Text = "Masculino";
            this.rbtMasc.UseVisualStyleBackColor = true;
            // 
            // tbxCorreo
            // 
            this.tbxCorreo.Location = new System.Drawing.Point(188, 265);
            this.tbxCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxCorreo.Name = "tbxCorreo";
            this.tbxCorreo.Size = new System.Drawing.Size(112, 25);
            this.tbxCorreo.TabIndex = 2;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(188, 158);
            this.tbxDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(112, 25);
            this.tbxDireccion.TabIndex = 1;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(188, 52);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(112, 25);
            this.tbxNombre.TabIndex = 0;
            // 
            // tabPreferencias
            // 
            this.tabPreferencias.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPreferencias.Controls.Add(this.lbNumSatisfaccion);
            this.tabPreferencias.Controls.Add(this.lbSatisfaccion);
            this.tabPreferencias.Controls.Add(this.lbHobbies);
            this.tabPreferencias.Controls.Add(this.lbPais);
            this.tabPreferencias.Controls.Add(this.lbSuscribir);
            this.tabPreferencias.Controls.Add(this.trbSatisfaccion);
            this.tabPreferencias.Controls.Add(this.combPais);
            this.tabPreferencias.Controls.Add(this.clbHobbies);
            this.tabPreferencias.Controls.Add(this.cbxSuscribir);
            this.tabPreferencias.Location = new System.Drawing.Point(4, 26);
            this.tabPreferencias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPreferencias.Name = "tabPreferencias";
            this.tabPreferencias.Size = new System.Drawing.Size(917, 349);
            this.tabPreferencias.TabIndex = 1;
            this.tabPreferencias.Text = "Preferencias";
            // 
            // lbSatisfaccion
            // 
            this.lbSatisfaccion.AutoSize = true;
            this.lbSatisfaccion.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSatisfaccion.Location = new System.Drawing.Point(495, 218);
            this.lbSatisfaccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSatisfaccion.Name = "lbSatisfaccion";
            this.lbSatisfaccion.Size = new System.Drawing.Size(350, 17);
            this.lbSatisfaccion.TabIndex = 7;
            this.lbSatisfaccion.Text = "Ingresa tu nivel de satisfaccion con el servicio:";
            // 
            // lbHobbies
            // 
            this.lbHobbies.AutoSize = true;
            this.lbHobbies.Location = new System.Drawing.Point(491, 41);
            this.lbHobbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHobbies.Name = "lbHobbies";
            this.lbHobbies.Size = new System.Drawing.Size(258, 17);
            this.lbHobbies.TabIndex = 6;
            this.lbHobbies.Text = "Selecciona tus hobbies o intereses:";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(86, 61);
            this.lbPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(206, 17);
            this.lbPais.TabIndex = 5;
            this.lbPais.Text = "Elige tu país de residencia:";
            // 
            // lbSuscribir
            // 
            this.lbSuscribir.AutoSize = true;
            this.lbSuscribir.Location = new System.Drawing.Point(86, 242);
            this.lbSuscribir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSuscribir.Name = "lbSuscribir";
            this.lbSuscribir.Size = new System.Drawing.Size(291, 17);
            this.lbSuscribir.TabIndex = 4;
            this.lbSuscribir.Text = "¿Quieres suscribirte a nuestro boletín?";
            // 
            // trbSatisfaccion
            // 
            this.trbSatisfaccion.Cursor = System.Windows.Forms.Cursors.Default;
            this.trbSatisfaccion.Location = new System.Drawing.Point(499, 258);
            this.trbSatisfaccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.trbSatisfaccion.Name = "trbSatisfaccion";
            this.trbSatisfaccion.Size = new System.Drawing.Size(335, 56);
            this.trbSatisfaccion.TabIndex = 3;
            this.trbSatisfaccion.Scroll += new System.EventHandler(this.trbSatisfaccion_Scroll);
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
            this.combPais.Location = new System.Drawing.Point(90, 98);
            this.combPais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.combPais.Name = "combPais";
            this.combPais.Size = new System.Drawing.Size(135, 25);
            this.combPais.TabIndex = 2;
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
            this.clbHobbies.Location = new System.Drawing.Point(495, 82);
            this.clbHobbies.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbHobbies.MultiColumn = true;
            this.clbHobbies.Name = "clbHobbies";
            this.clbHobbies.Size = new System.Drawing.Size(261, 84);
            this.clbHobbies.TabIndex = 1;
            // 
            // cbxSuscribir
            // 
            this.cbxSuscribir.AutoSize = true;
            this.cbxSuscribir.ForeColor = System.Drawing.Color.Black;
            this.cbxSuscribir.Location = new System.Drawing.Point(90, 285);
            this.cbxSuscribir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxSuscribir.Name = "cbxSuscribir";
            this.cbxSuscribir.Size = new System.Drawing.Size(287, 21);
            this.cbxSuscribir.TabIndex = 0;
            this.cbxSuscribir.Text = "Si, suscribirse para recibir noticias";
            this.cbxSuscribir.UseVisualStyleBackColor = true;
            // 
            // tabVisualizacion
            // 
            this.tabVisualizacion.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabVisualizacion.Controls.Add(this.lbPulsarGuardar);
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
            this.tabVisualizacion.Location = new System.Drawing.Point(4, 26);
            this.tabVisualizacion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabVisualizacion.Name = "tabVisualizacion";
            this.tabVisualizacion.Size = new System.Drawing.Size(917, 349);
            this.tabVisualizacion.TabIndex = 2;
            this.tabVisualizacion.Text = "Visualización";
            // 
            // lbPulsarGuardar
            // 
            this.lbPulsarGuardar.AutoSize = true;
            this.lbPulsarGuardar.Location = new System.Drawing.Point(371, 27);
            this.lbPulsarGuardar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPulsarGuardar.Name = "lbPulsarGuardar";
            this.lbPulsarGuardar.Size = new System.Drawing.Size(370, 17);
            this.lbPulsarGuardar.TabIndex = 13;
            this.lbPulsarGuardar.Text = "Pulsa el boton guardar para actualizar los datos";
            // 
            // lbDatosSuscripcion
            // 
            this.lbDatosSuscripcion.AutoSize = true;
            this.lbDatosSuscripcion.Location = new System.Drawing.Point(580, 299);
            this.lbDatosSuscripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosSuscripcion.Name = "lbDatosSuscripcion";
            this.lbDatosSuscripcion.Size = new System.Drawing.Size(104, 17);
            this.lbDatosSuscripcion.TabIndex = 12;
            this.lbDatosSuscripcion.Text = "Subscripcion:";
            // 
            // lbDatosHobbies
            // 
            this.lbDatosHobbies.Location = new System.Drawing.Point(580, 213);
            this.lbDatosHobbies.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosHobbies.Name = "lbDatosHobbies";
            this.lbDatosHobbies.Size = new System.Drawing.Size(221, 86);
            this.lbDatosHobbies.TabIndex = 11;
            this.lbDatosHobbies.Text = "Hobbies:";
            // 
            // lbDatosPais
            // 
            this.lbDatosPais.AutoSize = true;
            this.lbDatosPais.Location = new System.Drawing.Point(580, 174);
            this.lbDatosPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosPais.Name = "lbDatosPais";
            this.lbDatosPais.Size = new System.Drawing.Size(43, 17);
            this.lbDatosPais.TabIndex = 10;
            this.lbDatosPais.Text = "País:";
            // 
            // lbDatosFechaNac
            // 
            this.lbDatosFechaNac.AutoSize = true;
            this.lbDatosFechaNac.Location = new System.Drawing.Point(580, 138);
            this.lbDatosFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosFechaNac.Name = "lbDatosFechaNac";
            this.lbDatosFechaNac.Size = new System.Drawing.Size(167, 17);
            this.lbDatosFechaNac.TabIndex = 9;
            this.lbDatosFechaNac.Text = "Fecha de nacimiento:";
            // 
            // lbDatosEdad
            // 
            this.lbDatosEdad.AutoSize = true;
            this.lbDatosEdad.Location = new System.Drawing.Point(580, 102);
            this.lbDatosEdad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosEdad.Name = "lbDatosEdad";
            this.lbDatosEdad.Size = new System.Drawing.Size(50, 17);
            this.lbDatosEdad.TabIndex = 8;
            this.lbDatosEdad.Text = "Edad:";
            // 
            // lbDatosGenero
            // 
            this.lbDatosGenero.AutoSize = true;
            this.lbDatosGenero.Location = new System.Drawing.Point(371, 288);
            this.lbDatosGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosGenero.Name = "lbDatosGenero";
            this.lbDatosGenero.Size = new System.Drawing.Size(63, 17);
            this.lbDatosGenero.TabIndex = 7;
            this.lbDatosGenero.Text = "Género:";
            // 
            // lbDatosEmail
            // 
            this.lbDatosEmail.AutoSize = true;
            this.lbDatosEmail.Location = new System.Drawing.Point(580, 64);
            this.lbDatosEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosEmail.Name = "lbDatosEmail";
            this.lbDatosEmail.Size = new System.Drawing.Size(61, 17);
            this.lbDatosEmail.TabIndex = 6;
            this.lbDatosEmail.Text = "E-mail:";
            // 
            // lbDatosDireccion
            // 
            this.lbDatosDireccion.AutoSize = true;
            this.lbDatosDireccion.Location = new System.Drawing.Point(371, 250);
            this.lbDatosDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosDireccion.Name = "lbDatosDireccion";
            this.lbDatosDireccion.Size = new System.Drawing.Size(83, 17);
            this.lbDatosDireccion.TabIndex = 5;
            this.lbDatosDireccion.Text = "Dirección:";
            // 
            // lbDatosNombre
            // 
            this.lbDatosNombre.AutoSize = true;
            this.lbDatosNombre.Location = new System.Drawing.Point(371, 217);
            this.lbDatosNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDatosNombre.Name = "lbDatosNombre";
            this.lbDatosNombre.Size = new System.Drawing.Size(74, 17);
            this.lbDatosNombre.TabIndex = 4;
            this.lbDatosNombre.Text = "Nombre: ";
            // 
            // lbFoto
            // 
            this.lbFoto.AutoSize = true;
            this.lbFoto.Location = new System.Drawing.Point(51, 51);
            this.lbFoto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFoto.Name = "lbFoto";
            this.lbFoto.Size = new System.Drawing.Size(221, 17);
            this.lbFoto.TabIndex = 3;
            this.lbFoto.Text = "Selecciona una foto de perfil:";
            // 
            // lbHora
            // 
            this.lbHora.AutoSize = true;
            this.lbHora.Font = new System.Drawing.Font("Lucida Handwriting", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHora.Location = new System.Drawing.Point(48, 201);
            this.lbHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHora.Name = "lbHora";
            this.lbHora.Size = new System.Drawing.Size(222, 33);
            this.lbHora.TabIndex = 2;
            this.lbHora.Text = "Hora: 00:00:00";
            // 
            // btnFoto
            // 
            this.btnFoto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnFoto.ForeColor = System.Drawing.Color.Black;
            this.btnFoto.Location = new System.Drawing.Point(88, 83);
            this.btnFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(144, 55);
            this.btnFoto.TabIndex = 1;
            this.btnFoto.Text = "Seleccionar Imagen";
            this.ttAyuda.SetToolTip(this.btnFoto, "Selecciona una imagen de tu equipo para tu perfil");
            this.btnFoto.UseVisualStyleBackColor = true;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(390, 51);
            this.pbxFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(140, 140);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
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
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(224, 407);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 60);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.ttAyuda.SetToolTip(this.btnGuardar, "Guarda los datos introducidos y los muestra en la pestaña de visualización\r\n");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(432, 407);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 60);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.ttAyuda.SetToolTip(this.btnLimpiar, "Deja todos los campos vacíos");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("MV Boli", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Location = new System.Drawing.Point(652, 407);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 60);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.ttAyuda.SetToolTip(this.btnSalir, "Salir del formulario");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lbNumSatisfaccion
            // 
            this.lbNumSatisfaccion.AutoSize = true;
            this.lbNumSatisfaccion.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumSatisfaccion.ForeColor = System.Drawing.Color.Black;
            this.lbNumSatisfaccion.Location = new System.Drawing.Point(841, 258);
            this.lbNumSatisfaccion.Name = "lbNumSatisfaccion";
            this.lbNumSatisfaccion.Size = new System.Drawing.Size(26, 26);
            this.lbNumSatisfaccion.TabIndex = 8;
            this.lbNumSatisfaccion.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(952, 479);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControlPrincipal);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Maroon;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.TextBox tbxDireccion;
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
        private System.Windows.Forms.Label lbPulsarGuardar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip ttAyuda;
        private System.Windows.Forms.Label lbNumSatisfaccion;
    }
}

