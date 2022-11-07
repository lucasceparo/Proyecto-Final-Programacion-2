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
        internal static string Alumno, Curso;

        public Computadoras()
        {
            InitializeComponent();
        }

        private void classBottonFormPrincipal1_Click(object sender, EventArgs e)
        {

        }

        private void classBottonFormPrincipal1_Click_1(object sender, EventArgs e)
        {
            if (txtAlumo.Texts == "")
                MessageBox.Show("Debe ingresar un alumno");
            else if (txtCurso.Texts == "")
                MessageBox.Show("Debe ingresar un curso");
            else
            {
                Alumno = txtAlumo.Texts;
                Curso = txtCurso.Texts;

                GrabarDatos();

              //  ListViewItem fila = new ListViewItem();
               // fila.SubItems.Add(Computadoras.Alumno);
               // fila.SubItems.Add(Computadoras.Curso);
                //listaHistrialPc.Items.Add(fila);

                txtAlumo.Texts = "";
                txtCurso.Texts = "";

            }
        }

        private void GrabarDatos()
        {
            StreamWriter archivo = new StreamWriter("historial.txt", true);
            archivo.WriteLine(txtAlumo.Texts);
            archivo.WriteLine(txtCurso.Texts);
            archivo.Close();


        }

        private void labelFecha_Click(object sender, EventArgs e)
        {

        }

        private void Computadoras_Load(object sender, EventArgs e)
        {
            labelFecha.Text = DateTime.Today.Date.ToString("d");
            Historial historial = new Historial();
        }

    }
}
