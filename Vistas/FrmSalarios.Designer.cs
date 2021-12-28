
namespace Proyecto.Vistas
{
    partial class FrmSalarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSalarios));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.dgvSalarios = new System.Windows.Forms.DataGridView();
            this.Salario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1Maximo = new System.Windows.Forms.Button();
            this.button2Minimo = new System.Windows.Forms.Button();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.atletaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.atletaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(460, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salarios de los atletas por evento en $";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Image = global::Proyecto.Properties.Resources.ordenar__2_;
            this.btnOrdenar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrdenar.Location = new System.Drawing.Point(350, 315);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(102, 51);
            this.btnOrdenar.TabIndex = 119;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOrdenar.UseVisualStyleBackColor = false;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click_1);
            // 
            // dgvSalarios
            // 
            this.dgvSalarios.AutoGenerateColumns = false;
            this.dgvSalarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.Salario});
            this.dgvSalarios.DataSource = this.atletaBindingSource1;
            this.dgvSalarios.Location = new System.Drawing.Point(28, 70);
            this.dgvSalarios.Name = "dgvSalarios";
            this.dgvSalarios.Size = new System.Drawing.Size(270, 307);
            this.dgvSalarios.TabIndex = 120;
            // 
            // Salario
            // 
            this.Salario.DataPropertyName = "Salario";
            this.Salario.HeaderText = "Salario";
            this.Salario.Name = "Salario";
            // 
            // button1Maximo
            // 
            this.button1Maximo.BackColor = System.Drawing.Color.SpringGreen;
            this.button1Maximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1Maximo.ForeColor = System.Drawing.Color.Black;
            this.button1Maximo.Location = new System.Drawing.Point(336, 87);
            this.button1Maximo.Name = "button1Maximo";
            this.button1Maximo.Size = new System.Drawing.Size(126, 77);
            this.button1Maximo.TabIndex = 121;
            this.button1Maximo.Text = "Bolsa mas grande pagada";
            this.button1Maximo.UseVisualStyleBackColor = false;
            this.button1Maximo.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2Minimo
            // 
            this.button2Minimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2Minimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2Minimo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2Minimo.Location = new System.Drawing.Point(335, 191);
            this.button2Minimo.Name = "button2Minimo";
            this.button2Minimo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2Minimo.Size = new System.Drawing.Size(127, 73);
            this.button2Minimo.TabIndex = 122;
            this.button2Minimo.Text = "Bolsa mas pequeña pagada";
            this.button2Minimo.UseVisualStyleBackColor = false;
            this.button2Minimo.Click += new System.EventHandler(this.button2_Click);
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // atletaBindingSource1
            // 
            this.atletaBindingSource1.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // atletaBindingSource
            // 
            this.atletaBindingSource.DataSource = typeof(Proyecto.Clases.Atleta);
            // 
            // FrmSalarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(496, 408);
            this.Controls.Add(this.button2Minimo);
            this.Controls.Add(this.button1Maximo);
            this.Controls.Add(this.dgvSalarios);
            this.Controls.Add(this.btnOrdenar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSalarios";
            this.Text = "Salarios y bonificaciones";
            this.Load += new System.EventHandler(this.FrmSalarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atletaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource atletaBindingSource;
        private System.Windows.Forms.BindingSource atletaBindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.DataGridView dgvSalarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salario;
        private System.Windows.Forms.Button button1Maximo;
        private System.Windows.Forms.Button button2Minimo;
    }
}