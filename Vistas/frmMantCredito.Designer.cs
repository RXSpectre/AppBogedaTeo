
namespace AppBogedaTeo.Vistas
{
    partial class frmMantCredito
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
            this.panelBus = new System.Windows.Forms.Panel();
            this.btnModificarHPC = new System.Windows.Forms.Button();
            this.btnCrearHPC = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarHPC = new System.Windows.Forms.Button();
            this.txtBusNroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelCreacion = new System.Windows.Forms.Panel();
            this.btnSalirCrea = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroDocCrea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panelModificacion = new System.Windows.Forms.Panel();
            this.btnAnadirOP = new System.Windows.Forms.Button();
            this.txtRazonSocialMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.txtNroDocMod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvOrdenPedido = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.panelAdicion = new System.Windows.Forms.Panel();
            this.dtFechaLimiteAdd = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNroOPAdd = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSalirAdd = new System.Windows.Forms.Button();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panelCreacion.SuspendLayout();
            this.panelModificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).BeginInit();
            this.panelAdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBus
            // 
            this.panelBus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBus.Controls.Add(this.btnModificarHPC);
            this.panelBus.Controls.Add(this.btnCrearHPC);
            this.panelBus.Controls.Add(this.label14);
            this.panelBus.Controls.Add(this.btnBuscarHPC);
            this.panelBus.Controls.Add(this.txtBusNroDoc);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Controls.Add(this.dgvClientes);
            this.panelBus.Controls.Add(this.label8);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1094, 261);
            this.panelBus.TabIndex = 2;
            // 
            // btnModificarHPC
            // 
            this.btnModificarHPC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnModificarHPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHPC.ForeColor = System.Drawing.Color.White;
            this.btnModificarHPC.Location = new System.Drawing.Point(816, 198);
            this.btnModificarHPC.Name = "btnModificarHPC";
            this.btnModificarHPC.Size = new System.Drawing.Size(249, 34);
            this.btnModificarHPC.TabIndex = 52;
            this.btnModificarHPC.Text = "Seleccionar";
            this.btnModificarHPC.UseVisualStyleBackColor = false;
            this.btnModificarHPC.Click += new System.EventHandler(this.btnModificarHPC_Click);
            // 
            // btnCrearHPC
            // 
            this.btnCrearHPC.BackColor = System.Drawing.Color.Crimson;
            this.btnCrearHPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearHPC.ForeColor = System.Drawing.Color.White;
            this.btnCrearHPC.Location = new System.Drawing.Point(816, 153);
            this.btnCrearHPC.Name = "btnCrearHPC";
            this.btnCrearHPC.Size = new System.Drawing.Size(249, 34);
            this.btnCrearHPC.TabIndex = 51;
            this.btnCrearHPC.Text = "Creación Historial de Pagos";
            this.btnCrearHPC.UseVisualStyleBackColor = false;
            this.btnCrearHPC.Click += new System.EventHandler(this.btnCrearHPC_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(249, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Buscar Historial de Pagos";
            // 
            // btnBuscarHPC
            // 
            this.btnBuscarHPC.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarHPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHPC.ForeColor = System.Drawing.Color.White;
            this.btnBuscarHPC.Location = new System.Drawing.Point(816, 83);
            this.btnBuscarHPC.Name = "btnBuscarHPC";
            this.btnBuscarHPC.Size = new System.Drawing.Size(249, 32);
            this.btnBuscarHPC.TabIndex = 43;
            this.btnBuscarHPC.Text = "Buscar";
            this.btnBuscarHPC.UseVisualStyleBackColor = false;
            this.btnBuscarHPC.Click += new System.EventHandler(this.btnBuscarHPC_Click);
            // 
            // txtBusNroDoc
            // 
            this.txtBusNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNroDoc.Location = new System.Drawing.Point(21, 83);
            this.txtBusNroDoc.MaxLength = 8;
            this.txtBusNroDoc.Name = "txtBusNroDoc";
            this.txtBusNroDoc.Size = new System.Drawing.Size(268, 24);
            this.txtBusNroDoc.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "DNI:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(13, 153);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.Size = new System.Drawing.Size(704, 84);
            this.dgvClientes.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Historial de Pagos";
            // 
            // panelCreacion
            // 
            this.panelCreacion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelCreacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCreacion.Controls.Add(this.btnSalirCrea);
            this.panelCreacion.Controls.Add(this.btnCrear);
            this.panelCreacion.Controls.Add(this.label4);
            this.panelCreacion.Controls.Add(this.txtNroDocCrea);
            this.panelCreacion.Controls.Add(this.label5);
            this.panelCreacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCreacion.Location = new System.Drawing.Point(0, 261);
            this.panelCreacion.Name = "panelCreacion";
            this.panelCreacion.Size = new System.Drawing.Size(1094, 166);
            this.panelCreacion.TabIndex = 3;
            // 
            // btnSalirCrea
            // 
            this.btnSalirCrea.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalirCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirCrea.ForeColor = System.Drawing.Color.White;
            this.btnSalirCrea.Location = new System.Drawing.Point(816, 45);
            this.btnSalirCrea.Name = "btnSalirCrea";
            this.btnSalirCrea.Size = new System.Drawing.Size(249, 34);
            this.btnSalirCrea.TabIndex = 52;
            this.btnSalirCrea.Text = "Volver";
            this.btnSalirCrea.UseVisualStyleBackColor = false;
            this.btnSalirCrea.Click += new System.EventHandler(this.btnSalirCrea_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Crimson;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(21, 115);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(249, 34);
            this.btnCrear.TabIndex = 51;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 24);
            this.label4.TabIndex = 45;
            this.label4.Text = "Creación Historial de Pagos";
            // 
            // txtNroDocCrea
            // 
            this.txtNroDocCrea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocCrea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocCrea.Location = new System.Drawing.Point(21, 72);
            this.txtNroDocCrea.MaxLength = 11;
            this.txtNroDocCrea.Name = "txtNroDocCrea";
            this.txtNroDocCrea.Size = new System.Drawing.Size(268, 24);
            this.txtNroDocCrea.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "DNI:";
            // 
            // panelModificacion
            // 
            this.panelModificacion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelModificacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelModificacion.Controls.Add(this.btnAnadirOP);
            this.panelModificacion.Controls.Add(this.txtRazonSocialMod);
            this.panelModificacion.Controls.Add(this.label3);
            this.panelModificacion.Controls.Add(this.label6);
            this.panelModificacion.Controls.Add(this.button5);
            this.panelModificacion.Controls.Add(this.txtNroDocMod);
            this.panelModificacion.Controls.Add(this.label7);
            this.panelModificacion.Controls.Add(this.dgvOrdenPedido);
            this.panelModificacion.Controls.Add(this.label9);
            this.panelModificacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelModificacion.Location = new System.Drawing.Point(0, 427);
            this.panelModificacion.Name = "panelModificacion";
            this.panelModificacion.Size = new System.Drawing.Size(1094, 259);
            this.panelModificacion.TabIndex = 4;
            // 
            // btnAnadirOP
            // 
            this.btnAnadirOP.BackColor = System.Drawing.Color.Navy;
            this.btnAnadirOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirOP.ForeColor = System.Drawing.Color.White;
            this.btnAnadirOP.Location = new System.Drawing.Point(560, 116);
            this.btnAnadirOP.Name = "btnAnadirOP";
            this.btnAnadirOP.Size = new System.Drawing.Size(249, 34);
            this.btnAnadirOP.TabIndex = 51;
            this.btnAnadirOP.Text = "Añadir Orden de Pedido";
            this.btnAnadirOP.UseVisualStyleBackColor = false;
            this.btnAnadirOP.Click += new System.EventHandler(this.btnAnadirOP_Click);
            // 
            // txtRazonSocialMod
            // 
            this.txtRazonSocialMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocialMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialMod.Location = new System.Drawing.Point(315, 72);
            this.txtRazonSocialMod.Name = "txtRazonSocialMod";
            this.txtRazonSocialMod.ReadOnly = true;
            this.txtRazonSocialMod.Size = new System.Drawing.Size(348, 24);
            this.txtRazonSocialMod.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 47;
            this.label3.Text = "Cliente:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Detalle del Historial de Pagos";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Olive;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(816, 62);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(249, 34);
            this.button5.TabIndex = 43;
            this.button5.Text = "Volver";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txtNroDocMod
            // 
            this.txtNroDocMod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocMod.Location = new System.Drawing.Point(22, 72);
            this.txtNroDocMod.MaxLength = 11;
            this.txtNroDocMod.Name = "txtNroDocMod";
            this.txtNroDocMod.ReadOnly = true;
            this.txtNroDocMod.Size = new System.Drawing.Size(268, 24);
            this.txtNroDocMod.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 24);
            this.label7.TabIndex = 42;
            this.label7.Text = "DNI:";
            // 
            // dgvOrdenPedido
            // 
            this.dgvOrdenPedido.AllowUserToAddRows = false;
            this.dgvOrdenPedido.AllowUserToDeleteRows = false;
            this.dgvOrdenPedido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvOrdenPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOrdenPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrdenPedido.Location = new System.Drawing.Point(13, 153);
            this.dgvOrdenPedido.MultiSelect = false;
            this.dgvOrdenPedido.Name = "dgvOrdenPedido";
            this.dgvOrdenPedido.ReadOnly = true;
            this.dgvOrdenPedido.RowHeadersWidth = 51;
            this.dgvOrdenPedido.Size = new System.Drawing.Size(796, 85);
            this.dgvOrdenPedido.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(17, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Ordenes de Pedido";
            // 
            // panelAdicion
            // 
            this.panelAdicion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelAdicion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelAdicion.Controls.Add(this.dtFechaLimiteAdd);
            this.panelAdicion.Controls.Add(this.label12);
            this.panelAdicion.Controls.Add(this.txtNroOPAdd);
            this.panelAdicion.Controls.Add(this.label11);
            this.panelAdicion.Controls.Add(this.btnSalirAdd);
            this.panelAdicion.Controls.Add(this.btnAnadir);
            this.panelAdicion.Controls.Add(this.label10);
            this.panelAdicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAdicion.Location = new System.Drawing.Point(0, 686);
            this.panelAdicion.Name = "panelAdicion";
            this.panelAdicion.Size = new System.Drawing.Size(1094, 187);
            this.panelAdicion.TabIndex = 5;
            // 
            // dtFechaLimiteAdd
            // 
            this.dtFechaLimiteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaLimiteAdd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaLimiteAdd.Location = new System.Drawing.Point(305, 71);
            this.dtFechaLimiteAdd.Name = "dtFechaLimiteAdd";
            this.dtFechaLimiteAdd.Size = new System.Drawing.Size(233, 24);
            this.dtFechaLimiteAdd.TabIndex = 56;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(301, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 24);
            this.label12.TabIndex = 55;
            this.label12.Text = "Fecha Limite de Pago:";
            // 
            // txtNroOPAdd
            // 
            this.txtNroOPAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroOPAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOPAdd.Location = new System.Drawing.Point(22, 71);
            this.txtNroOPAdd.Name = "txtNroOPAdd";
            this.txtNroOPAdd.Size = new System.Drawing.Size(268, 24);
            this.txtNroOPAdd.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(18, 44);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(202, 24);
            this.label11.TabIndex = 54;
            this.label11.Text = "Nro. Orden de Pedido:";
            // 
            // btnSalirAdd
            // 
            this.btnSalirAdd.BackColor = System.Drawing.Color.DarkCyan;
            this.btnSalirAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirAdd.ForeColor = System.Drawing.Color.White;
            this.btnSalirAdd.Location = new System.Drawing.Point(816, 32);
            this.btnSalirAdd.Name = "btnSalirAdd";
            this.btnSalirAdd.Size = new System.Drawing.Size(249, 36);
            this.btnSalirAdd.TabIndex = 52;
            this.btnSalirAdd.Text = "Volver";
            this.btnSalirAdd.UseVisualStyleBackColor = false;
            this.btnSalirAdd.Click += new System.EventHandler(this.btnSalirAdd_Click);
            // 
            // btnAnadir
            // 
            this.btnAnadir.BackColor = System.Drawing.Color.Crimson;
            this.btnAnadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadir.ForeColor = System.Drawing.Color.White;
            this.btnAnadir.Location = new System.Drawing.Point(21, 115);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(249, 39);
            this.btnAnadir.TabIndex = 51;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = false;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(278, 24);
            this.label10.TabIndex = 45;
            this.label10.Text = "Adición de Orden de Pedido";
            // 
            // frmMantCredito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 885);
            this.Controls.Add(this.panelAdicion);
            this.Controls.Add(this.panelModificacion);
            this.Controls.Add(this.panelCreacion);
            this.Controls.Add(this.panelBus);
            this.Name = "frmMantCredito";
            this.Text = "Mant. Pagos Al Crédito";
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panelCreacion.ResumeLayout(false);
            this.panelCreacion.PerformLayout();
            this.panelModificacion.ResumeLayout(false);
            this.panelModificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).EndInit();
            this.panelAdicion.ResumeLayout(false);
            this.panelAdicion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Button btnCrearHPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarHPC;
        private System.Windows.Forms.TextBox txtBusNroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificarHPC;
        private System.Windows.Forms.Panel panelCreacion;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroDocCrea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalirCrea;
        private System.Windows.Forms.Panel panelModificacion;
        private System.Windows.Forms.Button btnAnadirOP;
        private System.Windows.Forms.TextBox txtRazonSocialMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtNroDocMod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvOrdenPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelAdicion;
        private System.Windows.Forms.Button btnSalirAdd;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNroOPAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtFechaLimiteAdd;
    }
}