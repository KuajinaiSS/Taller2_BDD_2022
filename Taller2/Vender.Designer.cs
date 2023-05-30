namespace Taller2
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Regresar = new System.Windows.Forms.Button();
            this.Input_Cliente = new System.Windows.Forms.ComboBox();
            this.Input_Vendedor = new System.Windows.Forms.ComboBox();
            this.Input_Producto = new System.Windows.Forms.ComboBox();
            this.Input_CantidadCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Vender = new System.Windows.Forms.Button();
            this.Input_Descuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vender";
            // 
            // button_Regresar
            // 
            this.button_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_Regresar.Location = new System.Drawing.Point(14, 281);
            this.button_Regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Regresar.Name = "button_Regresar";
            this.button_Regresar.Size = new System.Drawing.Size(169, 71);
            this.button_Regresar.TabIndex = 5;
            this.button_Regresar.Text = "Regresar";
            this.button_Regresar.UseVisualStyleBackColor = false;
            this.button_Regresar.Click += new System.EventHandler(this.button_Regresar_Click);
            // 
            // Input_Cliente
            // 
            this.Input_Cliente.FormattingEnabled = true;
            this.Input_Cliente.Location = new System.Drawing.Point(365, 123);
            this.Input_Cliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Cliente.Name = "Input_Cliente";
            this.Input_Cliente.Size = new System.Drawing.Size(133, 28);
            this.Input_Cliente.TabIndex = 6;
            this.Input_Cliente.SelectedIndexChanged += new System.EventHandler(this.Input_Cliente_SelectedIndexChanged);
            // 
            // Input_Vendedor
            // 
            this.Input_Vendedor.FormattingEnabled = true;
            this.Input_Vendedor.Location = new System.Drawing.Point(48, 123);
            this.Input_Vendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Vendedor.Name = "Input_Vendedor";
            this.Input_Vendedor.Size = new System.Drawing.Size(133, 28);
            this.Input_Vendedor.TabIndex = 8;
            // 
            // Input_Producto
            // 
            this.Input_Producto.FormattingEnabled = true;
            this.Input_Producto.Location = new System.Drawing.Point(210, 123);
            this.Input_Producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Producto.Name = "Input_Producto";
            this.Input_Producto.Size = new System.Drawing.Size(133, 28);
            this.Input_Producto.TabIndex = 9;
            // 
            // Input_CantidadCompra
            // 
            this.Input_CantidadCompra.Location = new System.Drawing.Point(130, 199);
            this.Input_CantidadCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CantidadCompra.Name = "Input_CantidadCompra";
            this.Input_CantidadCompra.Size = new System.Drawing.Size(133, 27);
            this.Input_CantidadCompra.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(79, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(243, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(406, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label5.Location = new System.Drawing.Point(167, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "cantidad";
            // 
            // button_Vender
            // 
            this.button_Vender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_Vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Vender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_Vender.Location = new System.Drawing.Point(365, 281);
            this.button_Vender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Vender.Name = "button_Vender";
            this.button_Vender.Size = new System.Drawing.Size(169, 71);
            this.button_Vender.TabIndex = 15;
            this.button_Vender.Text = "Vender";
            this.button_Vender.UseVisualStyleBackColor = false;
            this.button_Vender.Click += new System.EventHandler(this.button_Vender_Click);
            // 
            // Input_Descuento
            // 
            this.Input_Descuento.Location = new System.Drawing.Point(285, 199);
            this.Input_Descuento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Descuento.Name = "Input_Descuento";
            this.Input_Descuento.Size = new System.Drawing.Size(133, 27);
            this.Input_Descuento.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label6.Location = new System.Drawing.Point(297, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "DESCUENTO (%)";
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(547, 368);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Input_Descuento);
            this.Controls.Add(this.button_Vender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_CantidadCompra);
            this.Controls.Add(this.Input_Producto);
            this.Controls.Add(this.Input_Vendedor);
            this.Controls.Add(this.Input_Cliente);
            this.Controls.Add(this.button_Regresar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Vender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nerf Aatrox";
            this.Load += new System.EventHandler(this.Vender_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_Regresar;
        private ComboBox Input_Cliente;
        private ComboBox Input_Vendedor;
        private ComboBox Input_Producto;
        private TextBox Input_CantidadCompra;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button_Vender;
        private TextBox Input_Descuento;
        private Label label6;
    }
}