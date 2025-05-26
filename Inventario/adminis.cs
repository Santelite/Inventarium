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

        private void adminis_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
