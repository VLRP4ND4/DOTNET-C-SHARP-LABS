namespace LAB_6
{
    partial class FormMain
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
            this.labelChooseAuthor = new System.Windows.Forms.Label();
            this.buttonChooseAuthor = new System.Windows.Forms.Button();
            this.comboBoxChooseAuthor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelChooseAuthor
            // 
            this.labelChooseAuthor.AutoSize = true;
            this.labelChooseAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChooseAuthor.Location = new System.Drawing.Point(114, 31);
            this.labelChooseAuthor.Name = "labelChooseAuthor";
            this.labelChooseAuthor.Size = new System.Drawing.Size(181, 24);
            this.labelChooseAuthor.TabIndex = 0;
            this.labelChooseAuthor.Text = "Выбери художника";
            // 
            // buttonChooseAuthor
            // 
            this.buttonChooseAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChooseAuthor.Location = new System.Drawing.Point(58, 403);
            this.buttonChooseAuthor.Name = "buttonChooseAuthor";
            this.buttonChooseAuthor.Size = new System.Drawing.Size(280, 28);
            this.buttonChooseAuthor.TabIndex = 2;
            this.buttonChooseAuthor.Text = "Выбрать художника\r\n\r\n";
            this.buttonChooseAuthor.UseVisualStyleBackColor = true;
            this.buttonChooseAuthor.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxChooseAuthor
            // 
            this.comboBoxChooseAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxChooseAuthor.FormattingEnabled = true;
            this.comboBoxChooseAuthor.Location = new System.Drawing.Point(32, 78);
            this.comboBoxChooseAuthor.Name = "comboBoxChooseAuthor";
            this.comboBoxChooseAuthor.Size = new System.Drawing.Size(338, 32);
            this.comboBoxChooseAuthor.TabIndex = 4;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 461);
            this.Controls.Add(this.comboBoxChooseAuthor);
            this.Controls.Add(this.buttonChooseAuthor);
            this.Controls.Add(this.labelChooseAuthor);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseAuthor;
        private System.Windows.Forms.Button buttonChooseAuthor;
        private System.Windows.Forms.ComboBox comboBoxChooseAuthor;
    }
}