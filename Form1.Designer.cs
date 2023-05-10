namespace Voronoi_firs
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
            this.FieldWidthTB = new System.Windows.Forms.TextBox();
            this.FieldHeightTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AmountOfPointsTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AmountOfThreadsTB = new System.Windows.Forms.TextBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.singleRadio = new System.Windows.Forms.RadioButton();
            this.multiRadio = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FieldWidthTB
            // 
            this.FieldWidthTB.Location = new System.Drawing.Point(69, 37);
            this.FieldWidthTB.Name = "FieldWidthTB";
            this.FieldWidthTB.Size = new System.Drawing.Size(71, 20);
            this.FieldWidthTB.TabIndex = 0;
            this.FieldWidthTB.Text = "500";
            this.FieldWidthTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FieldHeightTB
            // 
            this.FieldHeightTB.Location = new System.Drawing.Point(156, 37);
            this.FieldHeightTB.Name = "FieldHeightTB";
            this.FieldHeightTB.Size = new System.Drawing.Size(71, 20);
            this.FieldHeightTB.TabIndex = 1;
            this.FieldHeightTB.Text = "400";
            this.FieldHeightTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Field size:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Amount of Points:";
            // 
            // AmountOfPointsTB
            // 
            this.AmountOfPointsTB.Location = new System.Drawing.Point(108, 90);
            this.AmountOfPointsTB.Name = "AmountOfPointsTB";
            this.AmountOfPointsTB.Size = new System.Drawing.Size(71, 20);
            this.AmountOfPointsTB.TabIndex = 6;
            this.AmountOfPointsTB.Text = "10";
            this.AmountOfPointsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Amount of Treads:";
            // 
            // AmountOfThreadsTB
            // 
            this.AmountOfThreadsTB.Location = new System.Drawing.Point(108, 133);
            this.AmountOfThreadsTB.Name = "AmountOfThreadsTB";
            this.AmountOfThreadsTB.Size = new System.Drawing.Size(71, 20);
            this.AmountOfThreadsTB.TabIndex = 8;
            this.AmountOfThreadsTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(55, 318);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(105, 45);
            this.GenerateBtn.TabIndex = 9;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(244, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(544, 426);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // singleRadio
            // 
            this.singleRadio.AutoSize = true;
            this.singleRadio.Location = new System.Drawing.Point(15, 176);
            this.singleRadio.Name = "singleRadio";
            this.singleRadio.Size = new System.Drawing.Size(85, 17);
            this.singleRadio.TabIndex = 11;
            this.singleRadio.TabStop = true;
            this.singleRadio.Text = "single thread";
            this.singleRadio.UseVisualStyleBackColor = true;
            // 
            // multiRadio
            // 
            this.multiRadio.AutoSize = true;
            this.multiRadio.Location = new System.Drawing.Point(15, 199);
            this.multiRadio.Name = "multiRadio";
            this.multiRadio.Size = new System.Drawing.Size(79, 17);
            this.multiRadio.TabIndex = 12;
            this.multiRadio.TabStop = true;
            this.multiRadio.Text = "multi thread";
            this.multiRadio.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.multiRadio);
            this.Controls.Add(this.singleRadio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.AmountOfThreadsTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AmountOfPointsTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FieldHeightTB);
            this.Controls.Add(this.FieldWidthTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FieldWidthTB;
        private System.Windows.Forms.TextBox FieldHeightTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AmountOfPointsTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AmountOfThreadsTB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton singleRadio;
        private System.Windows.Forms.RadioButton multiRadio;
    }
}

