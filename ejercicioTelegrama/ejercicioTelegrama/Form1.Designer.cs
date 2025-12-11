namespace ejercicioTelegrama
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalcularPrecio = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblCoste = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdinarioBtn = new System.Windows.Forms.RadioButton();
            this.Urgentebtn = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnCalcularPrecio
            // 
            this.btnCalcularPrecio.Location = new System.Drawing.Point(469, 301);
            this.btnCalcularPrecio.Name = "btnCalcularPrecio";
            this.btnCalcularPrecio.Size = new System.Drawing.Size(92, 34);
            this.btnCalcularPrecio.TabIndex = 11;
            this.btnCalcularPrecio.Text = "Calcular";
            this.btnCalcularPrecio.UseVisualStyleBackColor = true;
            this.btnCalcularPrecio.Click += new System.EventHandler(this.btnCalcularPrecio_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(283, 322);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 10;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Location = new System.Drawing.Point(240, 322);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(37, 13);
            this.lblCoste.TabIndex = 9;
            this.lblCoste.Text = "Coste:";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(240, 133);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(321, 138);
            this.txtTelegrama.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Texto";
            // 
            // OrdinarioBtn
            // 
            this.OrdinarioBtn.AutoSize = true;
            this.OrdinarioBtn.Location = new System.Drawing.Point(240, 286);
            this.OrdinarioBtn.Name = "OrdinarioBtn";
            this.OrdinarioBtn.Size = new System.Drawing.Size(67, 17);
            this.OrdinarioBtn.TabIndex = 12;
            this.OrdinarioBtn.TabStop = true;
            this.OrdinarioBtn.Text = "Ordinario";
            this.OrdinarioBtn.UseVisualStyleBackColor = true;
            this.OrdinarioBtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Urgentebtn
            // 
            this.Urgentebtn.AutoSize = true;
            this.Urgentebtn.Location = new System.Drawing.Point(316, 286);
            this.Urgentebtn.Name = "Urgentebtn";
            this.Urgentebtn.Size = new System.Drawing.Size(63, 17);
            this.Urgentebtn.TabIndex = 13;
            this.Urgentebtn.TabStop = true;
            this.Urgentebtn.Text = "Urgente";
            this.Urgentebtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Urgentebtn);
            this.Controls.Add(this.OrdinarioBtn);
            this.Controls.Add(this.btnCalcularPrecio);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblCoste);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcularPrecio;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton OrdinarioBtn;
        private System.Windows.Forms.RadioButton Urgentebtn;
    }
}

