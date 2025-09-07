using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //libreia para lectura y escitura de archivos

namespace _3OLIDTS_MarianaTorres_04sh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lim_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellidos.Clear();
            tbtelefono.Clear();
            tbestatura.Clear();
            tbedad.Clear();
            rb.Checked = false;
            rb2.Checked = false;
        }

        private void gua_Click(object sender, EventArgs e)
        {
            string apellidos = tbapellidos.Text;
            string nombre = tbnombre.Text;
            string telefono = tbtelefono.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string genero = "";

            if (rb2.Checked)
            {
                genero = "Femenino";
            }
            else if (rb.Checked)
            {
                genero = "Masculino";
            }

            string datos = $"Nombre: {nombre}\r\nApellidos: {apellidos}\r\n" +
                           $"Teléfono: {telefono}\r\nEstatura: {estatura}\r\n" +
                           $"Edad: {edad}\r\nGénero: {genero}";
              string ruta = "C:\\Users\\marde\\Downloads\\nada.txt";
            // string ruta = "C:\\Users\\marde\\Downloads";
            // string ruta = @"C:\Users\mariana torres\Downloads";
            bool archivoExiste = File.Exists(ruta);
            using (StreamWriter writer = new StreamWriter(ruta, true))
            {
                if (archivoExiste)
                {
                    writer.WriteLine();
                }
                writer.WriteLine(datos);
            }
            MessageBox.Show(datos, "Valores ingresados",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

