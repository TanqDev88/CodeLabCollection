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
            BArticulo = new Button();
            BClientes = new Button();
            BSalir = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // BArticulo
            // 
            BArticulo.Location = new Point(28, 84);
            BArticulo.Name = "BArticulo";
            BArticulo.Size = new Size(176, 64);
            BArticulo.TabIndex = 0;
            BArticulo.Text = "Articulos";
            BArticulo.UseVisualStyleBackColor = true;
            // 
            // BClientes
            // 
            BClientes.Location = new Point(28, 181);
            BClientes.Name = "BClientes";
            BClientes.Size = new Size(176, 76);
            BClientes.TabIndex = 1;
            BClientes.Text = "Clientes";
            BClientes.UseVisualStyleBackColor = true;
            BClientes.Click += button2_Click;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(616, 378);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(120, 60);
            BSalir.TabIndex = 2;
            BSalir.Text = "Salir";
            BSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 29);
            label1.Name = "label1";
            label1.Size = new Size(182, 20);
            label1.TabIndex = 3;
            label1.Text = "Administrador de ventas";
            label1.Click += label1_Click;
            // 
            // FMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BSalir);
            Controls.Add(BClientes);
            Controls.Add(BArticulo);
            Name = "FMain";
            Text = "FMain";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BArticulo;
        private Button BClientes;
        private Button BSalir;
        private Label label1;
    }
}