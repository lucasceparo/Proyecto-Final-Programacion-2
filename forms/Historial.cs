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

namespace Proyecto_Final_Programacion_2.forms
{
    public partial class Historial : Form
    {
        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            Computadoras computadoras = new Computadoras();
            if (!File.Exists("Historial.txt"))
            {
                StreamWriter archivo = new StreamWriter("historial.txt");
                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("historial.txt");  //leemos el archivo de texto y cargamos los datos que estan en el archivo
                while (!archivo.EndOfStream)
                {
                    string listaPc = archivo.ReadLine();
                    string alumno = archivo.ReadLine();
                    string curso = archivo.ReadLine();
                    string fecha = archivo.ReadLine();
                    dataGridView1.Rows.Add(listaPc ,alumno, curso, fecha);
                }
                archivo.Close();
            }
        }

        public void GrabarDatos(string listaPc, string alumno, string curso, string fecha)
        {
            StreamWriter archivo = new StreamWriter("historial.txt", true);  //abrimos el archivo y agregamos los datos
            archivo.WriteLine(listaPc);
            archivo.WriteLine(alumno);
            archivo.WriteLine(curso);
            archivo.WriteLine(fecha);
            
            archivo.Close();           
        }
    }
}
