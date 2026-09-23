namespace prySP3LucianoBlancoER
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            cmbMarca = new ComboBox();
            rbNacional = new RadioButton();
            rbImportado = new RadioButton();
            lblMarca = new Label();
            lblOrigen = new Label();
            txtNumero = new TextBox();
            lbl = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            btnGuardar = new Button();
            gbconsulta = new GroupBox();
            txtResultados = new TextBox();
            btnConsultar = new Button();
            lblResultados = new Label();
            cmbFiltroMarca = new ComboBox();
            lblFiltroOrigen = new Label();
            lblFiltroMarca = new Label();
            rbFiltroImportado = new RadioButton();
            rbFiltroNacional = new RadioButton();
            gbCarga = new GroupBox();
            gbconsulta.SuspendLayout();
            gbCarga.SuspendLayout();
            SuspendLayout();
            // 
            // cmbMarca
            // 
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat", "(R) Renault" });
            cmbMarca.Location = new Point(6, 34);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(121, 23);
            cmbMarca.TabIndex = 0;
            // 
            // rbNacional
            // 
            rbNacional.AutoSize = true;
            rbNacional.Location = new Point(159, 37);
            rbNacional.Name = "rbNacional";
            rbNacional.Size = new Size(92, 19);
            rbNacional.TabIndex = 1;
            rbNacional.TabStop = true;
            rbNacional.Text = "(N) Nacional";
            rbNacional.UseVisualStyleBackColor = true;
            // 
            // rbImportado
            // 
            rbImportado.AutoSize = true;
            rbImportado.Location = new Point(159, 67);
            rbImportado.Name = "rbImportado";
            rbImportado.Size = new Size(95, 19);
            rbImportado.TabIndex = 2;
            rbImportado.TabStop = true;
            rbImportado.Text = "(I) Importado";
            rbImportado.UseVisualStyleBackColor = true;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(6, 16);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(40, 15);
            lblMarca.TabIndex = 3;
            lblMarca.Text = "Marca";
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(159, 19);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(43, 15);
            lblOrigen.TabIndex = 4;
            lblOrigen.Text = "Origen";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(9, 127);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(63, 23);
            txtNumero.TabIndex = 5;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(6, 102);
            lbl.Name = "lbl";
            lbl.Size = new Size(116, 15);
            lbl.TabIndex = 6;
            lbl.Text = "Numero de repuesto";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(140, 102);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 7;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(261, 102);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(140, 127);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 9;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(261, 127);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(82, 23);
            txtPrecio.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(292, 164);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(91, 30);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // gbconsulta
            // 
            gbconsulta.Controls.Add(txtResultados);
            gbconsulta.Controls.Add(btnConsultar);
            gbconsulta.Controls.Add(lblResultados);
            gbconsulta.Controls.Add(cmbFiltroMarca);
            gbconsulta.Controls.Add(lblFiltroOrigen);
            gbconsulta.Controls.Add(lblFiltroMarca);
            gbconsulta.Controls.Add(rbFiltroImportado);
            gbconsulta.Controls.Add(rbFiltroNacional);
            gbconsulta.Location = new Point(12, 213);
            gbconsulta.Name = "gbconsulta";
            gbconsulta.Size = new Size(419, 206);
            gbconsulta.TabIndex = 12;
            gbconsulta.TabStop = false;
            gbconsulta.Text = "Consulta";
            // 
            // txtResultados
            // 
            txtResultados.Location = new Point(9, 137);
            txtResultados.Multiline = true;
            txtResultados.Name = "txtResultados";
            txtResultados.ReadOnly = true;
            txtResultados.ScrollBars = ScrollBars.Vertical;
            txtResultados.Size = new Size(375, 61);
            txtResultados.TabIndex = 19;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(278, 101);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(105, 30);
            btnConsultar.TabIndex = 18;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // lblResultados
            // 
            lblResultados.AutoSize = true;
            lblResultados.Location = new Point(9, 116);
            lblResultados.Name = "lblResultados";
            lblResultados.Size = new Size(64, 15);
            lblResultados.TabIndex = 14;
            lblResultados.Text = "Resultados";
            // 
            // cmbFiltroMarca
            // 
            cmbFiltroMarca.FormattingEnabled = true;
            cmbFiltroMarca.Items.AddRange(new object[] { "(P) Peugeot", "(F) Fiat ", "(R) Renault." });
            cmbFiltroMarca.Location = new Point(6, 37);
            cmbFiltroMarca.Name = "cmbFiltroMarca";
            cmbFiltroMarca.Size = new Size(93, 23);
            cmbFiltroMarca.TabIndex = 13;
            // 
            // lblFiltroOrigen
            // 
            lblFiltroOrigen.AutoSize = true;
            lblFiltroOrigen.Location = new Point(130, 19);
            lblFiltroOrigen.Name = "lblFiltroOrigen";
            lblFiltroOrigen.Size = new Size(43, 15);
            lblFiltroOrigen.TabIndex = 17;
            lblFiltroOrigen.Text = "Origen";
            // 
            // lblFiltroMarca
            // 
            lblFiltroMarca.AutoSize = true;
            lblFiltroMarca.Location = new Point(8, 19);
            lblFiltroMarca.Name = "lblFiltroMarca";
            lblFiltroMarca.Size = new Size(40, 15);
            lblFiltroMarca.TabIndex = 16;
            lblFiltroMarca.Text = "Marca";
            // 
            // rbFiltroImportado
            // 
            rbFiltroImportado.AutoSize = true;
            rbFiltroImportado.Location = new Point(124, 69);
            rbFiltroImportado.Name = "rbFiltroImportado";
            rbFiltroImportado.Size = new Size(95, 19);
            rbFiltroImportado.TabIndex = 15;
            rbFiltroImportado.TabStop = true;
            rbFiltroImportado.Text = "Importado (I)";
            rbFiltroImportado.UseVisualStyleBackColor = true;
            // 
            // rbFiltroNacional
            // 
            rbFiltroNacional.AutoSize = true;
            rbFiltroNacional.Location = new Point(124, 44);
            rbFiltroNacional.Name = "rbFiltroNacional";
            rbFiltroNacional.Size = new Size(92, 19);
            rbFiltroNacional.TabIndex = 14;
            rbFiltroNacional.TabStop = true;
            rbFiltroNacional.Text = "Nacional (N)";
            rbFiltroNacional.UseVisualStyleBackColor = true;
            // 
            // gbCarga
            // 
            gbCarga.Controls.Add(lbl);
            gbCarga.Controls.Add(cmbMarca);
            gbCarga.Controls.Add(lblMarca);
            gbCarga.Controls.Add(lblPrecio);
            gbCarga.Controls.Add(btnGuardar);
            gbCarga.Controls.Add(txtPrecio);
            gbCarga.Controls.Add(rbImportado);
            gbCarga.Controls.Add(lblDescripcion);
            gbCarga.Controls.Add(rbNacional);
            gbCarga.Controls.Add(txtDescripcion);
            gbCarga.Controls.Add(lblOrigen);
            gbCarga.Controls.Add(txtNumero);
            gbCarga.Location = new Point(12, 7);
            gbCarga.Name = "gbCarga";
            gbCarga.Size = new Size(419, 200);
            gbCarga.TabIndex = 15;
            gbCarga.TabStop = false;
            gbCarga.Text = "Carga";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 447);
            Controls.Add(gbCarga);
            Controls.Add(gbconsulta);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repuestos";
            gbconsulta.ResumeLayout(false);
            gbconsulta.PerformLayout();
            gbCarga.ResumeLayout(false);
            gbCarga.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbMarca;
        private RadioButton rbNacional;
        private RadioButton rbImportado;
        private Label lblMarca;
        private Label lblOrigen;
        private TextBox txtNumero;
        private Label lbl;
        private Label lblDescripcion;
        private Label lblPrecio;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
        private Button btnGuardar;
        private GroupBox gbconsulta;
        private ComboBox cmbFiltroMarca;
        private RadioButton rbFiltroImportado;
        private RadioButton rbFiltroNacional;
        private Label lblFiltroMarca;
        private Label lblFiltroOrigen;
        private Button btnConsultar;
        private Label lblResultados;
        private GroupBox gbCarga;
        private TextBox txtResultados;
    }
}