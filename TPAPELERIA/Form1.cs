using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPAPELERIA
{
    public partial class Form1 : Form
    {
        private Inventario inventario;
        public Form1()
        {
            InitializeComponent();
            inventario = new Inventario();
            dataGridInventario.DataSource = null;
            dataGridInventario.DataSource = inventario.ObtenerProductos();
        }
        private void InicializarDataGridView()
        {
            dataGridInventario.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(8, 77, 73);
            dataGridInventario.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridInventario.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 10, FontStyle.Bold);
            dataGridInventario.DefaultCellStyle.SelectionBackColor = Color.FromArgb(32, 178, 170);
            dataGridInventario.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridInventario.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGridInventario.EnableHeadersVisualStyles = false;
            dataGridInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridInventario.ReadOnly = true; 
            dataGridInventario.AllowUserToAddRows = false; 
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(inventario);
            agregar.Show();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            RegistrarVenta registrarVenta = new RegistrarVenta(inventario);
            registrarVenta.Show();
        }

        private void TextoABuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string texto = TextoABuscar.Text.ToLower();
            var productosFiltrados = inventario.ObtenerProductos()
                .Where(p => p.Nombre.ToLower().Contains(texto) || p.Id.ToString().Contains(texto))
                .ToList();

            dataGridInventario.Rows.Clear();
            foreach (var producto in productosFiltrados)
            {
                dataGridInventario.Rows.Add(producto.Id, producto.Nombre, producto.Cantidad, producto.Precio);
            }
        }

        private void dataGridInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void ActualizarTodo()
        {
            ActualizarDataGridView(); // Refresca el DataGridView

            // Verifica si el formulario RegistrarVenta está abierto
            if (Application.OpenForms["RegistrarVenta"] is RegistrarVenta registrarVenta)
            {
                registrarVenta.ActualizarComboBox();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarDataGridView();
        }
        private void ActualizarDataGridView()
        {
            dataGridInventario.DataSource = null; 
            dataGridInventario.DataSource = inventario.ObtenerProductos(); 
        }
    }
}
