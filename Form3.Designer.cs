
namespace TrabajoIntegrador
{
    partial class FormRegistro
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
            this.btnRegistroAsociarse = new System.Windows.Forms.Button();
            this.textBoxRegistroContrasenia = new System.Windows.Forms.TextBox();
            this.textBoxRegistroUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLoginBiblioteca = new System.Windows.Forms.Label();
            this.btnRegistroAceptar = new System.Windows.Forms.Button();
            this.labelRegistroError = new System.Windows.Forms.Label();
            this.labelRegistroExitoso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistroAsociarse
            // 
            this.btnRegistroAsociarse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnRegistroAsociarse.ForeColor = System.Drawing.Color.White;
            this.btnRegistroAsociarse.Location = new System.Drawing.Point(263, 274);
            this.btnRegistroAsociarse.Name = "btnRegistroAsociarse";
            this.btnRegistroAsociarse.Size = new System.Drawing.Size(110, 35);
            this.btnRegistroAsociarse.TabIndex = 10;
            this.btnRegistroAsociarse.Text = "ASOCIARSE";
            this.btnRegistroAsociarse.UseVisualStyleBackColor = false;
            this.btnRegistroAsociarse.Click += new System.EventHandler(this.BtnRegistroAsociarse_Click);
            // 
            // textBoxRegistroContrasenia
            // 
            this.textBoxRegistroContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(145)))));
            this.textBoxRegistroContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistroContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(5)))));
            this.textBoxRegistroContrasenia.Location = new System.Drawing.Point(18, 199);
            this.textBoxRegistroContrasenia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRegistroContrasenia.Name = "textBoxRegistroContrasenia";
            this.textBoxRegistroContrasenia.Size = new System.Drawing.Size(355, 22);
            this.textBoxRegistroContrasenia.TabIndex = 9;
            this.textBoxRegistroContrasenia.UseSystemPasswordChar = true;
            // 
            // textBoxRegistroUsuario
            // 
            this.textBoxRegistroUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(145)))));
            this.textBoxRegistroUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRegistroUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRegistroUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(5)))));
            this.textBoxRegistroUsuario.Location = new System.Drawing.Point(18, 125);
            this.textBoxRegistroUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRegistroUsuario.Name = "textBoxRegistroUsuario";
            this.textBoxRegistroUsuario.Size = new System.Drawing.Size(355, 22);
            this.textBoxRegistroUsuario.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "ELEGÍ UNA CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(14, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ELIGÍ UN NOMBRE DE USUARIO";
            // 
            // labelLoginBiblioteca
            // 
            this.labelLoginBiblioteca.AutoSize = true;
            this.labelLoginBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.labelLoginBiblioteca.Font = new System.Drawing.Font("Stencil", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.labelLoginBiblioteca.Location = new System.Drawing.Point(75, 21);
            this.labelLoginBiblioteca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginBiblioteca.Name = "labelLoginBiblioteca";
            this.labelLoginBiblioteca.Size = new System.Drawing.Size(251, 46);
            this.labelLoginBiblioteca.TabIndex = 11;
            this.labelLoginBiblioteca.Text = "Registrate";
            this.labelLoginBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistroAceptar
            // 
            this.btnRegistroAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnRegistroAceptar.ForeColor = System.Drawing.Color.White;
            this.btnRegistroAceptar.Location = new System.Drawing.Point(263, 274);
            this.btnRegistroAceptar.Name = "btnRegistroAceptar";
            this.btnRegistroAceptar.Size = new System.Drawing.Size(110, 35);
            this.btnRegistroAceptar.TabIndex = 12;
            this.btnRegistroAceptar.Text = "ACEPTAR";
            this.btnRegistroAceptar.UseVisualStyleBackColor = false;
            this.btnRegistroAceptar.Visible = false;
            this.btnRegistroAceptar.Click += new System.EventHandler(this.BtnRegistroAceptar_Click);
            // 
            // labelRegistroError
            // 
            this.labelRegistroError.AutoSize = true;
            this.labelRegistroError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroError.ForeColor = System.Drawing.Color.Maroon;
            this.labelRegistroError.Location = new System.Drawing.Point(18, 240);
            this.labelRegistroError.Name = "labelRegistroError";
            this.labelRegistroError.Size = new System.Drawing.Size(0, 15);
            this.labelRegistroError.TabIndex = 13;
            // 
            // labelRegistroExitoso
            // 
            this.labelRegistroExitoso.AutoSize = true;
            this.labelRegistroExitoso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistroExitoso.ForeColor = System.Drawing.Color.Green;
            this.labelRegistroExitoso.Location = new System.Drawing.Point(18, 283);
            this.labelRegistroExitoso.Name = "labelRegistroExitoso";
            this.labelRegistroExitoso.Size = new System.Drawing.Size(0, 15);
            this.labelRegistroExitoso.TabIndex = 14;
            // 
            // FormRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(416, 340);
            this.Controls.Add(this.labelRegistroExitoso);
            this.Controls.Add(this.labelRegistroError);
            this.Controls.Add(this.btnRegistroAceptar);
            this.Controls.Add(this.labelLoginBiblioteca);
            this.Controls.Add(this.btnRegistroAsociarse);
            this.Controls.Add(this.textBoxRegistroContrasenia);
            this.Controls.Add(this.textBoxRegistroUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormRegistro";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormRegistro_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroAsociarse;
        private System.Windows.Forms.TextBox textBoxRegistroContrasenia;
        private System.Windows.Forms.TextBox textBoxRegistroUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLoginBiblioteca;
        private System.Windows.Forms.Button btnRegistroAceptar;
        private System.Windows.Forms.Label labelRegistroError;
        private System.Windows.Forms.Label labelRegistroExitoso;
    }
}