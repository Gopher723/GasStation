namespace GasStation
{
    partial class CashReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashReceipt));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPay = new System.Windows.Forms.Button();
            this.buttonAdditionalProducts = new System.Windows.Forms.Button();
            this.labelTypeGas = new System.Windows.Forms.Label();
            this.labelCountLitres = new System.Windows.Forms.Label();
            this.labelAllPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelDopPrice = new System.Windows.Forms.Label();
            this.labelOilPrice = new System.Windows.Forms.Label();
            this.labelNuberPump = new System.Windows.Forms.Label();
            this.labelNumberPump = new System.Windows.Forms.Label();
            this.buttonDiscountCard = new System.Windows.Forms.Button();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelAmountDiscount = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(683, 613);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип топлива:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "Количество литров:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(24, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Итог к оплате:";
            // 
            // buttonPay
            // 
            this.buttonPay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPay.Location = new System.Drawing.Point(468, 515);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(172, 92);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "ОПЛАТИТЬ";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // buttonAdditionalProducts
            // 
            this.buttonAdditionalProducts.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdditionalProducts.Location = new System.Drawing.Point(32, 515);
            this.buttonAdditionalProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAdditionalProducts.Name = "buttonAdditionalProducts";
            this.buttonAdditionalProducts.Size = new System.Drawing.Size(172, 92);
            this.buttonAdditionalProducts.TabIndex = 4;
            this.buttonAdditionalProducts.Text = "Выбрать дополнительные товары";
            this.buttonAdditionalProducts.UseVisualStyleBackColor = true;
            this.buttonAdditionalProducts.Click += new System.EventHandler(this.buttonAdditionalProducts_Click);
            // 
            // labelTypeGas
            // 
            this.labelTypeGas.AutoSize = true;
            this.labelTypeGas.BackColor = System.Drawing.Color.Transparent;
            this.labelTypeGas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeGas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTypeGas.Location = new System.Drawing.Point(354, 28);
            this.labelTypeGas.Name = "labelTypeGas";
            this.labelTypeGas.Size = new System.Drawing.Size(0, 34);
            this.labelTypeGas.TabIndex = 5;
            // 
            // labelCountLitres
            // 
            this.labelCountLitres.AutoSize = true;
            this.labelCountLitres.BackColor = System.Drawing.Color.Transparent;
            this.labelCountLitres.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountLitres.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCountLitres.Location = new System.Drawing.Point(354, 70);
            this.labelCountLitres.Name = "labelCountLitres";
            this.labelCountLitres.Size = new System.Drawing.Size(0, 34);
            this.labelCountLitres.TabIndex = 6;
            // 
            // labelAllPrice
            // 
            this.labelAllPrice.AutoSize = true;
            this.labelAllPrice.BackColor = System.Drawing.Color.Transparent;
            this.labelAllPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAllPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAllPrice.Location = new System.Drawing.Point(266, 421);
            this.labelAllPrice.Name = "labelAllPrice";
            this.labelAllPrice.Size = new System.Drawing.Size(0, 34);
            this.labelAllPrice.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(27, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(218, 34);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата покупки:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.BackColor = System.Drawing.Color.Transparent;
            this.labelData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelData.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelData.Location = new System.Drawing.Point(354, 154);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(0, 34);
            this.labelData.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(26, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 34);
            this.label9.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(0, 398);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(600, 2);
            this.label10.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(26, 196);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(289, 34);
            this.label12.TabIndex = 14;
            this.label12.Text = "Топливо на сумму:";
            // 
            // labelDopPrice
            // 
            this.labelDopPrice.AutoSize = true;
            this.labelDopPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDopPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDopPrice.Location = new System.Drawing.Point(354, 255);
            this.labelDopPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDopPrice.Name = "labelDopPrice";
            this.labelDopPrice.Size = new System.Drawing.Size(0, 34);
            this.labelDopPrice.TabIndex = 15;
            // 
            // labelOilPrice
            // 
            this.labelOilPrice.AutoSize = true;
            this.labelOilPrice.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOilPrice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelOilPrice.Location = new System.Drawing.Point(354, 196);
            this.labelOilPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOilPrice.Name = "labelOilPrice";
            this.labelOilPrice.Size = new System.Drawing.Size(0, 34);
            this.labelOilPrice.TabIndex = 16;
            // 
            // labelNuberPump
            // 
            this.labelNuberPump.AutoSize = true;
            this.labelNuberPump.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNuberPump.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNuberPump.Location = new System.Drawing.Point(26, 112);
            this.labelNuberPump.Name = "labelNuberPump";
            this.labelNuberPump.Size = new System.Drawing.Size(177, 33);
            this.labelNuberPump.TabIndex = 17;
            this.labelNuberPump.Text = "Номер ТРК:";
            // 
            // labelNumberPump
            // 
            this.labelNumberPump.AutoSize = true;
            this.labelNumberPump.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNumberPump.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelNumberPump.Location = new System.Drawing.Point(354, 112);
            this.labelNumberPump.Name = "labelNumberPump";
            this.labelNumberPump.Size = new System.Drawing.Size(0, 33);
            this.labelNumberPump.TabIndex = 18;
            // 
            // buttonDiscountCard
            // 
            this.buttonDiscountCard.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
            this.buttonDiscountCard.Location = new System.Drawing.Point(250, 515);
            this.buttonDiscountCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDiscountCard.Name = "buttonDiscountCard";
            this.buttonDiscountCard.Size = new System.Drawing.Size(172, 92);
            this.buttonDiscountCard.TabIndex = 19;
            this.buttonDiscountCard.Text = "Применить скидочную карту";
            this.buttonDiscountCard.UseVisualStyleBackColor = true;
            this.buttonDiscountCard.Click += new System.EventHandler(this.buttonDiscountCard_Click);
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelDiscount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDiscount.Location = new System.Drawing.Point(26, 330);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(0, 34);
            this.labelDiscount.TabIndex = 20;
            // 
            // labelAmountDiscount
            // 
            this.labelAmountDiscount.AutoSize = true;
            this.labelAmountDiscount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.labelAmountDiscount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAmountDiscount.Location = new System.Drawing.Point(385, 344);
            this.labelAmountDiscount.Name = "labelAmountDiscount";
            this.labelAmountDiscount.Size = new System.Drawing.Size(0, 34);
            this.labelAmountDiscount.TabIndex = 21;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBox1.Location = new System.Drawing.Point(31, 474);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(271, 28);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Отправить чек на почту";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CashReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(675, 620);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelAmountDiscount);
            this.Controls.Add(this.labelDiscount);
            this.Controls.Add(this.buttonDiscountCard);
            this.Controls.Add(this.labelNumberPump);
            this.Controls.Add(this.labelNuberPump);
            this.Controls.Add(this.labelOilPrice);
            this.Controls.Add(this.labelDopPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelAllPrice);
            this.Controls.Add(this.labelCountLitres);
            this.Controls.Add(this.labelTypeGas);
            this.Controls.Add(this.buttonAdditionalProducts);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(697, 676);
            this.MinimumSize = new System.Drawing.Size(697, 676);
            this.Name = "CashReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OilCity";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.Button buttonAdditionalProducts;
        private System.Windows.Forms.Label labelTypeGas;
        private System.Windows.Forms.Label labelCountLitres;
        private System.Windows.Forms.Label labelAllPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelDopPrice;
        private System.Windows.Forms.Label labelOilPrice;
        private System.Windows.Forms.Label labelNuberPump;
        private System.Windows.Forms.Label labelNumberPump;
        private System.Windows.Forms.Button buttonDiscountCard;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelAmountDiscount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}