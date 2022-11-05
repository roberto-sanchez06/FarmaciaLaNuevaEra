
namespace FarmaciaLaNuevaEra.View
{
    partial class FrmLaboratorio
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
            Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLaboratorio));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.dgvLaboratorios = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnAgregarLaboratorio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lblLaboratorios = new System.Windows.Forms.Label();
            this.cmbTipoLaboratorio = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTipoLaboratorio = new System.Windows.Forms.Label();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).BeginInit();
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
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1027, -1);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 29);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1049, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 8;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // guna2AnimateWindow1
            // 
            guna2AnimateWindow1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_ACTIVATE;
            // 
            // dgvLaboratorios
            // 
            this.dgvLaboratorios.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvLaboratorios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaboratorios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLaboratorios.ColumnHeadersHeight = 40;
            this.dgvLaboratorios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaboratorios.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLaboratorios.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLaboratorios.Location = new System.Drawing.Point(62, 174);
            this.dgvLaboratorios.Name = "dgvLaboratorios";
            this.dgvLaboratorios.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLaboratorios.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLaboratorios.RowHeadersVisible = false;
            this.dgvLaboratorios.Size = new System.Drawing.Size(985, 487);
            this.dgvLaboratorios.TabIndex = 9;
            this.dgvLaboratorios.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLaboratorios.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvLaboratorios.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvLaboratorios.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvLaboratorios.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvLaboratorios.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvLaboratorios.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvLaboratorios.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvLaboratorios.ThemeStyle.ReadOnly = true;
            this.dgvLaboratorios.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvLaboratorios.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLaboratorios.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLaboratorios.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLaboratorios.ThemeStyle.RowsStyle.Height = 22;
            this.dgvLaboratorios.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvLaboratorios.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvLaboratorios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvLaboratorios_MouseClick);
            // 
            // btnAgregarLaboratorio
            // 
            this.btnAgregarLaboratorio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarLaboratorio.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnAgregarLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLaboratorio.HoverState.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAgregarLaboratorio.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarLaboratorio.Image")));
            this.btnAgregarLaboratorio.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnAgregarLaboratorio.ImageRotate = 0F;
            this.btnAgregarLaboratorio.ImageSize = new System.Drawing.Size(45, 45);
            this.btnAgregarLaboratorio.Location = new System.Drawing.Point(296, 114);
            this.btnAgregarLaboratorio.Name = "btnAgregarLaboratorio";
            this.btnAgregarLaboratorio.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnAgregarLaboratorio.Size = new System.Drawing.Size(51, 54);
            this.btnAgregarLaboratorio.TabIndex = 10;
            this.btnAgregarLaboratorio.Click += new System.EventHandler(this.btnAgregarLaboratorio_Click);
            // 
            // lblLaboratorios
            // 
            this.lblLaboratorios.AutoSize = true;
            this.lblLaboratorios.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaboratorios.Location = new System.Drawing.Point(56, 126);
            this.lblLaboratorios.Name = "lblLaboratorios";
            this.lblLaboratorios.Size = new System.Drawing.Size(207, 32);
            this.lblLaboratorios.TabIndex = 11;
            this.lblLaboratorios.Text = "Laboratorios";
            // 
            // cmbTipoLaboratorio
            // 
            this.cmbTipoLaboratorio.BackColor = System.Drawing.Color.Transparent;
            this.cmbTipoLaboratorio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTipoLaboratorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoLaboratorio.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoLaboratorio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTipoLaboratorio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbTipoLaboratorio.ItemHeight = 30;
            this.cmbTipoLaboratorio.Items.AddRange(new object[] {
            "Operando",
            "Eliminados"});
            this.cmbTipoLaboratorio.Location = new System.Drawing.Point(820, 122);
            this.cmbTipoLaboratorio.Name = "cmbTipoLaboratorio";
            this.cmbTipoLaboratorio.Size = new System.Drawing.Size(227, 36);
            this.cmbTipoLaboratorio.StartIndex = 0;
            this.cmbTipoLaboratorio.TabIndex = 12;
            this.cmbTipoLaboratorio.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // lblTipoLaboratorio
            // 
            this.lblTipoLaboratorio.AutoSize = true;
            this.lblTipoLaboratorio.Font = new System.Drawing.Font("Verdana", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoLaboratorio.Location = new System.Drawing.Point(713, 132);
            this.lblTipoLaboratorio.Name = "lblTipoLaboratorio";
            this.lblTipoLaboratorio.Size = new System.Drawing.Size(86, 18);
            this.lblTipoLaboratorio.TabIndex = 13;
            this.lblTipoLaboratorio.Text = "Laboratios";
            // 
            // FrmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.lblTipoLaboratorio);
            this.Controls.Add(this.cmbTipoLaboratorio);
            this.Controls.Add(this.lblLaboratorios);
            this.Controls.Add(this.btnAgregarLaboratorio);
            this.Controls.Add(this.dgvLaboratorios);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLaboratorio";
            this.Text = "FormLaboratorio";
            this.Activated += new System.EventHandler(this.FrmLaboratorio_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaboratorios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLaboratorios;
        private Guna.UI2.WinForms.Guna2ImageButton btnAgregarLaboratorio;
        private System.Windows.Forms.Label lblLaboratorios;
        private System.Windows.Forms.Label lblTipoLaboratorio;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTipoLaboratorio;
    }
}