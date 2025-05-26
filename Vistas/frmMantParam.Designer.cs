
namespace AppBogedaTeo
{
    partial class frmMantParam
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelBus = new System.Windows.Forms.Panel();
            this.dgvParametro = new System.Windows.Forms.DataGridView();
            this.btnCrear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarRol = new System.Windows.Forms.Button();
            this.txtCodPrmBus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValor2Bus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodIdenBus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkHabilBus = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValor1Bus = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMantParam = new System.Windows.Forms.Panel();
            this.panelChkHabMant = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.chkHabilMant = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtCodPrmMant = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValor2Mant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCodIdenMant = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValor1Mant = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblMantParam = new System.Windows.Forms.Label();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).BeginInit();
            this.panelMantParam.SuspendLayout();
            this.panelChkHabMant.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBus
            // 
            this.panelBus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBus.Controls.Add(this.dgvParametro);
            this.panelBus.Controls.Add(this.btnCrear);
            this.panelBus.Controls.Add(this.button1);
            this.panelBus.Controls.Add(this.btnBuscarRol);
            this.panelBus.Controls.Add(this.txtCodPrmBus);
            this.panelBus.Controls.Add(this.label6);
            this.panelBus.Controls.Add(this.txtValor2Bus);
            this.panelBus.Controls.Add(this.label5);
            this.panelBus.Controls.Add(this.txtCodIdenBus);
            this.panelBus.Controls.Add(this.label4);
            this.panelBus.Controls.Add(this.chkHabilBus);
            this.panelBus.Controls.Add(this.label3);
            this.panelBus.Controls.Add(this.txtValor1Bus);
            this.panelBus.Controls.Add(this.label2);
            this.panelBus.Controls.Add(this.label1);
            this.panelBus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBus.Location = new System.Drawing.Point(0, 0);
            this.panelBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(1780, 628);
            this.panelBus.TabIndex = 1;
            this.panelBus.Visible = false;
            // 
            // dgvParametro
            // 
            this.dgvParametro.AllowUserToAddRows = false;
            this.dgvParametro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvParametro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvParametro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvParametro.Location = new System.Drawing.Point(48, 310);
            this.dgvParametro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvParametro.MultiSelect = false;
            this.dgvParametro.Name = "dgvParametro";
            this.dgvParametro.ReadOnly = true;
            this.dgvParametro.RowHeadersWidth = 51;
            this.dgvParametro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvParametro.Size = new System.Drawing.Size(1716, 297);
            this.dgvParametro.TabIndex = 19;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Crimson;
            this.btnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(1347, 124);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(177, 48);
            this.btnCrear.TabIndex = 18;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1347, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 48);
            this.button1.TabIndex = 17;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscarRol
            // 
            this.btnBuscarRol.BackColor = System.Drawing.Color.Indigo;
            this.btnBuscarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarRol.ForeColor = System.Drawing.Color.White;
            this.btnBuscarRol.Location = new System.Drawing.Point(1347, 73);
            this.btnBuscarRol.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarRol.Name = "btnBuscarRol";
            this.btnBuscarRol.Size = new System.Drawing.Size(177, 48);
            this.btnBuscarRol.TabIndex = 16;
            this.btnBuscarRol.Text = "Buscar";
            this.btnBuscarRol.UseVisualStyleBackColor = false;
            this.btnBuscarRol.Click += new System.EventHandler(this.btnBuscarRol_Click);
            // 
            // txtCodPrmBus
            // 
            this.txtCodPrmBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPrmBus.Location = new System.Drawing.Point(48, 133);
            this.txtCodPrmBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodPrmBus.Name = "txtCodPrmBus";
            this.txtCodPrmBus.Size = new System.Drawing.Size(336, 29);
            this.txtCodPrmBus.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(48, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Código Parametro";
            // 
            // txtValor2Bus
            // 
            this.txtValor2Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2Bus.Location = new System.Drawing.Point(623, 242);
            this.txtValor2Bus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor2Bus.Name = "txtValor2Bus";
            this.txtValor2Bus.Size = new System.Drawing.Size(468, 29);
            this.txtValor2Bus.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(623, 193);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Valor 2:";
            // 
            // txtCodIdenBus
            // 
            this.txtCodIdenBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodIdenBus.Location = new System.Drawing.Point(623, 133);
            this.txtCodIdenBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodIdenBus.Name = "txtCodIdenBus";
            this.txtCodIdenBus.Size = new System.Drawing.Size(336, 29);
            this.txtCodIdenBus.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(623, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código Identificador:";
            // 
            // chkHabilBus
            // 
            this.chkHabilBus.AutoSize = true;
            this.chkHabilBus.Checked = true;
            this.chkHabilBus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilBus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilBus.ForeColor = System.Drawing.Color.White;
            this.chkHabilBus.Location = new System.Drawing.Point(1040, 138);
            this.chkHabilBus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHabilBus.Name = "chkHabilBus";
            this.chkHabilBus.Size = new System.Drawing.Size(46, 24);
            this.chkHabilBus.TabIndex = 8;
            this.chkHabilBus.Text = "SÍ";
            this.chkHabilBus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1035, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Habilitado:";
            // 
            // txtValor1Bus
            // 
            this.txtValor1Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1Bus.Location = new System.Drawing.Point(48, 242);
            this.txtValor1Bus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor1Bus.Name = "txtValor1Bus";
            this.txtValor1Bus.Size = new System.Drawing.Size(457, 29);
            this.txtValor1Bus.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 1:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Búsqueda Parametro";
            // 
            // panelMantParam
            // 
            this.panelMantParam.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelMantParam.Controls.Add(this.panelChkHabMant);
            this.panelMantParam.Controls.Add(this.panel2);
            this.panelMantParam.Controls.Add(this.txtCodPrmMant);
            this.panelMantParam.Controls.Add(this.label7);
            this.panelMantParam.Controls.Add(this.txtValor2Mant);
            this.panelMantParam.Controls.Add(this.label8);
            this.panelMantParam.Controls.Add(this.txtCodIdenMant);
            this.panelMantParam.Controls.Add(this.label9);
            this.panelMantParam.Controls.Add(this.txtValor1Mant);
            this.panelMantParam.Controls.Add(this.label11);
            this.panelMantParam.Controls.Add(this.lblMantParam);
            this.panelMantParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMantParam.Location = new System.Drawing.Point(0, 628);
            this.panelMantParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMantParam.Name = "panelMantParam";
            this.panelMantParam.Size = new System.Drawing.Size(1780, 427);
            this.panelMantParam.TabIndex = 2;
            this.panelMantParam.Visible = false;
            // 
            // panelChkHabMant
            // 
            this.panelChkHabMant.Controls.Add(this.label10);
            this.panelChkHabMant.Controls.Add(this.chkHabilMant);
            this.panelChkHabMant.Location = new System.Drawing.Point(1377, 80);
            this.panelChkHabMant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChkHabMant.Name = "panelChkHabMant";
            this.panelChkHabMant.Size = new System.Drawing.Size(147, 111);
            this.panelChkHabMant.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(17, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 25);
            this.label10.TabIndex = 17;
            this.label10.Text = "Habilitado:";
            // 
            // chkHabilMant
            // 
            this.chkHabilMant.AutoSize = true;
            this.chkHabilMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkHabilMant.ForeColor = System.Drawing.Color.White;
            this.chkHabilMant.Location = new System.Drawing.Point(23, 74);
            this.chkHabilMant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkHabilMant.Name = "chkHabilMant";
            this.chkHabilMant.Size = new System.Drawing.Size(46, 24);
            this.chkHabilMant.TabIndex = 18;
            this.chkHabilMant.Text = "SÍ";
            this.chkHabilMant.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnVolver);
            this.panel2.Controls.Add(this.btnActualizar);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(412, 406);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 55);
            this.panel2.TabIndex = 29;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnVolver.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVolver.Location = new System.Drawing.Point(368, 0);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(184, 55);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.DarkBlue;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnActualizar.Location = new System.Drawing.Point(184, 0);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(184, 55);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Crimson;
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrar.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 55);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtCodPrmMant
            // 
            this.txtCodPrmMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodPrmMant.Location = new System.Drawing.Point(48, 161);
            this.txtCodPrmMant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodPrmMant.Name = "txtCodPrmMant";
            this.txtCodPrmMant.Size = new System.Drawing.Size(336, 29);
            this.txtCodPrmMant.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(48, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 25);
            this.label7.TabIndex = 23;
            this.label7.Text = "Código Parametro(*):";
            // 
            // txtValor2Mant
            // 
            this.txtValor2Mant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor2Mant.Location = new System.Drawing.Point(731, 273);
            this.txtValor2Mant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor2Mant.Multiline = true;
            this.txtValor2Mant.Name = "txtValor2Mant";
            this.txtValor2Mant.Size = new System.Drawing.Size(601, 86);
            this.txtValor2Mant.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(731, 224);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "Valor 2:";
            // 
            // txtCodIdenMant
            // 
            this.txtCodIdenMant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodIdenMant.Location = new System.Drawing.Point(736, 161);
            this.txtCodIdenMant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodIdenMant.Name = "txtCodIdenMant";
            this.txtCodIdenMant.Size = new System.Drawing.Size(336, 29);
            this.txtCodIdenMant.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(736, 112);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Código Identificador(*):";
            // 
            // txtValor1Mant
            // 
            this.txtValor1Mant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor1Mant.Location = new System.Drawing.Point(43, 273);
            this.txtValor1Mant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor1Mant.Multiline = true;
            this.txtValor1Mant.Name = "txtValor1Mant";
            this.txtValor1Mant.Size = new System.Drawing.Size(580, 80);
            this.txtValor1Mant.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(43, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 25);
            this.label11.TabIndex = 15;
            this.label11.Text = "Valor 1(*):";
            // 
            // lblMantParam
            // 
            this.lblMantParam.AutoSize = true;
            this.lblMantParam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMantParam.ForeColor = System.Drawing.Color.White;
            this.lblMantParam.Location = new System.Drawing.Point(43, 36);
            this.lblMantParam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMantParam.Name = "lblMantParam";
            this.lblMantParam.Size = new System.Drawing.Size(34, 29);
            this.lblMantParam.TabIndex = 4;
            this.lblMantParam.Text = "...";
            // 
            // frmMantParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 1055);
            this.Controls.Add(this.panelMantParam);
            this.Controls.Add(this.panelBus);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMantParam";
            this.Text = "frmMantParam";
            this.panelBus.ResumeLayout(false);
            this.panelBus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParametro)).EndInit();
            this.panelMantParam.ResumeLayout(false);
            this.panelMantParam.PerformLayout();
            this.panelChkHabMant.ResumeLayout(false);
            this.panelChkHabMant.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.DataGridView dgvParametro;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarRol;
        private System.Windows.Forms.TextBox txtCodPrmBus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValor2Bus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodIdenBus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkHabilBus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValor1Bus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMantParam;
        private System.Windows.Forms.Panel panelChkHabMant;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkHabilMant;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtCodPrmMant;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValor2Mant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCodIdenMant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValor1Mant;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblMantParam;
    }
}