
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
            this.NPMedicamentos = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.btnPedidos = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLaboratorio = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnEmpleados = new Guna.UI2.WinForms.Guna2ImageButton();
            this.npEmpleados = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
            this.npUsuarios = new Guna.UI2.WinForms.Guna2NotificationPaint(this.components);
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
            this.lblFuncionalidad.Size = new System.Drawing.Size(259, 32);
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
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
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
            // NPMedicamentos
            // 
            this.NPMedicamentos.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.NPMedicamentos.BorderRadius = 8;
            this.NPMedicamentos.Location = new System.Drawing.Point(96, 0);
            this.NPMedicamentos.TargetControl = this.btnMedicamentos;
            // 
            // btnPedidos
            // 
            this.btnPedidos.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPedidos.ImageRotate = 0F;
            this.btnPedidos.ImageSize = new System.Drawing.Size(80, 80);
            this.btnPedidos.Location = new System.Drawing.Point(570, 114);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnPedidos.Size = new System.Drawing.Size(114, 96);
            this.btnPedidos.TabIndex = 5;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(80, 80);
            this.guna2ImageButton1.Location = new System.Drawing.Point(417, 114);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2ImageButton1.Size = new System.Drawing.Size(114, 96);
            this.guna2ImageButton1.TabIndex = 6;
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnLaboratorio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLaboratorio.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnLaboratorio.Image = ((System.Drawing.Image)(resources.GetObject("btnLaboratorio.Image")));
            this.btnLaboratorio.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnLaboratorio.ImageRotate = 0F;
            this.btnLaboratorio.ImageSize = new System.Drawing.Size(80, 80);
            this.btnLaboratorio.Location = new System.Drawing.Point(267, 114);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnLaboratorio.Size = new System.Drawing.Size(114, 96);
            this.btnLaboratorio.TabIndex = 7;
            this.btnLaboratorio.Click += new System.EventHandler(this.btnLaboratorio_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnUsuarios.ImageRotate = 0F;
            this.btnUsuarios.ImageSize = new System.Drawing.Size(80, 80);
            this.btnUsuarios.Location = new System.Drawing.Point(705, 114);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnUsuarios.Size = new System.Drawing.Size(114, 96);
            this.btnUsuarios.TabIndex = 12;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.HoverState.ImageSize = new System.Drawing.Size(75, 75);
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEmpleados.ImageRotate = 0F;
            this.btnEmpleados.ImageSize = new System.Drawing.Size(80, 80);
            this.btnEmpleados.Location = new System.Drawing.Point(841, 114);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.PressedState.ImageSize = new System.Drawing.Size(70, 70);
            this.btnEmpleados.Size = new System.Drawing.Size(114, 96);
            this.btnEmpleados.TabIndex = 13;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // npEmpleados
            // 
            this.npEmpleados.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.npEmpleados.Location = new System.Drawing.Point(96, 0);
            this.npEmpleados.TargetControl = this.btnEmpleados;
            this.npEmpleados.Visible = false;
            // 
            // npUsuarios
            // 
            this.npUsuarios.Alignment = Guna.UI2.WinForms.Enums.CustomContentAlignment.TopRight;
            this.npUsuarios.Location = new System.Drawing.Point(96, 0);
            this.npUsuarios.TargetControl = this.btnUsuarios;
            this.npUsuarios.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnLaboratorio);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.btnMedicamentos);
            this.Controls.Add(this.lblFuncionalidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.Activated += new System.EventHandler(this.FrmPrincipal_Activated);
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
        private Guna.UI2.WinForms.Guna2NotificationPaint NPMedicamentos;
        private Guna.UI2.WinForms.Guna2ImageButton btnPedidos;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2ImageButton btnLaboratorio;
        private Guna.UI2.WinForms.Guna2ImageButton btnEmpleados;
        private Guna.UI2.WinForms.Guna2ImageButton btnUsuarios;
        private Guna.UI2.WinForms.Guna2NotificationPaint npEmpleados;
        private Guna.UI2.WinForms.Guna2NotificationPaint npUsuarios;
    }
}