namespace DemoWinForms
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.contexto = new System.Windows.Forms.ListBox();
            this.memoryDump = new System.Windows.Forms.ListBox();
            this.stackDump = new System.Windows.Forms.ListBox();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxResponse = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(75, 414);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(724, 20);
            this.txt_nome.TabIndex = 1;
            this.txt_nome.Text = "Digite Aqui";
            this.txt_nome.Click += new System.EventHandler(this.txt_nome_Click);
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            this.txt_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_nome_KeyDown);
            // 
            // contexto
            // 
            this.contexto.FormattingEnabled = true;
            this.contexto.Location = new System.Drawing.Point(594, 27);
            this.contexto.Name = "contexto";
            this.contexto.Size = new System.Drawing.Size(205, 212);
            this.contexto.TabIndex = 5;
            // 
            // memoryDump
            // 
            this.memoryDump.FormattingEnabled = true;
            this.memoryDump.Location = new System.Drawing.Point(12, 311);
            this.memoryDump.Name = "memoryDump";
            this.memoryDump.Size = new System.Drawing.Size(576, 95);
            this.memoryDump.TabIndex = 5;
            this.memoryDump.SelectedIndexChanged += new System.EventHandler(this.memoryDump_SelectedIndexChanged);
            // 
            // stackDump
            // 
            this.stackDump.FormattingEnabled = true;
            this.stackDump.Location = new System.Drawing.Point(594, 246);
            this.stackDump.Name = "stackDump";
            this.stackDump.Size = new System.Drawing.Size(205, 160);
            this.stackDump.TabIndex = 7;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Controls.Add(this.tabPage3);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 12);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(576, 293);
            this.tabs.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxResponse);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(568, 267);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dissasembler";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxResponse.Location = new System.Drawing.Point(-4, 0);
            this.textBoxResponse.Multiline = true;
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.Size = new System.Drawing.Size(576, 271);
            this.textBoxResponse.TabIndex = 0;
            this.textBoxResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(568, 267);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Log";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(568, 267);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Notes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 449);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.stackDump);
            this.Controls.Add(this.memoryDump);
            this.Controls.Add(this.contexto);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Debugger";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.ListBox contexto;
        private System.Windows.Forms.ListBox memoryDump;
        private System.Windows.Forms.ListBox stackDump;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxResponse;
    }
}

