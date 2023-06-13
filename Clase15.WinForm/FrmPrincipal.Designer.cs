namespace Clase15.WinForm
{
    partial class FrmPrincipal
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
            btnCrearJugador = new Button();
            label1 = new Label();
            btnTerminarPartida = new Button();
            SuspendLayout();
            // 
            // btnCrearJugador
            // 
            btnCrearJugador.Location = new Point(165, 354);
            btnCrearJugador.Name = "btnCrearJugador";
            btnCrearJugador.Size = new Size(176, 84);
            btnCrearJugador.TabIndex = 0;
            btnCrearJugador.Text = "Crear jugador";
            btnCrearJugador.UseVisualStyleBackColor = true;
            btnCrearJugador.Click += btnCrearJugador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(148, 146);
            label1.Name = "label1";
            label1.Size = new Size(166, 65);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // btnTerminarPartida
            // 
            btnTerminarPartida.Location = new Point(377, 354);
            btnTerminarPartida.Name = "btnTerminarPartida";
            btnTerminarPartida.Size = new Size(176, 84);
            btnTerminarPartida.TabIndex = 2;
            btnTerminarPartida.Text = "Terminar partida";
            btnTerminarPartida.UseVisualStyleBackColor = true;
            btnTerminarPartida.Click += btnTerminarPartida_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 450);
            Controls.Add(btnTerminarPartida);
            Controls.Add(label1);
            Controls.Add(btnCrearJugador);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearJugador;
        private Label label1;
        private Button btnTerminarPartida;
    }
}