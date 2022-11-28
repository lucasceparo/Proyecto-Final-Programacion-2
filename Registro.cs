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
using System.Windows.Controls.Primitives;

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
            txtUsernameReg.Clear();
            this.Hide();
            Login volver = new Login();
            volver.ShowDialog();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (txtPasswordReg.Texts == "" || txtUsernameReg.Texts == "")
            {
                MessageBox.Show("Ingese el usuario o contraseña");
            }
            else
            { 
            CuentasRepetidas();
                txtPasswordReg.Texts= string.Empty;
                txtUsernameReg.Texts= string.Empty;
            }
            

        }

        public void CuentasRepetidas()
        {
            string userReg = txtUsernameReg.Texts;
            StreamReader leer;
            leer = File.OpenText("usuarios.txt");
            string cadena;
            string[] arreglos = new string[1];  //creamos arreglos
            char[] separador = { '-' };  //separador entre user y pass
            bool repetido = false;
            cadena = leer.ReadLine();
            while (cadena != null && repetido == false)
            {
                arreglos = cadena.Split(separador);
                if (arreglos[0].Trim().Equals(userReg))
                {
                    MessageBox.Show("Usuario ya registrado. Ingrese otro");
                    leer.Close();
                    repetido = true;
                }
                else
                {
                    cadena = leer.ReadLine();
                }
            }
            if (repetido == false)
            {
                leer.Close();
                RegistroCuentas();
            }
        }

        public void RegistroCuentas()
        {
          
            
            string userReg = txtUsernameReg.Texts;
            string passReg = txtPasswordReg.Texts;
            StreamWriter registrar = new StreamWriter("usuarios.txt", true);
            registrar.WriteLine(userReg + "-" + passReg);
            registrar.Close();
            MessageBox.Show("Usuario Registrado");
            

        }

        private void Btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void Btbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
    }
}
