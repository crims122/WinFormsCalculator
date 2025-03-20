namespace MyCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtTotal = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn0 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            plusBtn = new Button();
            minusBtn = new Button();
            multiplyBtn = new Button();
            divideBtn = new Button();
            clearBtn = new Button();
            equalsBtn = new Button();
            SuspendLayout();
            // 
            // txtTotal
            // 
            txtTotal.Cursor = Cursors.No;
            txtTotal.Font = new Font("Segoe UI Black", 24F, FontStyle.Bold);
            txtTotal.Location = new Point(50, 20);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(473, 56);
            txtTotal.TabIndex = 0;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(64, 64, 64);
            btn1.Cursor = Cursors.Hand;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(50, 95);
            btn1.Name = "btn1";
            btn1.Size = new Size(70, 65);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(64, 64, 64);
            btn2.Cursor = Cursors.Hand;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(141, 95);
            btn2.Name = "btn2";
            btn2.Size = new Size(70, 65);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(64, 64, 64);
            btn3.Cursor = Cursors.Hand;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(235, 95);
            btn3.Name = "btn3";
            btn3.Size = new Size(70, 65);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(64, 64, 64);
            btn4.Cursor = Cursors.Hand;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(328, 95);
            btn4.Name = "btn4";
            btn4.Size = new Size(70, 65);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(64, 64, 64);
            btn5.Cursor = Cursors.Hand;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(419, 95);
            btn5.Name = "btn5";
            btn5.Size = new Size(70, 65);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(64, 64, 64);
            btn0.Cursor = Cursors.Hand;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(419, 181);
            btn0.Name = "btn0";
            btn0.Size = new Size(70, 65);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(64, 64, 64);
            btn9.Cursor = Cursors.Hand;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(328, 181);
            btn9.Name = "btn9";
            btn9.Size = new Size(70, 65);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(64, 64, 64);
            btn8.Cursor = Cursors.Hand;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(235, 181);
            btn8.Name = "btn8";
            btn8.Size = new Size(70, 65);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(64, 64, 64);
            btn7.Cursor = Cursors.Hand;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(141, 181);
            btn7.Name = "btn7";
            btn7.Size = new Size(70, 65);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(64, 64, 64);
            btn6.Cursor = Cursors.Hand;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(50, 181);
            btn6.Name = "btn6";
            btn6.Size = new Size(70, 65);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // plusBtn
            // 
            plusBtn.BackColor = Color.FromArgb(64, 64, 64);
            plusBtn.Cursor = Cursors.Hand;
            plusBtn.FlatStyle = FlatStyle.Flat;
            plusBtn.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            plusBtn.ForeColor = SystemColors.ButtonFace;
            plusBtn.Location = new Point(50, 265);
            plusBtn.Name = "plusBtn";
            plusBtn.Size = new Size(70, 65);
            plusBtn.TabIndex = 11;
            plusBtn.Text = "+";
            plusBtn.UseVisualStyleBackColor = false;
            plusBtn.Click += plusBtn_Click;
            // 
            // minusBtn
            // 
            minusBtn.BackColor = Color.FromArgb(64, 64, 64);
            minusBtn.Cursor = Cursors.Hand;
            minusBtn.FlatStyle = FlatStyle.Flat;
            minusBtn.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            minusBtn.ForeColor = SystemColors.ButtonFace;
            minusBtn.Location = new Point(141, 265);
            minusBtn.Name = "minusBtn";
            minusBtn.Size = new Size(70, 65);
            minusBtn.TabIndex = 12;
            minusBtn.Text = "-";
            minusBtn.UseVisualStyleBackColor = false;
            minusBtn.Click += minusBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = Color.FromArgb(64, 64, 64);
            multiplyBtn.Cursor = Cursors.Hand;
            multiplyBtn.FlatStyle = FlatStyle.Flat;
            multiplyBtn.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            multiplyBtn.ForeColor = SystemColors.ButtonFace;
            multiplyBtn.Location = new Point(235, 265);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(70, 65);
            multiplyBtn.TabIndex = 13;
            multiplyBtn.Text = "*";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = Color.FromArgb(64, 64, 64);
            divideBtn.Cursor = Cursors.Hand;
            divideBtn.FlatStyle = FlatStyle.Flat;
            divideBtn.Font = new Font("Segoe UI Black", 19F, FontStyle.Bold);
            divideBtn.ForeColor = SystemColors.ButtonFace;
            divideBtn.Location = new Point(328, 265);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(70, 65);
            divideBtn.TabIndex = 14;
            divideBtn.Text = "/";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.FromArgb(64, 64, 64);
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.ForeColor = SystemColors.ButtonFace;
            clearBtn.Location = new Point(419, 265);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(143, 65);
            clearBtn.TabIndex = 16;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // equalsBtn
            // 
            equalsBtn.BackColor = Color.FromArgb(64, 64, 64);
            equalsBtn.Cursor = Cursors.Hand;
            equalsBtn.FlatStyle = FlatStyle.Flat;
            equalsBtn.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            equalsBtn.ForeColor = SystemColors.ButtonFace;
            equalsBtn.Location = new Point(50, 345);
            equalsBtn.Name = "equalsBtn";
            equalsBtn.Size = new Size(512, 65);
            equalsBtn.TabIndex = 15;
            equalsBtn.Text = "=";
            equalsBtn.UseVisualStyleBackColor = false;
            equalsBtn.Click += equalsBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImage = Properties.Resources.solid_gray;
            ClientSize = new Size(574, 450);
            Controls.Add(clearBtn);
            Controls.Add(equalsBtn);
            Controls.Add(divideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(minusBtn);
            Controls.Add(plusBtn);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTotal;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn0;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button plusBtn;
        private Button minusBtn;
        private Button multiplyBtn;
        private Button divideBtn;
        private Button clearBtn;
        private Button equalsBtn;
    }
}
