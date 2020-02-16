namespace lab1_3
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.num6 = new System.Windows.Forms.TextBox();
            this.num8 = new System.Windows.Forms.TextBox();
            this.num7 = new System.Windows.Forms.TextBox();
            this.num10 = new System.Windows.Forms.TextBox();
            this.num9 = new System.Windows.Forms.TextBox();
            this.num4 = new System.Windows.Forms.TextBox();
            this.num3 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.TextBox();
            this.num5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.execButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.result, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.execButton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.exitButton, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.16456F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(366, 267);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(142, 45);
            this.num6.MaxLength = 4;
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(65, 20);
            this.num6.TabIndex = 9;
            this.num6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(285, 45);
            this.num8.MaxLength = 4;
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(66, 20);
            this.num8.TabIndex = 8;
            this.num8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(213, 45);
            this.num7.MaxLength = 4;
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(66, 20);
            this.num7.TabIndex = 7;
            this.num7.TextChanged += new System.EventHandler(this.num7_TextChanged);
            this.num7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num10
            // 
            this.num10.Location = new System.Drawing.Point(0, 45);
            this.num10.MaxLength = 4;
            this.num10.Name = "num10";
            this.num10.Size = new System.Drawing.Size(66, 20);
            this.num10.TabIndex = 6;
            this.num10.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(72, 45);
            this.num9.MaxLength = 4;
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(64, 20);
            this.num9.TabIndex = 4;
            this.num9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(213, 19);
            this.num4.MaxLength = 4;
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(66, 20);
            this.num4.TabIndex = 3;
            this.num4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(142, 19);
            this.num3.MaxLength = 4;
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(65, 20);
            this.num3.TabIndex = 2;
            this.num3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(72, 19);
            this.num2.MaxLength = 4;
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(64, 20);
            this.num2.TabIndex = 1;
            this.num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(0, 19);
            this.num1.MaxLength = 4;
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(66, 20);
            this.num1.TabIndex = 0;
            this.num1.TextChanged += new System.EventHandler(this.num1_TextChanged);
            this.num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(285, 19);
            this.num5.MaxLength = 4;
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(66, 20);
            this.num5.TabIndex = 5;
            this.num5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите 10 положительных четырехзначных целых чисел";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(3, 135);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(63, 20);
            this.result.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label2, 4);
            this.label2.Location = new System.Drawing.Point(3, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество чисел, сумма цифр которых кратна 7 и их среднее арифметическое меньше " +
    "7";
            // 
            // execButton
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.execButton, 2);
            this.execButton.Location = new System.Drawing.Point(3, 169);
            this.execButton.Name = "execButton";
            this.execButton.Size = new System.Drawing.Size(75, 23);
            this.execButton.TabIndex = 13;
            this.execButton.Text = "Выполнить";
            this.execButton.UseVisualStyleBackColor = true;
            this.execButton.Click += new System.EventHandler(this.execButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(141, 169);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(65, 23);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 5);
            this.groupBox1.Controls.Add(this.num8);
            this.groupBox1.Controls.Add(this.num6);
            this.groupBox1.Controls.Add(this.num7);
            this.groupBox1.Controls.Add(this.num1);
            this.groupBox1.Controls.Add(this.num2);
            this.groupBox1.Controls.Add(this.num3);
            this.groupBox1.Controls.Add(this.num9);
            this.groupBox1.Controls.Add(this.num10);
            this.groupBox1.Controls.Add(this.num4);
            this.groupBox1.Controls.Add(this.num5);
            this.groupBox1.Location = new System.Drawing.Point(3, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 76);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 308);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox num3;
        private System.Windows.Forms.TextBox num6;
        private System.Windows.Forms.TextBox num8;
        private System.Windows.Forms.TextBox num7;
        private System.Windows.Forms.TextBox num10;
        private System.Windows.Forms.TextBox num9;
        private System.Windows.Forms.TextBox num4;
        private System.Windows.Forms.TextBox num5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Button execButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

