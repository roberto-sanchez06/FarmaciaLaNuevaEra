
namespace FarmaciaLaNuevaEra.View
{
    partial class FrmEspecificacionMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEspecificacionMedicamento));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btnNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNombreMedicamento = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblCantidadDeLetras = new System.Windows.Forms.Label();
            this.lblPrecioDeCompra = new System.Windows.Forms.Label();
            this.txtPrecioDeCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrecioDeVenta = new System.Windows.Forms.Label();
            this.txtPrecioDeVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.txtMinimo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAgregarLaboratorio = new System.Windows.Forms.Label();
            this.btnAgregarLaboratorio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnAgregarMedicamento = new Guna.UI2.WinForms.Guna2Button();
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
            // btnNombre
            // 
            this.btnNombre.BorderColor = System.Drawing.Color.Silver;
            this.btnNombre.BorderRadius = 3;
            this.btnNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnNombre.DefaultText = "";
            this.btnNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.btnNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.btnNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.btnNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnNombre.Location = new System.Drawing.Point(12, 42);
            this.btnNombre.Name = "btnNombre";
            this.btnNombre.PasswordChar = '\0';
            this.btnNombre.PlaceholderText = "";
            this.btnNombre.SelectedText = "";
            this.btnNombre.Size = new System.Drawing.Size(287, 36);
            this.btnNombre.TabIndex = 0;
            this.btnNombre.TextChanged += new System.EventHandler(this.btnNombre_TextChanged);
            // 
            // lblNombreMedicamento
            // 
            this.lblNombreMedicamento.AutoSize = true;
            this.lblNombreMedicamento.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreMedicamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreMedicamento.Location = new System.Drawing.Point(15, 23);
            this.lblNombreMedicamento.Name = "lblNombreMedicamento";
            this.lblNombreMedicamento.Size = new System.Drawing.Size(146, 16);
            this.lblNombreMedicamento.TabIndex = 1;
            this.lblNombreMedicamento.Text = "Nombre del medicamento";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.CustomIconSize = 8F;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(328, -2);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 29);
            this.guna2ControlBox2.TabIndex = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.CustomIconSize = 8F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(352, -2);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(28, 28);
            this.guna2ControlBox1.TabIndex = 7;
            // 
            // lblCantidadDeLetras
            // 
            this.lblCantidadDeLetras.AutoSize = true;
            this.lblCantidadDeLetras.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeLetras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadDeLetras.Location = new System.Drawing.Point(268, 81);
            this.lblCantidadDeLetras.Name = "lblCantidadDeLetras";
            this.lblCantidadDeLetras.Size = new System.Drawing.Size(30, 16);
            this.lblCantidadDeLetras.TabIndex = 9;
            this.lblCantidadDeLetras.Text = "0/30";
            // 
            // lblPrecioDeCompra
            // 
            this.lblPrecioDeCompra.AutoSize = true;
            this.lblPrecioDeCompra.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDeCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecioDeCompra.Location = new System.Drawing.Point(21, 112);
            this.lblPrecioDeCompra.Name = "lblPrecioDeCompra";
            this.lblPrecioDeCompra.Size = new System.Drawing.Size(104, 16);
            this.lblPrecioDeCompra.TabIndex = 11;
            this.lblPrecioDeCompra.Text = "Precio de compra";
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
            this.txtPrecioDeCompra.Location = new System.Drawing.Point(18, 131);
            this.txtPrecioDeCompra.Name = "txtPrecioDeCompra";
            this.txtPrecioDeCompra.PasswordChar = '\0';
            this.txtPrecioDeCompra.PlaceholderText = "";
            this.txtPrecioDeCompra.SelectedText = "";
            this.txtPrecioDeCompra.Size = new System.Drawing.Size(124, 36);
            this.txtPrecioDeCompra.TabIndex = 10;
            // 
            // lblPrecioDeVenta
            // 
            this.lblPrecioDeVenta.AutoSize = true;
            this.lblPrecioDeVenta.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDeVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPrecioDeVenta.Location = new System.Drawing.Point(178, 112);
            this.lblPrecioDeVenta.Name = "lblPrecioDeVenta";
            this.lblPrecioDeVenta.Size = new System.Drawing.Size(93, 16);
            this.lblPrecioDeVenta.TabIndex = 13;
            this.lblPrecioDeVenta.Text = "Precio de venta";
            // 
            // txtPrecioDeVenta
            // 
            this.txtPrecioDeVenta.BorderColor = System.Drawing.Color.Silver;
            this.txtPrecioDeVenta.BorderRadius = 3;
            this.txtPrecioDeVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioDeVenta.DefaultText = "";
            this.txtPrecioDeVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioDeVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioDeVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioDeVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioDeVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioDeVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioDeVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioDeVenta.Location = new System.Drawing.Point(175, 131);
            this.txtPrecioDeVenta.Name = "txtPrecioDeVenta";
            this.txtPrecioDeVenta.PasswordChar = '\0';
            this.txtPrecioDeVenta.PlaceholderText = "";
            this.txtPrecioDeVenta.SelectedText = "";
            this.txtPrecioDeVenta.Size = new System.Drawing.Size(124, 36);
            this.txtPrecioDeVenta.TabIndex = 12;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStock.Location = new System.Drawing.Point(21, 210);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(71, 16);
            this.lblStock.TabIndex = 15;
            this.lblStock.Text = "Cantidades:";
            // 
            // txtStock
            // 
            this.txtStock.BorderColor = System.Drawing.Color.Silver;
            this.txtStock.BorderRadius = 3;
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.Location = new System.Drawing.Point(18, 229);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.PlaceholderText = "";
            this.txtStock.SelectedText = "";
            this.txtStock.Size = new System.Drawing.Size(124, 36);
            this.txtStock.TabIndex = 14;
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockMinimo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblStockMinimo.Location = new System.Drawing.Point(178, 210);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(116, 16);
            this.lblStockMinimo.TabIndex = 17;
            this.lblStockMinimo.Text = "Cantidades mínimas:";
            // 
            // txtMinimo
            // 
            this.txtMinimo.BorderColor = System.Drawing.Color.Silver;
            this.txtMinimo.BorderRadius = 3;
            this.txtMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMinimo.DefaultText = "";
            this.txtMinimo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMinimo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMinimo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMinimo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMinimo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMinimo.Location = new System.Drawing.Point(175, 229);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.PasswordChar = '\0';
            this.txtMinimo.PlaceholderText = "";
            this.txtMinimo.SelectedText = "";
            this.txtMinimo.Size = new System.Drawing.Size(124, 36);
            this.txtMinimo.TabIndex = 16;
            // 
            // lblAgregarLaboratorio
            // 
            this.lblAgregarLaboratorio.AutoSize = true;
            this.lblAgregarLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAgregarLaboratorio.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblAgregarLaboratorio.Location = new System.Drawing.Point(21, 320);
            this.lblAgregarLaboratorio.Name = "lblAgregarLaboratorio";
            this.lblAgregarLaboratorio.Size = new System.Drawing.Size(214, 16);
            this.lblAgregarLaboratorio.TabIndex = 18;
            this.lblAgregarLaboratorio.Text = "Agregar laboratorio del medicamento:";
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
            this.btnAgregarLaboratorio.Location = new System.Drawing.Point(247, 301);
            this.btnAgregarLaboratorio.Name = "btnAgregarLaboratorio";
            this.btnAgregarLaboratorio.PressedState.ImageSize = new System.Drawing.Size(38, 38);
            this.btnAgregarLaboratorio.Size = new System.Drawing.Size(51, 54);
            this.btnAgregarLaboratorio.TabIndex = 19;
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
            this.btnAgregarMedicamento.Location = new System.Drawing.Point(119, 383);
            this.btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            this.btnAgregarMedicamento.Size = new System.Drawing.Size(103, 39);
            this.btnAgregarMedicamento.TabIndex = 20;
            this.btnAgregarMedicamento.Text = "Agregar";
            this.btnAgregarMedicamento.Tile = true;
            // 
            // FrmEspecificacionMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(381, 445);
            this.Controls.Add(this.btnAgregarMedicamento);
            this.Controls.Add(this.btnAgregarLaboratorio);
            this.Controls.Add(this.lblAgregarLaboratorio);
            this.Controls.Add(this.lblStockMinimo);
            this.Controls.Add(this.txtMinimo);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblPrecioDeVenta);
            this.Controls.Add(this.txtPrecioDeVenta);
            this.Controls.Add(this.lblPrecioDeCompra);
            this.Controls.Add(this.txtPrecioDeCompra);
            this.Controls.Add(this.lblCantidadDeLetras);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.lblNombreMedicamento);
            this.Controls.Add(this.btnNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEspecificacionMedicamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmEspecificacionMedicamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2TextBox btnNombre;
        private System.Windows.Forms.Label lblNombreMedicamento;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label lblCantidadDeLetras;
        private System.Windows.Forms.Label lblAgregarLaboratorio;
        private System.Windows.Forms.Label lblStockMinimo;
        private Guna.UI2.WinForms.Guna2TextBox txtMinimo;
        private System.Windows.Forms.Label lblStock;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private System.Windows.Forms.Label lblPrecioDeVenta;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioDeVenta;
        private System.Windows.Forms.Label lblPrecioDeCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioDeCompra;
        private Guna.UI2.WinForms.Guna2ImageButton btnAgregarLaboratorio;
        private Guna.UI2.WinForms.Guna2Button btnAgregarMedicamento;
    }
}