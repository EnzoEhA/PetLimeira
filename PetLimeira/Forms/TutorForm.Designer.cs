namespace PetLimeira.Forms
{
    partial class TutoresForm
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
            groupBox1 = new GroupBox();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            txtTelefone3 = new TextBox();
            txtTelefone2 = new TextBox();
            txtTelefone1 = new TextBox();
            label1 = new Label();
            txtRua = new TextBox();
            txtCidade = new TextBox();
            txtNumero = new TextBox();
            txtCep = new TextBox();
            txtBairro = new TextBox();
            txtCpf = new TextBox();
            txtNome = new TextBox();
            dataGridView1 = new DataGridView();
            txtCampoBusca = new TextBox();
            btnBuscar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtTelefone3);
            groupBox1.Controls.Add(txtTelefone2);
            groupBox1.Controls.Add(txtTelefone1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtRua);
            groupBox1.Controls.Add(txtCidade);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(txtCep);
            groupBox1.Controls.Add(txtBairro);
            groupBox1.Controls.Add(txtCpf);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(12, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 461);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Tutor";
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(302, 411);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(79, 30);
            btnLimpar.TabIndex = 14;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(210, 411);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(86, 30);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnAtualizar
            // 
            btnAtualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAtualizar.Location = new Point(107, 410);
            btnAtualizar.Name = "btnAtualizar";
            btnAtualizar.Size = new Size(84, 30);
            btnAtualizar.TabIndex = 12;
            btnAtualizar.Text = "Atualizar";
            btnAtualizar.UseVisualStyleBackColor = true;
            btnAtualizar.Click += btnAtualizar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionar.Location = new Point(6, 411);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(84, 29);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "Add";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtTelefone3
            // 
            txtTelefone3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone3.Location = new Point(6, 165);
            txtTelefone3.Name = "txtTelefone3";
            txtTelefone3.PlaceholderText = "Telefone";
            txtTelefone3.Size = new Size(168, 27);
            txtTelefone3.TabIndex = 10;
            txtTelefone3.TextChanged += txtTelefone3_TextChanged;
            txtTelefone3.KeyPress += txtTelefone3_KeyPress;
            // 
            // txtTelefone2
            // 
            txtTelefone2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone2.Location = new Point(6, 132);
            txtTelefone2.Name = "txtTelefone2";
            txtTelefone2.PlaceholderText = "Telefone";
            txtTelefone2.Size = new Size(168, 27);
            txtTelefone2.TabIndex = 9;
            txtTelefone2.KeyPress += txtTelefone2_KeyPress;
            // 
            // txtTelefone1
            // 
            txtTelefone1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTelefone1.Location = new Point(6, 99);
            txtTelefone1.Name = "txtTelefone1";
            txtTelefone1.PlaceholderText = "Telefone (Obrigatório)";
            txtTelefone1.Size = new Size(168, 27);
            txtTelefone1.TabIndex = 8;
            txtTelefone1.TextChanged += txtTelefone1_TextChanged;
            txtTelefone1.KeyPress += txtTelefone1_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 205);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 7;
            label1.Text = "Endereço :";
            label1.Click += label1_Click;
            // 
            // txtRua
            // 
            txtRua.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRua.Location = new Point(6, 271);
            txtRua.Name = "txtRua";
            txtRua.PlaceholderText = "Rua";
            txtRua.Size = new Size(344, 27);
            txtRua.TabIndex = 6;
            // 
            // txtCidade
            // 
            txtCidade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCidade.Location = new Point(6, 358);
            txtCidade.Name = "txtCidade";
            txtCidade.PlaceholderText = "Cidade";
            txtCidade.Size = new Size(344, 27);
            txtCidade.TabIndex = 5;
            // 
            // txtNumero
            // 
            txtNumero.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumero.Location = new Point(123, 228);
            txtNumero.Name = "txtNumero";
            txtNumero.PlaceholderText = "Número";
            txtNumero.Size = new Size(100, 27);
            txtNumero.TabIndex = 4;
            txtNumero.TextChanged += txtNumero_TextChanged;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // txtCep
            // 
            txtCep.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCep.Location = new Point(6, 228);
            txtCep.Name = "txtCep";
            txtCep.PlaceholderText = "CEP";
            txtCep.Size = new Size(100, 27);
            txtCep.TabIndex = 3;
            txtCep.KeyPress += txtCep_KeyPress;
            // 
            // txtBairro
            // 
            txtBairro.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBairro.Location = new Point(6, 315);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(344, 27);
            txtBairro.TabIndex = 2;
            txtBairro.Text = "Bairro";
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCpf.Location = new Point(6, 66);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(120, 27);
            txtCpf.TabIndex = 1;
            txtCpf.TextChanged += textBox2_TextChanged;
            txtCpf.KeyPress += txtCpf_KeyPress;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(6, 33);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome Completo";
            txtNome.Size = new Size(168, 27);
            txtNome.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(425, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 424);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtCampoBusca
            // 
            txtCampoBusca.Location = new Point(425, 41);
            txtCampoBusca.Name = "txtCampoBusca";
            txtCampoBusca.PlaceholderText = "Buscar por nome";
            txtCampoBusca.Size = new Size(164, 23);
            txtCampoBusca.TabIndex = 2;
            txtCampoBusca.TextChanged += txtCampoBusca_TextChanged;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(606, 40);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // TutoresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 601);
            Controls.Add(btnBuscar);
            Controls.Add(txtCampoBusca);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Name = "TutoresForm";
            Text = "Tutores";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtCpf;
        private TextBox txtNome;
        private TextBox txtRua;
        private TextBox txtCidade;
        private TextBox txtNumero;
        private TextBox txtCep;
        private TextBox txtBairro;
        private Label label1;
        private TextBox txtTelefone3;
        private TextBox txtTelefone2;
        private TextBox txtTelefone1;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private DataGridView dataGridView1;
        private TextBox txtCampoBusca;
        private Button btnBuscar;
    }
}