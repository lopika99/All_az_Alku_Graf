namespace graf_All_Az_Alku
{
    partial class Form1
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
            this.jatekter = new System.Windows.Forms.Panel();
            this.informacio = new System.Windows.Forms.Panel();
            this.info = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.újJátékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rangsorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lb = new System.Windows.Forms.ListBox();
            this.informacio.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // jatekter
            // 
            this.jatekter.Dock = System.Windows.Forms.DockStyle.Left;
            this.jatekter.Location = new System.Drawing.Point(0, 0);
            this.jatekter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jatekter.Name = "jatekter";
            this.jatekter.Size = new System.Drawing.Size(1059, 930);
            this.jatekter.TabIndex = 0;
            this.jatekter.Paint += new System.Windows.Forms.PaintEventHandler(this.jatekter_Paint);
            // 
            // informacio
            // 
            this.informacio.Controls.Add(this.lb);
            this.informacio.Controls.Add(this.info);
            this.informacio.Controls.Add(this.label1);
            this.informacio.Controls.Add(this.menuStrip1);
            this.informacio.Dock = System.Windows.Forms.DockStyle.Right;
            this.informacio.Location = new System.Drawing.Point(1064, 0);
            this.informacio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.informacio.Name = "informacio";
            this.informacio.Size = new System.Drawing.Size(468, 930);
            this.informacio.TabIndex = 1;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info.Location = new System.Drawing.Point(15, 128);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(439, 255);
            this.info.TabIndex = 1;
            this.info.Text = "Kérlek válaszd ki a Saját táskádat!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(5, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Játékinformációk:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újJátékToolStripMenuItem,
            this.rangsorToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(468, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // újJátékToolStripMenuItem
            // 
            this.újJátékToolStripMenuItem.Name = "újJátékToolStripMenuItem";
            this.újJátékToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.újJátékToolStripMenuItem.Text = "Új Játék";
            this.újJátékToolStripMenuItem.Click += new System.EventHandler(this.újJátékToolStripMenuItem_Click);
            // 
            // rangsorToolStripMenuItem
            // 
            this.rangsorToolStripMenuItem.Name = "rangsorToolStripMenuItem";
            this.rangsorToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.rangsorToolStripMenuItem.Text = "Rangsor";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.ItemHeight = 16;
            this.lb.Location = new System.Drawing.Point(20, 386);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(434, 532);
            this.lb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 930);
            this.Controls.Add(this.informacio);
            this.Controls.Add(this.jatekter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Áll az Alku";
            this.informacio.ResumeLayout(false);
            this.informacio.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel jatekter;
        private System.Windows.Forms.Panel informacio;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem újJátékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rangsorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.ListBox lb;
    }
}

