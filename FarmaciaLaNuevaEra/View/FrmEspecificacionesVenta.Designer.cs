
namespace FarmaciaLaNuevaEra.View
{
    partial class FrmEspecificacionesVenta
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblCantidadMedicamentos = new System.Windows.Forms.Label();
            this.lblMedicamento = new System.Windows.Forms.Label();
            this.dgvMedicamento = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMedicamentos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreLaboratorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrecioDeCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAgregarMedicamento = new Guna.UI2.WinForms.Guna2Button();
            this.btnFinalizar = new Guna.UI2.WinForms.Guna2Button();
            this.lblMedicamentos = new System.Windows.Forms.Label();
            this.dgvMedicamentoAñadidos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.NombreMedicamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadPedida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cmsOpciones = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.borrarMedicamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentoAñadidos)).BeginInit();
            this.cmsOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.BorderRadius = 8;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 8;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblCantidadMedicamentos
            // 
            this.lblCantidadMedicamentos.AutoSize = true;
            this.lblCantidadMedicamentos.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadMedicamentos.Location = new System.Drawing.Point(26, 61);
            this.lblCantidadMedicamentos.Name = "lblCantidadMedicamentos";
            this.lblCantidadMedicamentos.Size = new System.Drawing.Size(199, 16);
            this.lblCantidadMedicamentos.TabIndex = 2;
            this.lblCantidadMedicamentos.Text = "Número de medicamentos a vender";
            this.lblCantidadMedicamentos.Visible = false;
            // 
            // lblMedicamento
            // 
            this.lblMedicamento.AutoSize = true;
            this.lblMedicamento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamento.Location = new System.Drawing.Point(26, 173);
            this.lblMedicamento.Name = "lblMedicamento";
            this.lblMedicamento.Size = new System.Drawing.Size(260, 16);
            this.lblMedicamento.TabIndex = 9;
            this.lblMedicamento.Text = "Presiona el medicamento a vender";
            // 
            // dgvMedicamento
            // 
            this.dgvMedicamento.AllowUserToAddRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dgvMedicamento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgvMedicamento.ColumnHeadersHeight = 40;
            this.dgvMedicamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdMedicamento,
            this.NombreMedicamentos,
            this.NombreLaboratorio,
            this.Stock,
            this.PrecioVenta});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.Format = "N2";
            dataGridViewCellStyle23.NullValue = null;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamento.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgvMedicamento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamento.Location = new System.Drawing.Point(12, 206);
            this.dgvMedicamento.Name = "dgvMedicamento";
            this.dgvMedicamento.ReadOnly = true;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamento.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgvMedicamento.RowHeadersVisible = false;
            this.dgvMedicamento.Size = new System.Drawing.Size(651, 191);
            this.dgvMedicamento.TabIndex = 10;
            this.dgvMedicamento.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamento.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicamento.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicamento.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicamento.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicamento.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamento.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamento.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicamento.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicamento.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicamento.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicamento.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicamento.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMedicamento.ThemeStyle.ReadOnly = true;
            this.dgvMedicamento.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamento.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicamento.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicamento.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicamento.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedicamento.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamento.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamento_CellClick);
            // 
            // IdMedicamento
            // 
            this.IdMedicamento.HeaderText = "Id del Medicamento";
            this.IdMedicamento.Name = "IdMedicamento";
            this.IdMedicamento.ReadOnly = true;
            // 
            // NombreMedicamentos
            // 
            this.NombreMedicamentos.HeaderText = "Medicamentos";
            this.NombreMedicamentos.Name = "NombreMedicamentos";
            this.NombreMedicamentos.ReadOnly = true;
            // 
            // NombreLaboratorio
            // 
            this.NombreLaboratorio.HeaderText = "Laboratorio";
            this.NombreLaboratorio.Name = "NombreLaboratorio";
            this.NombreLaboratorio.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Cantidad en Inventario";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // txtPrecioDeCompra
            // 
            this.txtPrecioDeCompra.BorderColor = System.Drawing.Color.Silver;
            this.txtPrecioDeCompra.BorderRadius = 3;
            this.txtPrecioDeCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioDeCompra.DefaultText = "";
            this.txtPrecioDeCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioDeCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioDeCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioDeCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioDeCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioDeCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioDeCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioDeCompra.Location = new System.Drawing.Point(29, 90);
            this.txtPrecioDeCompra.Name = "txtPrecioDeCompra";
            this.txtPrecioDeCompra.PasswordChar = '\0';
            this.txtPrecioDeCompra.PlaceholderText = "";
            this.txtPrecioDeCompra.SelectedText = "";
            this.txtPrecioDeCompra.Size = new System.Drawing.Size(124, 36);
            this.txtPrecioDeCompra.TabIndex = 11;
            this.txtPrecioDeCompra.Visible = false;
            // 
            // btnAgregarMedicamento
            // 
            this.btnAgregarMedicamento.BorderRadius = 12;
            this.btnAgregarMedicamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarMedicamento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMedicamento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarMedicamento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarMedicamento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarMedicamento.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarMedicamento.ForeColor = System.Drawing.Color.White;
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(160, 427);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(166, 39);
            this.btnAgregarMedicamento.TabIndex = 21;
            this.btnAgregarMedicamento.Text = "Agregar medicamento";
            this.btnAgregarMedicamento.Tile = true;
            this.btnAgregarMedicamento.Click += new System.EventHandler(this.btnAgregarMedicamento_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BorderRadius = 12;
            this.btnFinalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFinalizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFinalizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFinalizar.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(344, 427);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(138, 39);
            this.btnFinalizar.TabIndex = 22;
            this.btnFinalizar.Text = "Finalizar pedido";
            this.btnFinalizar.Tile = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblMedicamentos
            // 
            this.lblMedicamentos.AutoSize = true;
            this.lblMedicamentos.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMedicamentos.Location = new System.Drawing.Point(429, 30);
            this.lblMedicamentos.Name = "lblMedicamentos";
            this.lblMedicamentos.Size = new System.Drawing.Size(136, 16);
            this.lblMedicamentos.TabIndex = 23;
            this.lblMedicamentos.Text = "Medicamentos añadidos";
            this.lblMedicamentos.Visible = false;
            // 
            // dgvMedicamentoAñadidos
            // 
            this.dgvMedicamentoAñadidos.AllowUserToAddRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.White;
            this.dgvMedicamentoAñadidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentoAñadidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvMedicamentoAñadidos.ColumnHeadersHeight = 40;
            this.dgvMedicamentoAñadidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicamentoAñadidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreMedicamento,
            this.CantidadPedida});
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.Format = "N2";
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentoAñadidos.DefaultCellStyle = dataGridViewCellStyle19;
            this.dgvMedicamentoAñadidos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamentoAñadidos.Location = new System.Drawing.Point(334, 49);
            this.dgvMedicamentoAñadidos.Name = "dgvMedicamentoAñadidos";
            this.dgvMedicamentoAñadidos.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicamentoAñadidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvMedicamentoAñadidos.RowHeadersVisible = false;
            this.dgvMedicamentoAñadidos.Size = new System.Drawing.Size(329, 140);
            this.dgvMedicamentoAñadidos.TabIndex = 24;
            this.dgvMedicamentoAñadidos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamentoAñadidos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMedicamentoAñadidos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMedicamentoAñadidos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMedicamentoAñadidos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMedicamentoAñadidos.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamentoAñadidos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMedicamentoAñadidos.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvMedicamentoAñadidos.ThemeStyle.ReadOnly = true;
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.Height = 22;
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMedicamentoAñadidos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMedicamentoAñadidos.Visible = false;
            this.dgvMedicamentoAñadidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedicamentoAñadidos_CellClick);
            this.dgvMedicamentoAñadidos.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMedicamentoAñadidos_CellMouseUp);
            // 
            // NombreMedicamento
            // 
            this.NombreMedicamento.HeaderText = "Medicamento";
            this.NombreMedicamento.Name = "NombreMedicamento";
            this.NombreMedicamento.ReadOnly = true;
            // 
            // CantidadPedida
            // 
            this.CantidadPedida.HeaderText = "Cantidad pedida";
            this.CantidadPedida.Name = "CantidadPedida";
            this.CantidadPedida.ReadOnly = true;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(615, 1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 29);
            this.guna2ControlBox2.TabIndex = 26;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(638, 2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 25;
            // 
            // cmsOpciones
            // 
            this.cmsOpciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.borrarMedicamentoToolStripMenuItem});
            this.cmsOpciones.Name = "cmsOpciones";
            this.cmsOpciones.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.cmsOpciones.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmsOpciones.RenderStyle.ColorTable = null;
            this.cmsOpciones.RenderStyle.RoundedEdges = true;
            this.cmsOpciones.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.cmsOpciones.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmsOpciones.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.cmsOpciones.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.cmsOpciones.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmsOpciones.Size = new System.Drawing.Size(186, 26);
            // 
            // borrarMedicamentoToolStripMenuItem
            // 
            this.borrarMedicamentoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.borrarMedicamentoToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.borrarMedicamentoToolStripMenuItem.Name = "borrarMedicamentoToolStripMenuItem";
            this.borrarMedicamentoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.borrarMedicamentoToolStripMenuItem.Text = "Borrar Medicamento";
            this.borrarMedicamentoToolStripMenuItem.Click += new System.EventHandler(this.borrarMedicamentoToolStripMenuItem_Click);
            // 
            // FrmEspecificacionesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(675, 478);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.dgvMedicamentoAñadidos);
            this.Controls.Add(this.lblMedicamentos);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregarMedicamento);
            this.Controls.Add(this.txtPrecioDeCompra);
            this.Controls.Add(this.dgvMedicamento);
            this.Controls.Add(this.lblMedicamento);
            this.Controls.Add(this.lblCantidadMedicamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEspecificacionesVenta";
            this.Text = "FrmEspecificacionesVenta";
            this.Load += new System.EventHandler(this.FrmEspecificacionesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicamentoAñadidos)).EndInit();
            this.cmsOpciones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label lblCantidadMedicamentos;
        private System.Windows.Forms.Label lblMedicamento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicamento;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioDeCompra;
        private System.Windows.Forms.Label lblMedicamentos;
        private Guna.UI2.WinForms.Guna2Button btnFinalizar;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMedicamento;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMedicamentoAñadidos;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadPedida;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdMedicamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMedicamentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreLaboratorio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsOpciones;
        private System.Windows.Forms.ToolStripMenuItem borrarMedicamentoToolStripMenuItem;
    }
}