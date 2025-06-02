using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;
using System.Xml.Linq;
using Document = iTextSharp.text.Document;
using Font = iTextSharp.text.Font;
using static System.ComponentModel.Design.ObjectSelectorEditor;

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
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(dataGridView2.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 90;
            pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;
            pdfTable.DefaultCell.BorderWidth = 1;
            pdfTable.SpacingBefore = 20f;

            //Adding Header row
            foreach (DataGridViewColumn column in dataGridView2.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }


            //Exporting to PDF
            string folderPath = "C:\\PDFs\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            Font tituloFuente = new Font(BaseFont.CreateFont((BaseFont.HELVETICA_BOLD), BaseFont.CP1252, false), 26);
            Font parrafoFuente = new Font(BaseFont.CreateFont((BaseFont.HELVETICA), BaseFont.CP1252, false), 14);

            Paragraph titulo = new Paragraph("Factura de Venta", tituloFuente);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.SpacingAfter = 20f;

            Paragraph saludo = new Paragraph("Saludos señor/a " + textBox6.Text + " aquí se le presenta la factura de su compra.", parrafoFuente);
            titulo.Alignment = Element.ALIGN_LEFT;
            titulo.SpacingAfter = 20f;

            Paragraph total = new Paragraph("Su total es de: " + label6.Text, parrafoFuente);
            titulo.Alignment = Element.ALIGN_RIGHT;
            titulo.SpacingAfter = 20f;

            Paragraph gracias = new Paragraph("Gracias por su compra!", tituloFuente);
            titulo.Alignment = Element.ALIGN_RIGHT;
            titulo.SpacingAfter = 20f;

            using (FileStream stream = new FileStream(folderPath + "Factura.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.LETTER, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                pdfDoc.Add(titulo);
                pdfDoc.Add(saludo);
                pdfDoc.Add(pdfTable);
                pdfDoc.Add(total);

                pdfDoc.Close();
                stream.Close();

                SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=Master;Integrated Security=True");
                con.Open();
                String cadena = "UPDATE producto SET existencia = existencia - ventas.total_vendida FROM (SELECT id_producto, SUM(cantidad) AS total_vendida FROM venta GROUP BY id_producto) AS ventas WHERE producto.id_producto = ventas.id_producto";
                SqlCommand comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox4.Clear();

                cadena = "UPDATE producto SET existencia = existencia - ventas.total_vendida FROM (SELECT id_producto, SUM(cantidad) AS total_vendida FROM venta GROUP BY id_producto) AS ventas WHERE producto.id_producto = ventas.id_producto";
                comando = new SqlCommand(cadena, con);
                comando.ExecuteNonQuery();

                MessageBox.Show("Venta completada.");
                con.Close();

                DialogResult resultado = MessageBox.Show("Factura generada en: " + folderPath + "Factura.pdf, abrir?","Abrir Factura", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var pdflugar = "C:\\PDFs\\Factura.pdf";
                    var process = new System.Diagnostics.Process();

                    process.StartInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = pdflugar,
                        UseShellExecute = true // 🔸 Esto indica que debe usarse el programa predeterminado del sistema
                    };

                    process.Start();
                }

                Refresh1();
                Refresh2();

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
