﻿namespace Heftiges_Programm
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.variablenAMKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schleifenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verzweigungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.methToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.variablenAMKToolStripMenuItem,
            this.schleifenToolStripMenuItem,
            this.verzweigungenToolStripMenuItem,
            this.testToolStripMenuItem,
            this.methToolStripMenuItem});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // variablenAMKToolStripMenuItem
            // 
            this.variablenAMKToolStripMenuItem.Name = "variablenAMKToolStripMenuItem";
            this.variablenAMKToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.variablenAMKToolStripMenuItem.Text = "Variablen";
            this.variablenAMKToolStripMenuItem.Click += new System.EventHandler(this.variablenAMKToolStripMenuItem_Click);
            // 
            // schleifenToolStripMenuItem
            // 
            this.schleifenToolStripMenuItem.Name = "schleifenToolStripMenuItem";
            this.schleifenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schleifenToolStripMenuItem.Text = "Schleifen";
            this.schleifenToolStripMenuItem.Click += new System.EventHandler(this.schleifenToolStripMenuItem_Click);
            // 
            // verzweigungenToolStripMenuItem
            // 
            this.verzweigungenToolStripMenuItem.Name = "verzweigungenToolStripMenuItem";
            this.verzweigungenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verzweigungenToolStripMenuItem.Text = "Verzweigungen";
            this.verzweigungenToolStripMenuItem.Click += new System.EventHandler(this.verzweigungenToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testToolStripMenuItem.Text = "Test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // methToolStripMenuItem
            // 
            this.methToolStripMenuItem.Name = "methToolStripMenuItem";
            this.methToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.methToolStripMenuItem.Text = "Meth";
            this.methToolStripMenuItem.Click += new System.EventHandler(this.methToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Heftige Hauptform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem variablenAMKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schleifenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verzweigungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem methToolStripMenuItem;
    }
}

