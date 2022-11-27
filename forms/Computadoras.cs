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
            historial.GrabarDatos(pcsselect,txtAlumno.Texts, txtCurso.Texts, labelFecha.Text);
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
    }
}
