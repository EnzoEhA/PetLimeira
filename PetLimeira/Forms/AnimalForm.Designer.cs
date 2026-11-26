namespace PetLimeira.Forms
{
    partial class AnimalForm
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
            btnBuscar = new Button();
            btnLimpar = new Button();
            btnExcluir = new Button();
            btnAtualizar = new Button();
            btnAdicionar = new Button();
            txtIdade = new TextBox();
            txtRaca = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            txtPeso = new TextBox();
            txtEspecie = new TextBox();
            txtNome = new TextBox();
            txtCampoBusca = new TextBox();
            groupBox1 = new GroupBox();
            cmbTelefoneTutor = new ComboBox();
            cmbCpfTutor = new ComboBox();
            cmbNomeTutor = new ComboBox();
            cmbSexo = new ComboBox();
            lbDadosTutor = new Label();
            cmbCastrado = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(624, 62);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
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
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIdade.Location = new Point(6, 154);
            txtIdade.Name = "txtIdade";
            txtIdade.PlaceholderText = "Idade";
            txtIdade.Size = new Size(168, 27);
            txtIdade.TabIndex = 10;
            // 
            // txtRaca
            // 
            txtRaca.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRaca.Location = new Point(6, 88);
            txtRaca.Name = "txtRaca";
            txtRaca.PlaceholderText = "Raça";
            txtRaca.Size = new Size(168, 27);
            txtRaca.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 165);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(443, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(443, 424);
            dataGridView1.TabIndex = 5;
            // 
            // txtPeso
            // 
            txtPeso.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPeso.Location = new Point(6, 187);
            txtPeso.Name = "txtPeso";
            txtPeso.PlaceholderText = "Peso";
            txtPeso.Size = new Size(168, 27);
            txtPeso.TabIndex = 4;
            // 
            // txtEspecie
            // 
            txtEspecie.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEspecie.Location = new Point(6, 55);
            txtEspecie.Name = "txtEspecie";
            txtEspecie.PlaceholderText = "Espécie";
            txtEspecie.Size = new Size(168, 27);
            txtEspecie.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(6, 22);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome";
            txtNome.Size = new Size(168, 27);
            txtNome.TabIndex = 0;
            // 
            // txtCampoBusca
            // 
            txtCampoBusca.Location = new Point(443, 63);
            txtCampoBusca.Name = "txtCampoBusca";
            txtCampoBusca.PlaceholderText = "Buscar por nome";
            txtCampoBusca.Size = new Size(164, 23);
            txtCampoBusca.TabIndex = 6;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTelefoneTutor);
            groupBox1.Controls.Add(cmbCpfTutor);
            groupBox1.Controls.Add(cmbNomeTutor);
            groupBox1.Controls.Add(cmbSexo);
            groupBox1.Controls.Add(lbDadosTutor);
            groupBox1.Controls.Add(cmbCastrado);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(btnExcluir);
            groupBox1.Controls.Add(btnAtualizar);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(txtIdade);
            groupBox1.Controls.Add(txtRaca);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtPeso);
            groupBox1.Controls.Add(txtEspecie);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Location = new Point(30, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(407, 461);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados do Animal";
            // 
            // cmbTelefoneTutor
            // 
            cmbTelefoneTutor.FormattingEnabled = true;
            cmbTelefoneTutor.Items.AddRange(new object[] { "M", "F" });
            cmbTelefoneTutor.Location = new Point(8, 352);
            cmbTelefoneTutor.Name = "cmbTelefoneTutor";
            cmbTelefoneTutor.Size = new Size(168, 23);
            cmbTelefoneTutor.TabIndex = 23;
            cmbTelefoneTutor.Text = "Telefone";
            // 
            // cmbCpfTutor
            // 
            cmbCpfTutor.FormattingEnabled = true;
            cmbCpfTutor.Items.AddRange(new object[] { "M", "F" });
            cmbCpfTutor.Location = new Point(8, 308);
            cmbCpfTutor.Name = "cmbCpfTutor";
            cmbCpfTutor.Size = new Size(168, 23);
            cmbCpfTutor.TabIndex = 22;
            cmbCpfTutor.Text = "CPF";
            // 
            // cmbNomeTutor
            // 
            cmbNomeTutor.FormattingEnabled = true;
            cmbNomeTutor.Items.AddRange(new object[] { "M", "F" });
            cmbNomeTutor.Location = new Point(8, 269);
            cmbNomeTutor.Name = "cmbNomeTutor";
            cmbNomeTutor.Size = new Size(166, 23);
            cmbNomeTutor.TabIndex = 21;
            cmbNomeTutor.Text = "Nome";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "M", "F" });
            cmbSexo.Location = new Point(6, 125);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(109, 23);
            cmbSexo.TabIndex = 20;
            cmbSexo.Text = "Sexo";
            // 
            // lbDadosTutor
            // 
            lbDadosTutor.AutoSize = true;
            lbDadosTutor.Location = new Point(8, 251);
            lbDadosTutor.Name = "lbDadosTutor";
            lbDadosTutor.Size = new Size(86, 15);
            lbDadosTutor.TabIndex = 16;
            lbDadosTutor.Text = "Dados do tutor";
            // 
            // cmbCastrado
            // 
            cmbCastrado.FormattingEnabled = true;
            cmbCastrado.Items.AddRange(new object[] { "Sim", "Não" });
            cmbCastrado.Location = new Point(6, 220);
            cmbCastrado.Name = "cmbCastrado";
            cmbCastrado.Size = new Size(109, 23);
            cmbCastrado.TabIndex = 15;
            cmbCastrado.Text = "Castrado ";
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 601);
            Controls.Add(btnBuscar);
            Controls.Add(dataGridView1);
            Controls.Add(txtCampoBusca);
            Controls.Add(groupBox1);
            Name = "AnimalForm";
            Text = "CadastroForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBuscar;
        private Button btnLimpar;
        private Button btnExcluir;
        private Button btnAtualizar;
        private Button btnAdicionar;
        private TextBox txtIdade;
        private TextBox txtRaca;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox txtRua;
        private TextBox txtPeso;
        private TextBox txtCep;
        private TextBox txtBairro;
        private TextBox txtEspecie;
        private TextBox txtNome;
        private TextBox txtCampoBusca;
        private TextBox txtCidade;
        private GroupBox groupBox1;
        private ComboBox cmbCastrado;
        private Label lbDadosTutor;
        private ComboBox cmbSexo;
        private ComboBox cmbTelefoneTutor;
        private ComboBox cmbCpfTutor;
        private ComboBox cmbNomeTutor;
    }
}