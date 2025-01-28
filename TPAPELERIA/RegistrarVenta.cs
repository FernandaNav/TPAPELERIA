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
    public partial class RegistrarVenta : Form
    {
        private Inventario inventario;
        public RegistrarVenta(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
        }

        private void RegistrarVenta_Load(object sender, EventArgs e)
        {
            cmbProductos.Items.Clear();
            var productos = inventario.ObtenerProductos();
            foreach (var producto in productos)
            {
                cmbProductos.Items.Add($"{producto.Id} - {producto.Nombre}");
            }
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                int idProducto = int.Parse(cmbProductos.SelectedItem.ToString().Split('-')[0].Trim());
                int cantidadVenta = int.Parse(txtVentaCantidad.Text);

                inventario.RegistrarVenta(idProducto, cantidadVenta);
                MessageBox.Show("Venta registrada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtVentaCantidad.Clear();

                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.ActualizarTodo();
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores si no se encuentra el producto o la cantidad es inválida
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void ActualizarComboBox()
        {
            cmbProductos.Items.Clear(); // Limpia las opciones anteriores
            foreach (var producto in inventario.ObtenerProductos())
            {
                cmbProductos.Items.Add($"{producto.Id} - {producto.Nombre}");
            }
        }
    }
}
