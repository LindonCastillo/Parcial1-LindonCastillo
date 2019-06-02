namespace Parcial1_LindonCastillo.UI.Consultas
{
    partial class cValorInventarioTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cValorInventarioTotal));
            this.ValorInventarioTotal_textBox = new System.Windows.Forms.TextBox();
            this.Actualizar_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValorInventarioTotal_textBox
            // 
            this.ValorInventarioTotal_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValorInventarioTotal_textBox.Location = new System.Drawing.Point(48, 115);
            this.ValorInventarioTotal_textBox.Name = "ValorInventarioTotal_textBox";
            this.ValorInventarioTotal_textBox.Size = new System.Drawing.Size(313, 38);
            this.ValorInventarioTotal_textBox.TabIndex = 1;
            // 
            // Actualizar_button
            // 
            this.Actualizar_button.Image = global::Parcial1_LindonCastillo.Properties.Resources.Sync_Icon;
            this.Actualizar_button.Location = new System.Drawing.Point(384, 115);
            this.Actualizar_button.Name = "Actualizar_button";
            this.Actualizar_button.Size = new System.Drawing.Size(43, 38);
            this.Actualizar_button.TabIndex = 0;
            this.Actualizar_button.UseVisualStyleBackColor = true;
            this.Actualizar_button.Click += new System.EventHandler(this.Actualizar_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total de Inventario";
            // 
            // cValorInventarioTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 187);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorInventarioTotal_textBox);
            this.Controls.Add(this.Actualizar_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cValorInventarioTotal";
            this.Text = "Ver Valor Total de Inventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Actualizar_button;
        private System.Windows.Forms.TextBox ValorInventarioTotal_textBox;
        private System.Windows.Forms.Label label1;
    }
}