namespace GasStation
{
    partial class MainPage
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonAI92 = new System.Windows.Forms.Button();
            this.buttonAI95 = new System.Windows.Forms.Button();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.labelSumma = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPump1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonPump2 = new System.Windows.Forms.Button();
            this.buttonPump3 = new System.Windows.Forms.Button();
            this.buttonPump4 = new System.Windows.Forms.Button();
            this.buttonPump5 = new System.Windows.Forms.Button();
            this.buttonPump6 = new System.Windows.Forms.Button();
            this.labelPriceLitre = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(144, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(449, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(226, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите пожалуйста тип топлива:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(226, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Цена за литр:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(226, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(545, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Выберите необходимое количество литров:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(226, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сумма:";
            // 
            // buttonAI92
            // 
            this.buttonAI92.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAI92.Location = new System.Drawing.Point(321, 105);
            this.buttonAI92.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAI92.Name = "buttonAI92";
            this.buttonAI92.Size = new System.Drawing.Size(76, 62);
            this.buttonAI92.TabIndex = 5;
            this.buttonAI92.Text = "АИ-92";
            this.buttonAI92.UseVisualStyleBackColor = true;
            this.buttonAI92.Click += new System.EventHandler(this.buttonAI92_Click);
            // 
            // buttonAI95
            // 
            this.buttonAI95.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAI95.Location = new System.Drawing.Point(442, 105);
            this.buttonAI95.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAI95.Name = "buttonAI95";
            this.buttonAI95.Size = new System.Drawing.Size(75, 62);
            this.buttonAI95.TabIndex = 6;
            this.buttonAI95.Text = "АИ-95";
            this.buttonAI95.UseVisualStyleBackColor = true;
            this.buttonAI95.Click += new System.EventHandler(this.buttonAI95_Click);
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownVolume.Location = new System.Drawing.Point(442, 269);
            this.numericUpDownVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(75, 26);
            this.numericUpDownVolume.TabIndex = 8;
            // 
            // buttonContinue
            // 
            this.buttonContinue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonContinue.Location = new System.Drawing.Point(580, 371);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(168, 42);
            this.buttonContinue.TabIndex = 9;
            this.buttonContinue.Text = "ПРОДОЛЖИТЬ";
            this.buttonContinue.UseVisualStyleBackColor = true;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // labelSumma
            // 
            this.labelSumma.AutoSize = true;
            this.labelSumma.BackColor = System.Drawing.Color.Transparent;
            this.labelSumma.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSumma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelSumma.Location = new System.Drawing.Point(344, 328);
            this.labelSumma.Name = "labelSumma";
            this.labelSumma.Size = new System.Drawing.Size(0, 29);
            this.labelSumma.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 114);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPump1
            // 
            this.buttonPump1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonPump1.Location = new System.Drawing.Point(42, 140);
            this.buttonPump1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump1.Name = "buttonPump1";
            this.buttonPump1.Size = new System.Drawing.Size(27, 29);
            this.buttonPump1.TabIndex = 12;
            this.buttonPump1.Text = "1";
            this.buttonPump1.UseVisualStyleBackColor = true;
            this.buttonPump1.Click += new System.EventHandler(this.buttonPump1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 114);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(30, 212);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(122, 212);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(30, 305);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(122, 305);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            // 
            // buttonPump2
            // 
            this.buttonPump2.Location = new System.Drawing.Point(134, 140);
            this.buttonPump2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump2.Name = "buttonPump2";
            this.buttonPump2.Size = new System.Drawing.Size(27, 29);
            this.buttonPump2.TabIndex = 18;
            this.buttonPump2.Text = "2";
            this.buttonPump2.UseVisualStyleBackColor = true;
            this.buttonPump2.Click += new System.EventHandler(this.buttonPump2_Click);
            // 
            // buttonPump3
            // 
            this.buttonPump3.BackColor = System.Drawing.Color.Transparent;
            this.buttonPump3.Location = new System.Drawing.Point(42, 238);
            this.buttonPump3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump3.Name = "buttonPump3";
            this.buttonPump3.Size = new System.Drawing.Size(27, 29);
            this.buttonPump3.TabIndex = 19;
            this.buttonPump3.Text = "3";
            this.buttonPump3.UseVisualStyleBackColor = false;
            this.buttonPump3.Click += new System.EventHandler(this.buttonPump3_Click);
            // 
            // buttonPump4
            // 
            this.buttonPump4.Location = new System.Drawing.Point(134, 238);
            this.buttonPump4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump4.Name = "buttonPump4";
            this.buttonPump4.Size = new System.Drawing.Size(27, 29);
            this.buttonPump4.TabIndex = 20;
            this.buttonPump4.Text = "4";
            this.buttonPump4.UseVisualStyleBackColor = true;
            this.buttonPump4.Click += new System.EventHandler(this.buttonPump4_Click);
            // 
            // buttonPump5
            // 
            this.buttonPump5.Location = new System.Drawing.Point(42, 331);
            this.buttonPump5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump5.Name = "buttonPump5";
            this.buttonPump5.Size = new System.Drawing.Size(27, 29);
            this.buttonPump5.TabIndex = 21;
            this.buttonPump5.Text = "5";
            this.buttonPump5.UseVisualStyleBackColor = true;
            this.buttonPump5.Click += new System.EventHandler(this.buttonPump5_Click);
            // 
            // buttonPump6
            // 
            this.buttonPump6.Location = new System.Drawing.Point(134, 331);
            this.buttonPump6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPump6.Name = "buttonPump6";
            this.buttonPump6.Size = new System.Drawing.Size(27, 29);
            this.buttonPump6.TabIndex = 22;
            this.buttonPump6.Text = "6";
            this.buttonPump6.UseVisualStyleBackColor = true;
            this.buttonPump6.Click += new System.EventHandler(this.buttonPump6_Click);
            // 
            // labelPriceLitre
            // 
            this.labelPriceLitre.AutoSize = true;
            this.labelPriceLitre.BackColor = System.Drawing.Color.Transparent;
            this.labelPriceLitre.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriceLitre.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPriceLitre.Location = new System.Drawing.Point(420, 188);
            this.labelPriceLitre.Name = "labelPriceLitre";
            this.labelPriceLitre.Size = new System.Drawing.Size(0, 29);
            this.labelPriceLitre.TabIndex = 23;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-9, -2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(792, 454);
            this.pictureBox7.TabIndex = 24;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(770, 429);
            this.Controls.Add(this.labelPriceLitre);
            this.Controls.Add(this.buttonPump6);
            this.Controls.Add(this.buttonPump5);
            this.Controls.Add(this.buttonPump4);
            this.Controls.Add(this.buttonPump3);
            this.Controls.Add(this.buttonPump2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPump1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelSumma);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.numericUpDownVolume);
            this.Controls.Add(this.buttonAI95);
            this.Controls.Add(this.buttonAI92);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(792, 485);
            this.MinimumSize = new System.Drawing.Size(792, 485);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OilCity";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonAI92;
        private System.Windows.Forms.Button buttonAI95;
        private System.Windows.Forms.NumericUpDown numericUpDownVolume;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Label labelSumma;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPump1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button buttonPump2;
        private System.Windows.Forms.Button buttonPump3;
        private System.Windows.Forms.Button buttonPump4;
        private System.Windows.Forms.Button buttonPump5;
        private System.Windows.Forms.Button buttonPump6;
        private System.Windows.Forms.Label labelPriceLitre;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

