
namespace AppBogedaTeo.Vistas
{
    partial class frmConsOrdenPedido
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
            this.label10 = new System.Windows.Forms.Label();
            this.dgvDetOP = new System.Windows.Forms.DataGridView();
            this.panelPie = new System.Windows.Forms.Panel();
            this.txtDetImpTotal = new System.Windows.Forms.TextBox();
            this.panelAcciones = new System.Windows.Forms.Panel();
            this.btnPreventa = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.panelCabecera = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDetEmpleaCrea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetEmpleaModi = new System.Windows.Forms.TextBox();
            this.txtDetNroOrdenPedido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDetNomCompletos = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDetEstado = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDetNroDocumento = new System.Windows.Forms.TextBox();
            this.panelBus = new System.Windows.Forms.Panel();
            this.btnSeleccion = new System.Windows.Forms.Button();
            this.dgvOrdenPedido = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.btnBuscarHPC = new System.Windows.Forms.Button();
            this.cmbEstadoOP = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroOP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBuss.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.panelCuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).BeginInit();
            this.panelPie.SuspendLayout();
            this.panelAcciones.SuspendLayout();
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
            this.panelBuss.Size = new System.Drawing.Size(1094, 1041);
            this.panelBuss.TabIndex = 3;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.panelCuerpo);
            this.panelDetalle.Controls.Add(this.panelPie);
            this.panelDetalle.Controls.Add(this.panelCabecera);
            this.panelDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetalle.Location = new System.Drawing.Point(0, 415);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1090, 622);
            this.panelDetalle.TabIndex = 69;
            this.panelDetalle.Visible = false;
            // 
            // panelCuerpo
            // 
            this.panelCuerpo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCuerpo.Controls.Add(this.btnCancelar);
            this.panelCuerpo.Controls.Add(this.label10);
            this.panelCuerpo.Controls.Add(this.dgvDetOP);
            this.panelCuerpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCuerpo.Location = new System.Drawing.Point(0, 268);
            this.panelCuerpo.Name = "panelCuerpo";
            this.panelCuerpo.Size = new System.Drawing.Size(1090, 234);
            this.panelCuerpo.TabIndex = 82;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(711, 37);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(260, 30);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(23, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "Detalle";
            // 
            // dgvDetOP
            // 
            this.dgvDetOP.AllowUserToAddRows = false;
            this.dgvDetOP.AllowUserToDeleteRows = false;
            this.dgvDetOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDetOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetOP.Location = new System.Drawing.Point(27, 73);
            this.dgvDetOP.MultiSelect = false;
            this.dgvDetOP.Name = "dgvDetOP";
            this.dgvDetOP.ReadOnly = true;
            this.dgvDetOP.RowHeadersWidth = 51;
            this.dgvDetOP.Size = new System.Drawing.Size(944, 127);
            this.dgvDetOP.TabIndex = 50;
            // 
            // panelPie
            // 
            this.panelPie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPie.Controls.Add(this.txtDetImpTotal);
            this.panelPie.Controls.Add(this.panelAcciones);
            this.panelPie.Controls.Add(this.label18);
            this.panelPie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelPie.Location = new System.Drawing.Point(0, 502);
            this.panelPie.Name = "panelPie";
            this.panelPie.Size = new System.Drawing.Size(1090, 120);
            this.panelPie.TabIndex = 81;
            // 
            // txtDetImpTotal
            // 
            this.txtDetImpTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetImpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetImpTotal.Location = new System.Drawing.Point(263, 28);
            this.txtDetImpTotal.Name = "txtDetImpTotal";
            this.txtDetImpTotal.ReadOnly = true;
            this.txtDetImpTotal.Size = new System.Drawing.Size(218, 24);
            this.txtDetImpTotal.TabIndex = 61;
            this.txtDetImpTotal.Text = "0";
            // 
            // panelAcciones
            // 
            this.panelAcciones.Controls.Add(this.btnPreventa);
            this.panelAcciones.Controls.Add(this.btnAnular);
            this.panelAcciones.Location = new System.Drawing.Point(692, 26);
            this.panelAcciones.Name = "panelAcciones";
            this.panelAcciones.Size = new System.Drawing.Size(279, 79);
            this.panelAcciones.TabIndex = 67;
            this.panelAcciones.Visible = false;
            // 
            // btnPreventa
            // 
            this.btnPreventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPreventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreventa.ForeColor = System.Drawing.Color.White;
            this.btnPreventa.Location = new System.Drawing.Point(3, 3);
            this.btnPreventa.Name = "btnPreventa";
            this.btnPreventa.Size = new System.Drawing.Size(257, 32);
            this.btnPreventa.TabIndex = 65;
            this.btnPreventa.Text = "Preventa";
            this.btnPreventa.UseVisualStyleBackColor = false;
            this.btnPreventa.Click += new System.EventHandler(this.btnPreventa_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Indigo;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Location = new System.Drawing.Point(3, 41);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(257, 32);
            this.btnAnular.TabIndex = 66;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(55, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(193, 24);
            this.label18.TabIndex = 60;
            this.label18.Text = "Importe Total a Pagar:";
            // 
            // panelCabecera
            // 
            this.panelCabecera.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCabecera.Controls.Add(this.label4);
            this.panelCabecera.Controls.Add(this.txtDetEmpleaCrea);
            this.panelCabecera.Controls.Add(this.label5);
            this.panelCabecera.Controls.Add(this.txtDetEmpleaModi);
            this.panelCabecera.Controls.Add(this.txtDetNroOrdenPedido);
            this.panelCabecera.Controls.Add(this.label19);
            this.panelCabecera.Controls.Add(this.txtDetNomCompletos);
            this.panelCabecera.Controls.Add(this.label15);
            this.panelCabecera.Controls.Add(this.label6);
            this.panelCabecera.Controls.Add(this.txtDetEstado);
            this.panelCabecera.Controls.Add(this.label7);
            this.panelCabecera.Controls.Add(this.label8);
            this.panelCabecera.Controls.Add(this.txtDetNroDocumento);
            this.panelCabecera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCabecera.Location = new System.Drawing.Point(0, 0);
            this.panelCabecera.Name = "panelCabecera";
            this.panelCabecera.Size = new System.Drawing.Size(1090, 268);
            this.panelCabecera.TabIndex = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Orden de Pedido";
            // 
            // txtDetEmpleaCrea
            // 
            this.txtDetEmpleaCrea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetEmpleaCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetEmpleaCrea.Location = new System.Drawing.Point(519, 93);
            this.txtDetEmpleaCrea.Name = "txtDetEmpleaCrea";
            this.txtDetEmpleaCrea.ReadOnly = true;
            this.txtDetEmpleaCrea.Size = new System.Drawing.Size(420, 24);
            this.txtDetEmpleaCrea.TabIndex = 79;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 24);
            this.label5.TabIndex = 64;
            this.label5.Text = "Nro. Orden de Pedido:";
            // 
            // txtDetEmpleaModi
            // 
            this.txtDetEmpleaModi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetEmpleaModi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetEmpleaModi.Location = new System.Drawing.Point(520, 147);
            this.txtDetEmpleaModi.Name = "txtDetEmpleaModi";
            this.txtDetEmpleaModi.ReadOnly = true;
            this.txtDetEmpleaModi.Size = new System.Drawing.Size(420, 24);
            this.txtDetEmpleaModi.TabIndex = 78;
            // 
            // txtDetNroOrdenPedido
            // 
            this.txtDetNroOrdenPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNroOrdenPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNroOrdenPedido.Location = new System.Drawing.Point(27, 93);
            this.txtDetNroOrdenPedido.Name = "txtDetNroOrdenPedido";
            this.txtDetNroOrdenPedido.ReadOnly = true;
            this.txtDetNroOrdenPedido.Size = new System.Drawing.Size(421, 24);
            this.txtDetNroOrdenPedido.TabIndex = 63;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(516, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(179, 24);
            this.label19.TabIndex = 77;
            this.label19.Text = "Ultima Edición Por : ";
            // 
            // txtDetNomCompletos
            // 
            this.txtDetNomCompletos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNomCompletos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNomCompletos.Location = new System.Drawing.Point(26, 201);
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
            this.label15.Location = new System.Drawing.Point(515, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 24);
            this.label15.TabIndex = 76;
            this.label15.Text = "Registrado Por : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 66;
            this.label6.Text = "Cliente:";
            // 
            // txtDetEstado
            // 
            this.txtDetEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetEstado.Location = new System.Drawing.Point(520, 201);
            this.txtDetEstado.Name = "txtDetEstado";
            this.txtDetEstado.ReadOnly = true;
            this.txtDetEstado.Size = new System.Drawing.Size(419, 24);
            this.txtDetEstado.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 68;
            this.label7.Text = "DNI:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(516, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 24);
            this.label8.TabIndex = 69;
            this.label8.Text = "Estado:";
            // 
            // txtDetNroDocumento
            // 
            this.txtDetNroDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetNroDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetNroDocumento.Location = new System.Drawing.Point(27, 147);
            this.txtDetNroDocumento.Name = "txtDetNroDocumento";
            this.txtDetNroDocumento.ReadOnly = true;
            this.txtDetNroDocumento.Size = new System.Drawing.Size(421, 24);
            this.txtDetNroDocumento.TabIndex = 67;
            // 
            // panelBus
            // 
            this.panelBus.Controls.Add(this.btnSeleccion);
            this.panelBus.Controls.Add(this.dgvOrdenPedido);
            this.panelBus.Controls.Add(this.label9);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Controls.Add(this.txtRazonSocial);
            this.panelBus.Controls.Add(this.btnBuscarHPC);
            this.panelBus.Controls.Add(this.cmbEstadoOP);
            this.panelBus.Controls.Add(this.label14);
            this.panelBus.Controls.Add(this.label3);
            this.panelBus.Controls.Add(this.txtNroOP);
            this.panelBus.Controls.Add(this.label11);
            this.panelBus.Controls.Add(this.label12);
            this.panelBus.Controls.Add(this.dtFechaFinal);
            this.panelBus.Controls.Add(this.dtFechaInicio);
            this.panelBus.Controls.Add(this.label2);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1090, 415);
            this.panelBus.TabIndex = 68;
            // 
            // btnSeleccion
            // 
            this.btnSeleccion.BackColor = System.Drawing.Color.Crimson;
            this.btnSeleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccion.ForeColor = System.Drawing.Color.White;
            this.btnSeleccion.Location = new System.Drawing.Point(640, 256);
            this.btnSeleccion.Name = "btnSeleccion";
            this.btnSeleccion.Size = new System.Drawing.Size(243, 34);
            this.btnSeleccion.TabIndex = 65;
            this.btnSeleccion.Text = "Seleccionar";
            this.btnSeleccion.UseVisualStyleBackColor = false;
            this.btnSeleccion.Click += new System.EventHandler(this.btnSeleccion_Click);
            // 
            // dgvOrdenPedido
            // 
            this.dgvOrdenPedido.AllowUserToAddRows = false;
            this.dgvOrdenPedido.AllowUserToDeleteRows = false;
            this.dgvOrdenPedido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOrdenPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenPedido.Location = new System.Drawing.Point(16, 297);
            this.dgvOrdenPedido.MultiSelect = false;
            this.dgvOrdenPedido.Name = "dgvOrdenPedido";
            this.dgvOrdenPedido.ReadOnly = true;
            this.dgvOrdenPedido.RowHeadersWidth = 51;
            this.dgvOrdenPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrdenPedido.Size = new System.Drawing.Size(867, 112);
            this.dgvOrdenPedido.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 24);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ordenes de Pedido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Cliente:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(25, 150);
            this.txtRazonSocial.MaxLength = 11;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(573, 24);
            this.txtRazonSocial.TabIndex = 41;
            // 
            // btnBuscarHPC
            // 
            this.btnBuscarHPC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarHPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHPC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHPC.Location = new System.Drawing.Point(634, 57);
            this.btnBuscarHPC.Name = "btnBuscarHPC";
            this.btnBuscarHPC.Size = new System.Drawing.Size(249, 32);
            this.btnBuscarHPC.TabIndex = 43;
            this.btnBuscarHPC.Text = "Buscar";
            this.btnBuscarHPC.UseVisualStyleBackColor = false;
            this.btnBuscarHPC.Click += new System.EventHandler(this.btnBuscarHPC_Click);
            // 
            // cmbEstadoOP
            // 
            this.cmbEstadoOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoOP.FormattingEnabled = true;
            this.cmbEstadoOP.Location = new System.Drawing.Point(358, 84);
            this.cmbEstadoOP.Name = "cmbEstadoOP";
            this.cmbEstadoOP.Size = new System.Drawing.Size(239, 21);
            this.cmbEstadoOP.TabIndex = 64;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(265, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Consultar Orden de Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(354, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 63;
            this.label3.Text = "Estado:";
            // 
            // txtNroOP
            // 
            this.txtNroOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOP.Location = new System.Drawing.Point(25, 84);
            this.txtNroOP.Name = "txtNroOP";
            this.txtNroOP.Size = new System.Drawing.Size(268, 24);
            this.txtNroOP.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 62;
            this.label11.Text = "Nro. Orden de Pedido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 57;
            this.label12.Text = "Fecha Inicio:";
            // 
            // dtFechaFinal
            // 
            this.dtFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFinal.Location = new System.Drawing.Point(358, 215);
            this.dtFechaFinal.Name = "dtFechaFinal";
            this.dtFechaFinal.Size = new System.Drawing.Size(233, 24);
            this.dtFechaFinal.TabIndex = 60;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaInicio.Location = new System.Drawing.Point(24, 215);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(233, 24);
            this.dtFechaInicio.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 59;
            this.label2.Text = "Fecha Final:";
            // 
            // frmConsOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 1041);
            this.Controls.Add(this.panelBuss);
            this.Name = "frmConsOrdenPedido";
            this.Text = "frmConsOrdenPedido";
            this.panelBuss.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelCuerpo.ResumeLayout(false);
            this.panelCuerpo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).EndInit();
            this.panelPie.ResumeLayout(false);
            this.panelPie.PerformLayout();
            this.panelAcciones.ResumeLayout(false);
            this.panelCabecera.ResumeLayout(false);
            this.panelCabecera.PerformLayout();
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBuss;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarHPC;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdenPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtFechaFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNroOP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbEstadoOP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPreventa;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Panel panelAcciones;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDetNroOrdenPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDetNomCompletos;
        private System.Windows.Forms.TextBox txtDetNroDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDetEstado;
        private System.Windows.Forms.TextBox txtDetEmpleaCrea;
        private System.Windows.Forms.TextBox txtDetEmpleaModi;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panelCabecera;
        private System.Windows.Forms.Panel panelPie;
        private System.Windows.Forms.TextBox txtDetImpTotal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panelCuerpo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvDetOP;
        private System.Windows.Forms.Button btnSeleccion;
    }
}