﻿namespace Proyecto_Final_Programacion_2
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
            this.PanelOps = new System.Windows.Forms.Panel();
            this.listapc = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.txtCurso = new Proyecto_Final_Programacion_2.TextBox();
            this.txtAlumno = new Proyecto_Final_Programacion_2.TextBox();
            this.BTHabilitar = new Proyecto_Final_Programacion_2.ClassBottonFormPrincipal();
            this.BtDeshabilitar = new Proyecto_Final_Programacion_2.ClassBottonFormPrincipal();
            this.BtEliminar = new Proyecto_Final_Programacion_2.ClassBottonFormPrincipal();
            this.classBottonFormPrincipal2 = new Proyecto_Final_Programacion_2.ClassBottonFormPrincipal();
            this.Btnusarpc = new Proyecto_Final_Programacion_2.ClassBottonFormPrincipal();
            this.PanelOps.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelOps
            // 
            this.PanelOps.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PanelOps.Controls.Add(this.BTHabilitar);
            this.PanelOps.Controls.Add(this.BtDeshabilitar);
            this.PanelOps.Controls.Add(this.BtEliminar);
            this.PanelOps.Controls.Add(this.classBottonFormPrincipal2);
            this.PanelOps.Controls.Add(this.Btnusarpc);
            this.PanelOps.Location = new System.Drawing.Point(348, 3);
            this.PanelOps.Name = "PanelOps";
            this.PanelOps.Size = new System.Drawing.Size(213, 364);
            this.PanelOps.TabIndex = 1;
            this.PanelOps.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelOps_Paint);
            // 
            // listapc
            // 
            this.listapc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listapc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.listapc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listapc.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listapc.ForeColor = System.Drawing.SystemColors.Window;
            this.listapc.FormattingEnabled = true;
            this.listapc.Items.AddRange(new object[] {
            "PC N°1",
            "PC N°2",
            "PC N°3",
            "PC N°4",
            "PC N°5",
            "PC N°6",
            "PC N°7",
            "PC N°8",
            "PC N°9",
            "PC N°10",
            "PC N°11",
            "PC N°12",
            "PC N°13",
            "PC N°14",
            "PC N°15",
            "PC N°16",
            "PC N°17",
            "PC N°18",
            "PC N°19",
            "PC N°20",
            "PC N°21",
            "PC N°22",
            "PC N°23",
            "PC N°24",
            "PC N°25",
            "PC N°26",
            "PC N°27",
            "PC N°28",
            "PC N°29",
            "PC N°30",
            "PC N°31",
            "PC N°32",
            "PC N°33",
            "PC N°34",
            "PC N°35",
            "PC N°36",
            "PC N°37",
            "PC N°38",
            "PC N°39",
            "PC N°40",
            "PC N°41",
            "PC N°42",
            "PC N°43",
            "PC N°44",
            "PC N°45",
            "PC N°46",
            "PC N°47",
            "PC N°48",
            "PC N°49",
            "PC N°50",
            "PC N°51",
            "PC N°52",
            "PC N°53",
            "PC N°54",
            "PC N°55",
            "PC N°56",
            "PC N°57",
            "PC N°58",
            "PC N°59",
            "PC N°60"});
            this.listapc.Location = new System.Drawing.Point(22, 94);
            this.listapc.Name = "listapc";
            this.listapc.Size = new System.Drawing.Size(302, 236);
            this.listapc.TabIndex = 63;
            this.listapc.SelectedIndexChanged += new System.EventHandler(this.listapc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 66;
            this.label1.Text = "Fecha actual:";
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.Transparent;
            this.labelFecha.Location = new System.Drawing.Point(201, 9);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(75, 16);
            this.labelFecha.TabIndex = 67;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.Click += new System.EventHandler(this.labelFecha_Click);
            // 
            // txtCurso
            // 
            this.txtCurso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCurso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtCurso.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtCurso.BorderSize = 2;
            this.txtCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurso.ForeColor = System.Drawing.Color.Transparent;
            this.txtCurso.Location = new System.Drawing.Point(177, 45);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurso.Multiline = false;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Padding = new System.Windows.Forms.Padding(7);
            this.txtCurso.PasswordChar = false;
            this.txtCurso.PlaceholderColor = System.Drawing.Color.Transparent;
            this.txtCurso.PlaceholderText = "Curso";
            this.txtCurso.Size = new System.Drawing.Size(147, 31);
            this.txtCurso.TabIndex = 65;
            this.txtCurso.Texts = "";
            this.txtCurso.UnderlinedStyle = true;
            this.txtCurso.TextChanged2 += new System.EventHandler(this.txtCurso_TextChanged2);
            // 
            // txtAlumno
            // 
            this.txtAlumno.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.txtAlumno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(125)))));
            this.txtAlumno.BorderSize = 2;
            this.txtAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlumno.ForeColor = System.Drawing.Color.Transparent;
            this.txtAlumno.Location = new System.Drawing.Point(22, 45);
            this.txtAlumno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlumno.Multiline = false;
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Padding = new System.Windows.Forms.Padding(7);
            this.txtAlumno.PasswordChar = false;
            this.txtAlumno.PlaceholderColor = System.Drawing.Color.Transparent;
            this.txtAlumno.PlaceholderText = "Alumno";
            this.txtAlumno.Size = new System.Drawing.Size(147, 31);
            this.txtAlumno.TabIndex = 64;
            this.txtAlumno.Texts = "";
            this.txtAlumno.UnderlinedStyle = true;
            this.txtAlumno.TextChanged2 += new System.EventHandler(this.txtAlumno_TextChanged2);
            // 
            // BTHabilitar
            // 
            this.BTHabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BTHabilitar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BTHabilitar.BorderColor = System.Drawing.Color.Magenta;
            this.BTHabilitar.BorderRadius = 40;
            this.BTHabilitar.BorderSize = 2;
            this.BTHabilitar.FlatAppearance.BorderSize = 0;
            this.BTHabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTHabilitar.ForeColor = System.Drawing.Color.White;
            this.BTHabilitar.Location = new System.Drawing.Point(28, 235);
            this.BTHabilitar.Name = "BTHabilitar";
            this.BTHabilitar.Size = new System.Drawing.Size(150, 40);
            this.BTHabilitar.TabIndex = 4;
            this.BTHabilitar.Text = "HABILITAR PC";
            this.BTHabilitar.TextColor = System.Drawing.Color.White;
            this.BTHabilitar.UseVisualStyleBackColor = false;
            this.BTHabilitar.Click += new System.EventHandler(this.BTHabilitar_Click);
            // 
            // BtDeshabilitar
            // 
            this.BtDeshabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtDeshabilitar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtDeshabilitar.BorderColor = System.Drawing.Color.Magenta;
            this.BtDeshabilitar.BorderRadius = 40;
            this.BtDeshabilitar.BorderSize = 2;
            this.BtDeshabilitar.FlatAppearance.BorderSize = 0;
            this.BtDeshabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtDeshabilitar.ForeColor = System.Drawing.Color.White;
            this.BtDeshabilitar.Location = new System.Drawing.Point(28, 161);
            this.BtDeshabilitar.Name = "BtDeshabilitar";
            this.BtDeshabilitar.Size = new System.Drawing.Size(150, 40);
            this.BtDeshabilitar.TabIndex = 3;
            this.BtDeshabilitar.Text = "DESHABILITAR PC";
            this.BtDeshabilitar.TextColor = System.Drawing.Color.White;
            this.BtDeshabilitar.UseVisualStyleBackColor = false;
            this.BtDeshabilitar.Click += new System.EventHandler(this.classBottonFormPrincipal4_Click);
            // 
            // BtEliminar
            // 
            this.BtEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtEliminar.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.BtEliminar.BorderColor = System.Drawing.Color.Magenta;
            this.BtEliminar.BorderRadius = 40;
            this.BtEliminar.BorderSize = 2;
            this.BtEliminar.FlatAppearance.BorderSize = 0;
            this.BtEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtEliminar.ForeColor = System.Drawing.Color.White;
            this.BtEliminar.Location = new System.Drawing.Point(28, 301);
            this.BtEliminar.Name = "BtEliminar";
            this.BtEliminar.Size = new System.Drawing.Size(150, 40);
            this.BtEliminar.TabIndex = 2;
            this.BtEliminar.Text = "ELIMINAR HISTORIAL";
            this.BtEliminar.TextColor = System.Drawing.Color.White;
            this.BtEliminar.UseVisualStyleBackColor = false;
            this.BtEliminar.Click += new System.EventHandler(this.classBottonFormPrincipal3_Click);
            // 
            // classBottonFormPrincipal2
            // 
            this.classBottonFormPrincipal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.classBottonFormPrincipal2.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.classBottonFormPrincipal2.BorderColor = System.Drawing.Color.Magenta;
            this.classBottonFormPrincipal2.BorderRadius = 40;
            this.classBottonFormPrincipal2.BorderSize = 2;
            this.classBottonFormPrincipal2.FlatAppearance.BorderSize = 0;
            this.classBottonFormPrincipal2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classBottonFormPrincipal2.ForeColor = System.Drawing.Color.White;
            this.classBottonFormPrincipal2.Location = new System.Drawing.Point(28, 90);
            this.classBottonFormPrincipal2.Name = "classBottonFormPrincipal2";
            this.classBottonFormPrincipal2.Size = new System.Drawing.Size(150, 40);
            this.classBottonFormPrincipal2.TabIndex = 1;
            this.classBottonFormPrincipal2.Text = "ENTREGAR PC";
            this.classBottonFormPrincipal2.TextColor = System.Drawing.Color.White;
            this.classBottonFormPrincipal2.UseVisualStyleBackColor = false;
            // 
            // Btnusarpc
            // 
            this.Btnusarpc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Btnusarpc.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.Btnusarpc.BorderColor = System.Drawing.Color.Magenta;
            this.Btnusarpc.BorderRadius = 40;
            this.Btnusarpc.BorderSize = 2;
            this.Btnusarpc.FlatAppearance.BorderSize = 0;
            this.Btnusarpc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnusarpc.ForeColor = System.Drawing.Color.White;
            this.Btnusarpc.Location = new System.Drawing.Point(28, 18);
            this.Btnusarpc.Name = "Btnusarpc";
            this.Btnusarpc.Size = new System.Drawing.Size(150, 40);
            this.Btnusarpc.TabIndex = 0;
            this.Btnusarpc.Text = "USAR PC";
            this.Btnusarpc.TextColor = System.Drawing.Color.White;
            this.Btnusarpc.UseVisualStyleBackColor = false;
            this.Btnusarpc.Click += new System.EventHandler(this.classBottonFormPrincipal1_Click_1);
            // 
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(573, 369);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.listapc);
            this.Controls.Add(this.PanelOps);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Computadoras";
            this.Text = "Computadoras";
            this.Load += new System.EventHandler(this.Computadoras_Load);
            this.PanelOps.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel PanelOps;
        private ClassBottonFormPrincipal BtDeshabilitar;
        private ClassBottonFormPrincipal BtEliminar;
        private ClassBottonFormPrincipal classBottonFormPrincipal2;
        private ClassBottonFormPrincipal Btnusarpc;
        private ClassBottonFormPrincipal BTHabilitar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFecha;
        public System.Windows.Forms.CheckedListBox listapc;
        public TextBox txtAlumno;
        public TextBox txtCurso;
    }
}