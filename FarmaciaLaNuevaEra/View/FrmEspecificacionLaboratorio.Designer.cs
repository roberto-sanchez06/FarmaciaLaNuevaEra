
namespace FarmaciaLaNuevaEra.View
{
    partial class FrmEspecificacionLaboratorio
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.lblCantidadDeLetras = new System.Windows.Forms.Label();
            this.lblNombreLaboratorio = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.StEstado = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAgregarLaboratorio = new Guna.UI2.WinForms.Guna2Button();
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
            this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.DarkGray;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // lblCantidadDeLetras
            // 
            this.lblCantidadDeLetras.AutoSize = true;
            this.lblCantidadDeLetras.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadDeLetras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCantidadDeLetras.Location = new System.Drawing.Point(279, 80);
            this.lblCantidadDeLetras.Name = "lblCantidadDeLetras";
            this.lblCantidadDeLetras.Size = new System.Drawing.Size(30, 16);
            this.lblCantidadDeLetras.TabIndex = 12;
            this.lblCantidadDeLetras.Text = "0/30";
            // 
            // lblNombreLaboratorio
            // 
            this.lblNombreLaboratorio.AutoSize = true;
            this.lblNombreLaboratorio.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreLaboratorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNombreLaboratorio.Location = new System.Drawing.Point(26, 22);
            this.lblNombreLaboratorio.Name = "lblNombreLaboratorio";
            this.lblNombreLaboratorio.Size = new System.Drawing.Size(133, 16);
            this.lblNombreLaboratorio.TabIndex = 11;
            this.lblNombreLaboratorio.Text = "Nombre del laboratorio";
            // 
            // txtNombre
            // 
            this.txtNombre.BorderColor = System.Drawing.Color.Silver;
            this.txtNombre.BorderRadius = 3;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombre.Location = new System.Drawing.Point(23, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(287, 36);
            this.txtNombre.TabIndex = 10;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // StEstado
            // 
            this.StEstado.Checked = true;
            this.StEstado.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StEstado.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StEstado.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.StEstado.CheckedState.InnerColor = System.Drawing.Color.White;
            this.StEstado.Enabled = false;
            this.StEstado.Location = new System.Drawing.Point(162, 127);
            this.StEstado.Name = "StEstado";
            this.StEstado.Size = new System.Drawing.Size(35, 20);
            this.StEstado.TabIndex = 13;
            this.StEstado.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.StEstado.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.StEstado.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.StEstado.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEstado.Location = new System.Drawing.Point(26, 129);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(123, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado de laboratorio";
            // 
            // btnAgregarLaboratorio
            // 
            this.btnAgregarLaboratorio.BorderRadius = 12;
            this.btnAgregarLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarLaboratorio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarLaboratorio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAgregarLaboratorio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAgregarLaboratorio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAgregarLaboratorio.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLaboratorio.ForeColor = System.Drawing.Color.White;
            this.btnAgregarLaboratorio.Location = new System.Drawing.Point(120, 195);
            this.btnAgregarLaboratorio.Name = "btnAgregarLaboratorio";
            this.btnAgregarLaboratorio.Size = new System.Drawing.Size(103, 39);
            this.btnAgregarLaboratorio.TabIndex = 21;
            this.btnAgregarLaboratorio.Text = "Agregar";
            this.btnAgregarLaboratorio.Tile = true;
            this.btnAgregarLaboratorio.Click += new System.EventHandler(this.btnAgregarLaboratorio_Click);
            // 
            // FrmEspecificacionLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(371, 246);
            this.Controls.Add(this.btnAgregarLaboratorio);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.StEstado);
            this.Controls.Add(this.lblCantidadDeLetras);
            this.Controls.Add(this.lblNombreLaboratorio);
            this.Controls.Add(this.txtNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEspecificacionLaboratorio";
            this.Text = "FrmEspecificacionLaboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch StEstado;
        private System.Windows.Forms.Label lblCantidadDeLetras;
        private System.Windows.Forms.Label lblNombreLaboratorio;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label lblEstado;
        private Guna.UI2.WinForms.Guna2Button btnAgregarLaboratorio;
    }
}