namespace Inventario
{
    partial class adminis
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
            dataGridView1 = new DataGridView();
            id_producto = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            Existencia = new DataGridViewTextBoxColumn();
            Ventas = new DataGridViewTextBoxColumn();
            precons = new DataGridViewTextBoxColumn();
            prepro = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            actualizar = new Button();
            elim = new Button();
            ver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_producto, nombre, descripcion, Existencia, Ventas, precons, prepro });
            dataGridView1.Location = new Point(12, 292);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(866, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id_producto
            // 
            id_producto.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id_producto.HeaderText = "ID del Prod.";
            id_producto.MinimumWidth = 6;
            id_producto.Name = "id_producto";
            id_producto.Width = 107;
            // 
            // nombre
            // 
            nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 93;
            // 
            // descripcion
            // 
            descripcion.HeaderText = "Descripción";
            descripcion.MinimumWidth = 6;
            descripcion.Name = "descripcion";
            descripcion.Width = 125;
            // 
            // Existencia
            // 
            Existencia.HeaderText = "Existencia";
            Existencia.MinimumWidth = 6;
            Existencia.Name = "Existencia";
            Existencia.Width = 125;
            // 
            // Ventas
            // 
            Ventas.HeaderText = "Ventas";
            Ventas.MinimumWidth = 6;
            Ventas.Name = "Ventas";
            Ventas.Width = 125;
            // 
            // precons
            // 
            precons.HeaderText = "Precio al Consumidor";
            precons.MinimumWidth = 6;
            precons.Name = "precons";
            precons.Width = 125;
            // 
            // prepro
            // 
            prepro.HeaderText = "Precio del Proveedor";
            prepro.MinimumWidth = 6;
            prepro.Name = "prepro";
            prepro.Width = 125;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 246);
            button1.Name = "button1";
            button1.Size = new Size(220, 29);
            button1.TabIndex = 2;
            button1.Text = "Añadir Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(334, 49);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(264, 52);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 52);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "ID Producto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 52);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 7;
            label3.Text = "descripción";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(589, 49);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 115);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 9;
            label4.Text = "existencia";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 112);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 119);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 11;
            label5.Text = "Precio al Cons";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(312, 151);
            label6.Name = "label6";
            label6.Size = new Size(147, 20);
            label6.TabIndex = 12;
            label6.Text = "Precio del Proveedor";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(465, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 13;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(465, 148);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 27);
            textBox6.TabIndex = 14;
            // 
            // actualizar
            // 
            actualizar.Location = new Point(264, 246);
            actualizar.Name = "actualizar";
            actualizar.Size = new Size(195, 29);
            actualizar.TabIndex = 15;
            actualizar.Text = "Actualizar Producto";
            actualizar.UseVisualStyleBackColor = true;
            actualizar.Click += actualizar_Click;
            // 
            // elim
            // 
            elim.Location = new Point(498, 246);
            elim.Name = "elim";
            elim.Size = new Size(177, 29);
            elim.TabIndex = 16;
            elim.Text = "Eliminar ID Prod.";
            elim.UseVisualStyleBackColor = true;
            elim.Click += elim_Click;
            // 
            // ver
            // 
            ver.Location = new Point(707, 246);
            ver.Name = "ver";
            ver.Size = new Size(171, 29);
            ver.TabIndex = 17;
            ver.Text = "Actualizar Inventario";
            ver.UseVisualStyleBackColor = true;
            ver.Click += ver_Click;
            // 
            // adminis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 492);
            Controls.Add(ver);
            Controls.Add(elim);
            Controls.Add(actualizar);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Name = "adminis";
            Text = "adminis";
            Load += adminis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private Label label6;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button actualizar;
        private Button elim;
        private Button ver;
        private DataGridViewTextBoxColumn id_producto;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn Existencia;
        private DataGridViewTextBoxColumn Ventas;
        private DataGridViewTextBoxColumn precons;
        private DataGridViewTextBoxColumn prepro;
    }
}