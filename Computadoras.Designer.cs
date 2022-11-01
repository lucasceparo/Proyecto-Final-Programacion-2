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
            this.btDesabilitarPC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btHabilitarPC = new System.Windows.Forms.Button();
            this.btEntregarPC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(26, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(222, 277);
            this.listBox1.TabIndex = 0;
            // 
            // btAgregarPC
            // 
            this.btAgregarPC.Location = new System.Drawing.Point(324, 24);
            this.btAgregarPC.Name = "btAgregarPC";
            this.btAgregarPC.Size = new System.Drawing.Size(173, 38);
            this.btAgregarPC.TabIndex = 1;
            this.btAgregarPC.Text = "AGREGAR PC";
            this.btAgregarPC.UseVisualStyleBackColor = true;
            // 
            // btDesabilitarPC
            // 
            this.btDesabilitarPC.Location = new System.Drawing.Point(324, 188);
            this.btDesabilitarPC.Name = "btDesabilitarPC";
            this.btDesabilitarPC.Size = new System.Drawing.Size(173, 38);
            this.btDesabilitarPC.TabIndex = 2;
            this.btDesabilitarPC.Text = "DESABILITAR PC";
            this.btDesabilitarPC.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "AGREGAR COMENTARIO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btHabilitarPC
            // 
            this.btHabilitarPC.Location = new System.Drawing.Point(324, 245);
            this.btHabilitarPC.Name = "btHabilitarPC";
            this.btHabilitarPC.Size = new System.Drawing.Size(173, 38);
            this.btHabilitarPC.TabIndex = 4;
            this.btHabilitarPC.Text = "HABILITAR PC";
            this.btHabilitarPC.UseVisualStyleBackColor = true;
            // 
            // btEntregarPC
            // 
            this.btEntregarPC.Location = new System.Drawing.Point(324, 77);
            this.btEntregarPC.Name = "btEntregarPC";
            this.btEntregarPC.Size = new System.Drawing.Size(173, 38);
            this.btEntregarPC.TabIndex = 5;
            this.btEntregarPC.Text = "ENTREGAR PC";
            this.btEntregarPC.UseVisualStyleBackColor = true;
            // 
            // Computadoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(557, 342);
            this.Controls.Add(this.btEntregarPC);
            this.Controls.Add(this.btHabilitarPC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btDesabilitarPC);
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
        private System.Windows.Forms.Button btDesabilitarPC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btHabilitarPC;
        private System.Windows.Forms.Button btEntregarPC;
    }
}