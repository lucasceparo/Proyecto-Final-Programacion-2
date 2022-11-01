namespace Proyecto_Final_Programacion_2
{
    partial class Formprincipal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formprincipal));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Barra_de_titulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.titulo_de_form_hijo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icono_form_principal = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel_de_escritorio = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.Btnhome = new System.Windows.Forms.PictureBox();
            this.Home = new FontAwesome.Sharp.IconButton();
            this.Computadoras = new FontAwesome.Sharp.IconButton();
            this.HistorialPc = new FontAwesome.Sharp.IconButton();
            this.BtnConfiguracion = new FontAwesome.Sharp.IconButton();
            this.iconLogout = new FontAwesome.Sharp.IconButton();
            this.PanelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.Barra_de_titulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_form_principal)).BeginInit();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Btnhome)).BeginInit();
            this.PanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Barra_de_titulo
            // 
            this.Barra_de_titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.Barra_de_titulo.Controls.Add(this.pictureBox2);
            this.Barra_de_titulo.Controls.Add(this.pictureBox3);
            this.Barra_de_titulo.Controls.Add(this.titulo_de_form_hijo);
            this.Barra_de_titulo.Controls.Add(this.pictureBox1);
            this.Barra_de_titulo.Controls.Add(this.icono_form_principal);
            this.Barra_de_titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_de_titulo.Location = new System.Drawing.Point(200, 0);
            this.Barra_de_titulo.Name = "Barra_de_titulo";
            this.Barra_de_titulo.Size = new System.Drawing.Size(573, 75);
            this.Barra_de_titulo.TabIndex = 1;
            this.Barra_de_titulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_de_titulo_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(508, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(474, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // titulo_de_form_hijo
            // 
            this.titulo_de_form_hijo.AutoSize = true;
            this.titulo_de_form_hijo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_de_form_hijo.ForeColor = System.Drawing.Color.Gainsboro;
            this.titulo_de_form_hijo.Location = new System.Drawing.Point(65, 27);
            this.titulo_de_form_hijo.Name = "titulo_de_form_hijo";
            this.titulo_de_form_hijo.Size = new System.Drawing.Size(36, 15);
            this.titulo_de_form_hijo.TabIndex = 1;
            this.titulo_de_form_hijo.Text = "Inicio";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // icono_form_principal
            // 
            this.icono_form_principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.icono_form_principal.ForeColor = System.Drawing.Color.MediumPurple;
            this.icono_form_principal.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icono_form_principal.IconColor = System.Drawing.Color.MediumPurple;
            this.icono_form_principal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.icono_form_principal.IconSize = 39;
            this.icono_form_principal.Location = new System.Drawing.Point(20, 17);
            this.icono_form_principal.Name = "icono_form_principal";
            this.icono_form_principal.Size = new System.Drawing.Size(39, 40);
            this.icono_form_principal.TabIndex = 0;
            this.icono_form_principal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(200, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 9);
            this.panel1.TabIndex = 2;
            // 
            // Panel_de_escritorio
            // 
            this.Panel_de_escritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Panel_de_escritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_de_escritorio.Location = new System.Drawing.Point(200, 84);
            this.Panel_de_escritorio.Name = "Panel_de_escritorio";
            this.Panel_de_escritorio.Size = new System.Drawing.Size(573, 381);
            this.Panel_de_escritorio.TabIndex = 3;
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.Btnhome);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(200, 140);
            this.PanelLogo.TabIndex = 0;
            // 
            // Btnhome
            // 
            this.Btnhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btnhome.Image = ((System.Drawing.Image)(resources.GetObject("Btnhome.Image")));
            this.Btnhome.Location = new System.Drawing.Point(0, 0);
            this.Btnhome.Name = "Btnhome";
            this.Btnhome.Size = new System.Drawing.Size(200, 140);
            this.Btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Btnhome.TabIndex = 0;
            this.Btnhome.TabStop = false;
            this.Btnhome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btnhome_MouseDown);
            // 
            // Home
            // 
            this.Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.Home.Text = "Inicio";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Computadoras
            // 
            this.Computadoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Computadoras.FlatAppearance.BorderSize = 0;
            this.Computadoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Computadoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // HistorialPc
            // 
            this.HistorialPc.Dock = System.Windows.Forms.DockStyle.Top;
            this.HistorialPc.FlatAppearance.BorderSize = 0;
            this.HistorialPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HistorialPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.HistorialPc.Click += new System.EventHandler(this.HistorialPc_Click);
            // 
            // BtnConfiguracion
            // 
            this.BtnConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnConfiguracion.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.BtnConfiguracion.Text = "Opciones";
            this.BtnConfiguracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracion.UseVisualStyleBackColor = true;
            this.BtnConfiguracion.Click += new System.EventHandler(this.BtnConfiguracion_Click);
            // 
            // iconLogout
            // 
            this.iconLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconLogout.FlatAppearance.BorderSize = 0;
            this.iconLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconLogout.IconChar = FontAwesome.Sharp.IconChar.RightFromBracket;
            this.iconLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.iconLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.Location = new System.Drawing.Point(0, 380);
            this.iconLogout.Name = "iconLogout";
            this.iconLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconLogout.Size = new System.Drawing.Size(200, 60);
            this.iconLogout.TabIndex = 5;
            this.iconLogout.Text = "Cerrar Sesion";
            this.iconLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconLogout.UseVisualStyleBackColor = true;
            this.iconLogout.Click += new System.EventHandler(this.iconLogout_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.iconLogout);
            this.PanelMenu.Controls.Add(this.BtnConfiguracion);
            this.PanelMenu.Controls.Add(this.HistorialPc);
            this.PanelMenu.Controls.Add(this.Computadoras);
            this.PanelMenu.Controls.Add(this.Home);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 465);
            this.PanelMenu.TabIndex = 0;
            // 
            // Formprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 465);
            this.Controls.Add(this.Panel_de_escritorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Barra_de_titulo);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Formprincipal_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.Barra_de_titulo.ResumeLayout(false);
            this.Barra_de_titulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_form_principal)).EndInit();
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Btnhome)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel Barra_de_titulo;
        private System.Windows.Forms.Label titulo_de_form_hijo;
        private FontAwesome.Sharp.IconPictureBox icono_form_principal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel Panel_de_escritorio;
        private System.Windows.Forms.Panel PanelMenu;
        private FontAwesome.Sharp.IconButton iconLogout;
        private FontAwesome.Sharp.IconButton BtnConfiguracion;
        private FontAwesome.Sharp.IconButton HistorialPc;
        private FontAwesome.Sharp.IconButton Computadoras;
        private FontAwesome.Sharp.IconButton Home;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.PictureBox Btnhome;
    }
}