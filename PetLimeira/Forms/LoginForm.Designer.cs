namespace PetLimeira.Forms
{
    partial class LoginForm
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
            pbLogo = new PictureBox();
            lblTitulo = new Label();
            lblLogin = new Label();
            panel1 = new Panel();
            ipUsuario = new FontAwesome.Sharp.IconPictureBox();
            txtLogin = new TextBox();
            lblUsuario = new Label();
            panel2 = new Panel();
            ipSenha = new FontAwesome.Sharp.IconPictureBox();
            txtSenha = new TextBox();
            lblSenha = new Label();
            cbLembrar = new CheckBox();
            lblEsqueci = new Label();
            btnEntrar = new Button();
            btnCancelar = new Button();
            lblPossuirConta = new Label();
            lbConta = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipUsuario).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ipSenha).BeginInit();
            SuspendLayout();
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.download___Copia;
            pbLogo.Location = new Point(197, 39);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(70, 50);
            pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(184, 111);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(96, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Bem Vindo";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblLogin.Location = new Point(124, 131);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(216, 16);
            lblLogin.TabIndex = 2;
            lblLogin.Text = "Entre com sua conta para continuar";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(ipUsuario);
            panel1.Controls.Add(txtLogin);
            panel1.Location = new Point(57, 210);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 64);
            panel1.TabIndex = 3;
            // 
            // ipUsuario
            // 
            ipUsuario.BackColor = SystemColors.Window;
            ipUsuario.ForeColor = SystemColors.ControlText;
            ipUsuario.IconChar = FontAwesome.Sharp.IconChar.User;
            ipUsuario.IconColor = SystemColors.ControlText;
            ipUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipUsuario.IconSize = 24;
            ipUsuario.Location = new Point(314, 23);
            ipUsuario.Name = "ipUsuario";
            ipUsuario.Size = new Size(24, 24);
            ipUsuario.TabIndex = 5;
            ipUsuario.TabStop = false;
            // 
            // txtLogin
            // 
            txtLogin.BorderStyle = BorderStyle.None;
            txtLogin.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Millimeter);
            txtLogin.Location = new Point(18, 16);
            txtLogin.Name = "txtLogin";
            txtLogin.PlaceholderText = "Login";
            txtLogin.Size = new Size(332, 31);
            txtLogin.TabIndex = 4;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUsuario.Location = new Point(57, 190);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(54, 17);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.Controls.Add(ipSenha);
            panel2.Controls.Add(txtSenha);
            panel2.Location = new Point(57, 314);
            panel2.Name = "panel2";
            panel2.Size = new Size(350, 64);
            panel2.TabIndex = 5;
            // 
            // ipSenha
            // 
            ipSenha.BackColor = SystemColors.Window;
            ipSenha.ForeColor = SystemColors.ControlText;
            ipSenha.IconChar = FontAwesome.Sharp.IconChar.Eye;
            ipSenha.IconColor = SystemColors.ControlText;
            ipSenha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ipSenha.IconSize = 24;
            ipSenha.Location = new Point(314, 23);
            ipSenha.Name = "ipSenha";
            ipSenha.Size = new Size(24, 24);
            ipSenha.TabIndex = 5;
            ipSenha.TabStop = false;
            ipSenha.Click += ipSenha_Click_1;
            // 
            // txtSenha
            // 
            txtSenha.BorderStyle = BorderStyle.None;
            txtSenha.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Millimeter);
            txtSenha.Location = new Point(18, 16);
            txtSenha.Name = "txtSenha";
            txtSenha.PlaceholderText = "Senha";
            txtSenha.Size = new Size(332, 31);
            txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSenha.Location = new Point(57, 294);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(45, 17);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha";
            // 
            // cbLembrar
            // 
            cbLembrar.AutoSize = true;
            cbLembrar.Font = new Font("Microsoft Sans Serif", 9.75F);
            cbLembrar.Location = new Point(57, 384);
            cbLembrar.Name = "cbLembrar";
            cbLembrar.Size = new Size(95, 20);
            cbLembrar.TabIndex = 7;
            cbLembrar.Text = "Lembra-me";
            cbLembrar.UseVisualStyleBackColor = true;
            // 
            // lblEsqueci
            // 
            lblEsqueci.AutoSize = true;
            lblEsqueci.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblEsqueci.ForeColor = SystemColors.Highlight;
            lblEsqueci.Location = new Point(272, 384);
            lblEsqueci.Name = "lblEsqueci";
            lblEsqueci.Size = new Size(135, 16);
            lblEsqueci.TabIndex = 8;
            lblEsqueci.Text = "Esqueci minha senha";
            lblEsqueci.Click += lblEsqueci_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnEntrar.Location = new Point(57, 439);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(170, 42);
            btnEntrar.TabIndex = 10;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnCancelar.Location = new Point(237, 439);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(170, 42);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPossuirConta
            // 
            lblPossuirConta.AutoSize = true;
            lblPossuirConta.Font = new Font("Microsoft Sans Serif", 9.75F);
            lblPossuirConta.Location = new Point(84, 500);
            lblPossuirConta.Name = "lblPossuirConta";
            lblPossuirConta.Size = new Size(183, 16);
            lblPossuirConta.TabIndex = 12;
            lblPossuirConta.Text = "Ainda não possui uma conta?";
            // 
            // lbConta
            // 
            lbConta.AutoSize = true;
            lbConta.Font = new Font("Microsoft Sans Serif", 9.75F);
            lbConta.LinkColor = SystemColors.Highlight;
            lbConta.Location = new Point(273, 501);
            lbConta.Name = "lbConta";
            lbConta.Size = new Size(71, 16);
            lbConta.TabIndex = 13;
            lbConta.TabStop = true;
            lbConta.Text = "Criar conta";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(464, 641);
            Controls.Add(lbConta);
            Controls.Add(lblPossuirConta);
            Controls.Add(btnCancelar);
            Controls.Add(btnEntrar);
            Controls.Add(lblEsqueci);
            Controls.Add(cbLembrar);
            Controls.Add(lblSenha);
            Controls.Add(panel2);
            Controls.Add(lblUsuario);
            Controls.Add(panel1);
            Controls.Add(lblLogin);
            Controls.Add(lblTitulo);
            Controls.Add(pbLogo);
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login-Acesso ao Sistema";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipUsuario).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ipSenha).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLogo;
        private Label lblTitulo;
        private Label lblLogin;
        private Panel panel1;
        private TextBox txtLogin;
        private FontAwesome.Sharp.IconPictureBox ipUsuario;
        private Label lblUsuario;
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox ipSenha;
        private TextBox txtSenha;
        private Label lblSenha;
        private CheckBox cbLembrar;
        private Label lblEsqueci;
        private Button btnEntrar;
        private Button btnCancelar;
        private Label lblPossuirConta;
        private LinkLabel lbConta;
    }
}