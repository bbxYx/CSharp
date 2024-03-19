namespace HelloCSharpWin
{
    partial class Calculator
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
            NumButton1 = new Button();
            NumButton2 = new Button();
            NumButton3 = new Button();
            NumButton4 = new Button();
            NumButton5 = new Button();
            NumButton7 = new Button();
            NumButton9 = new Button();
            NumButton6 = new Button();
            NumButton0 = new Button();
            NumButton8 = new Button();
            NumScreen = new Label();
            NumPlus = new Button();
            NumClear = new Button();
            NumMinus = new Button();
            NumMulti = new Button();
            NumDiv = new Button();
            NumResult = new Button();
            SuspendLayout();
            // 
            // NumButton1
            // 
            NumButton1.Location = new Point(12, 289);
            NumButton1.Name = "NumButton1";
            NumButton1.Size = new Size(108, 94);
            NumButton1.TabIndex = 0;
            NumButton1.Text = "1";
            NumButton1.UseVisualStyleBackColor = true;
            NumButton1.Click += NumButton_Click;
            // 
            // NumButton2
            // 
            NumButton2.Location = new Point(126, 289);
            NumButton2.Name = "NumButton2";
            NumButton2.Size = new Size(102, 94);
            NumButton2.TabIndex = 1;
            NumButton2.Text = "2";
            NumButton2.UseVisualStyleBackColor = true;
            NumButton2.Click += NumButton_Click;
            // 
            // NumButton3
            // 
            NumButton3.Location = new Point(234, 289);
            NumButton3.Name = "NumButton3";
            NumButton3.Size = new Size(101, 94);
            NumButton3.TabIndex = 2;
            NumButton3.Text = "3";
            NumButton3.UseVisualStyleBackColor = true;
            NumButton3.Click += NumButton_Click;
            // 
            // NumButton4
            // 
            NumButton4.Location = new Point(12, 191);
            NumButton4.Name = "NumButton4";
            NumButton4.Size = new Size(108, 92);
            NumButton4.TabIndex = 3;
            NumButton4.Text = "4";
            NumButton4.UseVisualStyleBackColor = true;
            NumButton4.Click += NumButton_Click;
            // 
            // NumButton5
            // 
            NumButton5.Location = new Point(126, 191);
            NumButton5.Name = "NumButton5";
            NumButton5.Size = new Size(102, 92);
            NumButton5.TabIndex = 4;
            NumButton5.Text = "5";
            NumButton5.UseVisualStyleBackColor = true;
            NumButton5.Click += NumButton_Click;
            // 
            // NumButton7
            // 
            NumButton7.Location = new Point(12, 93);
            NumButton7.Name = "NumButton7";
            NumButton7.Size = new Size(108, 92);
            NumButton7.TabIndex = 5;
            NumButton7.Text = "7";
            NumButton7.UseVisualStyleBackColor = true;
            NumButton7.Click += NumButton_Click;
            // 
            // NumButton9
            // 
            NumButton9.Location = new Point(234, 93);
            NumButton9.Name = "NumButton9";
            NumButton9.Size = new Size(101, 92);
            NumButton9.TabIndex = 6;
            NumButton9.Text = "9";
            NumButton9.UseVisualStyleBackColor = true;
            NumButton9.Click += NumButton_Click;
            // 
            // NumButton6
            // 
            NumButton6.Location = new Point(234, 191);
            NumButton6.Name = "NumButton6";
            NumButton6.Size = new Size(101, 92);
            NumButton6.TabIndex = 7;
            NumButton6.Text = "6";
            NumButton6.UseVisualStyleBackColor = true;
            NumButton6.Click += NumButton_Click;
            // 
            // NumButton0
            // 
            NumButton0.Location = new Point(126, 390);
            NumButton0.Name = "NumButton0";
            NumButton0.Size = new Size(102, 94);
            NumButton0.TabIndex = 8;
            NumButton0.Text = "0";
            NumButton0.UseVisualStyleBackColor = true;
            NumButton0.Click += NumButton_Click;
            // 
            // NumButton8
            // 
            NumButton8.Location = new Point(126, 93);
            NumButton8.Name = "NumButton8";
            NumButton8.Size = new Size(102, 92);
            NumButton8.TabIndex = 9;
            NumButton8.Text = "8";
            NumButton8.UseVisualStyleBackColor = true;
            NumButton8.Click += NumButton_Click;
            // 
            // NumScreen
            // 
            NumScreen.BackColor = SystemColors.ButtonHighlight;
            NumScreen.BorderStyle = BorderStyle.Fixed3D;
            NumScreen.Font = new Font("맑은 고딕", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            NumScreen.Location = new Point(12, 9);
            NumScreen.Name = "NumScreen";
            NumScreen.Size = new Size(425, 68);
            NumScreen.TabIndex = 10;
            NumScreen.Text = "0";
            NumScreen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NumPlus
            // 
            NumPlus.Location = new Point(341, 93);
            NumPlus.Name = "NumPlus";
            NumPlus.Size = new Size(96, 92);
            NumPlus.TabIndex = 11;
            NumPlus.Text = "+";
            NumPlus.UseVisualStyleBackColor = true;
            NumPlus.Click += Operation_Click;
            // 
            // NumClear
            // 
            NumClear.Location = new Point(12, 390);
            NumClear.Name = "NumClear";
            NumClear.Size = new Size(108, 94);
            NumClear.TabIndex = 15;
            NumClear.Text = "C";
            NumClear.UseVisualStyleBackColor = true;
            NumClear.Click += NumClear_Click;
            // 
            // NumMinus
            // 
            NumMinus.Location = new Point(341, 191);
            NumMinus.Name = "NumMinus";
            NumMinus.Size = new Size(96, 92);
            NumMinus.TabIndex = 16;
            NumMinus.Text = "-";
            NumMinus.UseVisualStyleBackColor = true;
            NumMinus.Click += Operation_Click;
            // 
            // NumMulti
            // 
            NumMulti.Location = new Point(341, 291);
            NumMulti.Name = "NumMulti";
            NumMulti.Size = new Size(96, 92);
            NumMulti.TabIndex = 17;
            NumMulti.Text = "*";
            NumMulti.UseVisualStyleBackColor = true;
            NumMulti.Click += Operation_Click;
            // 
            // NumDiv
            // 
            NumDiv.Location = new Point(341, 390);
            NumDiv.Name = "NumDiv";
            NumDiv.Size = new Size(96, 94);
            NumDiv.TabIndex = 18;
            NumDiv.Text = "/";
            NumDiv.UseVisualStyleBackColor = true;
            NumDiv.Click += Operation_Click;
            // 
            // NumResult
            // 
            NumResult.Location = new Point(234, 390);
            NumResult.Name = "NumResult";
            NumResult.Size = new Size(101, 94);
            NumResult.TabIndex = 19;
            NumResult.Text = "=";
            NumResult.UseVisualStyleBackColor = true;
            NumResult.Click += Operation_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 508);
            Controls.Add(NumResult);
            Controls.Add(NumDiv);
            Controls.Add(NumMulti);
            Controls.Add(NumMinus);
            Controls.Add(NumClear);
            Controls.Add(NumPlus);
            Controls.Add(NumScreen);
            Controls.Add(NumButton8);
            Controls.Add(NumButton0);
            Controls.Add(NumButton6);
            Controls.Add(NumButton9);
            Controls.Add(NumButton7);
            Controls.Add(NumButton5);
            Controls.Add(NumButton4);
            Controls.Add(NumButton3);
            Controls.Add(NumButton2);
            Controls.Add(NumButton1);
            Name = "Calculator";
            ResumeLayout(false);
        }

        #endregion

        private Button NumButton1;
        private Button NumButton2;
        private Button NumButton3;
        private Button NumButton4;
        private Button NumButton5;
        private Button NumButton7;
        private Button NumButton9;
        private Button NumButton6;
        private Button NumButton0;
        private Button NumButton8;
        private Label NumScreen;
        private Button NumPlus;
        private Button NumClear;
        private Button NumMinus;
        private Button NumMulti;
        private Button NumDiv;
        private Button NumResult;
    }
}
