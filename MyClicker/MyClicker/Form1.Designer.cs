namespace MyClicker
{
    partial class Form1
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
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonClick = new System.Windows.Forms.Button();
            this.labelShop1 = new System.Windows.Forms.Label();
            this.labelShop2 = new System.Windows.Forms.Label();
            this.buttonP1 = new System.Windows.Forms.Button();
            this.buttonP2 = new System.Windows.Forms.Button();
            this.buttonP3 = new System.Windows.Forms.Button();
            this.buttonP4 = new System.Windows.Forms.Button();
            this.buttonP5 = new System.Windows.Forms.Button();
            this.labelTarget = new System.Windows.Forms.Label();
            this.buttonA1 = new System.Windows.Forms.Button();
            this.buttonA2 = new System.Windows.Forms.Button();
            this.buttonA3 = new System.Windows.Forms.Button();
            this.buttonA4 = new System.Windows.Forms.Button();
            this.buttonA5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoney.Location = new System.Drawing.Point(82, 61);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(134, 31);
            this.labelMoney.TabIndex = 0;
            this.labelMoney.Text = "Деньги: 0";
            // 
            // buttonClick
            // 
            this.buttonClick.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClick.Location = new System.Drawing.Point(88, 211);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(223, 124);
            this.buttonClick.TabIndex = 1;
            this.buttonClick.Text = "Клик";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // labelShop1
            // 
            this.labelShop1.AutoSize = true;
            this.labelShop1.Location = new System.Drawing.Point(402, 79);
            this.labelShop1.Name = "labelShop1";
            this.labelShop1.Size = new System.Drawing.Size(99, 13);
            this.labelShop1.TabIndex = 2;
            this.labelShop1.Text = "Деньги за клик: 1";
            // 
            // labelShop2
            // 
            this.labelShop2.AutoSize = true;
            this.labelShop2.Location = new System.Drawing.Point(603, 79);
            this.labelShop2.Name = "labelShop2";
            this.labelShop2.Size = new System.Drawing.Size(109, 13);
            this.labelShop2.TabIndex = 3;
            this.labelShop2.Text = "Деньги в секунду: 0";
            // 
            // buttonP1
            // 
            this.buttonP1.Location = new System.Drawing.Point(405, 133);
            this.buttonP1.Name = "buttonP1";
            this.buttonP1.Size = new System.Drawing.Size(120, 50);
            this.buttonP1.TabIndex = 4;
            this.buttonP1.Text = "+1 (100)";
            this.buttonP1.UseVisualStyleBackColor = true;
            this.buttonP1.Click += new System.EventHandler(this.buttonP1_Click);
            // 
            // buttonP2
            // 
            this.buttonP2.Location = new System.Drawing.Point(405, 189);
            this.buttonP2.Name = "buttonP2";
            this.buttonP2.Size = new System.Drawing.Size(120, 48);
            this.buttonP2.TabIndex = 5;
            this.buttonP2.Text = "+10 (800)";
            this.buttonP2.UseVisualStyleBackColor = true;
            this.buttonP2.Click += new System.EventHandler(this.buttonP2_Click);
            // 
            // buttonP3
            // 
            this.buttonP3.Location = new System.Drawing.Point(405, 243);
            this.buttonP3.Name = "buttonP3";
            this.buttonP3.Size = new System.Drawing.Size(120, 47);
            this.buttonP3.TabIndex = 6;
            this.buttonP3.Text = "+50 (4000)";
            this.buttonP3.UseVisualStyleBackColor = true;
            this.buttonP3.Click += new System.EventHandler(this.buttonP3_Click);
            // 
            // buttonP4
            // 
            this.buttonP4.Location = new System.Drawing.Point(405, 296);
            this.buttonP4.Name = "buttonP4";
            this.buttonP4.Size = new System.Drawing.Size(120, 49);
            this.buttonP4.TabIndex = 7;
            this.buttonP4.Text = "+200 (18000)";
            this.buttonP4.UseVisualStyleBackColor = true;
            this.buttonP4.Click += new System.EventHandler(this.buttonP4_Click);
            // 
            // buttonP5
            // 
            this.buttonP5.Location = new System.Drawing.Point(405, 351);
            this.buttonP5.Name = "buttonP5";
            this.buttonP5.Size = new System.Drawing.Size(120, 48);
            this.buttonP5.TabIndex = 8;
            this.buttonP5.Text = "+1000 (90000)";
            this.buttonP5.UseVisualStyleBackColor = true;
            this.buttonP5.Click += new System.EventHandler(this.buttonP5_Click);
            // 
            // labelTarget
            // 
            this.labelTarget.AutoSize = true;
            this.labelTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTarget.Location = new System.Drawing.Point(130, 379);
            this.labelTarget.Name = "labelTarget";
            this.labelTarget.Size = new System.Drawing.Size(57, 20);
            this.labelTarget.TabIndex = 9;
            this.labelTarget.Text = "Цель: ";
            // 
            // buttonA1
            // 
            this.buttonA1.Location = new System.Drawing.Point(606, 133);
            this.buttonA1.Name = "buttonA1";
            this.buttonA1.Size = new System.Drawing.Size(116, 50);
            this.buttonA1.TabIndex = 10;
            this.buttonA1.Text = "+1 (1000)";
            this.buttonA1.UseVisualStyleBackColor = true;
            this.buttonA1.Click += new System.EventHandler(this.buttonA1_Click);
            // 
            // buttonA2
            // 
            this.buttonA2.Location = new System.Drawing.Point(606, 190);
            this.buttonA2.Name = "buttonA2";
            this.buttonA2.Size = new System.Drawing.Size(116, 47);
            this.buttonA2.TabIndex = 11;
            this.buttonA2.Text = "+10 (8000)";
            this.buttonA2.UseVisualStyleBackColor = true;
            this.buttonA2.Click += new System.EventHandler(this.buttonA2_Click);
            // 
            // buttonA3
            // 
            this.buttonA3.Location = new System.Drawing.Point(606, 244);
            this.buttonA3.Name = "buttonA3";
            this.buttonA3.Size = new System.Drawing.Size(116, 46);
            this.buttonA3.TabIndex = 12;
            this.buttonA3.Text = "+50 (40000)";
            this.buttonA3.UseVisualStyleBackColor = true;
            this.buttonA3.Click += new System.EventHandler(this.buttonA3_Click);
            // 
            // buttonA4
            // 
            this.buttonA4.Location = new System.Drawing.Point(606, 297);
            this.buttonA4.Name = "buttonA4";
            this.buttonA4.Size = new System.Drawing.Size(116, 48);
            this.buttonA4.TabIndex = 13;
            this.buttonA4.Text = "+200 (180000)";
            this.buttonA4.UseVisualStyleBackColor = true;
            this.buttonA4.Click += new System.EventHandler(this.buttonA4_Click);
            // 
            // buttonA5
            // 
            this.buttonA5.Location = new System.Drawing.Point(606, 352);
            this.buttonA5.Name = "buttonA5";
            this.buttonA5.Size = new System.Drawing.Size(116, 47);
            this.buttonA5.TabIndex = 14;
            this.buttonA5.Text = "+1000 (900000)";
            this.buttonA5.UseVisualStyleBackColor = true;
            this.buttonA5.Click += new System.EventHandler(this.buttonA5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonA5);
            this.Controls.Add(this.buttonA4);
            this.Controls.Add(this.buttonA3);
            this.Controls.Add(this.buttonA2);
            this.Controls.Add(this.buttonA1);
            this.Controls.Add(this.labelTarget);
            this.Controls.Add(this.buttonP5);
            this.Controls.Add(this.buttonP4);
            this.Controls.Add(this.buttonP3);
            this.Controls.Add(this.buttonP2);
            this.Controls.Add(this.buttonP1);
            this.Controls.Add(this.labelShop2);
            this.Controls.Add(this.labelShop1);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.labelMoney);
            this.Name = "Form1";
            this.Text = "MyClicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Label labelShop1;
        private System.Windows.Forms.Label labelShop2;
        private System.Windows.Forms.Button buttonP1;
        private System.Windows.Forms.Button buttonP2;
        private System.Windows.Forms.Button buttonP3;
        private System.Windows.Forms.Button buttonP4;
        private System.Windows.Forms.Button buttonP5;
        private System.Windows.Forms.Label labelTarget;
        private System.Windows.Forms.Button buttonA1;
        private System.Windows.Forms.Button buttonA2;
        private System.Windows.Forms.Button buttonA3;
        private System.Windows.Forms.Button buttonA4;
        private System.Windows.Forms.Button buttonA5;
    }
}

