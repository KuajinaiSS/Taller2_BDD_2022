namespace Taller2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button_Modificaciones = new System.Windows.Forms.Button();
            this.button_Consultas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(305, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 74);
            this.label1.TabIndex = 2;
            this.label1.Text = "inicio";
            // 
            // button_Modificaciones
            // 
            this.button_Modificaciones.AllowDrop = true;
            this.button_Modificaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_Modificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modificaciones.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Modificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_Modificaciones.Location = new System.Drawing.Point(106, 175);
            this.button_Modificaciones.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Modificaciones.Name = "button_Modificaciones";
            this.button_Modificaciones.Size = new System.Drawing.Size(274, 128);
            this.button_Modificaciones.TabIndex = 6;
            this.button_Modificaciones.Text = "Modificaciones a la base de datos";
            this.button_Modificaciones.UseVisualStyleBackColor = false;
            this.button_Modificaciones.Click += new System.EventHandler(this.button_Modificaciones_Click);
            // 
            // button_Consultas
            // 
            this.button_Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(121)))), ((int)(((byte)(176)))));
            this.button_Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Consultas.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Consultas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(218)))), ((int)(((byte)(249)))));
            this.button_Consultas.Location = new System.Drawing.Point(424, 173);
            this.button_Consultas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_Consultas.Name = "button_Consultas";
            this.button_Consultas.Size = new System.Drawing.Size(274, 132);
            this.button_Consultas.TabIndex = 5;
            this.button_Consultas.Text = "Consultas a la base de datos";
            this.button_Consultas.UseVisualStyleBackColor = false;
            this.button_Consultas.Click += new System.EventHandler(this.button_Consultas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 363);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(592, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(65)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(806, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_Modificaciones);
            this.Controls.Add(this.button_Consultas);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Totally not a virus";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button button_Modificaciones;
        private Button button_Consultas;
        private PictureBox pictureBox1;
    }
}