namespace Taller2
{
    partial class Consultas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Regresar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_ProductosSuministradosProveedor = new System.Windows.Forms.RadioButton();
            this.radio_ProductoSuministranProveedores = new System.Windows.Forms.RadioButton();
            this.Input_CategoriaProductosAsociados = new System.Windows.Forms.RadioButton();
            this.radioCategoriaProducto = new System.Windows.Forms.RadioButton();
            this.radioDatoOrdenCompra = new System.Windows.Forms.RadioButton();
            this.radioDatoVendedor = new System.Windows.Forms.RadioButton();
            this.radioEmitirListado = new System.Windows.Forms.RadioButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Input_Listado = new System.Windows.Forms.ComboBox();
            this.Input_Vendedor = new System.Windows.Forms.ComboBox();
            this.Input_DatosOrdenCompra = new System.Windows.Forms.ComboBox();
            this.Input_CategoriaProducto = new System.Windows.Forms.ComboBox();
            this.Input_CantidadProductosAsociados = new System.Windows.Forms.ComboBox();
            this.Input_ProductoProveedores = new System.Windows.Forms.ComboBox();
            this.Input_ProveedorProductos = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(284, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 52);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultas";
            // 
            // button_Regresar
            // 
            this.button_Regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_Regresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Regresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_Regresar.Location = new System.Drawing.Point(14, 643);
            this.button_Regresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Regresar.Name = "button_Regresar";
            this.button_Regresar.Size = new System.Drawing.Size(169, 71);
            this.button_Regresar.TabIndex = 6;
            this.button_Regresar.Text = "Regresar";
            this.button_Regresar.UseVisualStyleBackColor = false;
            this.button_Regresar.Click += new System.EventHandler(this.button_Regresar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_ProductosSuministradosProveedor);
            this.groupBox1.Controls.Add(this.radio_ProductoSuministranProveedores);
            this.groupBox1.Controls.Add(this.Input_CategoriaProductosAsociados);
            this.groupBox1.Controls.Add(this.radioCategoriaProducto);
            this.groupBox1.Controls.Add(this.radioDatoOrdenCompra);
            this.groupBox1.Controls.Add(this.radioDatoVendedor);
            this.groupBox1.Controls.Add(this.radioEmitirListado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(14, 337);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(400, 276);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija la consulta";
            // 
            // radio_ProductosSuministradosProveedor
            // 
            this.radio_ProductosSuministradosProveedor.AutoSize = true;
            this.radio_ProductosSuministradosProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radio_ProductosSuministradosProveedor.Location = new System.Drawing.Point(7, 229);
            this.radio_ProductosSuministradosProveedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_ProductosSuministradosProveedor.Name = "radio_ProductosSuministradosProveedor";
            this.radio_ProductosSuministradosProveedor.Size = new System.Drawing.Size(323, 24);
            this.radio_ProductosSuministradosProveedor.TabIndex = 7;
            this.radio_ProductosSuministradosProveedor.TabStop = true;
            this.radio_ProductosSuministradosProveedor.Text = "Productos que suministra un proveedor";
            this.radio_ProductosSuministradosProveedor.UseVisualStyleBackColor = true;
            this.radio_ProductosSuministradosProveedor.CheckedChanged += new System.EventHandler(this.radio_ProductosSuministradosProveedor_CheckedChanged);
            // 
            // radio_ProductoSuministranProveedores
            // 
            this.radio_ProductoSuministranProveedores.AutoSize = true;
            this.radio_ProductoSuministranProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radio_ProductoSuministranProveedores.Location = new System.Drawing.Point(7, 196);
            this.radio_ProductoSuministranProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radio_ProductoSuministranProveedores.Name = "radio_ProductoSuministranProveedores";
            this.radio_ProductoSuministranProveedores.Size = new System.Drawing.Size(340, 24);
            this.radio_ProductoSuministranProveedores.TabIndex = 6;
            this.radio_ProductoSuministranProveedores.TabStop = true;
            this.radio_ProductoSuministranProveedores.Text = "Proveedores que suministran un producto";
            this.radio_ProductoSuministranProveedores.UseVisualStyleBackColor = true;
            this.radio_ProductoSuministranProveedores.CheckedChanged += new System.EventHandler(this.radio_ProductoSuministranProveedores_CheckedChanged);
            // 
            // Input_CategoriaProductosAsociados
            // 
            this.Input_CategoriaProductosAsociados.AutoSize = true;
            this.Input_CategoriaProductosAsociados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.Input_CategoriaProductosAsociados.Location = new System.Drawing.Point(7, 163);
            this.Input_CategoriaProductosAsociados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CategoriaProductosAsociados.Name = "Input_CategoriaProductosAsociados";
            this.Input_CategoriaProductosAsociados.Size = new System.Drawing.Size(388, 24);
            this.Input_CategoriaProductosAsociados.TabIndex = 5;
            this.Input_CategoriaProductosAsociados.TabStop = true;
            this.Input_CategoriaProductosAsociados.Text = "Cantidad de productos asociados a una categoria";
            this.Input_CategoriaProductosAsociados.UseVisualStyleBackColor = true;
            this.Input_CategoriaProductosAsociados.CheckedChanged += new System.EventHandler(this.Input_CategoriaProductosAsociados_CheckedChanged);
            // 
            // radioCategoriaProducto
            // 
            this.radioCategoriaProducto.AutoSize = true;
            this.radioCategoriaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radioCategoriaProducto.Location = new System.Drawing.Point(7, 129);
            this.radioCategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioCategoriaProducto.Name = "radioCategoriaProducto";
            this.radioCategoriaProducto.Size = new System.Drawing.Size(218, 24);
            this.radioCategoriaProducto.TabIndex = 4;
            this.radioCategoriaProducto.TabStop = true;
            this.radioCategoriaProducto.Text = "Categoria de un producto";
            this.radioCategoriaProducto.UseVisualStyleBackColor = true;
            this.radioCategoriaProducto.CheckedChanged += new System.EventHandler(this.radioCategoriaProducto_CheckedChanged);
            // 
            // radioDatoOrdenCompra
            // 
            this.radioDatoOrdenCompra.AutoSize = true;
            this.radioDatoOrdenCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radioDatoOrdenCompra.Location = new System.Drawing.Point(7, 96);
            this.radioDatoOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioDatoOrdenCompra.Name = "radioDatoOrdenCompra";
            this.radioDatoOrdenCompra.Size = new System.Drawing.Size(254, 24);
            this.radioDatoOrdenCompra.TabIndex = 3;
            this.radioDatoOrdenCompra.TabStop = true;
            this.radioDatoOrdenCompra.Text = "Datos de una orden de compra";
            this.radioDatoOrdenCompra.UseVisualStyleBackColor = true;
            this.radioDatoOrdenCompra.CheckedChanged += new System.EventHandler(this.radioDatoOrdenCompra_CheckedChanged);
            // 
            // radioDatoVendedor
            // 
            this.radioDatoVendedor.AutoSize = true;
            this.radioDatoVendedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radioDatoVendedor.Location = new System.Drawing.Point(7, 63);
            this.radioDatoVendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioDatoVendedor.Name = "radioDatoVendedor";
            this.radioDatoVendedor.Size = new System.Drawing.Size(191, 24);
            this.radioDatoVendedor.TabIndex = 1;
            this.radioDatoVendedor.TabStop = true;
            this.radioDatoVendedor.Text = "Datos de un vendedor";
            this.radioDatoVendedor.UseVisualStyleBackColor = true;
            this.radioDatoVendedor.CheckedChanged += new System.EventHandler(this.radioDatoVendedor_CheckedChanged);
            // 
            // radioEmitirListado
            // 
            this.radioEmitirListado.AutoSize = true;
            this.radioEmitirListado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.radioEmitirListado.Location = new System.Drawing.Point(7, 29);
            this.radioEmitirListado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioEmitirListado.Name = "radioEmitirListado";
            this.radioEmitirListado.Size = new System.Drawing.Size(133, 24);
            this.radioEmitirListado.TabIndex = 0;
            this.radioEmitirListado.TabStop = true;
            this.radioEmitirListado.Text = "Emitir Listado";
            this.radioEmitirListado.UseVisualStyleBackColor = true;
            this.radioEmitirListado.CheckedChanged += new System.EventHandler(this.radioEmitirListado_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(21, 89);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(757, 224);
            this.dataGridView.TabIndex = 8;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // Input_Listado
            // 
            this.Input_Listado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_Listado.FormattingEnabled = true;
            this.Input_Listado.Location = new System.Drawing.Point(439, 361);
            this.Input_Listado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Listado.Name = "Input_Listado";
            this.Input_Listado.Size = new System.Drawing.Size(309, 28);
            this.Input_Listado.TabIndex = 9;
            this.Input_Listado.Text = "Elija el listado";
            this.Input_Listado.SelectedIndexChanged += new System.EventHandler(this.Input_Listado_SelectedIndexChanged);
            // 
            // Input_Vendedor
            // 
            this.Input_Vendedor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_Vendedor.FormattingEnabled = true;
            this.Input_Vendedor.Location = new System.Drawing.Point(439, 361);
            this.Input_Vendedor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_Vendedor.Name = "Input_Vendedor";
            this.Input_Vendedor.Size = new System.Drawing.Size(309, 28);
            this.Input_Vendedor.TabIndex = 16;
            this.Input_Vendedor.Text = "Elija un vendedor";
            this.Input_Vendedor.SelectedIndexChanged += new System.EventHandler(this.Input_Vendedor_SelectedIndexChanged);
            // 
            // Input_DatosOrdenCompra
            // 
            this.Input_DatosOrdenCompra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_DatosOrdenCompra.FormattingEnabled = true;
            this.Input_DatosOrdenCompra.Location = new System.Drawing.Point(439, 361);
            this.Input_DatosOrdenCompra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_DatosOrdenCompra.Name = "Input_DatosOrdenCompra";
            this.Input_DatosOrdenCompra.Size = new System.Drawing.Size(309, 28);
            this.Input_DatosOrdenCompra.TabIndex = 17;
            this.Input_DatosOrdenCompra.Text = "Elija una orden de compra";
            this.Input_DatosOrdenCompra.SelectedIndexChanged += new System.EventHandler(this.Input_DatosOrdenCompra_SelectedIndexChanged);
            // 
            // Input_CategoriaProducto
            // 
            this.Input_CategoriaProducto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_CategoriaProducto.FormattingEnabled = true;
            this.Input_CategoriaProducto.Location = new System.Drawing.Point(439, 361);
            this.Input_CategoriaProducto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CategoriaProducto.Name = "Input_CategoriaProducto";
            this.Input_CategoriaProducto.Size = new System.Drawing.Size(309, 28);
            this.Input_CategoriaProducto.TabIndex = 18;
            this.Input_CategoriaProducto.Text = "Eliga un producto";
            this.Input_CategoriaProducto.SelectedIndexChanged += new System.EventHandler(this.Input_CategoriaProducto_SelectedIndexChanged);
            // 
            // Input_CantidadProductosAsociados
            // 
            this.Input_CantidadProductosAsociados.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_CantidadProductosAsociados.FormattingEnabled = true;
            this.Input_CantidadProductosAsociados.Location = new System.Drawing.Point(439, 361);
            this.Input_CantidadProductosAsociados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_CantidadProductosAsociados.Name = "Input_CantidadProductosAsociados";
            this.Input_CantidadProductosAsociados.Size = new System.Drawing.Size(309, 28);
            this.Input_CantidadProductosAsociados.TabIndex = 19;
            this.Input_CantidadProductosAsociados.Text = "Elija una categoria";
            this.Input_CantidadProductosAsociados.SelectedIndexChanged += new System.EventHandler(this.Input_CantidadProductosAsociados_SelectedIndexChanged);
            // 
            // Input_ProductoProveedores
            // 
            this.Input_ProductoProveedores.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_ProductoProveedores.FormattingEnabled = true;
            this.Input_ProductoProveedores.Location = new System.Drawing.Point(439, 361);
            this.Input_ProductoProveedores.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_ProductoProveedores.Name = "Input_ProductoProveedores";
            this.Input_ProductoProveedores.Size = new System.Drawing.Size(309, 28);
            this.Input_ProductoProveedores.TabIndex = 20;
            this.Input_ProductoProveedores.Text = "Elija un produto";
            this.Input_ProductoProveedores.SelectedIndexChanged += new System.EventHandler(this.Input_ProductoProveedores_SelectedIndexChanged);
            // 
            // Input_ProveedorProductos
            // 
            this.Input_ProveedorProductos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Input_ProveedorProductos.FormattingEnabled = true;
            this.Input_ProveedorProductos.Location = new System.Drawing.Point(439, 361);
            this.Input_ProveedorProductos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Input_ProveedorProductos.Name = "Input_ProveedorProductos";
            this.Input_ProveedorProductos.Size = new System.Drawing.Size(309, 28);
            this.Input_ProveedorProductos.TabIndex = 21;
            this.Input_ProveedorProductos.Text = "Elija un proveedor";
            this.Input_ProveedorProductos.SelectedIndexChanged += new System.EventHandler(this.Input_ProveedorProductos_SelectedIndexChanged);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(806, 729);
            this.Controls.Add(this.Input_ProveedorProductos);
            this.Controls.Add(this.Input_ProductoProveedores);
            this.Controls.Add(this.Input_CantidadProductosAsociados);
            this.Controls.Add(this.Input_CategoriaProducto);
            this.Controls.Add(this.Input_DatosOrdenCompra);
            this.Controls.Add(this.Input_Vendedor);
            this.Controls.Add(this.Input_Listado);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_Regresar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Consultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiny Little Adiantum";
            this.Load += new System.EventHandler(this.Consultas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button button_Regresar;
        private GroupBox groupBox1;
        private RadioButton radioCategoriaProducto;
        private RadioButton radioDatoOrdenCompra;
        private RadioButton radioDatoVendedor;
        private RadioButton radioEmitirListado;
        private DataGridView dataGridView;
        private ComboBox Input_Listado;
        private ComboBox Input_Vendedor;
        private ComboBox Input_DatosOrdenCompra;
        private ComboBox Input_CategoriaProducto;
        private RadioButton Input_CategoriaProductosAsociados;
        private ComboBox Input_CantidadProductosAsociados;
        private RadioButton radio_ProductoSuministranProveedores;
        private ComboBox Input_ProductoProveedores;
        private RadioButton radio_ProductosSuministradosProveedor;
        private ComboBox Input_ProveedorProductos;
    }
}