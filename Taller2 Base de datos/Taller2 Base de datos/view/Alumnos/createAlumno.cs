using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2_Base_de_datos.view.Alumnos
{
    public partial class createAlumno : Form
    {
        public createAlumno()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textRutAlumno_KeyUp(object sender, KeyEventArgs e)
        {
            textRutAlumno.Text = FormatearRut(textRutAlumno.Text);
            textRutAlumno.SelectionStart = textRutAlumno.Text.Length;
            textRutAlumno.SelectionLength = 0;
        }

        private void textRutAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("K"))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().ToUpper().Equals("-"))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
            {
                e.Handled = false;
            }
            else
            {
                //el resto de teclas pulsadas se desactivan 
                e.Handled = true;
            }
        }

        // rutina que formatea con separadores de miles y agrega el guion
        public static string FormatearRut(string rut)
        {
            string rutFormateado = string.Empty;

            if (rut.Length == 0)
            {
                rutFormateado = "";
            }
            else
            {
                string rutTemporal;
                string dv;
                Int64 rutNumerico;

                rut = rut.Replace("-", "").Replace(".", "");

                if (rut.Length == 1)
                {
                    rutFormateado = rut;
                }
                else
                {
                    rutTemporal = rut.Substring(0, rut.Length - 1);
                    dv = rut.Substring(rut.Length - 1, 1);

                    //aqui convierto a un numero el RUT si ocurre un error lo deja en CERO
                    if (!Int64.TryParse(rutTemporal, out rutNumerico))
                    {
                        rutNumerico = 0;
                    }

                    //este comando es el que formatea con los separadores de miles
                    rutFormateado = rutNumerico.ToString("N0");

                    if (rutFormateado.Equals("0"))
                    {
                        rutFormateado = string.Empty;
                    }
                    else
                    {
                        //si no hubo problemas con el formateo agrego el DV a la salida
                        rutFormateado += "-" + dv;

                        //y hago este replace por si el servidor tuviese configuracion anglosajona y reemplazo las comas por puntos
                        rutFormateado = rutFormateado.Replace(",", ".");
                    }
                }
            }

            return rutFormateado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string rut = textRutAlumno.Text;
                string nombre = textNombreAlumno.Text;
                string fechaIngreso = dateFechaIngresoAlumno.Value.ToString("yyyy-MM-dd");
                string fechaNac = dateTimeNacimiento.Value.ToString("yyyy-MM-dd");
                if (rut != "" && nombre != "" && fechaIngreso != "" && fechaNac != "")
                {

                    string sql = "INSERT INTO estudiante (rut, nombre, fecha_ingreso, fecha_nacimiento) VALUES ('" + rut + "', '" + nombre + "','" + fechaIngreso + "','" + fechaNac +"')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Alumno guardado");
                        limpiar();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }



            } catch(FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
            
        }

        private void limpiar()
        {
            textNombreAlumno.Text = "";
            textRutAlumno.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
