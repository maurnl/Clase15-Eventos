namespace Clase15.WinForm
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
            btnAdivinar = new Button();
            txtNumero = new TextBox();
            lblTitulo = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // btnAdivinar
            // 
            btnAdivinar.Location = new Point(132, 269);
            btnAdivinar.Name = "btnAdivinar";
            btnAdivinar.Size = new Size(169, 75);
            btnAdivinar.TabIndex = 0;
            btnAdivinar.Text = "Adivinar";
            btnAdivinar.UseVisualStyleBackColor = true;
            btnAdivinar.Click += btnAdivinar_Click;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(118, 143);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(194, 23);
            txtNumero.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(115, 59);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 25);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Adivina un numero!!";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblResultado.Location = new Point(96, 200);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(83, 32);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 372);
            Controls.Add(lblResultado);
            Controls.Add(lblTitulo);
            Controls.Add(txtNumero);
            Controls.Add(btnAdivinar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdivinar;
        private TextBox txtNumero;
        private Label lblTitulo;
        private Label lblResultado;
    }
}