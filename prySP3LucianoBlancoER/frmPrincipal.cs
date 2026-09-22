using System;
using System.Windows.Forms;

namespace prySP3LucianoBlancoER
{
    public partial class frmPrincipal : Form
    {
        // 1. Estructura adecuada para contener los datos del repuesto
        public struct Repuesto
        {
            public char Marca;        // 'P', 'F' o 'R'
            public char Origen;       // 'N' o 'I'
            public int Numero;        // Número de repuesto (hasta 6 dígitos)
            public string Descripcion; // Texto de hasta 50 caracteres
            public float Precio;      // Precio del repuesto
        }

        // 2. Arreglo para 100 elementos y contador de repuestos ingresados
        Repuesto[] arregloRepuestos = new Repuesto[100];
        int cantidadRepuestos = 0;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar marcas en los ComboBox
            cmbMarca.Items.Add("P - Peugeot");
            cmbMarca.Items.Add("F - Fiat");
            cmbMarca.Items.Add("R - Renault");

            cmbFiltroMarca.Items.Add("P - Peugeot");
            cmbFiltroMarca.Items.Add("F - Fiat");
            cmbFiltroMarca.Items.Add("R - Renault");

            // Marcar por defecto Origen Nacional
            rbNacional.Checked = true;
            rbFiltroNacional.Checked = true;

            // Configurar el TextBox de resultados si se usó este control
            txtResultados.Multiline = true;
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
        }

        // =======================================================
        // BOTÓN GUARDAR (CARGA DE REPUESTOS)
        // =======================================================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que no se superen los 100 elementos
            if (cantidadRepuestos >= 100)
            {
                MessageBox.Show("No se pueden ingresar más de 100 repuestos.", "Límite Alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección de marca
            if (cmbMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una marca.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar número de repuesto (numérico de máximo 6 dígitos)
            int numRepuesto;
            if (!int.TryParse(txtNumero.Text, out numRepuesto) || txtNumero.Text.Length > 6 || numRepuesto <= 0)
            {
                MessageBox.Show("El número de repuesto debe ser un valor numérico positivo de hasta 6 dígitos.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que no existan repuestos duplicados con el mismo número
            for (int i = 0; i < cantidadRepuestos; i++)
            {
                if (arregloRepuestos[i].Numero == numRepuesto)
                {
                    MessageBox.Show("Ya existe un repuesto ingresado con el mismo número.", "Error: Registro Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validar precio
            float precioRepuesto;
            if (!float.TryParse(txtPrecio.Text, out precioRepuesto) || precioRepuesto < 0)
            {
                MessageBox.Show("Ingrese un precio válido.", "Error de Ingreso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Guardar datos en la estructura
            Repuesto nuevo = new Repuesto();
            nuevo.Marca = (cmbMarca.SelectedItem?.ToString() ?? "P")[0];
            nuevo.Origen = rbNacional.Checked ? 'N' : 'I';
            nuevo.Numero = numRepuesto;
            nuevo.Descripcion = txtDescripcion.Text.Trim();
            nuevo.Precio = precioRepuesto;

            // Cargar en el arreglo e incrementar contador
            arregloRepuestos[cantidadRepuestos] = nuevo;
            cantidadRepuestos++;

            MessageBox.Show("Repuesto cargado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar campos
            txtNumero.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            cmbMarca.SelectedIndex = -1;
            rbNacional.Checked = true;
        }

        // =======================================================
        // BOTÓN CONSULTAR (FILTRADO Y BÚSQUEDA)
        // =======================================================
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

            // Recorrer el arreglo buscando coincidencias de marca y origen
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
    }
}