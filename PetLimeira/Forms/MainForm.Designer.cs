namespace PetLimeira.Forms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            tutoresToolStripMenuItem = new ToolStripMenuItem();
            animaisToolStripMenuItem = new ToolStripMenuItem();
            carteiraDeVacinaçãoToolStripMenuItem = new ToolStripMenuItem();
            veterináriosToolStripMenuItem = new ToolStripMenuItem();
            procedimentosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            utilitáriosToolStripMenuItem = new ToolStripMenuItem();
            calculadoraToolStripMenuItem = new ToolStripMenuItem();
            blocoDeNotasToolStripMenuItem = new ToolStripMenuItem();
            caToolStripMenuItem = new ToolStripMenuItem();
            linhaDeComandoToolStripMenuItem = new ToolStripMenuItem();
            dadosToolStripMenuItem = new ToolStripMenuItem();
            listaDeCidadesToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            manualDoSistemaToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            contatoToolStripMenuItem = new ToolStripMenuItem();
            youtubeToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            status2 = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastroToolStripMenuItem, utilitáriosToolStripMenuItem, dadosToolStripMenuItem, ajudaToolStripMenuItem, sairToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tutoresToolStripMenuItem, animaisToolStripMenuItem, carteiraDeVacinaçãoToolStripMenuItem, veterináriosToolStripMenuItem, procedimentosToolStripMenuItem, consultasToolStripMenuItem });
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Size = new Size(69, 20);
            cadastroToolStripMenuItem.Text = "Cadastro ";
            // 
            // tutoresToolStripMenuItem
            // 
            tutoresToolStripMenuItem.Name = "tutoresToolStripMenuItem";
            tutoresToolStripMenuItem.Size = new Size(187, 22);
            tutoresToolStripMenuItem.Text = "Tutores";
            tutoresToolStripMenuItem.Click += tutoresToolStripMenuItem_Click;
            // 
            // animaisToolStripMenuItem
            // 
            animaisToolStripMenuItem.Name = "animaisToolStripMenuItem";
            animaisToolStripMenuItem.Size = new Size(187, 22);
            animaisToolStripMenuItem.Text = "Animais";
            animaisToolStripMenuItem.Click += animaisToolStripMenuItem_Click;
            // 
            // carteiraDeVacinaçãoToolStripMenuItem
            // 
            carteiraDeVacinaçãoToolStripMenuItem.Name = "carteiraDeVacinaçãoToolStripMenuItem";
            carteiraDeVacinaçãoToolStripMenuItem.Size = new Size(187, 22);
            carteiraDeVacinaçãoToolStripMenuItem.Text = "Carteira de Vacinação";
            // 
            // veterináriosToolStripMenuItem
            // 
            veterináriosToolStripMenuItem.Name = "veterináriosToolStripMenuItem";
            veterináriosToolStripMenuItem.Size = new Size(187, 22);
            veterináriosToolStripMenuItem.Text = "Veterinários";
            // 
            // procedimentosToolStripMenuItem
            // 
            procedimentosToolStripMenuItem.Name = "procedimentosToolStripMenuItem";
            procedimentosToolStripMenuItem.Size = new Size(187, 22);
            procedimentosToolStripMenuItem.Text = "Procedimentos";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(187, 22);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // utilitáriosToolStripMenuItem
            // 
            utilitáriosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraToolStripMenuItem, blocoDeNotasToolStripMenuItem, caToolStripMenuItem, linhaDeComandoToolStripMenuItem });
            utilitáriosToolStripMenuItem.Name = "utilitáriosToolStripMenuItem";
            utilitáriosToolStripMenuItem.Size = new Size(69, 20);
            utilitáriosToolStripMenuItem.Text = "Utilitários";
            // 
            // calculadoraToolStripMenuItem
            // 
            calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            calculadoraToolStripMenuItem.Size = new Size(175, 22);
            calculadoraToolStripMenuItem.Text = "Calculadora ";
            calculadoraToolStripMenuItem.Click += calculadoraToolStripMenuItem_Click;
            // 
            // blocoDeNotasToolStripMenuItem
            // 
            blocoDeNotasToolStripMenuItem.Name = "blocoDeNotasToolStripMenuItem";
            blocoDeNotasToolStripMenuItem.Size = new Size(175, 22);
            blocoDeNotasToolStripMenuItem.Text = "Bloco de Notas";
            blocoDeNotasToolStripMenuItem.Click += blocoDeNotasToolStripMenuItem_Click;
            // 
            // caToolStripMenuItem
            // 
            caToolStripMenuItem.Name = "caToolStripMenuItem";
            caToolStripMenuItem.Size = new Size(175, 22);
            caToolStripMenuItem.Text = "Calendário";
            // 
            // linhaDeComandoToolStripMenuItem
            // 
            linhaDeComandoToolStripMenuItem.Name = "linhaDeComandoToolStripMenuItem";
            linhaDeComandoToolStripMenuItem.Size = new Size(175, 22);
            linhaDeComandoToolStripMenuItem.Text = "Linha de Comando";
            linhaDeComandoToolStripMenuItem.Click += linhaDeComandoToolStripMenuItem_Click;
            // 
            // dadosToolStripMenuItem
            // 
            dadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listaDeCidadesToolStripMenuItem });
            dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            dadosToolStripMenuItem.Size = new Size(99, 20);
            dadosToolStripMenuItem.Text = "Dados Externos";
            // 
            // listaDeCidadesToolStripMenuItem
            // 
            listaDeCidadesToolStripMenuItem.Name = "listaDeCidadesToolStripMenuItem";
            listaDeCidadesToolStripMenuItem.Size = new Size(159, 22);
            listaDeCidadesToolStripMenuItem.Text = "Lista de Cidades";
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manualDoSistemaToolStripMenuItem, sobreToolStripMenuItem, contatoToolStripMenuItem, youtubeToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // manualDoSistemaToolStripMenuItem
            // 
            manualDoSistemaToolStripMenuItem.Name = "manualDoSistemaToolStripMenuItem";
            manualDoSistemaToolStripMenuItem.Size = new Size(175, 22);
            manualDoSistemaToolStripMenuItem.Text = "Manual do Sistema";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(175, 22);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // contatoToolStripMenuItem
            // 
            contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            contatoToolStripMenuItem.Size = new Size(175, 22);
            contatoToolStripMenuItem.Text = "Contato";
            // 
            // youtubeToolStripMenuItem
            // 
            youtubeToolStripMenuItem.Name = "youtubeToolStripMenuItem";
            youtubeToolStripMenuItem.Size = new Size(175, 22);
            youtubeToolStripMenuItem.Text = "Youtube";
            youtubeToolStripMenuItem.Click += youtubeToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, status2 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(170, 17);
            toolStripStatusLabel1.Text = "Sistema de Gestão Veterinária  |";
            // 
            // status2
            // 
            status2.Name = "status2";
            status2.Size = new Size(118, 17);
            status2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PetLimeira - Sistema de Gestão Veterinária";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastroToolStripMenuItem;
        private ToolStripMenuItem utilitáriosToolStripMenuItem;
        private ToolStripMenuItem tutoresToolStripMenuItem;
        private ToolStripMenuItem animaisToolStripMenuItem;
        private ToolStripMenuItem carteiraDeVacinaçãoToolStripMenuItem;
        private ToolStripMenuItem veterináriosToolStripMenuItem;
        private ToolStripMenuItem procedimentosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem calculadoraToolStripMenuItem;
        private ToolStripMenuItem blocoDeNotasToolStripMenuItem;
        private ToolStripMenuItem caToolStripMenuItem;
        private ToolStripMenuItem dadosToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem manualDoSistemaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem contatoToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel status2;
        private System.Windows.Forms.Timer timer1;
        private ToolStripMenuItem listaDeCidadesToolStripMenuItem;
        private ToolStripMenuItem youtubeToolStripMenuItem;
        private ToolStripMenuItem linhaDeComandoToolStripMenuItem;
    }
}