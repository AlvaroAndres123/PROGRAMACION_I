namespace Notas
{
    partial class frmNotas
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
            txtN1 = new TextBox();
            txtN2 = new TextBox();
            txtN3 = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(452, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 46);
            label1.TabIndex = 0;
            label1.Text = "Calcular Promedio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(173, 120);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 1;
            label2.Text = "Nota 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(559, 120);
            label3.Name = "label3";
            label3.Size = new Size(72, 28);
            label3.TabIndex = 2;
            label3.Text = "Nota 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(936, 120);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 3;
            label4.Text = "Nota 3";
            // 
            // txtN1
            // 
            txtN1.Location = new Point(148, 151);
            txtN1.Name = "txtN1";
            txtN1.Size = new Size(125, 27);
            txtN1.TabIndex = 4;
            // 
            // txtN2
            // 
            txtN2.Location = new Point(530, 151);
            txtN2.Name = "txtN2";
            txtN2.Size = new Size(125, 27);
            txtN2.TabIndex = 5;
            // 
            // txtN3
            // 
            txtN3.Location = new Point(910, 151);
            txtN3.Name = "txtN3";
            txtN3.Size = new Size(125, 27);
            txtN3.TabIndex = 6;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCalcular.Location = new Point(494, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(203, 79);
            btnCalcular.TabIndex = 7;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frmNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 450);
            Controls.Add(btnCalcular);
            Controls.Add(txtN3);
            Controls.Add(txtN2);
            Controls.Add(txtN1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNotas";
            Text = "frmNotas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtN1;
        private TextBox txtN2;
        private TextBox txtN3;
        private Button btnCalcular;
    }
}