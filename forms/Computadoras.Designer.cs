namespace Proyecto_Final_Programacion_2
{
    partial class Computadoras
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PanelOps = new System.Windows.Forms.Panel();
            this.btReservar = new FontAwesome.Sharp.IconButton();
            this.PanelOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(31, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 290);
            this.listBox1.TabIndex = 0;
            // 
            // PanelOps
            // 
            this.PanelOps.Controls.Add(this.btReservar);
            this.PanelOps.Location = new System.Drawing.Point(353, 1);
            this.PanelOps.Name = "PanelOps";
            this.PanelOps.Size = new System.Drawing.Size(201, 340);
            this.PanelOps.TabIndex = 1;
            // 
            // btReservar
            // 
            this.btReservar.FlatAppearance.BorderSize = 0;
            this.btReservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReservar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btReservar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btReservar.IconColor = System.Drawing.Color.Black;
            this.btReservar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btReservar.Location = new System.Drawing.Point(3, 3);
            this.btReservar.Name = "btReservar";
            this.btReservar.Size = new System.Drawing.Size(198, 54);
            this.btReservar.TabIndex = 0;
            this.btReservar.Text = "RESERVAR PC";
            this.btReservar.UseVisualStyleBackColor = true;
            this.btReservar.Click += new System.EventHandler(this.btReservar_Click);
            // 
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(557, 342);
            this.Controls.Add(this.PanelOps);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Computadoras";
            this.Text = "Computadoras";
            this.PanelOps.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel PanelOps;
        private FontAwesome.Sharp.IconButton btReservar;
    }
}