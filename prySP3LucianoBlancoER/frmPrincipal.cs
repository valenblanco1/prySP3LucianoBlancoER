using System;
using System.Windows.Forms;

namespace prySP3LucianoBlancoER
{
    public partial class frmPrincipal : Form
    {

        public struct Repuesto
        {
            public char Marca;
            public char Origen;
            public int Numero;
            public string Descripcion;
            public float Precio;
        }


        Repuesto[] arregloRepuestos = new Repuesto[100];
        int cantidadRepuestos = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

            cmbMarca.Items.Add("P - Peugeot");
            cmbMarca.Items.Add("F - Fiat");
            cmbMarca.Items.Add("R - Renault");

            cmbFiltroMarca.Items.Add("P - Peugeot");
            cmbFiltroMarca.Items.Add("F - Fiat");
            cmbFiltroMarca.Items.Add("R - Renault");


            rbNacional.Checked = true;
            rbFiltroNacional.Checked = true;


            txtResultados.Multiline = true;
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (cantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden ingresar más de 100 repuestos.", "Límite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (cmbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int numRepuesto;
            if (!int.TryParse(txtNumero.Text, out numRepuesto) || txtNumero.Text.Length > 6 || numRepuesto <= 0)
            {
                MessageBox.Show("El número de repuesto debe ser un valor numérico positivo de hasta 6 dígitos.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (arregloRepuestos[i].Numero == numRepuesto)
                {
                    MessageBox.Show("Ya existe un repuesto ingresado con el mismo número.", "Error: Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            float precioRepuesto;
            if (!float.TryParse(txtPrecio.Text, out precioRepuesto) || precioRepuesto < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            Repuesto nuevo = new Repuesto();
            nuevo.Marca = (cmbMarca.SelectedItem?.ToString() ?? "P")[0];
            nuevo.Origen = rbNacional.Checked ? 'N' : 'I';
            nuevo.Numero = numRepuesto;
            nuevo.Descripcion = txtDescripcion.Text.Trim();
            nuevo.Precio = precioRepuesto;


            arregloRepuestos[cantidadRepuestos] = nuevo;
            cantidadRepuestos++;

            MessageBox.Show("Repuesto cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbMarca.SelectedIndex = -1;
            rbNacional.Checked = true;
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            txtResultados.Clear();

            if (cmbFiltroMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione una marca para realizar la consulta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            char marcaBuscada = (cmbFiltroMarca.SelectedItem?.ToString() ?? "P")[0];
            char origenBuscado = rbFiltroNacional.Checked ? 'N' : 'I';

            bool encontrado = false;


            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (arregloRepuestos[i].Marca == marcaBuscada && arregloRepuestos[i].Origen == origenBuscado)
                {
                    string linea = $"N°: {arregloRepuestos[i].Numero} | Desc: {arregloRepuestos[i].Descripcion} | Precio: ${arregloRepuestos[i].Precio:F2}\r\n";
                    txtResultados.AppendText(linea);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                txtResultados.Text = "No se encontraron repuestos cargados que coincidan con la marca y origen seleccionados.";
            }
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultados_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbCarga_Enter(object sender, EventArgs e)
        {

        }
    }
}