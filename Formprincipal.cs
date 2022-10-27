using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using Color = System.Drawing.Color;

namespace Proyecto_Final_Programacion_2
{
    public partial class Formprincipal : Form
    {
        private IconButton btnActual; //almacenamos el boton actual
        private Panel leftBorderBtn; //aplicar un borde isquierdo al boton

        //constructor 
        public Formprincipal()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();  //inicializamos el panel borde izquierdo del boton
            leftBorderBtn.Size = new Size(10,60);
            PanelMenu.Controls.Add(leftBorderBtn);
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
            if(senderBtn != null)
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
      

        private void Computadoras_Click(object sender, EventArgs e)
        {

        }
    }
}
