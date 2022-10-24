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


namespace Proyecto_Final_Programacion_2
{
    public partial class Login : Form
    {
        //importamos dll con su libreria para poder arrastrar la ventana login luego agrego evento mousedown que se activara cuando queramos arrastrar el login.

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        string usuario = "pancho";
        string password = "pancho";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Texts != usuario || txtPassword.Texts != password)
            {
                if (txtUsername.Texts != usuario)
                {
                    MessageBox.Show("Usuario Incorrecto");
                    txtUsername.Clear();
                    txtUsername.Focus();
                    return;
                }
                if (txtPassword.Texts != password)
                {
                    MessageBox.Show("Contraseña Incorrecta");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                this.Hide();
                Formbienvenida bienvenida = new Formbienvenida();
                bienvenida.ShowDialog();
                this.Hide();
                Formprincipal principal = new Formprincipal();
                principal.ShowDialog();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_MouseEnter(object sender, EventArgs e)
        {

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
