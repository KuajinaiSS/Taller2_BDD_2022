namespace Taller2
{
    partial class Comprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
            this.label1 = new System.Windows.Forms.Label();
            this.button_regresar = new System.Windows.Forms.Button();
            this.Input_IDProducto = new System.Windows.Forms.ComboBox();
            this.Input_IDProveedor = new System.Windows.Forms.ComboBox();
            this.Input_CantidadComprar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_comprar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(226, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comprar";
            // 
            // button_regresar
            // 
            this.button_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_regresar.Location = new System.Drawing.Point(14, 284);
            this.button_regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_regresar.Name = "button_regresar";
            this.button_regresar.Size = new System.Drawing.Size(169, 71);
            this.button_regresar.TabIndex = 5;
            this.button_regresar.Text = "Regresar";
            this.button_regresar.UseVisualStyleBackColor = false;
            this.button_regresar.Click += new System.EventHandler(this.button_regresar_Click);
            // 
            // Input_IDProducto
            // 
            this.Input_IDProducto.FormattingEnabled = true;
            this.Input_IDProducto.Location = new System.Drawing.Point(29, 136);
            this.Input_IDProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_IDProducto.Name = "Input_IDProducto";
            this.Input_IDProducto.Size = new System.Drawing.Size(182, 28);
            this.Input_IDProducto.TabIndex = 6;
            this.Input_IDProducto.SelectedIndexChanged += new System.EventHandler(this.Input_IDProducto_SelectedIndexChanged);
            // 
            // Input_IDProveedor
            // 
            this.Input_IDProveedor.FormattingEnabled = true;
            this.Input_IDProveedor.Location = new System.Drawing.Point(239, 136);
            this.Input_IDProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_IDProveedor.Name = "Input_IDProveedor";
            this.Input_IDProveedor.Size = new System.Drawing.Size(182, 28);
            this.Input_IDProveedor.TabIndex = 7;
            this.Input_IDProveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Input_CantidadComprar
            // 
            this.Input_CantidadComprar.Location = new System.Drawing.Point(449, 136);
            this.Input_CantidadComprar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CantidadComprar.Name = "Input_CantidadComprar";
            this.Input_CantidadComprar.Size = new System.Drawing.Size(182, 27);
            this.Input_CantidadComprar.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(70, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(277, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "rut del proveedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label4.Location = new System.Drawing.Point(505, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "cantidad";
            // 
            // button_comprar
            // 
            this.button_comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_comprar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_comprar.Location = new System.Drawing.Point(479, 284);
            this.button_comprar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_comprar.Name = "button_comprar";
            this.button_comprar.Size = new System.Drawing.Size(169, 71);
            this.button_comprar.TabIndex = 13;
            this.button_comprar.Text = "Comprar";
            this.button_comprar.UseVisualStyleBackColor = false;
            this.button_comprar.Click += new System.EventHandler(this.button_comprar_Click);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(662, 371);
            this.Controls.Add(this.button_comprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Input_CantidadComprar);
            this.Controls.Add(this.Input_IDProveedor);
            this.Controls.Add(this.Input_IDProducto);
            this.Controls.Add(this.button_regresar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Comprar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BooM Dia";
            this.Load += new System.EventHandler(this.Comprar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_regresar;
        private ComboBox Input_IDProducto;
        private ComboBox Input_IDProveedor;
        private TextBox Input_CantidadComprar;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_comprar;
    }
}