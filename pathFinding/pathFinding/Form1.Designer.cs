namespace pathFinding
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioWalls = new System.Windows.Forms.RadioButton();
            this.radioStart = new System.Windows.Forms.RadioButton();
            this.radioEnd = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioWalls
            // 
            this.radioWalls.AutoSize = true;
            this.radioWalls.Checked = true;
            this.radioWalls.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioWalls.ForeColor = System.Drawing.Color.White;
            this.radioWalls.Location = new System.Drawing.Point(12, 185);
            this.radioWalls.Name = "radioWalls";
            this.radioWalls.Size = new System.Drawing.Size(102, 18);
            this.radioWalls.TabIndex = 1;
            this.radioWalls.TabStop = true;
            this.radioWalls.Text = "Place Walls";
            this.radioWalls.UseVisualStyleBackColor = true;
            // 
            // radioStart
            // 
            this.radioStart.AutoSize = true;
            this.radioStart.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioStart.ForeColor = System.Drawing.Color.White;
            this.radioStart.Location = new System.Drawing.Point(12, 209);
            this.radioStart.Name = "radioStart";
            this.radioStart.Size = new System.Drawing.Size(165, 18);
            this.radioStart.TabIndex = 1;
            this.radioStart.Text = "Place Starting Point";
            this.radioStart.UseVisualStyleBackColor = true;
            // 
            // radioEnd
            // 
            this.radioEnd.AutoSize = true;
            this.radioEnd.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioEnd.ForeColor = System.Drawing.Color.White;
            this.radioEnd.Location = new System.Drawing.Point(12, 233);
            this.radioEnd.Name = "radioEnd";
            this.radioEnd.Size = new System.Drawing.Size(151, 18);
            this.radioEnd.TabIndex = 1;
            this.radioEnd.Text = "Place Ending Point";
            this.radioEnd.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Find The Path";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(201, 186);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(312, 92);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(201, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Randomize";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(362, 284);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(525, 338);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioEnd);
            this.Controls.Add(this.radioStart);
            this.Controls.Add(this.radioWalls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Path Finding";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioWalls;
        private System.Windows.Forms.RadioButton radioStart;
        private System.Windows.Forms.RadioButton radioEnd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

