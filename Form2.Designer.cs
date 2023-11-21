
namespace TrabajoIntegrador
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.labelMenuBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconoLibro2 = new System.Windows.Forms.PictureBox();
            this.iconoLibro = new System.Windows.Forms.PictureBox();
            this.labelFiltros = new System.Windows.Forms.Label();
            this.comboBoxAutores = new System.Windows.Forms.ComboBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
            this.radioButton10 = new System.Windows.Forms.RadioButton();
            this.radioButton9 = new System.Windows.Forms.RadioButton();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnMenuLeidos = new System.Windows.Forms.Button();
            this.btnMenuUltimos = new System.Windows.Forms.Button();
            this.btnMenuCatalogo = new System.Windows.Forms.Button();
            this.panelLibros = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLibro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLibro)).BeginInit();
            this.groupBoxGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMenuBienvenida
            // 
            this.labelMenuBienvenida.AutoSize = true;
            this.labelMenuBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuBienvenida.Location = new System.Drawing.Point(359, 19);
            this.labelMenuBienvenida.Name = "labelMenuBienvenida";
            this.labelMenuBienvenida.Size = new System.Drawing.Size(52, 18);
            this.labelMenuBienvenida.TabIndex = 0;
            this.labelMenuBienvenida.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.iconoLibro2);
            this.panel1.Controls.Add(this.iconoLibro);
            this.panel1.Controls.Add(this.labelFiltros);
            this.panel1.Controls.Add(this.comboBoxAutores);
            this.panel1.Controls.Add(this.groupBoxGenero);
            this.panel1.Controls.Add(this.btnMenuLeidos);
            this.panel1.Controls.Add(this.btnMenuUltimos);
            this.panel1.Controls.Add(this.btnMenuCatalogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 541);
            this.panel1.TabIndex = 1;
            // 
            // iconoLibro2
            // 
            this.iconoLibro2.Image = ((System.Drawing.Image)(resources.GetObject("iconoLibro2.Image")));
            this.iconoLibro2.Location = new System.Drawing.Point(198, 12);
            this.iconoLibro2.Name = "iconoLibro2";
            this.iconoLibro2.Size = new System.Drawing.Size(44, 43);
            this.iconoLibro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoLibro2.TabIndex = 15;
            this.iconoLibro2.TabStop = false;
            this.iconoLibro2.Visible = false;
            this.iconoLibro2.Click += new System.EventHandler(this.IconoLibro2_Click);
            this.iconoLibro2.MouseLeave += new System.EventHandler(this.IconoLibro2_MouseLeave);
            // 
            // iconoLibro
            // 
            this.iconoLibro.Image = ((System.Drawing.Image)(resources.GetObject("iconoLibro.Image")));
            this.iconoLibro.Location = new System.Drawing.Point(198, 12);
            this.iconoLibro.Name = "iconoLibro";
            this.iconoLibro.Size = new System.Drawing.Size(44, 43);
            this.iconoLibro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconoLibro.TabIndex = 14;
            this.iconoLibro.TabStop = false;
            this.iconoLibro.Visible = false;
            this.iconoLibro.MouseHover += new System.EventHandler(this.IconoLibro_MouseHover);
            // 
            // labelFiltros
            // 
            this.labelFiltros.AutoSize = true;
            this.labelFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFiltros.ForeColor = System.Drawing.Color.White;
            this.labelFiltros.Location = new System.Drawing.Point(9, 214);
            this.labelFiltros.Name = "labelFiltros";
            this.labelFiltros.Size = new System.Drawing.Size(52, 18);
            this.labelFiltros.TabIndex = 3;
            this.labelFiltros.Text = "Filtrar";
            // 
            // comboBoxAutores
            // 
            this.comboBoxAutores.FormattingEnabled = true;
            this.comboBoxAutores.Location = new System.Drawing.Point(19, 508);
            this.comboBoxAutores.Name = "comboBoxAutores";
            this.comboBoxAutores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutores.TabIndex = 13;
            this.comboBoxAutores.Text = "Autores";
            this.comboBoxAutores.SelectedIndexChanged += new System.EventHandler(this.ComboBoxAutores_SelectedIndexChanged);
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButton10);
            this.groupBoxGenero.Controls.Add(this.radioButton9);
            this.groupBoxGenero.Controls.Add(this.radioButton8);
            this.groupBoxGenero.Controls.Add(this.radioButton7);
            this.groupBoxGenero.Controls.Add(this.radioButton6);
            this.groupBoxGenero.Controls.Add(this.radioButton5);
            this.groupBoxGenero.Controls.Add(this.radioButton4);
            this.groupBoxGenero.Controls.Add(this.radioButton3);
            this.groupBoxGenero.Controls.Add(this.radioButton2);
            this.groupBoxGenero.Controls.Add(this.radioButton1);
            this.groupBoxGenero.ForeColor = System.Drawing.Color.White;
            this.groupBoxGenero.Location = new System.Drawing.Point(12, 238);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(252, 253);
            this.groupBoxGenero.TabIndex = 12;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            // 
            // radioButton10
            // 
            this.radioButton10.AutoSize = true;
            this.radioButton10.Location = new System.Drawing.Point(7, 88);
            this.radioButton10.Name = "radioButton10";
            this.radioButton10.Size = new System.Drawing.Size(86, 17);
            this.radioButton10.TabIndex = 9;
            this.radioButton10.TabStop = true;
            this.radioButton10.Text = "espiritualidad";
            this.radioButton10.UseVisualStyleBackColor = true;
            this.radioButton10.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton9
            // 
            this.radioButton9.AutoSize = true;
            this.radioButton9.Location = new System.Drawing.Point(7, 226);
            this.radioButton9.Name = "radioButton9";
            this.radioButton9.Size = new System.Drawing.Size(49, 17);
            this.radioButton9.TabIndex = 8;
            this.radioButton9.TabStop = true;
            this.radioButton9.Text = "terror";
            this.radioButton9.UseVisualStyleBackColor = true;
            this.radioButton9.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton8
            // 
            this.radioButton8.AutoSize = true;
            this.radioButton8.Location = new System.Drawing.Point(7, 19);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(67, 17);
            this.radioButton8.TabIndex = 7;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "aventura";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton7
            // 
            this.radioButton7.AutoSize = true;
            this.radioButton7.Location = new System.Drawing.Point(7, 65);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(54, 17);
            this.radioButton7.TabIndex = 6;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "drama";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(7, 42);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(58, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "clasico";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 203);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "programacion";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 134);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "infantil";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 180);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(57, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "policial";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 111);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "fantasia/c. ficcion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 157);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "novela";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // btnMenuLeidos
            // 
            this.btnMenuLeidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuLeidos.ForeColor = System.Drawing.Color.White;
            this.btnMenuLeidos.Location = new System.Drawing.Point(0, 161);
            this.btnMenuLeidos.Name = "btnMenuLeidos";
            this.btnMenuLeidos.Size = new System.Drawing.Size(267, 35);
            this.btnMenuLeidos.TabIndex = 9;
            this.btnMenuLeidos.Text = "MAS LEIDOS";
            this.btnMenuLeidos.UseVisualStyleBackColor = false;
            this.btnMenuLeidos.Click += new System.EventHandler(this.BtnMenuLeidos_Click);
            // 
            // btnMenuUltimos
            // 
            this.btnMenuUltimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuUltimos.ForeColor = System.Drawing.Color.White;
            this.btnMenuUltimos.Location = new System.Drawing.Point(0, 120);
            this.btnMenuUltimos.Name = "btnMenuUltimos";
            this.btnMenuUltimos.Size = new System.Drawing.Size(267, 35);
            this.btnMenuUltimos.TabIndex = 8;
            this.btnMenuUltimos.Text = "ULTIMOS INGRESOS";
            this.btnMenuUltimos.UseVisualStyleBackColor = false;
            this.btnMenuUltimos.Click += new System.EventHandler(this.BtnMenuUltimos_Click);
            // 
            // btnMenuCatalogo
            // 
            this.btnMenuCatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuCatalogo.ForeColor = System.Drawing.Color.White;
            this.btnMenuCatalogo.Location = new System.Drawing.Point(0, 79);
            this.btnMenuCatalogo.Name = "btnMenuCatalogo";
            this.btnMenuCatalogo.Size = new System.Drawing.Size(267, 35);
            this.btnMenuCatalogo.TabIndex = 6;
            this.btnMenuCatalogo.Text = "CATALOGO GENERAL";
            this.btnMenuCatalogo.UseVisualStyleBackColor = false;
            this.btnMenuCatalogo.Click += new System.EventHandler(this.BtnMenuCatalogo_Click);
            // 
            // panelLibros
            // 
            this.panelLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLibros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLibros.Location = new System.Drawing.Point(302, 51);
            this.panelLibros.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.panelLibros.MinimumSize = new System.Drawing.Size(486, 387);
            this.panelLibros.Name = "panelLibros";
            this.panelLibros.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.panelLibros.Size = new System.Drawing.Size(520, 478);
            this.panelLibros.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(834, 541);
            this.Controls.Add(this.panelLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMenuBienvenida);
            this.MinimumSize = new System.Drawing.Size(850, 489);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMenu_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.FormMenu_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLibro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconoLibro)).EndInit();
            this.groupBoxGenero.ResumeLayout(false);
            this.groupBoxGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuCatalogo;
        private System.Windows.Forms.Button btnMenuLeidos;
        private System.Windows.Forms.Button btnMenuUltimos;
        private System.Windows.Forms.Panel panelLibros;
        private System.Windows.Forms.GroupBox groupBoxGenero;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBoxAutores;
        private System.Windows.Forms.Label labelFiltros;
        private System.Windows.Forms.PictureBox iconoLibro;
        private System.Windows.Forms.PictureBox iconoLibro2;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton10;
    }
}