namespace Proyecto_Final_Programacion_2
{
    partial class Formprincipal
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Computadoras = new FontAwesome.Sharp.IconButton();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.HistorialPc = new FontAwesome.Sharp.IconButton();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Barra_de_titulo = new System.Windows.Forms.Panel();
            this.icono_form_principal = new FontAwesome.Sharp.IconPictureBox();
            this.titulo_de_form = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Barra_de_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_form_principal)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.BtnConfiguracion);
            this.PanelMenu.Controls.Add(this.HistorialPc);
            this.PanelMenu.Controls.Add(this.Computadoras);
            this.PanelMenu.Controls.Add(this.Home);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 425);
            this.PanelMenu.TabIndex = 0;
            // 
            // Computadoras
            // 
            this.Computadoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Computadoras.FlatAppearance.BorderSize = 0;
            this.Computadoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Computadoras.ForeColor = System.Drawing.Color.Gainsboro;
            this.Computadoras.IconChar = FontAwesome.Sharp.IconChar.Laptop;
            this.Computadoras.IconColor = System.Drawing.Color.Gainsboro;
            this.Computadoras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Computadoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Computadoras.Location = new System.Drawing.Point(0, 200);
            this.Computadoras.Name = "Computadoras";
            this.Computadoras.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Computadoras.Size = new System.Drawing.Size(200, 60);
            this.Computadoras.TabIndex = 1;
            this.Computadoras.Text = "Computadoras";
            this.Computadoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Computadoras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Computadoras.UseVisualStyleBackColor = true;
            this.Computadoras.Click += new System.EventHandler(this.Computadoras_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // HistorialPc
            // 
            this.HistorialPc.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistorialPc.FlatAppearance.BorderSize = 0;
            this.HistorialPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistorialPc.ForeColor = System.Drawing.Color.Gainsboro;
            this.HistorialPc.IconChar = FontAwesome.Sharp.IconChar.Cloud;
            this.HistorialPc.IconColor = System.Drawing.Color.Gainsboro;
            this.HistorialPc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.HistorialPc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistorialPc.Location = new System.Drawing.Point(0, 260);
            this.HistorialPc.Name = "HistorialPc";
            this.HistorialPc.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.HistorialPc.Size = new System.Drawing.Size(200, 60);
            this.HistorialPc.TabIndex = 2;
            this.HistorialPc.Text = "Historial";
            this.HistorialPc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HistorialPc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HistorialPc.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.ForeColor = System.Drawing.Color.Gainsboro;
            this.Home.IconChar = FontAwesome.Sharp.IconChar.HouseChimneyUser;
            this.Home.IconColor = System.Drawing.Color.Gainsboro;
            this.Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(0, 140);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Home.Size = new System.Drawing.Size(200, 60);
            this.Home.TabIndex = 3;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracion.IconChar = FontAwesome.Sharp.IconChar.EllipsisH;
            this.BtnConfiguracion.IconColor = System.Drawing.Color.Gainsboro;
            this.BtnConfiguracion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConfiguracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.Location = new System.Drawing.Point(0, 320);
            this.BtnConfiguracion.Name = "BtnConfiguracion";
            this.BtnConfiguracion.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnConfiguracion.Size = new System.Drawing.Size(200, 60);
            this.BtnConfiguracion.TabIndex = 4;
            this.BtnConfiguracion.Text = "Setting ";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Barra_de_titulo
            // 
            this.Barra_de_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Barra_de_titulo.Controls.Add(this.titulo_de_form);
            this.Barra_de_titulo.Controls.Add(this.icono_form_principal);
            this.Barra_de_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_de_titulo.Location = new System.Drawing.Point(200, 0);
            this.Barra_de_titulo.Name = "Barra_de_titulo";
            this.Barra_de_titulo.Size = new System.Drawing.Size(564, 75);
            this.Barra_de_titulo.TabIndex = 1;
            // 
            // icono_form_principal
            // 
            this.icono_form_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icono_form_principal.ForeColor = System.Drawing.Color.MediumPurple;
            this.icono_form_principal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icono_form_principal.IconColor = System.Drawing.Color.MediumPurple;
            this.icono_form_principal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icono_form_principal.IconSize = 39;
            this.icono_form_principal.Location = new System.Drawing.Point(20, 12);
            this.icono_form_principal.Name = "icono_form_principal";
            this.icono_form_principal.Size = new System.Drawing.Size(39, 45);
            this.icono_form_principal.TabIndex = 0;
            this.icono_form_principal.TabStop = false;
            // 
            // titulo_de_form
            // 
            this.titulo_de_form.AutoSize = true;
            this.titulo_de_form.ForeColor = System.Drawing.Color.Gainsboro;
            this.titulo_de_form.Location = new System.Drawing.Point(65, 27);
            this.titulo_de_form.Name = "titulo_de_form";
            this.titulo_de_form.Size = new System.Drawing.Size(33, 13);
            this.titulo_de_form.TabIndex = 1;
            this.titulo_de_form.Text = "home";
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 425);
            this.Controls.Add(this.Barra_de_titulo);
            this.Controls.Add(this.PanelMenu);
            this.Name = "Formprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "qw";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Barra_de_titulo.ResumeLayout(false);
            this.Barra_de_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icono_form_principal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton Computadoras;
        private System.Windows.Forms.Panel PanelLogo;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private FontAwesome.Sharp.IconButton Home;
        private FontAwesome.Sharp.IconButton HistorialPc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel Barra_de_titulo;
        private System.Windows.Forms.Label titulo_de_form;
        private FontAwesome.Sharp.IconPictureBox icono_form_principal;
    }
}