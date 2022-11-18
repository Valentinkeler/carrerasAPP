namespace CarreasAPP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.Label();
            this.cboTitulo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAÑO = new System.Windows.Forms.TextBox();
            this.cboMaterias = new System.Windows.Forms.ComboBox();
            this.rbtPrimerCuatri = new System.Windows.Forms.RadioButton();
            this.rbtSegundoCuatri = new System.Windows.Forms.RadioButton();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(90, 28);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(121, 23);
            this.txtCarrera.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(29, 31);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(43, 15);
            this.nombre.TabIndex = 1;
            this.nombre.Text = "carrera";
            // 
            // cboTitulo
            // 
            this.cboTitulo.FormattingEnabled = true;
            this.cboTitulo.Location = new System.Drawing.Point(90, 75);
            this.cboTitulo.Name = "cboTitulo";
            this.cboTitulo.Size = new System.Drawing.Size(121, 23);
            this.cboTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "año de cursado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "materia";
            // 
            // txtAÑO
            // 
            this.txtAÑO.Location = new System.Drawing.Point(390, 23);
            this.txtAÑO.Name = "txtAÑO";
            this.txtAÑO.Size = new System.Drawing.Size(121, 23);
            this.txtAÑO.TabIndex = 6;
            // 
            // cboMaterias
            // 
            this.cboMaterias.FormattingEnabled = true;
            this.cboMaterias.Location = new System.Drawing.Point(390, 74);
            this.cboMaterias.Name = "cboMaterias";
            this.cboMaterias.Size = new System.Drawing.Size(121, 23);
            this.cboMaterias.TabIndex = 7;
            // 
            // rbtPrimerCuatri
            // 
            this.rbtPrimerCuatri.AutoSize = true;
            this.rbtPrimerCuatri.Location = new System.Drawing.Point(211, 129);
            this.rbtPrimerCuatri.Name = "rbtPrimerCuatri";
            this.rbtPrimerCuatri.Size = new System.Drawing.Size(129, 19);
            this.rbtPrimerCuatri.TabIndex = 8;
            this.rbtPrimerCuatri.TabStop = true;
            this.rbtPrimerCuatri.Text = "primer cuatrimestre";
            this.rbtPrimerCuatri.UseVisualStyleBackColor = true;
            // 
            // rbtSegundoCuatri
            // 
            this.rbtSegundoCuatri.AutoSize = true;
            this.rbtSegundoCuatri.Location = new System.Drawing.Point(371, 129);
            this.rbtSegundoCuatri.Name = "rbtSegundoCuatri";
            this.rbtSegundoCuatri.Size = new System.Drawing.Size(140, 19);
            this.rbtSegundoCuatri.TabIndex = 9;
            this.rbtSegundoCuatri.TabStop = true;
            this.rbtSegundoCuatri.Text = "segundo cuatrimestre";
            this.rbtSegundoCuatri.UseVisualStyleBackColor = true;
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(587, 46);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(108, 23);
            this.btnAgregarMateria.TabIndex = 10;
            this.btnAgregarMateria.Text = "agregar materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(658, 196);
            this.dataGridView1.TabIndex = 11;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(37, 408);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(108, 23);
            this.btnNuevo.TabIndex = 12;
            this.btnNuevo.Text = "nueva";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "gruardar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(390, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(587, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 459);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.rbtSegundoCuatri);
            this.Controls.Add(this.rbtPrimerCuatri);
            this.Controls.Add(this.cboMaterias);
            this.Controls.Add(this.txtAÑO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTitulo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.txtCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtCarrera;
        private Label nombre;
        private ComboBox cboTitulo;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtAÑO;
        private ComboBox cboMaterias;
        private RadioButton rbtPrimerCuatri;
        private RadioButton rbtSegundoCuatri;
        private Button btnAgregarMateria;
        private DataGridView dataGridView1;
        private Button btnNuevo;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}