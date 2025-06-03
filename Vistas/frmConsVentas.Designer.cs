
namespace AppBogedaTeo
{
    partial class frmConsVentas
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
            this.panelBuss = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.panelCuerpo = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.dgvDetVentas = new System.Windows.Forms.DataGridView();
            this.panelPie = new System.Windows.Forms.Panel();
            this.txtDetMetodoPago = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDetImporte = new System.Windows.Forms.TextBox();
            this.txtDetTipoComprobante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.txtDetNroDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetFechaCreacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetFechaLimite = new System.Windows.Forms.TextBox();
            this.txtDetCodVenta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDetNomCompletos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelBus = new System.Windows.Forms.Panel();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.dgvOrdenPedido = new System.Windows.Forms.DataGridView();
            this.btnBuscarHPC = new System.Windows.Forms.Button();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.panelBuss.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetVentas)).BeginInit();
            this.panelPie.SuspendLayout();
            this.panelCabecera.SuspendLayout();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBuss
            // 
            this.panelBuss.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBuss.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBuss.Controls.Add(this.panelDetalle);
            this.panelBuss.Controls.Add(this.panelBus);
            this.panelBuss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBuss.Location = new System.Drawing.Point(0, 0);
            this.panelBuss.Name = "panelBuss";
            this.panelBuss.Size = new System.Drawing.Size(1094, 1061);
            this.panelBuss.TabIndex = 4;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.panelCuerpo);
            this.panelDetalle.Controls.Add(this.panelPie);
            this.panelDetalle.Controls.Add(this.panelCabecera);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 483);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1090, 574);
            this.panelDetalle.TabIndex = 68;
            this.panelDetalle.Visible = false;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCuerpo.Controls.Add(this.btnCancelar);
            this.panelCuerpo.Controls.Add(this.label16);
            this.panelCuerpo.Controls.Add(this.dgvDetVentas);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 238);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(1090, 190);
            this.panelCuerpo.TabIndex = 83;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(782, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 29);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(25, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 24);
            this.label16.TabIndex = 51;
            this.label16.Text = "Detalle";
            // 
            // dgvDetVentas
            // 
            this.dgvDetVentas.AllowUserToAddRows = false;
            this.dgvDetVentas.AllowUserToDeleteRows = false;
            this.dgvDetVentas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDetVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetVentas.Location = new System.Drawing.Point(29, 49);
            this.dgvDetVentas.MultiSelect = false;
            this.dgvDetVentas.Name = "dgvDetVentas";
            this.dgvDetVentas.ReadOnly = true;
            this.dgvDetVentas.RowHeadersWidth = 51;
            this.dgvDetVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetVentas.Size = new System.Drawing.Size(895, 119);
            this.dgvDetVentas.TabIndex = 50;
            // 
            // panelPie
            // 
            this.panelPie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPie.Controls.Add(this.txtDetMetodoPago);
            this.panelPie.Controls.Add(this.label17);
            this.panelPie.Controls.Add(this.txtDetImporte);
            this.panelPie.Controls.Add(this.txtDetTipoComprobante);
            this.panelPie.Controls.Add(this.label7);
            this.panelPie.Controls.Add(this.label10);
            this.panelPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPie.Location = new System.Drawing.Point(0, 428);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(1090, 146);
            this.panelPie.TabIndex = 82;
            // 
            // txtDetMetodoPago
            // 
            this.txtDetMetodoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetMetodoPago.Location = new System.Drawing.Point(261, 61);
            this.txtDetMetodoPago.Name = "txtDetMetodoPago";
            this.txtDetMetodoPago.ReadOnly = true;
            this.txtDetMetodoPago.Size = new System.Drawing.Size(268, 24);
            this.txtDetMetodoPago.TabIndex = 69;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(31, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(155, 24);
            this.label17.TabIndex = 70;
            this.label17.Text = "Método de Pago:";
            // 
            // txtDetImporte
            // 
            this.txtDetImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetImporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetImporte.Location = new System.Drawing.Point(261, 98);
            this.txtDetImporte.Name = "txtDetImporte";
            this.txtDetImporte.ReadOnly = true;
            this.txtDetImporte.Size = new System.Drawing.Size(268, 24);
            this.txtDetImporte.TabIndex = 61;
            this.txtDetImporte.Text = "0";
            // 
            // txtDetTipoComprobante
            // 
            this.txtDetTipoComprobante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetTipoComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetTipoComprobante.Location = new System.Drawing.Point(261, 19);
            this.txtDetTipoComprobante.Name = "txtDetTipoComprobante";
            this.txtDetTipoComprobante.ReadOnly = true;
            this.txtDetTipoComprobante.Size = new System.Drawing.Size(268, 24);
            this.txtDetTipoComprobante.TabIndex = 67;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "Tipo Comprobante:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(193, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Importe Total a Pagar:";
            // 
            // panelCabecera
            // 
            this.panelCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCabecera.Controls.Add(this.txtDetNroDoc);
            this.panelCabecera.Controls.Add(this.label13);
            this.panelCabecera.Controls.Add(this.label4);
            this.panelCabecera.Controls.Add(this.txtDetFechaCreacion);
            this.panelCabecera.Controls.Add(this.label5);
            this.panelCabecera.Controls.Add(this.txtDetFechaLimite);
            this.panelCabecera.Controls.Add(this.txtDetCodVenta);
            this.panelCabecera.Controls.Add(this.label19);
            this.panelCabecera.Controls.Add(this.txtDetNomCompletos);
            this.panelCabecera.Controls.Add(this.label15);
            this.panelCabecera.Controls.Add(this.label6);
            this.panelCabecera.Controls.Add(this.txtDetEstado);
            this.panelCabecera.Controls.Add(this.label8);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1090, 238);
            this.panelCabecera.TabIndex = 81;
            // 
            // txtDetNroDoc
            // 
            this.txtDetNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNroDoc.Location = new System.Drawing.Point(27, 129);
            this.txtDetNroDoc.MaxLength = 11;
            this.txtDetNroDoc.Name = "txtDetNroDoc";
            this.txtDetNroDoc.ReadOnly = true;
            this.txtDetNroDoc.Size = new System.Drawing.Size(421, 24);
            this.txtDetNroDoc.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 24);
            this.label13.TabIndex = 81;
            this.label13.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Ventas";
            // 
            // txtDetFechaCreacion
            // 
            this.txtDetFechaCreacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetFechaCreacion.Location = new System.Drawing.Point(532, 75);
            this.txtDetFechaCreacion.Name = "txtDetFechaCreacion";
            this.txtDetFechaCreacion.ReadOnly = true;
            this.txtDetFechaCreacion.Size = new System.Drawing.Size(392, 24);
            this.txtDetFechaCreacion.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Código Venta:";
            // 
            // txtDetFechaLimite
            // 
            this.txtDetFechaLimite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetFechaLimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetFechaLimite.Location = new System.Drawing.Point(530, 129);
            this.txtDetFechaLimite.Name = "txtDetFechaLimite";
            this.txtDetFechaLimite.ReadOnly = true;
            this.txtDetFechaLimite.Size = new System.Drawing.Size(392, 24);
            this.txtDetFechaLimite.TabIndex = 78;
            // 
            // txtDetCodVenta
            // 
            this.txtDetCodVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetCodVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetCodVenta.Location = new System.Drawing.Point(30, 75);
            this.txtDetCodVenta.Name = "txtDetCodVenta";
            this.txtDetCodVenta.ReadOnly = true;
            this.txtDetCodVenta.Size = new System.Drawing.Size(421, 24);
            this.txtDetCodVenta.TabIndex = 63;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(528, 102);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(209, 24);
            this.label19.TabIndex = 77;
            this.label19.Text = "Fecha Limite de Pago : ";
            // 
            // txtDetNomCompletos
            // 
            this.txtDetNomCompletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNomCompletos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNomCompletos.Location = new System.Drawing.Point(29, 183);
            this.txtDetNomCompletos.MaxLength = 11;
            this.txtDetNomCompletos.Name = "txtDetNomCompletos";
            this.txtDetNomCompletos.ReadOnly = true;
            this.txtDetNomCompletos.Size = new System.Drawing.Size(421, 24);
            this.txtDetNomCompletos.TabIndex = 65;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(528, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 24);
            this.label15.TabIndex = 76;
            this.label15.Text = "Fecha Creación : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cliente:";
            // 
            // txtDetEstado
            // 
            this.txtDetEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetEstado.Location = new System.Drawing.Point(532, 183);
            this.txtDetEstado.Name = "txtDetEstado";
            this.txtDetEstado.ReadOnly = true;
            this.txtDetEstado.Size = new System.Drawing.Size(392, 24);
            this.txtDetEstado.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(528, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "Estado:";
            // 
            // panelBus
            // 
            this.panelBus.Controls.Add(this.btnSeleccion);
            this.panelBus.Controls.Add(this.dgvOrdenPedido);
            this.panelBus.Controls.Add(this.btnBuscarHPC);
            this.panelBus.Controls.Add(this.cmbMetodoPago);
            this.panelBus.Controls.Add(this.label9);
            this.panelBus.Controls.Add(this.label3);
            this.panelBus.Controls.Add(this.label14);
            this.panelBus.Controls.Add(this.txtRazonSocial);
            this.panelBus.Controls.Add(this.label12);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Controls.Add(this.dtFechaInicio);
            this.panelBus.Controls.Add(this.txtNroDoc);
            this.panelBus.Controls.Add(this.label2);
            this.panelBus.Controls.Add(this.label11);
            this.panelBus.Controls.Add(this.dtFechaFinal);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1090, 483);
            this.panelBus.TabIndex = 67;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.Crimson;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.ForeColor = System.Drawing.Color.White;
            this.btnSeleccion.Location = new System.Drawing.Point(891, 282);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(175, 34);
            this.btnSeleccion.TabIndex = 67;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // dgvOrdenPedido
            // 
            this.dgvOrdenPedido.AllowUserToAddRows = false;
            this.dgvOrdenPedido.AllowUserToDeleteRows = false;
            this.dgvOrdenPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOrdenPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenPedido.Location = new System.Drawing.Point(25, 320);
            this.dgvOrdenPedido.MultiSelect = false;
            this.dgvOrdenPedido.Name = "dgvOrdenPedido";
            this.dgvOrdenPedido.ReadOnly = true;
            this.dgvOrdenPedido.RowHeadersWidth = 51;
            this.dgvOrdenPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenPedido.Size = new System.Drawing.Size(1041, 95);
            this.dgvOrdenPedido.TabIndex = 54;
         
            // 
            // btnBuscarHPC
            // 
            this.btnBuscarHPC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarHPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHPC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHPC.Location = new System.Drawing.Point(891, 96);
            this.btnBuscarHPC.Name = "btnBuscarHPC";
            this.btnBuscarHPC.Size = new System.Drawing.Size(175, 32);
            this.btnBuscarHPC.TabIndex = 43;
            this.btnBuscarHPC.Text = "Buscar";
            this.btnBuscarHPC.UseVisualStyleBackColor = false;
            this.btnBuscarHPC.Click += new System.EventHandler(this.btnBuscarHPC_Click);
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(236, 247);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(268, 26);
            this.cmbMetodoPago.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(25, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ventas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 24);
            this.label3.TabIndex = 65;
            this.label3.Text = "Método de Pago:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(168, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Consultar Ventas";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(237, 150);
            this.txtRazonSocial.MaxLength = 200;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(602, 24);
            this.txtRazonSocial.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 198);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Fecha Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 64;
            this.label1.Text = "Cliente:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(236, 197);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(233, 24);
            this.dtFechaInicio.TabIndex = 58;
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDoc.Location = new System.Drawing.Point(237, 96);
            this.txtNroDoc.MaxLength = 8;
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(268, 24);
            this.txtNroDoc.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(475, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha Final:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(25, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "DNI:";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(606, 198);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(233, 24);
            this.dtFechaFinal.TabIndex = 60;
            // 
            // frmConsVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 1061);
            this.Controls.Add(this.panelBuss);
            this.Name = "frmConsVentas";
            this.Text = "frmConsVentas";
            this.panelBuss.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelCuerpo.ResumeLayout(false);
            this.panelCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetVentas)).EndInit();
            this.panelPie.ResumeLayout(false);
            this.panelPie.PerformLayout();
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuss;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvOrdenPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarHPC;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Button btnSeleccion;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetFechaCreacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetFechaLimite;
        private System.Windows.Forms.TextBox txtDetCodVenta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDetNomCompletos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetTipoComprobante;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.TextBox txtDetImporte;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDetNroDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panelCuerpo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dgvDetVentas;
        private System.Windows.Forms.TextBox txtDetMetodoPago;
        private System.Windows.Forms.Label label17;
    }
}