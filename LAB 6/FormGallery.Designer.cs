using System.Windows.Forms;

namespace LAB_6
{
    partial class FormGallery
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
            this.labelAuthor = new System.Windows.Forms.Label();
            this.authorText = new System.Windows.Forms.RichTextBox();
            this.galleryPicture = new System.Windows.Forms.PictureBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonBackMenu = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.galleryPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAuthor
            // 
            this.labelAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAuthor.Location = new System.Drawing.Point(56, 21);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(694, 24);
            this.labelAuthor.TabIndex = 0;
            this.labelAuthor.Text = "Автор";
            this.labelAuthor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // authorText
            // 
            this.authorText.BackColor = System.Drawing.SystemColors.Control;
            this.authorText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorText.Location = new System.Drawing.Point(56, 58);
            this.authorText.Name = "authorText";
            this.authorText.Size = new System.Drawing.Size(694, 79);
            this.authorText.TabIndex = 2;
            this.authorText.Text = "Описание автора";
            // 
            // galleryPicture
            // 
            this.galleryPicture.Location = new System.Drawing.Point(56, 155);
            this.galleryPicture.Name = "galleryPicture";
            this.galleryPicture.Size = new System.Drawing.Size(694, 392);
            this.galleryPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.galleryPicture.TabIndex = 3;
            this.galleryPicture.TabStop = false;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 320);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(32, 56);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(760, 320);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(32, 56);
            this.buttonNext.TabIndex = 5;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonBackMenu
            // 
            this.buttonBackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBackMenu.Location = new System.Drawing.Point(295, 608);
            this.buttonBackMenu.Name = "buttonBackMenu";
            this.buttonBackMenu.Size = new System.Drawing.Size(220, 28);
            this.buttonBackMenu.TabIndex = 6;
            this.buttonBackMenu.Text = "Назад в меню";
            this.buttonBackMenu.UseVisualStyleBackColor = true;
            this.buttonBackMenu.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(56, 563);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(694, 24);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 661);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonBackMenu);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.galleryPicture);
            this.Controls.Add(this.authorText);
            this.Controls.Add(this.labelAuthor);
            this.Name = "FormGallery";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.galleryPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.RichTextBox authorText;
        private System.Windows.Forms.PictureBox galleryPicture;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonBackMenu;
        private Label labelName;
    }
}