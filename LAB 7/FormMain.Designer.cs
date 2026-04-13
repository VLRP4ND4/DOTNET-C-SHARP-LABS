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
            this.окноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьВТрейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходИзТреяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сведенияToolStripMenuItem,
            this.окноToolStripMenuItem});
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
            // окноToolStripMenuItem
            // 
            this.окноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свернутьВТрейToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.окноToolStripMenuItem.Name = "окноToolStripMenuItem";
            this.окноToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.окноToolStripMenuItem.Text = "Окно";
            // 
            // свернутьВТрейToolStripMenuItem
            // 
            this.свернутьВТрейToolStripMenuItem.Name = "свернутьВТрейToolStripMenuItem";
            this.свернутьВТрейToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.свернутьВТрейToolStripMenuItem.Text = "Свернуть в трей";
            this.свернутьВТрейToolStripMenuItem.Click += new System.EventHandler(this.свернутьВТрейToolStripMenuItem_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
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
            this.выходИзТреяToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LAB 7";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
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
        private System.Windows.Forms.ToolStripMenuItem окноToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свернутьВТрейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходИзТреяToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}