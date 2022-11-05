
namespace FarmaciaLaNuevaEra.View
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lblFuncionalidad = new System.Windows.Forms.Label();
            this.btnMedicamentos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2NotificationPaint1 = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.imbVentas = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // guna2AnimateWindow1
            // 
            this.guna2AnimateWindow1.Interval = 400;
            this.guna2AnimateWindow1.TargetForm = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 8;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // lblFuncionalidad
            // 
            this.lblFuncionalidad.AutoSize = true;
            this.lblFuncionalidad.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuncionalidad.Location = new System.Drawing.Point(100, 58);
            this.lblFuncionalidad.Name = "lblFuncionalidad";
            this.lblFuncionalidad.Size = new System.Drawing.Size(260, 32);
            this.lblFuncionalidad.TabIndex = 0;
            this.lblFuncionalidad.Text = "Funcionalidades";
            // 
            // btnMedicamentos
            // 
            this.btnMedicamentos.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMedicamentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicamentos.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnMedicamentos.Image = ((System.Drawing.Image)(resources.GetObject("btnMedicamentos.Image")));
            this.btnMedicamentos.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMedicamentos.ImageRotate = 0F;
            this.btnMedicamentos.ImageSize = new System.Drawing.Size(80, 80);
            this.btnMedicamentos.Location = new System.Drawing.Point(108, 114);
            this.btnMedicamentos.Name = "btnMedicamentos";
            this.btnMedicamentos.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnMedicamentos.Size = new System.Drawing.Size(114, 96);
            this.btnMedicamentos.TabIndex = 2;
            this.btnMedicamentos.Click += new System.EventHandler(this.btnMedicamentos_Click);
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 8;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1044, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(35, 29);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.White;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.DimGray;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1019, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(23, 29);
            this.guna2ControlBox2.TabIndex = 4;
            // 
            // guna2NotificationPaint1
            // 
            this.guna2NotificationPaint1.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.guna2NotificationPaint1.BorderRadius = 8;
            this.guna2NotificationPaint1.Location = new System.Drawing.Point(96, 0);
            this.guna2NotificationPaint1.TargetControl = this.btnMedicamentos;
            // 
            // imbVentas
            // 
            this.imbVentas.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.imbVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imbVentas.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.imbVentas.Image = ((System.Drawing.Image)(resources.GetObject("imbVentas.Image")));
            this.imbVentas.ImageOffset = new System.Drawing.Point(0, 0);
            this.imbVentas.ImageRotate = 0F;
            this.imbVentas.ImageSize = new System.Drawing.Size(80, 80);
            this.imbVentas.Location = new System.Drawing.Point(264, 114);
            this.imbVentas.Name = "imbVentas";
            this.imbVentas.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.imbVentas.Size = new System.Drawing.Size(114, 96);
            this.imbVentas.TabIndex = 5;
            this.imbVentas.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.imbVentas);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.lblFuncionalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label lblFuncionalidad;
        private Guna.UI2.WinForms.Guna2ImageButton btnMedicamentos;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2NotificationPaint guna2NotificationPaint1;
        private Guna.UI2.WinForms.Guna2ImageButton imbVentas;
    }
}