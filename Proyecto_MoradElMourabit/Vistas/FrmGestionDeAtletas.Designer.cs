
using System;

namespace Proyecto.Vistas
{
    partial class FrmGestionDeAtletas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionDeAtletas));
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.mtxCIF = new System.Windows.Forms.MaskedTextBox();
            this.mtxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioBFemenino = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.radioBMasculino = new System.Windows.Forms.RadioButton();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lbltext = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvGestionAtletas = new System.Windows.Forms.DataGridView();
            this.comboBoxBuscar = new System.Windows.Forms.ComboBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContratar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnDespedir = new System.Windows.Forms.Button();
            this.snakeCaseNamingStrategyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.snakeCaseNamingStrategyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.snakeCaseNamingStrategyBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.snakeCaseNamingStrategyBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorNombre = new System.Windows.Forms.Label();
            this.lblErrorApellido = new System.Windows.Forms.Label();
            this.lblErrorNacionalidad = new System.Windows.Forms.Label();
            this.lblErrorSexo = new System.Windows.Forms.Label();
            this.lblErrorCorreo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label20ErrorCombo = new System.Windows.Forms.Label();
            this.label20ErrorEdad = new System.Windows.Forms.Label();
            this.labelErrorPeso = new System.Windows.Forms.Label();
            this.lblCifError = new System.Windows.Forms.Label();
            this.atletaBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionAtletas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(211, 365);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(218, 20);
            this.txtCorreo.TabIndex = 107;
            // 
            // mtxCIF
            // 
            this.mtxCIF.Location = new System.Drawing.Point(365, 315);
            this.mtxCIF.Mask = "a-00000000";
            this.mtxCIF.Name = "mtxCIF";
            this.mtxCIF.Size = new System.Drawing.Size(64, 20);
            this.mtxCIF.TabIndex = 103;
            // 
            // mtxTelefono
            // 
            this.mtxTelefono.Location = new System.Drawing.Point(353, 340);
            this.mtxTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.mtxTelefono.Mask = "(999)000-000";
            this.mtxTelefono.Name = "mtxTelefono";
            this.mtxTelefono.Size = new System.Drawing.Size(76, 20);
            this.mtxTelefono.TabIndex = 104;
            this.mtxTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxTelefono_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(64, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 16);
            this.label11.TabIndex = 102;
            this.label11.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(67, 365);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(55, 16);
            this.lblCorreo.TabIndex = 101;
            this.lblCorreo.Text = "Correo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 100;
            this.label3.Text = "CIF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 89;
            this.label7.Text = "Peso";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(211, 110);
            this.txtNombre.MaxLength = 32;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(218, 20);
            this.txtNombre.TabIndex = 99;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Nombre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioBFemenino
            // 
            this.radioBFemenino.AutoSize = true;
            this.radioBFemenino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBFemenino.Location = new System.Drawing.Point(350, 289);
            this.radioBFemenino.Name = "radioBFemenino";
            this.radioBFemenino.Size = new System.Drawing.Size(86, 20);
            this.radioBFemenino.TabIndex = 98;
            this.radioBFemenino.TabStop = true;
            this.radioBFemenino.Text = "Femenino";
            this.radioBFemenino.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Nacionalidad";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioBMasculino
            // 
            this.radioBMasculino.AutoSize = true;
            this.radioBMasculino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBMasculino.Location = new System.Drawing.Point(257, 289);
            this.radioBMasculino.Name = "radioBMasculino";
            this.radioBMasculino.Size = new System.Drawing.Size(87, 20);
            this.radioBMasculino.TabIndex = 97;
            this.radioBMasculino.TabStop = true;
            this.radioBMasculino.Text = "Masculino";
            this.radioBMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNacionalidad
            // 
            this.txtNacionalidad.Location = new System.Drawing.Point(211, 162);
            this.txtNacionalidad.MaxLength = 32;
            this.txtNacionalidad.Multiline = true;
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(218, 20);
            this.txtNacionalidad.TabIndex = 88;
            this.txtNacionalidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNacionalidad_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(365, 214);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(64, 20);
            this.txtEdad.TabIndex = 96;
            this.txtEdad.TextChanged += new System.EventHandler(this.txtEdad_TextChanged);
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Apellido";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(66, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 16);
            this.label12.TabIndex = 95;
            this.label12.Text = "Edad";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(365, 240);
            this.txtPeso.MaxLength = 3;
            this.txtPeso.Multiline = true;
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(64, 20);
            this.txtPeso.TabIndex = 90;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.Location = new System.Drawing.Point(68, 289);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(43, 16);
            this.lbltext.TabIndex = 94;
            this.lbltext.Text = "Sexo";
            this.lbltext.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 91;
            this.label8.Text = "Categoria";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(211, 136);
            this.txtApellido.MaxLength = 32;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(218, 20);
            this.txtApellido.TabIndex = 92;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 108;
            this.label4.Text = "Salario($/combate)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(350, 264);
            this.txtSalario.MaxLength = 6;
            this.txtSalario.Multiline = true;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(79, 20);
            this.txtSalario.TabIndex = 109;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Items.AddRange(new object[] {
            "Peso pesado            120kg  (265 lb)",
            "Peso semipesado      93kg  (205 lb)",
            "Peso medio             83,9kg  (185 lb)",
            "Peso wélter                77 kg  (169 lb)\t",
            "Peso ligero                 70 kg  (154 lb)\t",
            "Peso pluma                66 kg  (145 lb)\t",
            "Peso gallo                   61 kg  (134 lb)",
            "Peso mosca              56,7kg (125 lb)",
            "Peso paja                   52,3kg (115 lb)"});
            this.comboBoxCategoria.Location = new System.Drawing.Point(211, 187);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(216, 21);
            this.comboBoxCategoria.TabIndex = 110;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(406, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(309, 25);
            this.lblTitulo.TabIndex = 112;
            this.lblTitulo.Text = "Gestionar atletas del evento";
            // 
            // dgvGestionAtletas
            // 
            this.dgvGestionAtletas.AllowUserToOrderColumns = true;
            this.dgvGestionAtletas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionAtletas.Location = new System.Drawing.Point(493, 114);
            this.dgvGestionAtletas.Name = "dgvGestionAtletas";
            this.dgvGestionAtletas.Size = new System.Drawing.Size(573, 271);
            this.dgvGestionAtletas.TabIndex = 114;
            // 
            // comboBoxBuscar
            // 
            this.comboBoxBuscar.FormattingEnabled = true;
            this.comboBoxBuscar.Location = new System.Drawing.Point(493, 69);
            this.comboBoxBuscar.Name = "comboBoxBuscar";
            this.comboBoxBuscar.Size = new System.Drawing.Size(309, 21);
            this.comboBoxBuscar.TabIndex = 116;
            this.comboBoxBuscar.Text = "Buscar";
            this.comboBoxBuscar.SelectedIndexChanged += new System.EventHandler(this.comboBoxBuscar_SelectedIndexChanged);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Image = global::Proyecto.Properties.Resources.ordenar__2_;
            this.btnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenar.Location = new System.Drawing.Point(654, 407);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(110, 31);
            this.btnOrdenar.TabIndex = 118;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto.Properties.Resources.xmag_search_find_export_locate_5984__1_;
            this.pictureBox2.Location = new System.Drawing.Point(913, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 117;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto.Properties.Resources.logoUfc;
            this.pictureBox1.Location = new System.Drawing.Point(97, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // btnContratar
            // 
            this.btnContratar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnContratar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContratar.Image = global::Proyecto.Properties.Resources.plus;
            this.btnContratar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContratar.Location = new System.Drawing.Point(821, 407);
            this.btnContratar.Name = "btnContratar";
            this.btnContratar.Size = new System.Drawing.Size(110, 31);
            this.btnContratar.TabIndex = 12;
            this.btnContratar.Text = "    Contratar";
            this.btnContratar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnContratar.UseVisualStyleBackColor = false;
            this.btnContratar.Click += new System.EventHandler(this.btnContratar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = global::Proyecto.Properties.Resources.refresh__1_;
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnActualizar.Location = new System.Drawing.Point(493, 407);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 31);
            this.btnActualizar.TabIndex = 10;
            this.btnActualizar.Text = "     Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnDespedir
            // 
            this.btnDespedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDespedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDespedir.Image = global::Proyecto.Properties.Resources.cut;
            this.btnDespedir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDespedir.Location = new System.Drawing.Point(956, 407);
            this.btnDespedir.Name = "btnDespedir";
            this.btnDespedir.Size = new System.Drawing.Size(110, 31);
            this.btnDespedir.TabIndex = 9;
            this.btnDespedir.Text = "Despedir";
            this.btnDespedir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDespedir.UseVisualStyleBackColor = false;
            this.btnDespedir.Click += new System.EventHandler(this.btnDespedir_Click);
            // 
            // snakeCaseNamingStrategyBindingSource
            // 
            this.snakeCaseNamingStrategyBindingSource.DataSource = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy);
            // 
            // snakeCaseNamingStrategyBindingSource1
            // 
            this.snakeCaseNamingStrategyBindingSource1.DataSource = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy);
            // 
            // snakeCaseNamingStrategyBindingSource2
            // 
            this.snakeCaseNamingStrategyBindingSource2.DataSource = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy);
            // 
            // snakeCaseNamingStrategyBindingSource3
            // 
            this.snakeCaseNamingStrategyBindingSource3.DataSource = typeof(Newtonsoft.Json.Serialization.SnakeCaseNamingStrategy);
            // 
            // lblErrorNombre
            // 
            this.lblErrorNombre.AutoSize = true;
            this.lblErrorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNombre.Location = new System.Drawing.Point(435, 110);
            this.lblErrorNombre.Name = "lblErrorNombre";
            this.lblErrorNombre.Size = new System.Drawing.Size(16, 20);
            this.lblErrorNombre.TabIndex = 119;
            this.lblErrorNombre.Text = "*";
            this.lblErrorNombre.Visible = false;
            // 
            // lblErrorApellido
            // 
            this.lblErrorApellido.AutoSize = true;
            this.lblErrorApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorApellido.Location = new System.Drawing.Point(435, 136);
            this.lblErrorApellido.Name = "lblErrorApellido";
            this.lblErrorApellido.Size = new System.Drawing.Size(16, 20);
            this.lblErrorApellido.TabIndex = 120;
            this.lblErrorApellido.Text = "*";
            this.lblErrorApellido.Visible = false;
            // 
            // lblErrorNacionalidad
            // 
            this.lblErrorNacionalidad.AutoSize = true;
            this.lblErrorNacionalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNacionalidad.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNacionalidad.Location = new System.Drawing.Point(435, 162);
            this.lblErrorNacionalidad.Name = "lblErrorNacionalidad";
            this.lblErrorNacionalidad.Size = new System.Drawing.Size(16, 20);
            this.lblErrorNacionalidad.TabIndex = 121;
            this.lblErrorNacionalidad.Text = "*";
            this.lblErrorNacionalidad.Visible = false;
            // 
            // lblErrorSexo
            // 
            this.lblErrorSexo.AutoSize = true;
            this.lblErrorSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSexo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSexo.Location = new System.Drawing.Point(442, 289);
            this.lblErrorSexo.Name = "lblErrorSexo";
            this.lblErrorSexo.Size = new System.Drawing.Size(16, 20);
            this.lblErrorSexo.TabIndex = 123;
            this.lblErrorSexo.Text = "*";
            this.lblErrorSexo.Visible = false;
            // 
            // lblErrorCorreo
            // 
            this.lblErrorCorreo.AutoSize = true;
            this.lblErrorCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorCorreo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCorreo.Location = new System.Drawing.Point(442, 365);
            this.lblErrorCorreo.Name = "lblErrorCorreo";
            this.lblErrorCorreo.Size = new System.Drawing.Size(16, 20);
            this.lblErrorCorreo.TabIndex = 124;
            this.lblErrorCorreo.Text = "*";
            this.lblErrorCorreo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(32, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 20);
            this.label6.TabIndex = 125;
            this.label6.Text = "*";
            this.label6.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(32, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 20);
            this.label9.TabIndex = 126;
            this.label9.Text = "*";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(32, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 20);
            this.label10.TabIndex = 127;
            this.label10.Text = "*";
            this.label10.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Navy;
            this.label13.Location = new System.Drawing.Point(32, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 20);
            this.label13.TabIndex = 128;
            this.label13.Text = "*";
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Navy;
            this.label14.Location = new System.Drawing.Point(32, 214);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 20);
            this.label14.TabIndex = 129;
            this.label14.Text = "*";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Navy;
            this.label15.Location = new System.Drawing.Point(32, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 20);
            this.label15.TabIndex = 130;
            this.label15.Text = "*";
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Navy;
            this.label16.Location = new System.Drawing.Point(32, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 20);
            this.label16.TabIndex = 131;
            this.label16.Text = "*";
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Navy;
            this.label17.Location = new System.Drawing.Point(32, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 20);
            this.label17.TabIndex = 132;
            this.label17.Text = "*";
            this.label17.Visible = false;
            // 
            // label20ErrorCombo
            // 
            this.label20ErrorCombo.AutoSize = true;
            this.label20ErrorCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20ErrorCombo.ForeColor = System.Drawing.Color.Red;
            this.label20ErrorCombo.Location = new System.Drawing.Point(435, 188);
            this.label20ErrorCombo.Name = "label20ErrorCombo";
            this.label20ErrorCombo.Size = new System.Drawing.Size(16, 20);
            this.label20ErrorCombo.TabIndex = 135;
            this.label20ErrorCombo.Text = "*";
            this.label20ErrorCombo.Visible = false;
            // 
            // label20ErrorEdad
            // 
            this.label20ErrorEdad.AutoSize = true;
            this.label20ErrorEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20ErrorEdad.ForeColor = System.Drawing.Color.Red;
            this.label20ErrorEdad.Location = new System.Drawing.Point(435, 214);
            this.label20ErrorEdad.Name = "label20ErrorEdad";
            this.label20ErrorEdad.Size = new System.Drawing.Size(16, 20);
            this.label20ErrorEdad.TabIndex = 136;
            this.label20ErrorEdad.Text = "*";
            this.label20ErrorEdad.Visible = false;
            // 
            // labelErrorPeso
            // 
            this.labelErrorPeso.AutoSize = true;
            this.labelErrorPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPeso.ForeColor = System.Drawing.Color.Red;
            this.labelErrorPeso.Location = new System.Drawing.Point(435, 240);
            this.labelErrorPeso.Name = "labelErrorPeso";
            this.labelErrorPeso.Size = new System.Drawing.Size(16, 20);
            this.labelErrorPeso.TabIndex = 137;
            this.labelErrorPeso.Text = "*";
            this.labelErrorPeso.Visible = false;
            // 
            // lblCifError
            // 
            this.lblCifError.AutoSize = true;
            this.lblCifError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCifError.ForeColor = System.Drawing.Color.Red;
            this.lblCifError.Location = new System.Drawing.Point(442, 315);
            this.lblCifError.Name = "lblCifError";
            this.lblCifError.Size = new System.Drawing.Size(16, 20);
            this.lblCifError.TabIndex = 138;
            this.lblCifError.Text = "*";
            this.lblCifError.Visible = false;
            // 
            // atletaBindingSource5
            // 
            this.atletaBindingSource5.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource4
            // 
            this.atletaBindingSource4.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource3
            // 
            this.atletaBindingSource3.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource2
            // 
            this.atletaBindingSource2.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource1
            // 
            this.atletaBindingSource1.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource
            // 
            this.atletaBindingSource.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // FrmGestionDeAtletas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1100, 450);
            this.Controls.Add(this.lblCifError);
            this.Controls.Add(this.labelErrorPeso);
            this.Controls.Add(this.label20ErrorEdad);
            this.Controls.Add(this.label20ErrorCombo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblErrorCorreo);
            this.Controls.Add(this.lblErrorSexo);
            this.Controls.Add(this.lblErrorNacionalidad);
            this.Controls.Add(this.lblErrorApellido);
            this.Controls.Add(this.lblErrorNombre);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.comboBoxBuscar);
            this.Controls.Add(this.dgvGestionAtletas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.comboBoxCategoria);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.mtxCIF);
            this.Controls.Add(this.mtxTelefono);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioBFemenino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioBMasculino);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnContratar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnDespedir);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGestionDeAtletas";
            this.Text = "GestionDeAtletas";
            this.Load += new System.EventHandler(this.FrmGestionDeAtletas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionAtletas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.snakeCaseNamingStrategyBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        #endregion
        private System.Windows.Forms.BindingSource snakeCaseNamingStrategyBindingSource;
        private System.Windows.Forms.BindingSource atletaBindingSource;
        private System.Windows.Forms.Button btnDespedir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnContratar;
        private System.Windows.Forms.BindingSource atletaBindingSource1;
        private System.Windows.Forms.BindingSource snakeCaseNamingStrategyBindingSource1;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.MaskedTextBox mtxCIF;
        private System.Windows.Forms.MaskedTextBox mtxTelefono;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioBFemenino;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioBMasculino;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.BindingSource atletaBindingSource2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource atletaBindingSource3;
        private System.Windows.Forms.DataGridView dgvGestionAtletas;
        private System.Windows.Forms.BindingSource atletaBindingSource4;
        private System.Windows.Forms.BindingSource snakeCaseNamingStrategyBindingSource2;
        private System.Windows.Forms.BindingSource snakeCaseNamingStrategyBindingSource3;
        private System.Windows.Forms.ComboBox comboBoxBuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblErrorNombre;
        private System.Windows.Forms.Label lblErrorApellido;
        private System.Windows.Forms.Label lblErrorNacionalidad;
        private System.Windows.Forms.Label lblErrorSexo;
        private System.Windows.Forms.Label lblErrorCorreo;
        private System.Windows.Forms.BindingSource atletaBindingSource5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20ErrorCombo;
        private System.Windows.Forms.Label label20ErrorEdad;
        private System.Windows.Forms.Label labelErrorPeso;
        private System.Windows.Forms.Label lblCifError;
    }
}