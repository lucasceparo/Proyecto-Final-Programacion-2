using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Proyecto_Final_Programacion_2.forms;
using Color = System.Drawing.Color;

namespace Proyecto_Final_Programacion_2
{
    public partial class Formprincipal : Form
    {
        private IconButton btnActual; //almacenamos el boton actual
        private Panel leftBorderBtn; //aplicar un borde isquierdo al boton
        private Form currentChildForm;

        //constructor 
        public Formprincipal(bool admin)
        {

            InitializeComponent();
            leftBorderBtn = new Panel();  //inicializamos el panel borde izquierdo del boton
            leftBorderBtn.Size = new Size(10, 60);
            PanelMenu.Controls.Add(leftBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            HistorialPc.Enabled = admin;
            BtnConfiguracion.Enabled = admin;
            
        }
        //estructura para almacenar color rgb

        private struct RGBColors
        {

            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //metodos
        private void ActivateButton(object senderBtn, Color color) //resaltamos el boton activo
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                btnActual = (IconButton)senderBtn; //asignamos el boton actual con el boton remitente
                btnActual.BackColor = Color.FromArgb(37, 36, 81); //color de fondo del boton
                btnActual.ForeColor = color; //cambiamos el color de texto del boton al parametro color 
                btnActual.TextAlign = ContentAlignment.MiddleCenter; //alineamos el texto al centro
                btnActual.IconColor = color; //cambiamos el color del icono a parametro color
                btnActual.TextImageRelation = TextImageRelation.TextBeforeImage;   //cambiamos la relacion text imagen a texto antes de img
                btnActual.ImageAlign = ContentAlignment.MiddleRight;  //alineamos el icono hacia la derecha

                //panel borde izquierdo del boton
                leftBorderBtn.BackColor = color;   //cambiamos el color de fondo al parametro color
                leftBorderBtn.Location = new Point(0, btnActual.Location.Y);  //asignamos nueva ubicacion 
                leftBorderBtn.Visible = true;  //visibilidad en verdadero
                leftBorderBtn.BringToFront();  //llevamos al frente

                icono_form_principal.IconChar = btnActual.IconChar;  //indico que el formulario principal sea igual al formulario hijo
                icono_form_principal.IconColor = color;  //cambiamos el color del iconoa parametro color
            }
        }

        //metodo para desactivar el resaltado del boton
        private void DisableButton()
        {
            if (btnActual != null)
            {
                btnActual.BackColor = Color.FromArgb(31, 30, 68);
                btnActual.ForeColor = Color.Gainsboro;
                btnActual.TextAlign = ContentAlignment.MiddleLeft;
                btnActual.IconColor = Color.Gainsboro;
                btnActual.TextImageRelation = TextImageRelation.ImageBeforeText;
                btnActual.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChilForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //abrir form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;     //indico que el formulario hijo no es de nivel superior
            childForm.FormBorderStyle = FormBorderStyle.None;     //quita el borde del formulario
            childForm.Dock = DockStyle.Fill;     //llena el contenedor con la propiedad dock
            Panel_de_escritorio.Controls.Add(childForm);  //agrego el formulario hijo a los controles del panel escritorio 
            Panel_de_escritorio.Tag = childForm;    //asocio los datos del formulario al panel
            childForm.BringToFront();    //traigo el formulario hacia el frente y lo muestra
            childForm.Show();
            titulo_de_form_hijo.Text = childForm.Text;    //muestra los datos del formulario en la etiquita titulo
        }

        private void Computadoras_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2); //enviamos primer parametro el objeto remitente del evento (sender) y como 2 parametro un color, lo mismo para los demas botones  
            OpenChilForm(new Computadoras());  //llamamos al formulario hijo desde cada boton y enviamos una estancia de formulario 
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            Reset();
            OpenChilForm(new Home());
        }

        private void HistorialPc_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            OpenChilForm(new Historial());
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            OpenChilForm(new Setting());
        }

        private void iconLogout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
            this.Hide();
            Login volver = new Login();
            volver.ShowDialog();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            icono_form_principal.IconChar = IconChar.Home;
            icono_form_principal.IconColor = Color.MediumPurple;
            icono_form_principal.Text = "Home";
        }

        //dll para arrastrar form principal
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Formprincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Barra_de_titulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Btnhome_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }
    }
}
