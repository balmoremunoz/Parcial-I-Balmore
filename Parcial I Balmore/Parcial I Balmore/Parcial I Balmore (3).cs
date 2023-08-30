namespace Parcial_I_Kimberly
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblDe = new Label();
            lblA = new Label();
            label3 = new Label();
            btnConvertir = new Button();
            btnSalir = new Button();
            lblCantidad = new Label();
            txtCantidadConversor = new TextBox();
            CboDeConversor = new ComboBox();
            CboAconversor = new ComboBox();
            lblRespuesta = new Label();
            SuspendLayout();
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDe.Location = new Point(34, 67);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(35, 21);
            lblDe.TabIndex = 0;
            lblDe.Text = "De:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblA.Location = new Point(34, 121);
            lblA.Name = "lblA";
            lblA.Size = new Size(27, 21);
            lblA.TabIndex = 1;
            lblA.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(114, 23);
            label3.Name = "label3";
            label3.Size = new Size(120, 21);
            label3.TabIndex = 2;
            label3.Text = "Convertir Área";
            label3.Click += label3_Click;
            // 
            // btnConvertir
            // 
            btnConvertir.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnConvertir.Location = new Point(36, 278);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(118, 33);
            btnConvertir.TabIndex = 3;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = true;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSalir.Location = new Point(184, 278);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 33);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCantidad.Location = new Point(34, 169);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(81, 21);
            lblCantidad.TabIndex = 5;
            lblCantidad.Text = "Cantidad:";
            lblCantidad.Click += label4_Click;
            // 
            // txtCantidadConversor
            // 
            txtCantidadConversor.Location = new Point(121, 169);
            txtCantidadConversor.Name = "txtCantidadConversor";
            txtCantidadConversor.Size = new Size(164, 23);
            txtCantidadConversor.TabIndex = 6;
            // 
            // CboDeConversor
            // 
            CboDeConversor.FormattingEnabled = true;
            CboDeConversor.Items.AddRange(new object[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea " });
            CboDeConversor.Location = new Point(75, 68);
            CboDeConversor.Name = "CboDeConversor";
            CboDeConversor.Size = new Size(210, 23);
            CboDeConversor.TabIndex = 7;
            // 
            // CboAconversor
            // 
            CboAconversor.FormattingEnabled = true;
            CboAconversor.Items.AddRange(new object[] { "Pie Cuadrado", "Vara Cuadrada", "Yarda Cuadrada", "Metro Cuadrado", "Tareas", "Manzana", "Hectárea " });
            CboAconversor.Location = new Point(75, 122);
            CboAconversor.Name = "CboAconversor";
            CboAconversor.Size = new Size(210, 23);
            CboAconversor.TabIndex = 8;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblRespuesta.Location = new Point(34, 229);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(96, 21);
            lblRespuesta.TabIndex = 9;
            lblRespuesta.Text = "Respuesta: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 349);
            Controls.Add(lblRespuesta);
            Controls.Add(CboAconversor);
            Controls.Add(CboDeConversor);
            Controls.Add(txtCantidadConversor);
            Controls.Add(lblCantidad);
            Controls.Add(btnSalir);
            Controls.Add(btnConvertir);
            Controls.Add(label3);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDe;
        private Label lblA;
        private Label label3;
        private Button btnConvertir;
        private Button btnSalir;
        private Label lblCantidad;
        private TextBox txtCantidadConversor;
        private ComboBox CboDeConversor;
        private ComboBox CboAconversor;
        private Label lblRespuesta;
    }
}