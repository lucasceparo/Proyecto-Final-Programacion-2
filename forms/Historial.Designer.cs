namespace Proyecto_Final_Programacion_2.forms
{
    partial class Historial
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
            this.listaHistrialPc = new System.Windows.Forms.ListView();
            this.PClista = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaAlumno = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaCurso = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EstadoPc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ListaFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listaHistrialPc
            // 
            this.listaHistrialPc.AllowDrop = true;
            this.listaHistrialPc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listaHistrialPc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PClista,
            this.ListaAlumno,
            this.ListaCurso,
            this.EstadoPc,
            this.ListaFecha});
            this.listaHistrialPc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listaHistrialPc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaHistrialPc.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaHistrialPc.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listaHistrialPc.GridLines = true;
            this.listaHistrialPc.HideSelection = false;
            this.listaHistrialPc.Location = new System.Drawing.Point(0, 0);
            this.listaHistrialPc.Name = "listaHistrialPc";
            this.listaHistrialPc.Size = new System.Drawing.Size(581, 342);
            this.listaHistrialPc.TabIndex = 71;
            this.listaHistrialPc.UseCompatibleStateImageBehavior = false;
            this.listaHistrialPc.View = System.Windows.Forms.View.Details;
            // 
            // PClista
            // 
            this.PClista.Text = "PC";
            this.PClista.Width = 50;
            // 
            // ListaAlumno
            // 
            this.ListaAlumno.Text = "Alumno";
            this.ListaAlumno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListaAlumno.Width = 130;
            // 
            // ListaCurso
            // 
            this.ListaCurso.Text = "Curso";
            this.ListaCurso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListaCurso.Width = 130;
            // 
            // EstadoPc
            // 
            this.EstadoPc.Text = "Estado";
            this.EstadoPc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EstadoPc.Width = 130;
            // 
            // ListaFecha
            // 
            this.ListaFecha.Text = "Fecha";
            this.ListaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ListaFecha.Width = 130;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(581, 342);
            this.Controls.Add(this.listaHistrialPc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaHistrialPc;
        private System.Windows.Forms.ColumnHeader PClista;
        private System.Windows.Forms.ColumnHeader ListaAlumno;
        private System.Windows.Forms.ColumnHeader ListaCurso;
        private System.Windows.Forms.ColumnHeader EstadoPc;
        private System.Windows.Forms.ColumnHeader ListaFecha;
    }
}