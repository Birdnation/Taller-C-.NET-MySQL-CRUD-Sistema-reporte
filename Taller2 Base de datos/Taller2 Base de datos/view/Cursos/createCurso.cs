using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2_Base_de_datos.view.Cursos
{
    public partial class createCurso : Form
    {
        public createCurso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string codigo = textCodigo.Text;
                string nombre = textNombreCurso.Text;
                int credito = int.Parse(textCreditoCurso.Text);

                if (codigo != "" && nombre != "" && credito > 0)
                {

                    string sql = "INSERT INTO curso (codigo, nombre, creditos) VALUES ('" + codigo + "', '" + nombre + "','" + credito + "')";

                    MySqlConnection conexionBD = Conexion.conexion();
                    conexionBD.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Registro guardado");
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



            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }
        }

        private void limpiar()
        {
            textCodigo.Text = "";
            textNombreCurso.Text = "";
            textCreditoCurso.Text = "";
        }
    }
}
