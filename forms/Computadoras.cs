using FontAwesome.Sharp;
using Proyecto_Final_Programacion_2.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace Proyecto_Final_Programacion_2
{
    public partial class Computadoras : Form
    {
        private IconButton btActual; //almacenamos el boton actual
        private Panel rightBorderBtn;
        public Computadoras()
        {

            InitializeComponent();
            rightBorderBtn = new Panel();  //inicializamos el panel borde izquierdo del boton
            rightBorderBtn.Size = new Size(10, 60);
            PanelOps.Controls.Add(rightBorderBtn);
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        

        }
        private struct RGBColor
        {

            public static Color color1 = Color.FromArgb(34, 33, 74);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
           
        }

        private void BotonesAct(object senderBtn, Color color) //resaltamos el boton activo
        {
            if (senderBtn != null)
            {
                DisableButton();
                //boton
                btActual = (IconButton)senderBtn; //asignamos el boton actual con el boton remitente
                btActual.BackColor = Color.FromArgb(37, 36, 81); //color de fondo del boton
                btActual.ForeColor = color; //cambiamos el color de texto del boton al parametro color 
                btActual.TextAlign = ContentAlignment.MiddleCenter; //alineamos el texto al centro

                //panel borde izquierdo del boton
                rightBorderBtn.BackColor = color;   //cambiamos el color de fondo al parametro color
                rightBorderBtn.Location = new Point(0, btActual.Location.X);  //asignamos nueva ubicacion 
                rightBorderBtn.Visible = true;  //visibilidad en verdadero
                

            }
        }
        private void DisableButton()
        {
            if (btActual != null)
            {
                btActual.BackColor = Color.FromArgb(34, 33, 74);
                btActual.ForeColor = Color.Gainsboro;//OBTIENE EL COLOR DE ARRIBA
                btActual.TextAlign = ContentAlignment.MiddleLeft;//ALINEA EL TEXTO
            }
        }
        private void Reset()
        {
            DisableButton();
            rightBorderBtn.Visible = false;
           
            
        }


        private void btReservar_Click(object sender, EventArgs e)
        {
            BotonesAct(sender, RGBColor.color1);
            
        }
    }
}
