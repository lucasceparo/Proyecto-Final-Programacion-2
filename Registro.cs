using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final_Programacion_2
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login volver = new Login();
            volver.ShowDialog();

            
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
           
            TextWriter UserRegister = new StreamWriter(txtUsernameReg.Texts + ".txt");
            UserRegister.WriteLine(txtPasswordReg.Texts);
            UserRegister.Close();

            MessageBox.Show("Registrado correctamente");

            this.Hide();
            Login volver = new Login();
            volver.ShowDialog();

            

        }
    }
}
