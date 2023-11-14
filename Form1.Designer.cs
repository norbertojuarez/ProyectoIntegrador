
namespace TrabajoIntegrador
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panelLoginLogo = new System.Windows.Forms.Panel();
            this.labelLogin = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.labelLoginIFTS = new System.Windows.Forms.Label();
            this.labelLoginBiblioteca = new System.Windows.Forms.Label();
            this.pictureBoxLoginLogo = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLoginUsuario = new System.Windows.Forms.TextBox();
            this.textBoxLoginContrasenia = new System.Windows.Forms.TextBox();
            this.btnLoginIngresar = new System.Windows.Forms.Button();
            this.labelLoginCerrar = new System.Windows.Forms.Label();
            this.labelLoginError = new System.Windows.Forms.Label();
            this.panelLoginLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLoginLogo
            // 
            this.panelLoginLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.panelLoginLogo.Controls.Add(this.labelLogin);
            this.panelLoginLogo.Controls.Add(this.btnRegistro);
            this.panelLoginLogo.Controls.Add(this.labelLoginIFTS);
            this.panelLoginLogo.Controls.Add(this.labelLoginBiblioteca);
            this.panelLoginLogo.Controls.Add(this.pictureBoxLoginLogo);
            this.panelLoginLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLoginLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLoginLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelLoginLogo.Name = "panelLoginLogo";
            this.panelLoginLogo.Size = new System.Drawing.Size(267, 462);
            this.panelLoginLogo.TabIndex = 0;
            // 
            // labelLogin
            // 
            this.labelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(39, 354);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(192, 15);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Que esperás para asociarte?";
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnRegistro.ForeColor = System.Drawing.Color.White;
            this.btnRegistro.Location = new System.Drawing.Point(78, 391);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(110, 35);
            this.btnRegistro.TabIndex = 6;
            this.btnRegistro.Text = "ASOCIATE";
            this.btnRegistro.UseVisualStyleBackColor = false;
            this.btnRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelLoginIFTS
            // 
            this.labelLoginIFTS.AutoSize = true;
            this.labelLoginIFTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.labelLoginIFTS.Font = new System.Drawing.Font("Stencil", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginIFTS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.labelLoginIFTS.Location = new System.Drawing.Point(39, 288);
            this.labelLoginIFTS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginIFTS.Name = "labelLoginIFTS";
            this.labelLoginIFTS.Size = new System.Drawing.Size(192, 46);
            this.labelLoginIFTS.TabIndex = 2;
            this.labelLoginIFTS.Text = "IFTS N 11";
            this.labelLoginIFTS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLoginBiblioteca
            // 
            this.labelLoginBiblioteca.AutoSize = true;
            this.labelLoginBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.labelLoginBiblioteca.Font = new System.Drawing.Font("Stencil", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginBiblioteca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.labelLoginBiblioteca.Location = new System.Drawing.Point(13, 231);
            this.labelLoginBiblioteca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLoginBiblioteca.Name = "labelLoginBiblioteca";
            this.labelLoginBiblioteca.Size = new System.Drawing.Size(241, 46);
            this.labelLoginBiblioteca.TabIndex = 1;
            this.labelLoginBiblioteca.Text = "BIBLIOTECA";
            this.labelLoginBiblioteca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLoginLogo
            // 
            this.pictureBoxLoginLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxLoginLogo.BackgroundImage")));
            this.pictureBoxLoginLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLoginLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLoginLogo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pictureBoxLoginLogo.Name = "pictureBoxLoginLogo";
            this.pictureBoxLoginLogo.Size = new System.Drawing.Size(267, 228);
            this.pictureBoxLoginLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLoginLogo.TabIndex = 0;
            this.pictureBoxLoginLogo.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label3.Location = new System.Drawing.Point(349, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "USUARIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.label4.Location = new System.Drawing.Point(349, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "CONTRASEÑA";
            // 
            // textBoxLoginUsuario
            // 
            this.textBoxLoginUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(145)))));
            this.textBoxLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(5)))));
            this.textBoxLoginUsuario.Location = new System.Drawing.Point(353, 172);
            this.textBoxLoginUsuario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLoginUsuario.Name = "textBoxLoginUsuario";
            this.textBoxLoginUsuario.Size = new System.Drawing.Size(355, 22);
            this.textBoxLoginUsuario.TabIndex = 3;
            // 
            // textBoxLoginContrasenia
            // 
            this.textBoxLoginContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(145)))));
            this.textBoxLoginContrasenia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLoginContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLoginContrasenia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(5)))));
            this.textBoxLoginContrasenia.Location = new System.Drawing.Point(353, 246);
            this.textBoxLoginContrasenia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxLoginContrasenia.Name = "textBoxLoginContrasenia";
            this.textBoxLoginContrasenia.Size = new System.Drawing.Size(355, 22);
            this.textBoxLoginContrasenia.TabIndex = 4;
            this.textBoxLoginContrasenia.UseSystemPasswordChar = true;
            // 
            // btnLoginIngresar
            // 
            this.btnLoginIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(129)))), ((int)(((byte)(84)))));
            this.btnLoginIngresar.ForeColor = System.Drawing.Color.White;
            this.btnLoginIngresar.Location = new System.Drawing.Point(598, 321);
            this.btnLoginIngresar.Name = "btnLoginIngresar";
            this.btnLoginIngresar.Size = new System.Drawing.Size(110, 35);
            this.btnLoginIngresar.TabIndex = 5;
            this.btnLoginIngresar.Text = "INGRESAR";
            this.btnLoginIngresar.UseVisualStyleBackColor = false;
            this.btnLoginIngresar.Click += new System.EventHandler(this.btnLoginIngresar_Click);
            // 
            // labelLoginCerrar
            // 
            this.labelLoginCerrar.AutoSize = true;
            this.labelLoginCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLoginCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLoginCerrar.Location = new System.Drawing.Point(765, 9);
            this.labelLoginCerrar.Name = "labelLoginCerrar";
            this.labelLoginCerrar.Size = new System.Drawing.Size(19, 18);
            this.labelLoginCerrar.TabIndex = 6;
            this.labelLoginCerrar.Text = "X";
            this.labelLoginCerrar.Click += new System.EventHandler(this.labelLoginCerrar_Click);
            // 
            // labelLoginError
            // 
            this.labelLoginError.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.labelLoginError.AutoSize = true;
            this.labelLoginError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.labelLoginError.Location = new System.Drawing.Point(350, 288);
            this.labelLoginError.Name = "labelLoginError";
            this.labelLoginError.Size = new System.Drawing.Size(0, 15);
            this.labelLoginError.TabIndex = 8;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(224)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(793, 462);
            this.Controls.Add(this.labelLoginError);
            this.Controls.Add(this.labelLoginCerrar);
            this.Controls.Add(this.btnLoginIngresar);
            this.Controls.Add(this.textBoxLoginContrasenia);
            this.Controls.Add(this.textBoxLoginUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelLoginLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(74)))), ((int)(((byte)(57)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormLogin";
            this.Opacity = 0.95D;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormLogin_MouseUp);
            this.panelLoginLogo.ResumeLayout(false);
            this.panelLoginLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLoginLogo;
        private System.Windows.Forms.PictureBox pictureBoxLoginLogo;
        private System.Windows.Forms.Label labelLoginBiblioteca;
        private System.Windows.Forms.Label labelLoginIFTS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLoginUsuario;
        private System.Windows.Forms.TextBox textBoxLoginContrasenia;
        private System.Windows.Forms.Button btnLoginIngresar;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLoginCerrar;
        private System.Windows.Forms.Label labelLoginError;
    }
}

