namespace DemoUIComponents
{
    partial class ClientControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DirectorLabel = new System.Windows.Forms.Label();
            this.TelephoneLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CompanyLabel.Location = new System.Drawing.Point(12, 15);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(270, 22);
            this.CompanyLabel.TabIndex = 0;
            this.CompanyLabel.Text = "Тип | Наименование партнёра";
            this.CompanyLabel.Click += new System.EventHandler(this.CompanyLabel_Click);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel.Location = new System.Drawing.Point(325, 15);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(49, 22);
            this.DiscountLabel.TabIndex = 1;
            this.DiscountLabel.Text = "10%";
            // 
            // DirectorLabel
            // 
            this.DirectorLabel.AutoSize = true;
            this.DirectorLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DirectorLabel.Location = new System.Drawing.Point(14, 46);
            this.DirectorLabel.Name = "DirectorLabel";
            this.DirectorLabel.Size = new System.Drawing.Size(60, 13);
            this.DirectorLabel.TabIndex = 2;
            this.DirectorLabel.Text = "Директор";
            // 
            // TelephoneLabel
            // 
            this.TelephoneLabel.AutoSize = true;
            this.TelephoneLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelephoneLabel.Location = new System.Drawing.Point(14, 60);
            this.TelephoneLabel.Name = "TelephoneLabel";
            this.TelephoneLabel.Size = new System.Drawing.Size(93, 13);
            this.TelephoneLabel.TabIndex = 3;
            this.TelephoneLabel.Text = "+7 223 322 22 32";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RatingLabel.Location = new System.Drawing.Point(14, 74);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(68, 13);
            this.RatingLabel.TabIndex = 4;
            this.RatingLabel.Text = "Рейтинг: 10";
            // 
            // ClientControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(232)))), ((int)(((byte)(211)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.TelephoneLabel);
            this.Controls.Add(this.DirectorLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.CompanyLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ClientControl";
            this.Size = new System.Drawing.Size(407, 102);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClientControl_MouseClick);
            this.MouseEnter += new System.EventHandler(this.ClientControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ClientControl_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label DirectorLabel;
        private System.Windows.Forms.Label TelephoneLabel;
        private System.Windows.Forms.Label RatingLabel;
    }
}
