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
    public partial class Agregar : Form
    {
        private Inventario inventario;

        public Agregar(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = Nombre.Text;
                int cantidad = int.Parse(Cantidad.Text);
                decimal precio = decimal.Parse(Precio.Text);
                DateTime fechaVencimiento = FechaVencimiento.Value;

                inventario.AgregarProducto(nombre, cantidad, precio, fechaVencimiento);
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpia los campos del formulario
                Nombre.Clear();
                Cantidad.Clear();
                Precio.Clear();
                Nombre.Focus();

                // Actualiza el DataGridView y combo box en el formulario principal
                if (Application.OpenForms["Form1"] is Form1 form1)
                {
                    form1.ActualizarTodo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}