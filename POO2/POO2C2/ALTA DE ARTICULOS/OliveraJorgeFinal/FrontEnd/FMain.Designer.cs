namespace FrontEnd
{
    partial class FMain
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
            BArticulos = new Button();
            Bclientes = new Button();
            bsalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BArticulos
            // 
            BArticulos.Location = new Point(50, 80);
            BArticulos.Name = "BArticulos";
            BArticulos.Size = new Size(182, 54);
            BArticulos.TabIndex = 0;
            BArticulos.Text = "Artículos";
            BArticulos.UseVisualStyleBackColor = true;
            BArticulos.Click += BArticulos_Click;
            // 
            // Bclientes
            // 
            Bclientes.Location = new Point(50, 150);
            Bclientes.Name = "Bclientes";
            Bclientes.Size = new Size(182, 51);
            Bclientes.TabIndex = 1;
            Bclientes.Text = "Clientes";
            Bclientes.UseVisualStyleBackColor = true;
            Bclientes.Click += Bclientes_Click;
            // 
            // bsalir
            // 
            bsalir.Location = new Point(621, 364);
            bsalir.Name = "bsalir";
            bsalir.Size = new Size(138, 52);
            bsalir.TabIndex = 2;
            bsalir.Text = "Salir";
            bsalir.UseVisualStyleBackColor = true;
            bsalir.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(257, 26);
            label1.Name = "label1";
            label1.Size = new Size(254, 30);
            label1.TabIndex = 3;
            label1.Text = "Administrador de ventas";
            label1.Click += label1_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HotTrack;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(bsalir);
            Controls.Add(Bclientes);
            Controls.Add(BArticulos);
            Name = "FMain";
            Text = "FMain";
            Load += FMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BArticulos;
        private Button Bclientes;
        private Button bsalir;
        private Label label1;
    }
}