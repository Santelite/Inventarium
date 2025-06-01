using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class adminis : Form
    {
        public adminis()
        {
            InitializeComponent();
        }

        void Refresh()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();
            String cadena = "SELECT * FROM Producto";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader reader = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView1.Rows.Add(values);
            }
            con.Close();
        }

        private void adminis_Load(object sender, EventArgs e)
        {
            Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String id_producto = textBox1.Text;
                String nombre = textBox2.Text;
                String descripcion = textBox3.Text;
                int existencia = int.Parse(textBox4.Text);
                String precons = textBox5.Text;
                String prepro = textBox6.Text;
                String cadena = $"INSERT INTO Producto (nombre, descripcion, existencia, precons, prepro) VALUES ('{nombre}', '{descripcion}', '{existencia}', '{precons}', '{prepro}')";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto agregado correctamente");
                con.Close();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void elim_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String cadena = $"DELETE FROM Producto WHERE id_producto={int.Parse(textBox1.Text)}";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto eliminado correctamente");
                con.Close();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String id_producto = textBox1.Text;
                String nombre = textBox2.Text;
                String descripcion = textBox3.Text;
                int existencia = int.Parse(textBox4.Text);
                String precons = textBox5.Text;
                String prepro = textBox6.Text;
                String cadena = $"UPDATE Producto SET nombre = '{nombre}', descripcion = '{descripcion}', existencia = '{existencia}', prepro = '{prepro}', precons = '{precons}' WHERE id_producto={id_producto}";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                MessageBox.Show("Producto actualizado");
                con.Close();
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message);
            }
        }

        private void ver_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();

            String cadena = "";

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                cadena = $"SELECT * FROM Producto WHERE id_producto='{textBox1.Text}'";
            }

            else if (!string.IsNullOrEmpty(textBox2.Text))
            {
                cadena = $"SELECT * FROM Producto WHERE nombre='{textBox2.Text}'";
            }

            else
            {
                cadena = "SELECT * FROM Producto";
            }

            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader reader = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView1.Rows.Add(values);
            }
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
