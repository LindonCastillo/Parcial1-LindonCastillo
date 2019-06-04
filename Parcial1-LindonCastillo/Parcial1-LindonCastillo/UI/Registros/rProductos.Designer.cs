namespace Parcial1_LindonCastillo.UI.Registros
{
    partial class rProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rProductos));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoId_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Existencia_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Costo_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ValorInventario_textBox = new System.Windows.Forms.TextBox();
            this.Buscar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.Ubicacion_comboBox = new System.Windows.Forms.ComboBox();
            this.RegistroUbicacion_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoId_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Costo_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductoId";
            // 
            // ProductoId_numericUpDown
            // 
            this.ProductoId_numericUpDown.Location = new System.Drawing.Point(159, 45);
            this.ProductoId_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ProductoId_numericUpDown.Name = "ProductoId_numericUpDown";
            this.ProductoId_numericUpDown.Size = new System.Drawing.Size(146, 20);
            this.ProductoId_numericUpDown.TabIndex = 1;
            // 
            // Existencia_numericUpDown
            // 
            this.Existencia_numericUpDown.Location = new System.Drawing.Point(159, 162);
            this.Existencia_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Existencia_numericUpDown.Name = "Existencia_numericUpDown";
            this.Existencia_numericUpDown.Size = new System.Drawing.Size(146, 20);
            this.Existencia_numericUpDown.TabIndex = 3;
            this.Existencia_numericUpDown.ValueChanged += new System.EventHandler(this.Existencia_numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Existencia";
            // 
            // Costo_numericUpDown
            // 
            this.Costo_numericUpDown.Location = new System.Drawing.Point(159, 219);
            this.Costo_numericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.Costo_numericUpDown.Name = "Costo_numericUpDown";
            this.Costo_numericUpDown.Size = new System.Drawing.Size(146, 20);
            this.Costo_numericUpDown.TabIndex = 5;
            this.Costo_numericUpDown.ValueChanged += new System.EventHandler(this.Costo_numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Costo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Inventario";
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(159, 107);
            this.Descripcion_textBox.MaxLength = 100;
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(249, 20);
            this.Descripcion_textBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descripcion";
            // 
            // ValorInventario_textBox
            // 
            this.ValorInventario_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ValorInventario_textBox.Enabled = false;
            this.ValorInventario_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorInventario_textBox.Location = new System.Drawing.Point(159, 330);
            this.ValorInventario_textBox.Name = "ValorInventario_textBox";
            this.ValorInventario_textBox.Size = new System.Drawing.Size(146, 22);
            this.ValorInventario_textBox.TabIndex = 10;
            // 
            // Buscar_button
            // 
            this.Buscar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscar_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.icono;
            this.Buscar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscar_button.Location = new System.Drawing.Point(320, 35);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(88, 36);
            this.Buscar_button.TabIndex = 14;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.delete_icon;
            this.Eliminar_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminar_button.Location = new System.Drawing.Point(312, 375);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(96, 57);
            this.Eliminar_button.TabIndex = 13;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.Save_black_512_icon;
            this.Guardar_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardar_button.Location = new System.Drawing.Point(175, 375);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(97, 57);
            this.Guardar_button.TabIndex = 12;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.application_add_512_icon;
            this.Nuevo_button.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevo_button.Location = new System.Drawing.Point(37, 375);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(97, 57);
            this.Nuevo_button.TabIndex = 11;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ubicación";
            // 
            // Ubicacion_comboBox
            // 
            this.Ubicacion_comboBox.FormattingEnabled = true;
            this.Ubicacion_comboBox.Location = new System.Drawing.Point(159, 272);
            this.Ubicacion_comboBox.Name = "Ubicacion_comboBox";
            this.Ubicacion_comboBox.Size = new System.Drawing.Size(207, 21);
            this.Ubicacion_comboBox.TabIndex = 16;
            // 
            // RegistroUbicacion_button
            // 
            this.RegistroUbicacion_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistroUbicacion_button.Location = new System.Drawing.Point(376, 263);
            this.RegistroUbicacion_button.Name = "RegistroUbicacion_button";
            this.RegistroUbicacion_button.Size = new System.Drawing.Size(32, 32);
            this.RegistroUbicacion_button.TabIndex = 17;
            this.RegistroUbicacion_button.Text = "+";
            this.RegistroUbicacion_button.UseVisualStyleBackColor = true;
            this.RegistroUbicacion_button.Click += new System.EventHandler(this.RegistroUbicacion_button_Click);
            // 
            // rProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 462);
            this.Controls.Add(this.RegistroUbicacion_button);
            this.Controls.Add(this.Ubicacion_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.ValorInventario_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Costo_numericUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Existencia_numericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductoId_numericUpDown);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "rProductos";
            this.Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.ProductoId_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Existencia_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Costo_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ProductoId_numericUpDown;
        private System.Windows.Forms.NumericUpDown Existencia_numericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Costo_numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ValorInventario_textBox;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Button Buscar_button;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button RegistroUbicacion_button;
        private System.Windows.Forms.ComboBox Ubicacion_comboBox;
        private System.Windows.Forms.Label label6;
    }
}