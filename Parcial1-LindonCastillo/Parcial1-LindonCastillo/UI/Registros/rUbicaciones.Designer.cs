namespace Parcial1_LindonCastillo.UI.Registros
{
    partial class rUbicaciones
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
            this.Id_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Descripcion_textBox = new System.Windows.Forms.TextBox();
            this.Nuevo_button = new System.Windows.Forms.Button();
            this.Guardar_button = new System.Windows.Forms.Button();
            this.Eliminar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Buscar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_numericUpDown
            // 
            this.Id_numericUpDown.Location = new System.Drawing.Point(40, 46);
            this.Id_numericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Id_numericUpDown.Name = "Id_numericUpDown";
            this.Id_numericUpDown.Size = new System.Drawing.Size(114, 20);
            this.Id_numericUpDown.TabIndex = 0;
            // 
            // Descripcion_textBox
            // 
            this.Descripcion_textBox.Location = new System.Drawing.Point(40, 101);
            this.Descripcion_textBox.Name = "Descripcion_textBox";
            this.Descripcion_textBox.Size = new System.Drawing.Size(205, 20);
            this.Descripcion_textBox.TabIndex = 1;
            // 
            // Nuevo_button
            // 
            this.Nuevo_button.Location = new System.Drawing.Point(12, 166);
            this.Nuevo_button.Name = "Nuevo_button";
            this.Nuevo_button.Size = new System.Drawing.Size(79, 28);
            this.Nuevo_button.TabIndex = 2;
            this.Nuevo_button.Text = "Nuevo";
            this.Nuevo_button.UseVisualStyleBackColor = true;
            this.Nuevo_button.Click += new System.EventHandler(this.Nuevo_button_Click);
            // 
            // Guardar_button
            // 
            this.Guardar_button.Location = new System.Drawing.Point(97, 166);
            this.Guardar_button.Name = "Guardar_button";
            this.Guardar_button.Size = new System.Drawing.Size(79, 28);
            this.Guardar_button.TabIndex = 3;
            this.Guardar_button.Text = "Guardar";
            this.Guardar_button.UseVisualStyleBackColor = true;
            this.Guardar_button.Click += new System.EventHandler(this.Guardar_button_Click);
            // 
            // Eliminar_button
            // 
            this.Eliminar_button.Location = new System.Drawing.Point(182, 166);
            this.Eliminar_button.Name = "Eliminar_button";
            this.Eliminar_button.Size = new System.Drawing.Size(79, 28);
            this.Eliminar_button.TabIndex = 4;
            this.Eliminar_button.Text = "Eliminar";
            this.Eliminar_button.UseVisualStyleBackColor = true;
            this.Eliminar_button.Click += new System.EventHandler(this.Eliminar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción";
            // 
            // Buscar_button
            // 
            this.Buscar_button.Location = new System.Drawing.Point(160, 42);
            this.Buscar_button.Name = "Buscar_button";
            this.Buscar_button.Size = new System.Drawing.Size(82, 24);
            this.Buscar_button.TabIndex = 7;
            this.Buscar_button.Text = "Buscar";
            this.Buscar_button.UseVisualStyleBackColor = true;
            this.Buscar_button.Click += new System.EventHandler(this.Buscar_button_Click);
            // 
            // rUbicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 210);
            this.Controls.Add(this.Buscar_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eliminar_button);
            this.Controls.Add(this.Guardar_button);
            this.Controls.Add(this.Nuevo_button);
            this.Controls.Add(this.Descripcion_textBox);
            this.Controls.Add(this.Id_numericUpDown);
            this.Name = "rUbicaciones";
            this.Text = "rUbicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.Id_numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Id_numericUpDown;
        private System.Windows.Forms.TextBox Descripcion_textBox;
        private System.Windows.Forms.Button Nuevo_button;
        private System.Windows.Forms.Button Guardar_button;
        private System.Windows.Forms.Button Eliminar_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Buscar_button;
    }
}