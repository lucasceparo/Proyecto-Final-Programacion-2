using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;   // libreria para poder arrastrar ventana de login 
using System.IO;

namespace Proyecto_Final_Programacion_2
{
    public partial class Login : Form
    {
        //importamos dll con su libreria para poder arrastrar la ventana login luego agrego evento mousedown que se activara cuando queramos arrastrar el login.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        string usuario;
        string password;
        bool admin = false;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)    //validamos el usuario y contraseña
        {
            try
            {
                usuario = txtUsername.Texts;
                password = txtPassword.Texts;

                StreamReader leer;
                leer = File.OpenText("usuarios.txt");
                string cadena;
                string[] arreglo = new string[2];
                char[] separador = { '-' };
                bool autorizado = false;
                cadena = leer.ReadLine();
                while (cadena != null && autorizado == false)
                {
                    arreglo = cadena.Split(separador);
                    if (arreglo[0].Trim().Equals(usuario) && arreglo[1].Trim().Equals(password))
                    {
                        if (txtUsername.Texts == "admin" || txtPassword.Texts == "admin")

                            admin = true;
                        txtUsername.Clear();
                        txtPassword.Clear();
                        autorizado = true;


                        this.Hide();
                        Formbienvenida bienvenida = new Formbienvenida();
                        bienvenida.ShowDialog();

                        this.Hide();
                        Formprincipal principal = new Formprincipal(admin);
                        principal.ShowDialog();
                        
                    }
                    else
                    {
                        cadena = leer.ReadLine();
                    }

                }
                if (autorizado == false)
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Erorr: " + error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btbminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registro ventana = new Registro();
            ventana.ShowDialog();

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}
