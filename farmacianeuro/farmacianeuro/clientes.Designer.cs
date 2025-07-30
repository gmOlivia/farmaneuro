namespace farmacianeuro
{
    partial class clientes
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.profissionaisDaSaúdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profissionaisDeSaúdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.estabelecimentosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profissionaisDaSaúdeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // profissionaisDaSaúdeToolStripMenuItem
            // 
            this.profissionaisDaSaúdeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profissionaisDeSaúdeToolStripMenuItem,
            this.pacientesToolStripMenuItem1,
            this.estabelecimentosToolStripMenuItem1});
            this.profissionaisDaSaúdeToolStripMenuItem.Name = "profissionaisDaSaúdeToolStripMenuItem";
            this.profissionaisDaSaúdeToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.profissionaisDaSaúdeToolStripMenuItem.Text = "Clientes";
            this.profissionaisDaSaúdeToolStripMenuItem.Click += new System.EventHandler(this.profissionaisDaSaúdeToolStripMenuItem_Click);
            // 
            // profissionaisDeSaúdeToolStripMenuItem
            // 
            this.profissionaisDeSaúdeToolStripMenuItem.Name = "profissionaisDeSaúdeToolStripMenuItem";
            this.profissionaisDeSaúdeToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.profissionaisDeSaúdeToolStripMenuItem.Text = "Profissionais de Saúde";
            this.profissionaisDeSaúdeToolStripMenuItem.Click += new System.EventHandler(this.profissionaisDeSaúdeToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            // 
            // estabelecimentosToolStripMenuItem1
            // 
            this.estabelecimentosToolStripMenuItem1.Name = "estabelecimentosToolStripMenuItem1";
            this.estabelecimentosToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.estabelecimentosToolStripMenuItem1.Text = "Estabelecimentos";
            // 
            // clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "clientes";
            this.Text = "clientes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem profissionaisDaSaúdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profissionaisDeSaúdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem estabelecimentosToolStripMenuItem1;
    }
}