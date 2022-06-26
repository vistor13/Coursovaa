
namespace Coursovaa
{
    partial class FirstAlbumForm
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
            this.listSubject1 = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btdelet = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLinked1 = new System.Windows.Forms.ListBox();
            this.btdislinked = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.listTime1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listSubject1
            // 
            this.listSubject1.FormattingEnabled = true;
            this.listSubject1.ItemHeight = 16;
            this.listSubject1.Location = new System.Drawing.Point(161, 134);
            this.listSubject1.Name = "listSubject1";
            this.listSubject1.Size = new System.Drawing.Size(103, 132);
            this.listSubject1.TabIndex = 0;
            this.listSubject1.SelectedIndexChanged += new System.EventHandler(this.listSubject1_SelectedIndexChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(77, 336);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(47, 38);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "+\r\n";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btdelet
            // 
            this.btdelet.Location = new System.Drawing.Point(191, 336);
            this.btdelet.Name = "btdelet";
            this.btdelet.Size = new System.Drawing.Size(47, 38);
            this.btdelet.TabIndex = 2;
            this.btdelet.Text = "-\r\n";
            this.btdelet.UseVisualStyleBackColor = true;
            this.btdelet.Click += new System.EventHandler(this.btdelet_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(306, 336);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(47, 38);
            this.btedit.TabIndex = 3;
            this.btedit.Text = "*\r\n";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 75);
            this.label1.TabIndex = 4;
            this.label1.Text = "Виберіть тему для пошуку фото\r\n   (недавньо вибранні теми)\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "додати";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(176, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "видалити ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "перейменувати";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(691, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Часовий період";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(234, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(533, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Налаштування пошуку фотографій згідно критерій";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 39);
            this.button1.TabIndex = 12;
            this.button1.Text = "З\'єднати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbLinked1
            // 
            this.lbLinked1.FormattingEnabled = true;
            this.lbLinked1.ItemHeight = 16;
            this.lbLinked1.Location = new System.Drawing.Point(722, 313);
            this.lbLinked1.Name = "lbLinked1";
            this.lbLinked1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbLinked1.Size = new System.Drawing.Size(105, 132);
            this.lbLinked1.TabIndex = 13;
            // 
            // btdislinked
            // 
            this.btdislinked.Location = new System.Drawing.Point(419, 204);
            this.btdislinked.Name = "btdislinked";
            this.btdislinked.Size = new System.Drawing.Size(105, 36);
            this.btdislinked.TabIndex = 14;
            this.btdislinked.Text = "Роз\'єднати";
            this.btdislinked.UseVisualStyleBackColor = true;
            this.btdislinked.Click += new System.EventHandler(this.btdislinked_Click);
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(696, 479);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(169, 70);
            this.btsearch.TabIndex = 15;
            this.btsearch.Text = "Знайти фото за критеріями";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(511, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "label7";
            // 
            // listTime1
            // 
            this.listTime1.FormattingEnabled = true;
            this.listTime1.ItemHeight = 16;
            this.listTime1.Location = new System.Drawing.Point(724, 134);
            this.listTime1.Name = "listTime1";
            this.listTime1.Size = new System.Drawing.Size(103, 132);
            this.listTime1.TabIndex = 9;
            this.listTime1.SelectedIndexChanged += new System.EventHandler(this.listTime1_SelectedIndexChanged);
            // 
            // FirstAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 618);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btsearch);
            this.Controls.Add(this.btdislinked);
            this.Controls.Add(this.lbLinked1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listTime1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btedit);
            this.Controls.Add(this.btdelet);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listSubject1);
            this.Name = "FirstAlbumForm";
            this.Text = "FirstAlbumForm";
            this.Load += new System.EventHandler(this.FirstAlbumForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listSubject1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btdelet;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbLinked1;
        private System.Windows.Forms.Button btdislinked;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listTime1;
    }
}