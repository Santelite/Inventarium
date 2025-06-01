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
    public partial class CCliente : Form
    {
        public CCliente()
        {
            InitializeComponent();
        }

        void PrecioCal() 
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();
            String cadena = "SELECT SUM(precio * cantidad) AS Total FROM venta";
            SqlCommand comando = new SqlCommand(cadena, con);
            object resultado = comando.ExecuteScalar();
            if (resultado != DBNull.Value)
            {
                decimal total = Convert.ToDecimal(resultado);
                label6.Text = "Total: $" + total.ToString("F2");
            }
            else
            {
                label6.Text = "Total: $0.00";
            }
        }
        void Refresh1()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();
            String cadena = "SELECT id_producto, nombre, existencia, preCons FROM Producto";
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
            PrecioCal();
        }

        void Refresh2()
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();
            String cadena = "SELECT * FROM venta";
            SqlCommand comando = new SqlCommand(cadena, con);
            SqlDataReader reader = comando.ExecuteReader();

            dataGridView2.Rows.Clear();

            while (reader.Read())
            {
                object[] values = new object[reader.FieldCount];
                reader.GetValues(values);
                dataGridView2.Rows.Add(values);
            }
            con.Close();
            PrecioCal();
        }

        void PorID()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String cadena = $"INSERT INTO venta (id_producto, nombre, precio, cantidad) SELECT id_producto, nombre, preCons, {int.Parse(textBox4.Text)} FROM Producto WHERE id_producto='{int.Parse(textBox1.Text)}'";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                //String cadena2 = $"INSERT INTO venta (cantidad) VALUES ('')";
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                MessageBox.Show("Producto agregado a la venta.");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
            PrecioCal();
        }

        void PorNombre()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String cadena = $"INSERT INTO venta (id_producto, nombre, precio, cantidad) SELECT id_producto, nombre, preCons, {int.Parse(textBox2.Text)} FROM Producto WHERE id_producto='{int.Parse(textBox1.Text)}'";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                //String cadena2 = $"INSERT INTO venta (cantidad) VALUES ('')";
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();
                MessageBox.Show("Producto agregado a la venta.");
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
            PrecioCal();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CCliente_Load(object sender, EventArgs e)
        {
            Refresh1();
            Refresh2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PorID();
            Refresh2();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PorNombre();
            Refresh2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
            con.Open();
            String cadena = "DELETE FROM venta";
            SqlCommand comando = new SqlCommand(cadena, con);
            comando.ExecuteNonQuery();
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            MessageBox.Show("Venta reiniciada.");
            con.Close();
            Refresh1();
            Refresh2();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
