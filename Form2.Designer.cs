
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
            this.labelMenuBienvenida = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFiltros = new System.Windows.Forms.Label();
            this.comboBoxAutores = new System.Windows.Forms.ComboBox();
            this.groupBoxGenero = new System.Windows.Forms.GroupBox();
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
            this.panel1.Size = new System.Drawing.Size(267, 450);
            this.panel1.TabIndex = 1;
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
            this.comboBoxAutores.Location = new System.Drawing.Point(19, 396);
            this.comboBoxAutores.Name = "comboBoxAutores";
            this.comboBoxAutores.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAutores.TabIndex = 13;
            this.comboBoxAutores.Text = "Autores";
            this.comboBoxAutores.SelectedIndexChanged += new System.EventHandler(this.comboBoxAutores_SelectedIndexChanged);
            // 
            // groupBoxGenero
            // 
            this.groupBoxGenero.Controls.Add(this.radioButton5);
            this.groupBoxGenero.Controls.Add(this.radioButton4);
            this.groupBoxGenero.Controls.Add(this.radioButton3);
            this.groupBoxGenero.Controls.Add(this.radioButton2);
            this.groupBoxGenero.Controls.Add(this.radioButton1);
            this.groupBoxGenero.ForeColor = System.Drawing.Color.White;
            this.groupBoxGenero.Location = new System.Drawing.Point(12, 238);
            this.groupBoxGenero.Name = "groupBoxGenero";
            this.groupBoxGenero.Size = new System.Drawing.Size(252, 139);
            this.groupBoxGenero.TabIndex = 12;
            this.groupBoxGenero.TabStop = false;
            this.groupBoxGenero.Text = "Género";
            this.groupBoxGenero.Enter += new System.EventHandler(this.groupBoxGenero_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(7, 112);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "programación";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(7, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "infantil";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 66);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "relato";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ciencia ficcion";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "novela";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
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
            this.btnMenuLeidos.Click += new System.EventHandler(this.btnMenuLeidos_Click);
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
            this.btnMenuUltimos.Click += new System.EventHandler(this.btnMenuUltimos_Click);
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
            this.btnMenuCatalogo.Click += new System.EventHandler(this.btnMenuCatalogo_Click);
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
            this.panelLibros.Size = new System.Drawing.Size(486, 387);
            this.panelLibros.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelLibros);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMenuBienvenida);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.ResizeEnd += new System.EventHandler(this.FormMenu_ResizeEnd);
            this.Resize += new System.EventHandler(this.FormMenu_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}