
namespace AppBogedaTeo.Vistas
{
    partial class frmRegisVenta
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
            this.btnGenerarOrdenPedido = new System.Windows.Forms.Button();
            this.txtBusNroOP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBuscarOP = new System.Windows.Forms.Button();
            this.txtBusNroDoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOrdenPedido = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelDetOP = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNroOrdPOP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroDocOP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazonSocialOP = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImpTotalOP = new System.Windows.Forms.TextBox();
            this.dgvDetOP = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbMetodoPago = new System.Windows.Forms.ComboBox();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).BeginInit();
            this.panelDetOP.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBus
            // 
            this.panelBus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBus.Controls.Add(this.btnGenerarOrdenPedido);
            this.panelBus.Controls.Add(this.txtBusNroOP);
            this.panelBus.Controls.Add(this.label2);
            this.panelBus.Controls.Add(this.label14);
            this.panelBus.Controls.Add(this.btnBuscarOP);
            this.panelBus.Controls.Add(this.txtBusNroDoc);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Controls.Add(this.dgvOrdenPedido);
            this.panelBus.Controls.Add(this.label8);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1094, 285);
            this.panelBus.TabIndex = 1;
            // 
            // btnGenerarOrdenPedido
            // 
            this.btnGenerarOrdenPedido.BackColor = System.Drawing.Color.Crimson;
            this.btnGenerarOrdenPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarOrdenPedido.ForeColor = System.Drawing.Color.White;
            this.btnGenerarOrdenPedido.Location = new System.Drawing.Point(643, 127);
            this.btnGenerarOrdenPedido.Name = "btnGenerarOrdenPedido";
            this.btnGenerarOrdenPedido.Size = new System.Drawing.Size(142, 34);
            this.btnGenerarOrdenPedido.TabIndex = 51;
            this.btnGenerarOrdenPedido.Text = "Seleccionar";
            this.btnGenerarOrdenPedido.UseVisualStyleBackColor = false;
            this.btnGenerarOrdenPedido.Click += new System.EventHandler(this.btnGenerarOrdenPedido_Click);
            // 
            // txtBusNroOP
            // 
            this.txtBusNroOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusNroOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNroOP.Location = new System.Drawing.Point(13, 83);
            this.txtBusNroOP.Name = "txtBusNroOP";
            this.txtBusNroOP.Size = new System.Drawing.Size(268, 24);
            this.txtBusNroOP.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nro. Orden de Pedido:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(263, 24);
            this.label14.TabIndex = 45;
            this.label14.Text = "Buscar Ordenes de Pedido";
            // 
            // btnBuscarOP
            // 
            this.btnBuscarOP.BackColor = System.Drawing.Color.ForestGreen;
            this.btnBuscarOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarOP.ForeColor = System.Drawing.Color.White;
            this.btnBuscarOP.Location = new System.Drawing.Point(643, 37);
            this.btnBuscarOP.Name = "btnBuscarOP";
            this.btnBuscarOP.Size = new System.Drawing.Size(142, 32);
            this.btnBuscarOP.TabIndex = 43;
            this.btnBuscarOP.Text = "Buscar";
            this.btnBuscarOP.UseVisualStyleBackColor = false;
            this.btnBuscarOP.Click += new System.EventHandler(this.btnBuscarOP_Click);
            // 
            // txtBusNroDoc
            // 
            this.txtBusNroDoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusNroDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusNroDoc.Location = new System.Drawing.Point(301, 83);
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
            this.label1.Location = new System.Drawing.Point(298, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "DNI:";
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
            this.dgvOrdenPedido.Location = new System.Drawing.Point(13, 167);
            this.dgvOrdenPedido.MultiSelect = false;
            this.dgvOrdenPedido.Name = "dgvOrdenPedido";
            this.dgvOrdenPedido.ReadOnly = true;
            this.dgvOrdenPedido.RowHeadersWidth = 51;
            this.dgvOrdenPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvOrdenPedido.Size = new System.Drawing.Size(772, 97);
            this.dgvOrdenPedido.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(17, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 24);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ordenes de Pedido";
            // 
            // panelDetOP
            // 
            this.panelDetOP.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelDetOP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDetOP.Controls.Add(this.panel3);
            this.panelDetOP.Controls.Add(this.panel1);
            this.panelDetOP.Controls.Add(this.panel5);
            this.panelDetOP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDetOP.Location = new System.Drawing.Point(0, 285);
            this.panelDetOP.Name = "panelDetOP";
            this.panelDetOP.Size = new System.Drawing.Size(1094, 653);
            this.panelDetOP.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbMetodoPago);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnConfirmar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1090, 188);
            this.panel3.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(433, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "Anular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(254, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(360, 24);
            this.textBox1.TabIndex = 58;
            this.textBox1.Text = "Boleta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 24);
            this.label3.TabIndex = 52;
            this.label3.Text = "Tipo de Comprobante:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.Crimson;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Location = new System.Drawing.Point(304, 146);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(123, 32);
            this.btnConfirmar.TabIndex = 50;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.MediumBlue;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(562, 146);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 32);
            this.btnCancelar.TabIndex = 51;
            this.btnCancelar.Text = "Volver";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtNroOrdPOP);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNroDocOP);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtRazonSocialOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 198);
            this.panel1.TabIndex = 59;
            // 
            // txtNroOrdPOP
            // 
            this.txtNroOrdPOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroOrdPOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroOrdPOP.Location = new System.Drawing.Point(254, 64);
            this.txtNroOrdPOP.Name = "txtNroOrdPOP";
            this.txtNroOrdPOP.ReadOnly = true;
            this.txtNroOrdPOP.Size = new System.Drawing.Size(360, 24);
            this.txtNroOrdPOP.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 24);
            this.label5.TabIndex = 43;
            this.label5.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 24);
            this.label4.TabIndex = 40;
            this.label4.Text = "Orden  Pedido";
            // 
            // txtNroDocOP
            // 
            this.txtNroDocOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNroDocOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNroDocOP.Location = new System.Drawing.Point(254, 106);
            this.txtNroDocOP.Name = "txtNroDocOP";
            this.txtNroDocOP.ReadOnly = true;
            this.txtNroDocOP.Size = new System.Drawing.Size(360, 24);
            this.txtNroDocOP.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 24);
            this.label7.TabIndex = 47;
            this.label7.Text = "Nro. Orden de Pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cliente :";
            // 
            // txtRazonSocialOP
            // 
            this.txtRazonSocialOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRazonSocialOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialOP.Location = new System.Drawing.Point(254, 148);
            this.txtRazonSocialOP.Name = "txtRazonSocialOP";
            this.txtRazonSocialOP.ReadOnly = true;
            this.txtRazonSocialOP.Size = new System.Drawing.Size(360, 24);
            this.txtRazonSocialOP.TabIndex = 46;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txtImpTotalOP);
            this.panel5.Controls.Add(this.dgvDetOP);
            this.panel5.Controls.Add(this.label12);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1090, 649);
            this.panel5.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 24);
            this.label9.TabIndex = 49;
            this.label9.Text = "Detalle";
            // 
            // txtImpTotalOP
            // 
            this.txtImpTotalOP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtImpTotalOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpTotalOP.Location = new System.Drawing.Point(474, 431);
            this.txtImpTotalOP.Name = "txtImpTotalOP";
            this.txtImpTotalOP.ReadOnly = true;
            this.txtImpTotalOP.Size = new System.Drawing.Size(160, 24);
            this.txtImpTotalOP.TabIndex = 57;
            // 
            // dgvDetOP
            // 
            this.dgvDetOP.AllowUserToAddRows = false;
            this.dgvDetOP.AllowUserToDeleteRows = false;
            this.dgvDetOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetOP.Location = new System.Drawing.Point(33, 255);
            this.dgvDetOP.MultiSelect = false;
            this.dgvDetOP.Name = "dgvDetOP";
            this.dgvDetOP.ReadOnly = true;
            this.dgvDetOP.RowHeadersWidth = 51;
            this.dgvDetOP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetOP.Size = new System.Drawing.Size(601, 158);
            this.dgvDetOP.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(377, 431);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 24);
            this.label12.TabIndex = 56;
            this.label12.Text = "Total";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(69, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Método de pago:";
            // 
            // cmbMetodoPago
            // 
            this.cmbMetodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMetodoPago.FormattingEnabled = true;
            this.cmbMetodoPago.Location = new System.Drawing.Point(254, 74);
            this.cmbMetodoPago.Name = "cmbMetodoPago";
            this.cmbMetodoPago.Size = new System.Drawing.Size(360, 26);
            this.cmbMetodoPago.TabIndex = 61;
            // 
            // frmRegisVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 938);
            this.Controls.Add(this.panelDetOP);
            this.Controls.Add(this.panelBus);
            this.Name = "frmRegisVenta";
            this.Text = "frmRegisVenta";
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrdenPedido)).EndInit();
            this.panelDetOP.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnBuscarOP;
        private System.Windows.Forms.TextBox txtBusNroDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOrdenPedido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBusNroOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerarOrdenPedido;
        private System.Windows.Forms.Panel panelDetOP;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtImpTotalOP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvDetOP;
        private System.Windows.Forms.TextBox txtNroOrdPOP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRazonSocialOP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNroDocOP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbMetodoPago;
    }
}