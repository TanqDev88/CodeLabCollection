namespace FrontEnd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView2 = new DataGridView();
            FNombre = new Label();
            FPrecio = new Label();
            FStock = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 28);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 1;
            // 
            // FNombre
            // 
            FNombre.AutoSize = true;
            FNombre.Location = new Point(462, 71);
            FNombre.Name = "FNombre";
            FNombre.Size = new Size(64, 20);
            FNombre.TabIndex = 2;
            FNombre.Text = "Nombre";
            // 
            // FPrecio
            // 
            FPrecio.AutoSize = true;
            FPrecio.Location = new Point(442, 145);
            FPrecio.Name = "FPrecio";
            FPrecio.Size = new Size(50, 20);
            FPrecio.TabIndex = 3;
            FPrecio.Text = "Precio";
            // 
            // FStock
            // 
            FStock.AutoSize = true;
            FStock.Location = new Point(462, 205);
            FStock.Name = "FStock";
            FStock.Size = new Size(45, 20);
            FStock.TabIndex = 4;
            FStock.Text = "Stock";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(563, 205);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 27);
            textBox1.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(639, 299);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Grabar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(563, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(231, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(563, 71);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(231, 27);
            textBox3.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(0, 0);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 9;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(483, 299);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 10;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(FStock);
            Controls.Add(FPrecio);
            Controls.Add(FNombre);
            Controls.Add(dataGridView2);
            Name = "Form1";
            Text = "ADMIN Articulos";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView2;
        private Label FNombre;
        private Label FPrecio;
        private Label FStock;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
    }
}
