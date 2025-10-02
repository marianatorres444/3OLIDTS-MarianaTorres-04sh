using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; //Libreria para lectura y escritura de archivos
using System.Text.RegularExpressions; //Libreria para la validacion de formato de texto

namespace _3OLIDTS_MarianaTorres_04sh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Creacion de manejadores de eventos
            tbnombre.TextChanged += validarNombre;
            tbapellidos.TextChanged += validarApellidos;
            tbestatura.TextChanged += validarEstatura;
            tbedad.TextChanged += validarEdad;
            tbtelefono.Leave += validarTelefono;
        }
        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese valores correctos para el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void validarEdad(object sender, EventArgs e)
        {


        }
        private void validarApellidos(object sender, EventArgs e)
        {


        }
        private void validarTelefono(object sender, EventArgs e)
        {


        }
        private void validarEstatura(object sender, EventArgs e)
        {


        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);

            //return false;

        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);

            //return false;

        }

        private bool EsEnteroValido10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;

            //return false;

        }


        private bool EsTextoValido(string valor)
        {

            return Regex.IsMatch(valor, @"^{[A-Za-z\s]+$");
        }
        private void lbNombre_Click(object sender, EventArgs e)
        {

        }

        private void lim_Click(object sender, EventArgs e)
        {
            tbapellidos.Clear();
            tbnombre.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rb.Checked = false;
            rb2.Checked = false;
        }

        private void gua_Click(object sender, EventArgs e)
        {
            string nombre = tbnombre.Text;
            string apellidos = tbapellidos.Text;
            string edad = tbedad.Text;
            string telefono = tbtelefono.Text;
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
            string datos = $"Nombre:{nombre}\n\rApellidos:{apellidos}\n\r" +
                $"Telefono:{telefono}\n\rEdad:{edad}\n\rEstatura:{estatura}\n\rGenero:{genero}\n\r";
            //el \r es inicio de renglon
            MessageBox.Show(datos, "Valores ingresados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
