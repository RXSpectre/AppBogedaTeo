
namespace AppBogedaTeo.Vistas
{
    partial class frmGenOrdenPedido
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSeleccProducto = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBusDescProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSeleccCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtBusNroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDet = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarOrdenPedido = new System.Windows.Forms.Button();
            this.txtImpTotalOP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnRetirarProducto = new System.Windows.Forms.Button();
            this.dgvDetOP = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroDocOP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazonSocialOP = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panelDet.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 817);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 393);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(580, 424);
            this.panel3.TabIndex = 43;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSeleccProducto);
            this.panel7.Controls.Add(this.txtCantidad);
            this.panel7.Controls.Add(this.label13);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 353);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(576, 67);
            this.panel7.TabIndex = 49;
            // 
            // btnSeleccProducto
            // 
            this.btnSeleccProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSeleccProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccProducto.ForeColor = System.Drawing.Color.White;
            this.btnSeleccProducto.Location = new System.Drawing.Point(371, 17);
            this.btnSeleccProducto.Name = "btnSeleccProducto";
            this.btnSeleccProducto.Size = new System.Drawing.Size(174, 34);
            this.btnSeleccProducto.TabIndex = 45;
            this.btnSeleccProducto.Text = "Agregar a la Orden";
            this.btnSeleccProducto.UseVisualStyleBackColor = false;
            this.btnSeleccProducto.Click += new System.EventHandler(this.btnSeleccProducto_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(109, 23);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 24);
            this.txtCantidad.TabIndex = 47;
            this.txtCantidad.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(14, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 24);
            this.label13.TabIndex = 46;
            this.label13.Text = "Cantidad:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Controls.Add(this.txtBusDescProducto);
            this.panel6.Controls.Add(this.btnBuscarProducto);
            this.panel6.Controls.Add(this.dgvProducto);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(576, 420);
            this.panel6.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 39;
            this.label3.Text = "Buscar Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Descripcion:";
            // 
            // txtBusDescProducto
            // 
            this.txtBusDescProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusDescProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusDescProducto.Location = new System.Drawing.Point(18, 75);
            this.txtBusDescProducto.Name = "txtBusDescProducto";
            this.txtBusDescProducto.Size = new System.Drawing.Size(279, 24);
            this.txtBusDescProducto.TabIndex = 41;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProducto.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProducto.Location = new System.Drawing.Point(398, 70);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(147, 32);
            this.btnBuscarProducto.TabIndex = 44;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.AllowUserToDeleteRows = false;
            this.dgvProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(18, 108);
            this.dgvProducto.MultiSelect = false;
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(527, 239);
            this.dgvProducto.TabIndex = 40;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnSeleccCliente);
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Controls.Add(this.txtBusNroDoc);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvClientes);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 393);
            this.panel2.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(14, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(253, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Generar Orden de Pedido";
            // 
            // btnSeleccCliente
            // 
            this.btnSeleccCliente.BackColor = System.Drawing.Color.Indigo;
            this.btnSeleccCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccCliente.ForeColor = System.Drawing.Color.White;
            this.btnSeleccCliente.Location = new System.Drawing.Point(436, 99);
            this.btnSeleccCliente.Name = "btnSeleccCliente";
            this.btnSeleccCliente.Size = new System.Drawing.Size(123, 32);
            this.btnSeleccCliente.TabIndex = 44;
            this.btnSeleccCliente.Text = "Seleccionar";
            this.btnSeleccCliente.UseVisualStyleBackColor = false;
            this.btnSeleccCliente.Click += new System.EventHandler(this.btnSeleccCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Location = new System.Drawing.Point(307, 99);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(123, 32);
            this.btnBuscarCliente.TabIndex = 43;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtBusNroDoc
            // 
            this.txtBusNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNroDoc.Location = new System.Drawing.Point(12, 107);
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
            this.label1.Location = new System.Drawing.Point(10, 80);
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
            this.dgvClientes.Location = new System.Drawing.Point(13, 140);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(546, 224);
            this.dgvClientes.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Buscar Cliente";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.panelDet);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(580, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(601, 817);
            this.panel4.TabIndex = 1;
            // 
            // panelDet
            // 
            this.panelDet.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelDet.Controls.Add(this.panel5);
            this.panelDet.Controls.Add(this.btnRetirarProducto);
            this.panelDet.Controls.Add(this.dgvDetOP);
            this.panelDet.Controls.Add(this.label9);
            this.panelDet.Controls.Add(this.label4);
            this.panelDet.Controls.Add(this.label5);
            this.panelDet.Controls.Add(this.txtNroDocOP);
            this.panelDet.Controls.Add(this.label6);
            this.panelDet.Controls.Add(this.txtRazonSocialOP);
            this.panelDet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDet.Location = new System.Drawing.Point(0, 0);
            this.panelDet.Name = "panelDet";
            this.panelDet.Size = new System.Drawing.Size(597, 813);
            this.panelDet.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnCancelar);
            this.panel5.Controls.Add(this.btnGenerarOrdenPedido);
            this.panel5.Controls.Add(this.txtImpTotalOP);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 661);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(597, 152);
            this.panel5.TabIndex = 58;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(450, 97);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 35);
            this.btnCancelar.TabIndex = 59;
            this.btnCancelar.Text = "Limpiar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarOrdenPedido
            // 
            this.btnGenerarOrdenPedido.BackColor = System.Drawing.Color.Crimson;
            this.btnGenerarOrdenPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrdenPedido.ForeColor = System.Drawing.Color.White;
            this.btnGenerarOrdenPedido.Location = new System.Drawing.Point(321, 98);
            this.btnGenerarOrdenPedido.Name = "btnGenerarOrdenPedido";
            this.btnGenerarOrdenPedido.Size = new System.Drawing.Size(123, 32);
            this.btnGenerarOrdenPedido.TabIndex = 50;
            this.btnGenerarOrdenPedido.Text = "Generar";
            this.btnGenerarOrdenPedido.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenPedido.Click += new System.EventHandler(this.btnGenerarOrdenPedido_Click);
            // 
            // txtImpTotalOP
            // 
            this.txtImpTotalOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpTotalOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpTotalOP.Location = new System.Drawing.Point(413, 19);
            this.txtImpTotalOP.Name = "txtImpTotalOP";
            this.txtImpTotalOP.ReadOnly = true;
            this.txtImpTotalOP.Size = new System.Drawing.Size(160, 24);
            this.txtImpTotalOP.TabIndex = 57;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(262, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "Importe Total:";
            // 
            // btnRetirarProducto
            // 
            this.btnRetirarProducto.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnRetirarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirarProducto.ForeColor = System.Drawing.Color.White;
            this.btnRetirarProducto.Location = new System.Drawing.Point(413, 228);
            this.btnRetirarProducto.Name = "btnRetirarProducto";
            this.btnRetirarProducto.Size = new System.Drawing.Size(162, 34);
            this.btnRetirarProducto.TabIndex = 46;
            this.btnRetirarProducto.Text = "Retirar Producto";
            this.btnRetirarProducto.UseVisualStyleBackColor = false;
            this.btnRetirarProducto.Click += new System.EventHandler(this.btnRetirarProducto_Click);
            // 
            // dgvDetOP
            // 
            this.dgvDetOP.AllowUserToAddRows = false;
            this.dgvDetOP.AllowUserToDeleteRows = false;
            this.dgvDetOP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvDetOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetOP.Location = new System.Drawing.Point(31, 268);
            this.dgvDetOP.MultiSelect = false;
            this.dgvDetOP.Name = "dgvDetOP";
            this.dgvDetOP.ReadOnly = true;
            this.dgvDetOP.RowHeadersWidth = 51;
            this.dgvDetOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetOP.Size = new System.Drawing.Size(542, 344);
            this.dgvDetOP.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(27, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(27, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Orden Pedido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(29, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "DNI:";
            // 
            // txtNroDocOP
            // 
            this.txtNroDocOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocOP.Location = new System.Drawing.Point(243, 104);
            this.txtNroDocOP.Name = "txtNroDocOP";
            this.txtNroDocOP.ReadOnly = true;
            this.txtNroDocOP.Size = new System.Drawing.Size(332, 24);
            this.txtNroDocOP.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(29, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cliente:";
            // 
            // txtRazonSocialOP
            // 
            this.txtRazonSocialOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocialOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialOP.Location = new System.Drawing.Point(243, 146);
            this.txtRazonSocialOP.Name = "txtRazonSocialOP";
            this.txtRazonSocialOP.ReadOnly = true;
            this.txtRazonSocialOP.Size = new System.Drawing.Size(332, 24);
            this.txtRazonSocialOP.TabIndex = 46;
            // 
            // frmGenOrdenPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 817);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmGenOrdenPedido";
            this.Text = "frmGenOrdenPedido";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panelDet.ResumeLayout(false);
            this.panelDet.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBusNroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtBusDescProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Button btnSeleccProducto;
        private System.Windows.Forms.Button btnSeleccCliente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRazonSocialOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroDocOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvDetOP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRetirarProducto;
        private System.Windows.Forms.Button btnGenerarOrdenPedido;
        private System.Windows.Forms.TextBox txtImpTotalOP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panelDet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCancelar;
    }
}