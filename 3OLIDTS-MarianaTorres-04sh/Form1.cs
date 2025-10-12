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
using System.Text.RegularExpressions; // Libreria para analisis de formatod de texto
using MySql.Data.MySqlClient; // Libreria externa para la conexión a la base de datos

namespace _3OLIDTS_MarianaTorres_04sh
{
    public partial class Form1 : Form
    {
        string ConexionSQL = "Server=127.0.0.1;Port=3306;Database=formulario3o;Uid=root;Pwd=mardecartorlo44;";
        public Form1()
        {
            InitializeComponent();
            tbedad.TextChanged += validarEdad;
            tbestatura.TextChanged += validarEstatura;
            tbtelefono.Leave += validarTelefono;
            tbnombre.TextChanged += validarNombre;
            tbapellidos.TextChanged += validarApellidos;
        }
        private void InsertarRegistro(string nombre, string apellidos, int edad, string genero, decimal estatura, string telefono)
        {
            using (MySqlConnection conn = new MySqlConnection(ConexionSQL))
            {
                conn.Open();
                string insertQuery = "INSERT INTO registro (nombre, apellidos, Telefono,estatura, edad, genero) " +
                    "VALUES(@Nombre, @Apellidos, @Telefono,@Estatura, @Edad, @Genero)";
                using (MySqlCommand comando = new MySqlCommand(insertQuery, conn))
                {
                    comando.Parameters.AddWithValue("@Nombre", nombre);
                    comando.Parameters.AddWithValue("@Apellidos", apellidos);
                    comando.Parameters.AddWithValue("@Telefono", telefono);
                    comando.Parameters.AddWithValue("@Estatura", estatura);
                    comando.Parameters.AddWithValue("@Edad", edad);
                    comando.Parameters.AddWithValue("@Genero", genero);
                    comando.ExecuteNonQuery(); 
                }
                conn.Close();
            }
        }

        private void lim_Click(object sender, EventArgs e)
        {
            tbapellidos.Clear();
            tbnombre.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            tbedad.Clear();
            rb.Checked = false;
            rb2.Checked = false;
        }



        private void gua_Click(object sender, EventArgs e)
        {
            string nombre = tbnombre.Text;
            string apellidos = tbapellidos.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string telefono = tbtelefono.Text;

            string genero = "";
            if (rb.Checked)
            {
                genero = "Hombre";
            }
            else if (rb2.Checked)
            {
                genero = "Mujer";
            }

            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telefono) &&
                EsTextoValido(nombre) && EsTextoValido(apellidos))
            {
                string datos = $"Nombres: {nombre}\r\nApellidos: {apellidos}\r\nTelefono: {telefono} " +
                    $"kg\r\nEstatura: {estatura} cm\r\nEdad: {edad} años\r\nGénero: {genero}\r\n";

                string rutaArchivo = "C:\\Users\\marde\\Downloads\\nada.txt";
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            writer.WriteLine();
                        }

                        writer.WriteLine(datos);
                        InsertarRegistro(nombre, apellidos, int.Parse(edad), genero, decimal.Parse(estatura), telefono);
                        MessageBox.Show("Datos insertados en la Base de Datos:\n\n" + datos, "Información BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEnteroValidoDe10Digitos(string valor)
        {
            long resultado;
            return long.TryParse(valor, out resultado) && valor.Length == 10;
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$"); 
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad valida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;

            if (input.Length == 10 && EsEnteroValidoDe10Digitos(input))
            {
                //MessageBox.Show("Por favor, ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.BackColor = Color.Green;
                //textBox.Clear();
            }
            else
            {
                //MessageBox.Show("Por favor, ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.BackColor = Color.Red;
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un nombre válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese apellidos válidos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

    }
}