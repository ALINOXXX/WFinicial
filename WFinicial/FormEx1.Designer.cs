namespace WFinicial
{
    partial class FormEx1
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
            label1 = new Label();
            btncalcular = new Button();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            lblNota1 = new Label();
            lblNota2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 65);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // btncalcular
            // 
            btncalcular.Location = new Point(127, 177);
            btncalcular.Name = "btncalcular";
            btncalcular.Size = new Size(75, 23);
            btncalcular.TabIndex = 1;
            btncalcular.Text = "Calcular Média";
            btncalcular.UseVisualStyleBackColor = true;
            btncalcular.Click += btncalcular_Click_1;
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(102, 83);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(100, 23);
            txtNota1.TabIndex = 2;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(102, 128);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(100, 23);
            txtNota2.TabIndex = 3;
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(51, 86);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(45, 15);
            lblNota1.TabIndex = 4;
            lblNota1.Text = "Nota 1:";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(51, 136);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(45, 15);
            lblNota2.TabIndex = 5;
            lblNota2.Text = "Nota 2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(btncalcular);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Calcular Média das Notas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btncalcular;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private Label lblNota1;
        private Label lblNota2;
    }
}
