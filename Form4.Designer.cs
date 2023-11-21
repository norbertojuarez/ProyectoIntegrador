
namespace TrabajoIntegrador
{
    partial class FormAdministrador
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAutor = new System.Windows.Forms.TextBox();
            this.textBoxImagen = new System.Windows.Forms.TextBox();
            this.textBoxLibro = new System.Windows.Forms.TextBox();
            this.BtnAgregarLibro = new System.Windows.Forms.Button();
            this.BtnAgregarImagen = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BtnAgregarPdf = new System.Windows.Forms.Button();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 450);
            this.panel1.TabIndex = 0;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(312, 98);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(100, 20);
            this.textBoxId.TabIndex = 2;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(312, 139);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(469, 20);
            this.textBoxTitulo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Título";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Autor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Imagen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Libro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(309, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Género";
            // 
            // textBoxAutor
            // 
            this.textBoxAutor.Location = new System.Drawing.Point(312, 180);
            this.textBoxAutor.Name = "textBoxAutor";
            this.textBoxAutor.Size = new System.Drawing.Size(469, 20);
            this.textBoxAutor.TabIndex = 12;
            // 
            // textBoxImagen
            // 
            this.textBoxImagen.Location = new System.Drawing.Point(312, 222);
            this.textBoxImagen.Name = "textBoxImagen";
            this.textBoxImagen.Size = new System.Drawing.Size(438, 20);
            this.textBoxImagen.TabIndex = 13;
            // 
            // textBoxLibro
            // 
            this.textBoxLibro.Location = new System.Drawing.Point(312, 264);
            this.textBoxLibro.Name = "textBoxLibro";
            this.textBoxLibro.Size = new System.Drawing.Size(438, 20);
            this.textBoxLibro.TabIndex = 14;
            // 
            // BtnAgregarLibro
            // 
            this.BtnAgregarLibro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.BtnAgregarLibro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarLibro.ForeColor = System.Drawing.Color.White;
            this.BtnAgregarLibro.Location = new System.Drawing.Point(671, 346);
            this.BtnAgregarLibro.Name = "BtnAgregarLibro";
            this.BtnAgregarLibro.Size = new System.Drawing.Size(110, 35);
            this.BtnAgregarLibro.TabIndex = 16;
            this.BtnAgregarLibro.Text = "AGREGAR";
            this.BtnAgregarLibro.UseVisualStyleBackColor = false;
            this.BtnAgregarLibro.Click += new System.EventHandler(this.BtnAgregarLibro_Click);
            // 
            // BtnAgregarImagen
            // 
            this.BtnAgregarImagen.BackColor = System.Drawing.Color.White;
            this.BtnAgregarImagen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarImagen.Location = new System.Drawing.Point(753, 222);
            this.BtnAgregarImagen.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregarImagen.Name = "BtnAgregarImagen";
            this.BtnAgregarImagen.Size = new System.Drawing.Size(28, 22);
            this.BtnAgregarImagen.TabIndex = 17;
            this.BtnAgregarImagen.Text = "...";
            this.BtnAgregarImagen.UseVisualStyleBackColor = false;
            this.BtnAgregarImagen.Click += new System.EventHandler(this.BtnAgregarImagen_click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "jpg files (*.jpg)|*.jpg";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "novela",
            "ciencia ficcion",
            "relato",
            "infantil",
            "programacion"});
            this.comboBox1.Location = new System.Drawing.Point(312, 306);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            // 
            // BtnAgregarPdf
            // 
            this.BtnAgregarPdf.BackColor = System.Drawing.Color.White;
            this.BtnAgregarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPdf.Location = new System.Drawing.Point(753, 264);
            this.BtnAgregarPdf.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAgregarPdf.Name = "BtnAgregarPdf";
            this.BtnAgregarPdf.Size = new System.Drawing.Size(28, 22);
            this.BtnAgregarPdf.TabIndex = 19;
            this.BtnAgregarPdf.Text = "...";
            this.BtnAgregarPdf.UseVisualStyleBackColor = false;
            this.BtnAgregarPdf.Click += new System.EventHandler(this.BtnAgregarPdf_click);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.Filter = "Pdf files (*.pdf)|*.pdf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label7.Location = new System.Drawing.Point(435, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(258, 39);
            this.label7.TabIndex = 20;
            this.label7.Text = "Agregar Libros";
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(834, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnAgregarPdf);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnAgregarImagen);
            this.Controls.Add(this.BtnAgregarLibro);
            this.Controls.Add(this.textBoxLibro);
            this.Controls.Add(this.textBoxImagen);
            this.Controls.Add(this.textBoxAutor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTitulo);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.panel1);
            this.Name = "FormAdministrador";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdministrador_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAutor;
        private System.Windows.Forms.TextBox textBoxImagen;
        private System.Windows.Forms.TextBox textBoxLibro;
        private System.Windows.Forms.Button BtnAgregarLibro;
        private System.Windows.Forms.Button BtnAgregarImagen;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button BtnAgregarPdf;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Label label7;
    }
}