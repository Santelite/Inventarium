namespace Inventario
{
    partial class CCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CCliente));
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Existencia = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Venta = new Label();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            label6 = new Label();
            button3 = new Button();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, Existencia, Column2 });
            dataGridView1.Location = new Point(12, 230);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(635, 188);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Existencia
            // 
            Existencia.HeaderText = "Existencia";
            Existencia.MinimumWidth = 6;
            Existencia.Name = "Existencia";
            Existencia.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Precio Consumidor";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Column3, Column4, Column5, Column6 });
            dataGridView2.Location = new Point(12, 455);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(635, 188);
            dataGridView2.TabIndex = 1;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Nombre";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Cantidad";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Precio";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(188, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(729, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 33);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "ID del Producto";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 207);
            label2.Name = "label2";
            label2.Size = new Size(151, 20);
            label2.TabIndex = 6;
            label2.Text = "Inventario Disponible";
            // 
            // Venta
            // 
            Venta.AutoSize = true;
            Venta.Location = new Point(12, 432);
            Venta.Name = "Venta";
            Venta.Size = new Size(92, 20);
            Venta.TabIndex = 7;
            Venta.Text = "Venta Actual";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 66);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 8;
            label3.Text = "Nombre";
            label3.TextAlign = ContentAlignment.TopCenter;
            label3.Click += label3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(188, 96);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 99);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 10;
            label4.Text = "Cantidad a Vender";
            // 
            // button1
            // 
            button1.Location = new Point(174, 148);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 11;
            button1.Text = "Agregar por ID";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(332, 148);
            button2.Name = "button2";
            button2.Size = new Size(178, 29);
            button2.TabIndex = 12;
            button2.Text = "Agregar por Nombre";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 673);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 13;
            label5.Text = "Total de la Venta:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(579, 673);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 14;
            label6.Text = "$0000.00";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button3
            // 
            button3.Location = new Point(12, 669);
            button3.Name = "button3";
            button3.Size = new Size(151, 29);
            button3.TabIndex = 15;
            button3.Text = "Confirmar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 17);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 16;
            label7.Text = "Nombre del Cliente";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(332, 73);
            label8.Name = "label8";
            label8.Size = new Size(121, 20);
            label8.TabIndex = 17;
            label8.Text = "Email del Cliente";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(332, 96);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(276, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(332, 40);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(276, 27);
            textBox6.TabIndex = 19;
            // 
            // CCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(659, 718);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(Venta);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CCliente";
            Text = "Crear Venta";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label Venta;
        private Label label3;
        private TextBox textBox4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label4;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Button button3;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}