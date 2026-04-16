namespace LAB_7
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                if (notifyIcon1 != null)
                    notifyIcon1.Dispose();

                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияОПреподавателяхToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияОСтудентахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзТреяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.свернутьТрейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияToolStripMenuItem,
            this.свернутьТрейToolStripMenuItem,
            this.закрытьToolStripMenuItem1,
            this.выходToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // сведенияToolStripMenuItem
            // 
            this.сведенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияОПреподавателяхToolStripMenuItem,
            this.сведенияОСтудентахToolStripMenuItem});
            this.сведенияToolStripMenuItem.Name = "сведенияToolStripMenuItem";
            this.сведенияToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.сведенияToolStripMenuItem.Text = "Сведения";
            // 
            // сведенияОПреподавателяхToolStripMenuItem
            // 
            this.сведенияОПреподавателяхToolStripMenuItem.Name = "сведенияОПреподавателяхToolStripMenuItem";
            this.сведенияОПреподавателяхToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сведенияОПреподавателяхToolStripMenuItem.Text = "Сведения о преподавателях";
            this.сведенияОПреподавателяхToolStripMenuItem.Click += new System.EventHandler(this.сведенияОПреподавателяхToolStripMenuItem_Click);
            // 
            // сведенияОСтудентахToolStripMenuItem
            // 
            this.сведенияОСтудентахToolStripMenuItem.Name = "сведенияОСтудентахToolStripMenuItem";
            this.сведенияОСтудентахToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.сведенияОСтудентахToolStripMenuItem.Text = "Сведения о студентах";
            this.сведенияОСтудентахToolStripMenuItem.Click += new System.EventHandler(this.сведенияОСтудентахToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.выходИзТреяToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 48);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.развернутьToolStripMenuItem.Text = "Развернуть";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // выходИзТреяToolStripMenuItem
            // 
            this.выходИзТреяToolStripMenuItem.Name = "выходИзТреяToolStripMenuItem";
            this.выходИзТреяToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выходИзТреяToolStripMenuItem.Text = "Выход";
            this.выходИзТреяToolStripMenuItem.Click += new System.EventHandler(this.выходИзТреяToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LAB 7";
            // 
            // свернутьТрейToolStripMenuItem
            // 
            this.свернутьТрейToolStripMenuItem.Name = "свернутьТрейToolStripMenuItem";
            this.свернутьТрейToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.свернутьТрейToolStripMenuItem.Text = "Свернуть трей";
            this.свернутьТрейToolStripMenuItem.Click += new System.EventHandler(this.свернутьВТрейToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem1
            // 
            this.закрытьToolStripMenuItem1.Name = "закрытьToolStripMenuItem1";
            this.закрытьToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.закрытьToolStripMenuItem1.Text = "Закрыть";
            this.закрытьToolStripMenuItem1.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LAB 7. UNIVERSITY";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияОПреподавателяхToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияОСтудентахToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзТреяToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem свернутьТрейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
    }
}