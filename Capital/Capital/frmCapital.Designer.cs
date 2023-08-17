namespace Capital
{
    partial class frmCapital
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtPrimer = new TextBox();
            txtSegundo = new TextBox();
            txtTercero = new TextBox();
            btnPorcentaje = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(476, 46);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 0;
            label1.Text = "Capital Porcentaje";
         
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(140, 155);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Primer Hermano";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(926, 155);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 2;
            label3.Text = "Segundo Hermano";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(567, 155);
            label4.Name = "label4";
            label4.Size = new Size(115, 20);
            label4.TabIndex = 3;
            label4.Text = "Tercer Hermano";
            // 
            // txtPrimer
            // 
            txtPrimer.Location = new Point(133, 178);
            txtPrimer.Name = "txtPrimer";
            txtPrimer.Size = new Size(125, 27);
            txtPrimer.TabIndex = 4;
            // 
            // txtSegundo
            // 
            txtSegundo.Location = new Point(926, 178);
            txtSegundo.Name = "txtSegundo";
            txtSegundo.Size = new Size(125, 27);
            txtSegundo.TabIndex = 5;
            // 
            // txtTercero
            // 
            txtTercero.Location = new Point(567, 178);
            txtTercero.Name = "txtTercero";
            txtTercero.Size = new Size(125, 27);
            txtTercero.TabIndex = 6;
            // 
            // btnPorcentaje
            // 
            btnPorcentaje.Location = new Point(517, 265);
            btnPorcentaje.Name = "btnPorcentaje";
            btnPorcentaje.Size = new Size(235, 29);
            btnPorcentaje.TabIndex = 7;
            btnPorcentaje.Text = "Calcular Porcentaje";
            btnPorcentaje.UseVisualStyleBackColor = true;
            btnPorcentaje.Click += btnPorcentaje_Click;
            // 
            // frmCapital
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 379);
            Controls.Add(btnPorcentaje);
            Controls.Add(txtTercero);
            Controls.Add(txtSegundo);
            Controls.Add(txtPrimer);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCapital";
            Text = "frmCapital";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtPrimer;
        private TextBox txtSegundo;
        private TextBox txtTercero;
        private Button btnPorcentaje;
    }
}