namespace DistribuidoraBebidas.Forms
{
    partial class Form2
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
            lblToken = new Label();
            label2 = new Label();
            lblAguardando = new Label();
            btnSolicitar = new Button();
            btnReset = new Button();
            label3 = new Label();
            btnEnviarAccess = new Button();
            lblAcessTest = new Label();
            btnGetAll = new Button();
            SuspendLayout();
            // 
            // lblToken
            // 
            lblToken.AutoSize = true;
            lblToken.Location = new Point(384, 100);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(38, 15);
            lblToken.TabIndex = 1;
            lblToken.Text = "Token";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 35);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 2;
            label2.Text = "HandShake";
            // 
            // lblAguardando
            // 
            lblAguardando.AutoSize = true;
            lblAguardando.Location = new Point(193, 35);
            lblAguardando.Name = "lblAguardando";
            lblAguardando.Size = new Size(132, 15);
            lblAguardando.TabIndex = 3;
            lblAguardando.Text = "Aguardando solicitação";
            // 
            // btnSolicitar
            // 
            btnSolicitar.Location = new Point(103, 31);
            btnSolicitar.Name = "btnSolicitar";
            btnSolicitar.Size = new Size(75, 23);
            btnSolicitar.TabIndex = 4;
            btnSolicitar.Text = "Solicitar";
            btnSolicitar.UseVisualStyleBackColor = true;
            btnSolicitar.Click += btnSolicitar_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(216, 53);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 6;
            label3.Text = "Accsess Test";
            // 
            // btnEnviarAccess
            // 
            btnEnviarAccess.Location = new Point(103, 96);
            btnEnviarAccess.Name = "btnEnviarAccess";
            btnEnviarAccess.Size = new Size(75, 23);
            btnEnviarAccess.TabIndex = 7;
            btnEnviarAccess.Text = "Enviar";
            btnEnviarAccess.UseVisualStyleBackColor = true;
            btnEnviarAccess.Click += btnEnviarAccess_Click;
            // 
            // lblAcessTest
            // 
            lblAcessTest.AutoSize = true;
            lblAcessTest.Location = new Point(193, 100);
            lblAcessTest.Name = "lblAcessTest";
            lblAcessTest.Size = new Size(99, 15);
            lblAcessTest.TabIndex = 8;
            lblAcessTest.Text = "Enviar Solicitação";
            // 
            // btnGetAll
            // 
            btnGetAll.Location = new Point(357, 179);
            btnGetAll.Name = "btnGetAll";
            btnGetAll.Size = new Size(75, 23);
            btnGetAll.TabIndex = 9;
            btnGetAll.Text = "btnGetAll";
            btnGetAll.UseVisualStyleBackColor = true;
            btnGetAll.Click += btnGetAll_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGetAll);
            Controls.Add(lblAcessTest);
            Controls.Add(btnEnviarAccess);
            Controls.Add(label3);
            Controls.Add(btnReset);
            Controls.Add(btnSolicitar);
            Controls.Add(lblAguardando);
            Controls.Add(label2);
            Controls.Add(lblToken);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblToken;
        private Label label2;
        private Label lblAguardando;
        private Button btnSolicitar;
        private Button btnReset;
        private Label label3;
        private Button btnEnviarAccess;
        private Label lblAcessTest;
        private Button btnGetAll;
    }
}