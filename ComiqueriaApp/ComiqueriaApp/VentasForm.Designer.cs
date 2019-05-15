namespace ComiqueriaApp
{
    partial class VentasForm
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
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnVender = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblPrecioFinal = new System.Windows.Forms.Label();
            this.lblNumeroPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(30, 21);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(288, 37);
            this.lblDescripcion.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(30, 58);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad";
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(33, 83);
            this.numericUpDownCantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCantidad.TabIndex = 2;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.ValueChanged += new System.EventHandler(this.numericUpDownCantidad_ValueChanged);
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(33, 149);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 3;
            this.btnVender.Text = "Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(187, 149);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblPrecioFinal
            // 
            this.lblPrecioFinal.AutoSize = true;
            this.lblPrecioFinal.Location = new System.Drawing.Point(184, 85);
            this.lblPrecioFinal.Name = "lblPrecioFinal";
            this.lblPrecioFinal.Size = new System.Drawing.Size(77, 13);
            this.lblPrecioFinal.TabIndex = 5;
            this.lblPrecioFinal.Text = "Precio Final:  $";
            // 
            // lblNumeroPrecio
            // 
            this.lblNumeroPrecio.Location = new System.Drawing.Point(258, 85);
            this.lblNumeroPrecio.Name = "lblNumeroPrecio";
            this.lblNumeroPrecio.Size = new System.Drawing.Size(76, 23);
            this.lblNumeroPrecio.TabIndex = 0;
            this.lblNumeroPrecio.Text = "XX.XX";
            // 
            // VentasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 218);
            this.Controls.Add(this.lblNumeroPrecio);
            this.Controls.Add(this.lblPrecioFinal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.numericUpDownCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDescripcion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nueva Venta";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioFinal;
        private System.Windows.Forms.Label lblNumeroPrecio;
    }
}