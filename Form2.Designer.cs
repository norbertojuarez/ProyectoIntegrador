
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
            this.btnMenuCatalogo = new System.Windows.Forms.Button();
            this.btnMenuGenero = new System.Windows.Forms.Button();
            this.btnMenuUltimos = new System.Windows.Forms.Button();
            this.btnMenuLeidos = new System.Windows.Forms.Button();
            this.btnMenuAutor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMenuBienvenida
            // 
            this.labelMenuBienvenida.AutoSize = true;
            this.labelMenuBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuBienvenida.Location = new System.Drawing.Point(362, 39);
            this.labelMenuBienvenida.Name = "labelMenuBienvenida";
            this.labelMenuBienvenida.Size = new System.Drawing.Size(52, 18);
            this.labelMenuBienvenida.TabIndex = 0;
            this.labelMenuBienvenida.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.panel1.Controls.Add(this.btnMenuAutor);
            this.panel1.Controls.Add(this.btnMenuLeidos);
            this.panel1.Controls.Add(this.btnMenuUltimos);
            this.panel1.Controls.Add(this.btnMenuGenero);
            this.panel1.Controls.Add(this.btnMenuCatalogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 450);
            this.panel1.TabIndex = 1;
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
            // 
            // btnMenuGenero
            // 
            this.btnMenuGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuGenero.ForeColor = System.Drawing.Color.White;
            this.btnMenuGenero.Location = new System.Drawing.Point(0, 120);
            this.btnMenuGenero.Name = "btnMenuGenero";
            this.btnMenuGenero.Size = new System.Drawing.Size(267, 35);
            this.btnMenuGenero.TabIndex = 7;
            this.btnMenuGenero.Text = "SELECCIONAR GENERO";
            this.btnMenuGenero.UseVisualStyleBackColor = false;
            // 
            // btnMenuUltimos
            // 
            this.btnMenuUltimos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuUltimos.ForeColor = System.Drawing.Color.White;
            this.btnMenuUltimos.Location = new System.Drawing.Point(0, 203);
            this.btnMenuUltimos.Name = "btnMenuUltimos";
            this.btnMenuUltimos.Size = new System.Drawing.Size(267, 35);
            this.btnMenuUltimos.TabIndex = 8;
            this.btnMenuUltimos.Text = "ULTIMOS INGRESOS";
            this.btnMenuUltimos.UseVisualStyleBackColor = false;
            // 
            // btnMenuLeidos
            // 
            this.btnMenuLeidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuLeidos.ForeColor = System.Drawing.Color.White;
            this.btnMenuLeidos.Location = new System.Drawing.Point(0, 244);
            this.btnMenuLeidos.Name = "btnMenuLeidos";
            this.btnMenuLeidos.Size = new System.Drawing.Size(267, 35);
            this.btnMenuLeidos.TabIndex = 9;
            this.btnMenuLeidos.Text = "MAS LEIDOS";
            this.btnMenuLeidos.UseVisualStyleBackColor = false;
            // 
            // btnMenuAutor
            // 
            this.btnMenuAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnMenuAutor.ForeColor = System.Drawing.Color.White;
            this.btnMenuAutor.Location = new System.Drawing.Point(0, 162);
            this.btnMenuAutor.Name = "btnMenuAutor";
            this.btnMenuAutor.Size = new System.Drawing.Size(267, 35);
            this.btnMenuAutor.TabIndex = 10;
            this.btnMenuAutor.Text = "SELECCIONAR AUTOR";
            this.btnMenuAutor.UseVisualStyleBackColor = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelMenuBienvenida);
            this.Name = "FormMenu";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuBienvenida;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnMenuCatalogo;
        private System.Windows.Forms.Button btnMenuAutor;
        private System.Windows.Forms.Button btnMenuLeidos;
        private System.Windows.Forms.Button btnMenuUltimos;
        private System.Windows.Forms.Button btnMenuGenero;
    }
}