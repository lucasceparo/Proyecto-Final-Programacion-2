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
            this.btAgregarPC = new System.Windows.Forms.Button();
            this.btEntregarPC = new System.Windows.Forms.Button();
            this.btAgregarComent = new System.Windows.Forms.Button();
            this.btDesabilitarPC = new System.Windows.Forms.Button();
            this.btHabilitarPC = new System.Windows.Forms.Button();
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
            // btAgregarPC
            // 
            this.btAgregarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btAgregarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarPC.ForeColor = System.Drawing.Color.RosyBrown;
            this.btAgregarPC.Location = new System.Drawing.Point(353, 12);
            this.btAgregarPC.Name = "btAgregarPC";
            this.btAgregarPC.Size = new System.Drawing.Size(161, 41);
            this.btAgregarPC.TabIndex = 1;
            this.btAgregarPC.Text = "RESERVAR PC";
            this.btAgregarPC.UseVisualStyleBackColor = false;
            // 
            // btEntregarPC
            // 
            this.btEntregarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btEntregarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEntregarPC.ForeColor = System.Drawing.Color.RosyBrown;
            this.btEntregarPC.Location = new System.Drawing.Point(353, 73);
            this.btEntregarPC.Name = "btEntregarPC";
            this.btEntregarPC.Size = new System.Drawing.Size(161, 41);
            this.btEntregarPC.TabIndex = 2;
            this.btEntregarPC.Text = "ENTREGAR PC";
            this.btEntregarPC.UseVisualStyleBackColor = false;
            // 
            // btAgregarComent
            // 
            this.btAgregarComent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btAgregarComent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAgregarComent.ForeColor = System.Drawing.Color.RosyBrown;
            this.btAgregarComent.Location = new System.Drawing.Point(353, 135);
            this.btAgregarComent.Name = "btAgregarComent";
            this.btAgregarComent.Size = new System.Drawing.Size(161, 41);
            this.btAgregarComent.TabIndex = 3;
            this.btAgregarComent.Text = "AGREGAR COMENTARIO";
            this.btAgregarComent.UseVisualStyleBackColor = false;
            // 
            // btDesabilitarPC
            // 
            this.btDesabilitarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btDesabilitarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDesabilitarPC.ForeColor = System.Drawing.Color.RosyBrown;
            this.btDesabilitarPC.Location = new System.Drawing.Point(353, 200);
            this.btDesabilitarPC.Name = "btDesabilitarPC";
            this.btDesabilitarPC.Size = new System.Drawing.Size(161, 41);
            this.btDesabilitarPC.TabIndex = 4;
            this.btDesabilitarPC.Text = "DESABILITAR PC";
            this.btDesabilitarPC.UseVisualStyleBackColor = false;
            this.btDesabilitarPC.Click += new System.EventHandler(this.btDesabilitarPC_Click);
            // 
            // btHabilitarPC
            // 
            this.btHabilitarPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btHabilitarPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHabilitarPC.ForeColor = System.Drawing.Color.RosyBrown;
            this.btHabilitarPC.Location = new System.Drawing.Point(353, 261);
            this.btHabilitarPC.Name = "btHabilitarPC";
            this.btHabilitarPC.Size = new System.Drawing.Size(161, 41);
            this.btHabilitarPC.TabIndex = 5;
            this.btHabilitarPC.Text = "HABILITAR PC";
            this.btHabilitarPC.UseVisualStyleBackColor = false;
            // 
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(557, 342);
            this.Controls.Add(this.btHabilitarPC);
            this.Controls.Add(this.btDesabilitarPC);
            this.Controls.Add(this.btAgregarComent);
            this.Controls.Add(this.btEntregarPC);
            this.Controls.Add(this.btAgregarPC);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Computadoras";
            this.Text = "Computadoras";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAgregarPC;
        private System.Windows.Forms.Button btEntregarPC;
        private System.Windows.Forms.Button btAgregarComent;
        private System.Windows.Forms.Button btDesabilitarPC;
        private System.Windows.Forms.Button btHabilitarPC;
    }
}