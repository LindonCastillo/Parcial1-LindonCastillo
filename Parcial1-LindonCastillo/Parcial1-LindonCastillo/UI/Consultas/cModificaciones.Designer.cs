namespace Parcial1_LindonCastillo.UI.Consultas
{
    partial class cModificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cModificaciones));
            this.Filtro_comboBox = new System.Windows.Forms.ComboBox();
            this.Criterio_textBox = new System.Windows.Forms.TextBox();
            this.Consulta_dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Consultar_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Filtro_comboBox
            // 
            this.Filtro_comboBox.FormattingEnabled = true;
            this.Filtro_comboBox.Items.AddRange(new object[] {
            "Todos",
            "ProductoId",
            "Descripción"});
            this.Filtro_comboBox.Location = new System.Drawing.Point(33, 36);
            this.Filtro_comboBox.Name = "Filtro_comboBox";
            this.Filtro_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Filtro_comboBox.TabIndex = 0;
            // 
            // Criterio_textBox
            // 
            this.Criterio_textBox.Location = new System.Drawing.Point(187, 37);
            this.Criterio_textBox.Name = "Criterio_textBox";
            this.Criterio_textBox.Size = new System.Drawing.Size(255, 20);
            this.Criterio_textBox.TabIndex = 1;
            // 
            // Consulta_dataGridView
            // 
            this.Consulta_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Consulta_dataGridView.Location = new System.Drawing.Point(33, 81);
            this.Consulta_dataGridView.Name = "Consulta_dataGridView";
            this.Consulta_dataGridView.Size = new System.Drawing.Size(514, 338);
            this.Consulta_dataGridView.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Criterio";
            // 
            // Consultar_button
            // 
            this.Consultar_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.preview_search_find_locate_1551;
            this.Consultar_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultar_button.Location = new System.Drawing.Point(459, 19);
            this.Consultar_button.Name = "Consultar_button";
            this.Consultar_button.Size = new System.Drawing.Size(88, 39);
            this.Consultar_button.TabIndex = 2;
            this.Consultar_button.Text = "Consultar";
            this.Consultar_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Consultar_button.UseVisualStyleBackColor = true;
            this.Consultar_button.Click += new System.EventHandler(this.Consultar_button_Click);
            // 
            // cModificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Consulta_dataGridView);
            this.Controls.Add(this.Consultar_button);
            this.Controls.Add(this.Criterio_textBox);
            this.Controls.Add(this.Filtro_comboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cModificaciones";
            this.Text = "Consulta de Modificación de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.Consulta_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Filtro_comboBox;
        private System.Windows.Forms.TextBox Criterio_textBox;
        private System.Windows.Forms.Button Consultar_button;
        private System.Windows.Forms.DataGridView Consulta_dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}