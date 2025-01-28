namespace TPAPELERIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Agregar = new System.Windows.Forms.Button();
            this.Registrar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.TextoABuscar = new System.Windows.Forms.TextBox();
            this.dataGridInventario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // Agregar
            // 
            this.Agregar.Font = new System.Drawing.Font("Poppins Black", 14.8F, System.Drawing.FontStyle.Bold);
            this.Agregar.Location = new System.Drawing.Point(262, 87);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(404, 58);
            this.Agregar.TabIndex = 3;
            this.Agregar.Text = "Agregar Producto";
            this.Agregar.UseVisualStyleBackColor = true;
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // Registrar
            // 
            this.Registrar.Font = new System.Drawing.Font("Poppins Black", 14.8F, System.Drawing.FontStyle.Bold);
            this.Registrar.Location = new System.Drawing.Point(793, 87);
            this.Registrar.Name = "Registrar";
            this.Registrar.Size = new System.Drawing.Size(404, 58);
            this.Registrar.TabIndex = 4;
            this.Registrar.Text = "Registrar Venta";
            this.Registrar.UseVisualStyleBackColor = true;
            this.Registrar.Click += new System.EventHandler(this.Registrar_Click);
            // 
            // Buscar
            // 
            this.Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Buscar.Font = new System.Drawing.Font("Poppins Black", 14.8F, System.Drawing.FontStyle.Bold);
            this.Buscar.Image = ((System.Drawing.Image)(resources.GetObject("Buscar.Image")));
            this.Buscar.Location = new System.Drawing.Point(922, 178);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(64, 58);
            this.Buscar.TabIndex = 5;
            this.Buscar.UseVisualStyleBackColor = false;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // TextoABuscar
            // 
            this.TextoABuscar.Font = new System.Drawing.Font("Poppins Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextoABuscar.Location = new System.Drawing.Point(511, 182);
            this.TextoABuscar.Name = "TextoABuscar";
            this.TextoABuscar.Size = new System.Drawing.Size(405, 45);
            this.TextoABuscar.TabIndex = 6;
            this.TextoABuscar.TextChanged += new System.EventHandler(this.TextoABuscar_TextChanged);
            // 
            // dataGridInventario
            // 
            this.dataGridInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridInventario.Location = new System.Drawing.Point(142, 392);
            this.dataGridInventario.Name = "dataGridInventario";
            this.dataGridInventario.RowHeadersWidth = 51;
            this.dataGridInventario.RowTemplate.Height = 24;
            this.dataGridInventario.Size = new System.Drawing.Size(1142, 232);
            this.dataGridInventario.TabIndex = 7;
            this.dataGridInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridInventario_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 817);
            this.Controls.Add(this.dataGridInventario);
            this.Controls.Add(this.TextoABuscar);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Registrar);
            this.Controls.Add(this.Agregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Agregar;
        private System.Windows.Forms.Button Registrar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.TextBox TextoABuscar;
        private System.Windows.Forms.DataGridView dataGridInventario;
    }
}

