
namespace exercicios
{
    partial class frmprincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exerciciosDeLoopingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio12ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercicio13ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exerciciosDeLoopingToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exerciciosDeLoopingToolStripMenuItem
            // 
            this.exerciciosDeLoopingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercicio11ToolStripMenuItem,
            this.exercicio12ToolStripMenuItem,
            this.exercicio13ToolStripMenuItem});
            this.exerciciosDeLoopingToolStripMenuItem.Name = "exerciciosDeLoopingToolStripMenuItem";
            this.exerciciosDeLoopingToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.exerciciosDeLoopingToolStripMenuItem.Text = "Exercicios de Looping";
            // 
            // exercicio11ToolStripMenuItem
            // 
            this.exercicio11ToolStripMenuItem.Name = "exercicio11ToolStripMenuItem";
            this.exercicio11ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercicio11ToolStripMenuItem.Text = "Exercicio 11";
            this.exercicio11ToolStripMenuItem.Click += new System.EventHandler(this.exercicio11ToolStripMenuItem_Click);
            // 
            // exercicio12ToolStripMenuItem
            // 
            this.exercicio12ToolStripMenuItem.Name = "exercicio12ToolStripMenuItem";
            this.exercicio12ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercicio12ToolStripMenuItem.Text = "Exercicio 12";
            this.exercicio12ToolStripMenuItem.Click += new System.EventHandler(this.exercicio12ToolStripMenuItem_Click);
            // 
            // exercicio13ToolStripMenuItem
            // 
            this.exercicio13ToolStripMenuItem.Name = "exercicio13ToolStripMenuItem";
            this.exercicio13ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.exercicio13ToolStripMenuItem.Text = "Exercicio 13";
            this.exercicio13ToolStripMenuItem.Click += new System.EventHandler(this.exercicio13ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::exercicios.Properties.Resources.muda_de_jaca_dura_enxertada_fc11_171_1_e40d1c6fd1d6734ab837eb849dea0b4f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exerciciosDeLoopingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio11ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio12ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercicio13ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

