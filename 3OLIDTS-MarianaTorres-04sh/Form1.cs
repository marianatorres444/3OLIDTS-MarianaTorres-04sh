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
                MessageBox.Show("Por favor ingrese valores correctos para el nombre", "Error Nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private bool EsTextoValido(string texto)
        {
            return Regex.IsMatch(texto, @"^[a-zA-Z\s]+$");
        }
        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Por favor ingrese valores correctos para el apellidos", "Error Nombre", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                textbox.Clear();
            }
        }
        private bool EstaturaValida(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
            //return false;
        }
        private bool EdadValida(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
            //return false;
        }
        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EdadValida(textbox.Text))
            {
                MessageBox.Show("Ingrese un valor decimal valido para la estatura", "Error Estatura", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                //textbox.Clear();
            }
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EdadValida(textbox.Text))
            {
                MessageBox.Show("Ingrese un valor entero valido para la edad", "Error Edad", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                //textbox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEnteroValido10Digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else
            {
                textbox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un telefono de 10 dígitos", "Error telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //textbox.Clear();
            }
        }
  
        private bool EsEnteroValido10Digitos(string valor)
        {
            //long resultado;
            //return long.TryParse(valor, out resultado) && valor.Length == 10;
            return valor.Length == 10 && valor.All(char.IsDigit) && long.TryParse(valor, out _);
            //string formato = @"^\d{10}$";
            //return Regex.IsWatch(valor, formato);
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

            if (rb.Checked)
            {
                genero = "Hombre";
            }
            else if (rb2.Checked)
            {
                genero = "Mujer";
            }

            if (!string.IsNullOrEmpty(tbapellidos.Text) && !string.IsNullOrEmpty(tbnombre.Text) && !string.IsNullOrEmpty(tbedad.Text) && !string.IsNullOrEmpty(tbestatura.Text) && !string.IsNullOrEmpty(tbtelefono.Text))
            {
                string datos = $"Nombre:{nombre}\n\rApellidos:{apellidos}\n\r" +
                    $"Telefono:{telefono}\n\rEdad:{edad}\n\rEstatura:{estatura}\n\rGenero:{genero}\n\r";
                //MessageBox.Show(datos,"Información de Registro",
                //MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            else
            {
                MessageBox.Show("Ingrese valores a los textBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
