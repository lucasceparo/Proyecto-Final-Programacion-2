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
using System.IO;
using System.Windows.Media;

namespace Proyecto_Final_Programacion_2
{
    public partial class Computadoras : Form
    {
        Historial historial;
        string pcsselect;

        public Computadoras()
        {
            InitializeComponent();
        }


        private void classBottonFormPrincipal1_Click(object sender, EventArgs e)
        {

        }

        private void classBottonFormPrincipal1_Click_1(object sender, EventArgs e)
        {
            if (txtAlumno.Texts == "" || txtCurso.Texts =="")
            {
                MessageBox.Show("Ingresar Alumno/curso");
            }
            
            else
            { 
            historial.GrabarDatos(pcsselect,txtAlumno.Texts, txtCurso.Texts, labelFecha.Text);
            }
        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void listapc_SelectedIndexChanged(object sender, EventArgs e)
        {
            pcsselect = listapc.Items[listapc.SelectedIndex].ToString();
        }

        private void txtAlumno_TextChanged2(object sender, EventArgs e)
        {

        }

        private void Computadoras_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Today.Date.ToString("d");
            historial = new Historial();
        }

        private void classBottonFormPrincipal4_Click(object sender, EventArgs e)
        {
            
           

            listapc.SetItemCheckState(1,CheckState.Indeterminate);
        }

        private void classBottonFormPrincipal3_Click(object sender, EventArgs e)
        {

            File.Delete("historial.txt");
            StreamWriter historial = new StreamWriter("historial.txt", true);
            historial.Close();
        }

        private void txtCurso_TextChanged2(object sender, EventArgs e)
        {

        }

        private void PanelOps_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTHabilitar_Click(object sender, EventArgs e)
        {
     
        }
    }
}
