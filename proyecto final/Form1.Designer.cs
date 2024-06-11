namespace proyecto_final
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.IebEfectivo = new System.Windows.Forms.TextBox();
            this.IebCantidad = new System.Windows.Forms.TextBox();
            this.ButEliminar = new System.Windows.Forms.Button();
            this.ButAgregar = new System.Windows.Forms.Button();
            this.ComProducto = new System.Windows.Forms.ComboBox();
            this.IebDevolucion = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.IebPagar = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.IebPrecio = new System.Windows.Forms.Label();
            this.IebNombre = new System.Windows.Forms.Label();
            this.IebCodigo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DgbLista = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IebVender = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbLista)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IebEfectivo);
            this.panel1.Controls.Add(this.IebCantidad);
            this.panel1.Controls.Add(this.ButEliminar);
            this.panel1.Controls.Add(this.ButAgregar);
            this.panel1.Controls.Add(this.ComProducto);
            this.panel1.Controls.Add(this.IebDevolucion);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.IebPagar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.IebPrecio);
            this.panel1.Controls.Add(this.IebNombre);
            this.panel1.Controls.Add(this.IebCodigo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgbLista);
            this.panel1.Location = new System.Drawing.Point(12, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 432);
            this.panel1.TabIndex = 0;
            // 
            // IebEfectivo
            // 
            this.IebEfectivo.Location = new System.Drawing.Point(198, 368);
            this.IebEfectivo.Name = "IebEfectivo";
            this.IebEfectivo.Size = new System.Drawing.Size(80, 23);
            this.IebEfectivo.TabIndex = 19;
            this.IebEfectivo.TextChanged += new System.EventHandler(this.IebEfectivo_TextChanged);
            // 
            // IebCantidad
            // 
            this.IebCantidad.Location = new System.Drawing.Point(82, 128);
            this.IebCantidad.Name = "IebCantidad";
            this.IebCantidad.Size = new System.Drawing.Size(100, 23);
            this.IebCantidad.TabIndex = 18;
            // 
            // ButEliminar
            // 
            this.ButEliminar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButEliminar.Location = new System.Drawing.Point(349, 108);
            this.ButEliminar.Name = "ButEliminar";
            this.ButEliminar.Size = new System.Drawing.Size(101, 53);
            this.ButEliminar.TabIndex = 17;
            this.ButEliminar.Text = "ELIMINAR";
            this.ButEliminar.UseVisualStyleBackColor = false;
            this.ButEliminar.Click += new System.EventHandler(this.ButEliminar_Click);
            // 
            // ButAgregar
            // 
            this.ButAgregar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButAgregar.Location = new System.Drawing.Point(349, 39);
            this.ButAgregar.Name = "ButAgregar";
            this.ButAgregar.Size = new System.Drawing.Size(101, 54);
            this.ButAgregar.TabIndex = 16;
            this.ButAgregar.Text = "AGREGAR";
            this.ButAgregar.UseVisualStyleBackColor = false;
            this.ButAgregar.Click += new System.EventHandler(this.ButAgregar_Click);
            // 
            // ComProducto
            // 
            this.ComProducto.FormattingEnabled = true;
            this.ComProducto.Items.AddRange(new object[] {
            "Playera",
            "Gorra",
            "Pantalon",
            "Calcetines",
            "Chanclas",
            "Chamarra",
            "Tennis",
            "Boxers",
            "Calzoncillos",
            "Camisa"});
            this.ComProducto.Location = new System.Drawing.Point(83, 23);
            this.ComProducto.Name = "ComProducto";
            this.ComProducto.Size = new System.Drawing.Size(121, 23);
            this.ComProducto.TabIndex = 15;
            this.ComProducto.SelectedIndexChanged += new System.EventHandler(this.ComProducto_SelectedIndexChanged);
            // 
            // IebDevolucion
            // 
            this.IebDevolucion.AutoSize = true;
            this.IebDevolucion.Location = new System.Drawing.Point(349, 376);
            this.IebDevolucion.Name = "IebDevolucion";
            this.IebDevolucion.Size = new System.Drawing.Size(12, 15);
            this.IebDevolucion.TabIndex = 13;
            this.IebDevolucion.Text = "-";
            this.IebDevolucion.Click += new System.EventHandler(this.label13_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(318, 331);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 15);
            this.label12.TabIndex = 12;
            this.label12.Text = "DEVOLUCION";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(203, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 11;
            this.label11.Text = "EFECTIVO";
            // 
            // IebPagar
            // 
            this.IebPagar.AutoSize = true;
            this.IebPagar.Location = new System.Drawing.Point(106, 376);
            this.IebPagar.Name = "IebPagar";
            this.IebPagar.Size = new System.Drawing.Size(12, 15);
            this.IebPagar.TabIndex = 10;
            this.IebPagar.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(83, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "TOTAL PAGAR";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // IebPrecio
            // 
            this.IebPrecio.AutoSize = true;
            this.IebPrecio.Location = new System.Drawing.Point(83, 108);
            this.IebPrecio.Name = "IebPrecio";
            this.IebPrecio.Size = new System.Drawing.Size(12, 15);
            this.IebPrecio.TabIndex = 8;
            this.IebPrecio.Text = "-";
            // 
            // IebNombre
            // 
            this.IebNombre.AutoSize = true;
            this.IebNombre.Location = new System.Drawing.Point(83, 78);
            this.IebNombre.Name = "IebNombre";
            this.IebNombre.Size = new System.Drawing.Size(12, 15);
            this.IebNombre.TabIndex = 7;
            this.IebNombre.Text = "-";
            // 
            // IebCodigo
            // 
            this.IebCodigo.AutoSize = true;
            this.IebCodigo.Location = new System.Drawing.Point(83, 52);
            this.IebCodigo.Name = "IebCodigo";
            this.IebCodigo.Size = new System.Drawing.Size(12, 15);
            this.IebCodigo.TabIndex = 6;
            this.IebCodigo.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "CANTIDAD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECIO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "CODIGO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTO";
            // 
            // DgbLista
            // 
            this.DgbLista.AllowUserToAddRows = false;
            this.DgbLista.AllowUserToDeleteRows = false;
            this.DgbLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgbLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgbLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.DgbLista.Location = new System.Drawing.Point(11, 167);
            this.DgbLista.Name = "DgbLista";
            this.DgbLista.ReadOnly = true;
            this.DgbLista.RowHeadersVisible = false;
            this.DgbLista.RowTemplate.Height = 25;
            this.DgbLista.Size = new System.Drawing.Size(459, 150);
            this.DgbLista.TabIndex = 0;
            this.DgbLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgbLista_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "CODIGO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "PRODUCTO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PRECIO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "CANTIDAD";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // IebVender
            // 
            this.IebVender.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.IebVender.Location = new System.Drawing.Point(160, 486);
            this.IebVender.Name = "IebVender";
            this.IebVender.Size = new System.Drawing.Size(189, 50);
            this.IebVender.TabIndex = 1;
            this.IebVender.Text = "VENDER";
            this.IebVender.UseVisualStyleBackColor = false;
            this.IebVender.Click += new System.EventHandler(this.IebVEnder_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Cuidado con el perro";
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(23, 500);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 3;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(501, 546);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.IebVender);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tienda de Ropa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgbLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox IebEfectivo;
        private TextBox IebCantidad;
        private Button ButEliminar;
        private Button ButAgregar;
        private ComboBox ComProducto;
        private Label IebDevolucion;
        private Label label12;
        private Label label11;
        private Label IebPagar;
        private Label label9;
        private Label IebPrecio;
        private Label IebNombre;
        private Label IebCodigo;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView DgbLista;
        private Button IebVender;
        private Label label14;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button BtnExit;
    }
}