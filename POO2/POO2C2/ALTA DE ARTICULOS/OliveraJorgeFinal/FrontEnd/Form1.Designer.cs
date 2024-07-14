namespace FrontEnd
{
    partial class FArticulos
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Fnombre = new TextBox();
            Fprecio = new TextBox();
            FStock = new TextBox();
            BGrabar = new Button();
            BCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 28);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(552, 282);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(685, 33);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(685, 101);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 2;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(685, 172);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Stock";
            // 
            // Fnombre
            // 
            Fnombre.Location = new Point(759, 28);
            Fnombre.Name = "Fnombre";
            Fnombre.Size = new Size(257, 23);
            Fnombre.TabIndex = 4;
            // 
            // Fprecio
            // 
            Fprecio.Location = new Point(759, 101);
            Fprecio.Name = "Fprecio";
            Fprecio.Size = new Size(257, 23);
            Fprecio.TabIndex = 5;
            // 
            // FStock
            // 
            FStock.Location = new Point(759, 172);
            FStock.Name = "FStock";
            FStock.Size = new Size(257, 23);
            FStock.TabIndex = 6;
            // 
            // BGrabar
            // 
            BGrabar.Location = new Point(685, 265);
            BGrabar.Name = "BGrabar";
            BGrabar.Size = new Size(331, 45);
            BGrabar.TabIndex = 7;
            BGrabar.Text = "Grabar";
            BGrabar.UseVisualStyleBackColor = true;
            BGrabar.Click += BGrabar_Click;
            // 
            // BCerrar
            // 
            BCerrar.Location = new Point(860, 390);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(196, 52);
            BCerrar.TabIndex = 8;
            BCerrar.Text = "Cerrar";
            BCerrar.UseVisualStyleBackColor = true;
            BCerrar.Click += BCerrar_Click;
            // 
            // FArticulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 463);
            Controls.Add(BCerrar);
            Controls.Add(BGrabar);
            Controls.Add(FStock);
            Controls.Add(Fprecio);
            Controls.Add(Fnombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FArticulos";
            Text = "Administración de articulos";
            Load += FArticulos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Fnombre;
        private TextBox Fprecio;
        private TextBox FStock;
        private Button BGrabar;
        private Button BCerrar;
    }
}