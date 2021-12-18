namespace GasStation
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.buttonOutputScreen = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.buttonEnd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonOutputScreen
            // 
            this.buttonOutputScreen.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOutputScreen.Location = new System.Drawing.Point(52, 32);
            this.buttonOutputScreen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOutputScreen.Name = "buttonOutputScreen";
            this.buttonOutputScreen.Size = new System.Drawing.Size(118, 80);
            this.buttonOutputScreen.TabIndex = 1;
            this.buttonOutputScreen.Text = "Вывести отчет на экран";
            this.buttonOutputScreen.UseVisualStyleBackColor = true;
            this.buttonOutputScreen.Click += new System.EventHandler(this.buttonOutputScreen_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDownload.Location = new System.Drawing.Point(240, 32);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(118, 80);
            this.buttonDownload.TabIndex = 2;
            this.buttonDownload.Text = "Скачать отчет на компьютер";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(52, 138);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(502, 286);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // buttonEnd
            // 
            this.buttonEnd.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnd.Location = new System.Drawing.Point(436, 32);
            this.buttonEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEnd.Name = "buttonEnd";
            this.buttonEnd.Size = new System.Drawing.Size(117, 80);
            this.buttonEnd.TabIndex = 4;
            this.buttonEnd.Text = "Закончить просмотр";
            this.buttonEnd.UseVisualStyleBackColor = true;
            this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(605, 444);
            this.Controls.Add(this.buttonEnd);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonOutputScreen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(627, 500);
            this.MinimumSize = new System.Drawing.Size(627, 500);
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OilCity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonOutputScreen;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button buttonEnd;
    }
}