namespace RaceReady
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
            tiresLabel = new Label();
            frontLeftLabel = new Label();
            frontRightLabel = new Label();
            rearRightLabel = new Label();
            rearLeftLabel = new Label();
            frontLeftTextBox = new TextBox();
            rearLeftTextBox = new TextBox();
            frontRightTextBox = new TextBox();
            rearRightTextBox = new TextBox();
            resultsLabel = new Label();
            resultsTextBox = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // tiresLabel
            // 
            tiresLabel.AutoSize = true;
            tiresLabel.Location = new Point(12, 9);
            tiresLabel.Name = "tiresLabel";
            tiresLabel.Size = new Size(40, 20);
            tiresLabel.TabIndex = 0;
            tiresLabel.Text = "Tires";
            // 
            // frontLeftLabel
            // 
            frontLeftLabel.AutoSize = true;
            frontLeftLabel.Location = new Point(12, 43);
            frontLeftLabel.Name = "frontLeftLabel";
            frontLeftLabel.Size = new Size(29, 20);
            frontLeftLabel.TabIndex = 1;
            frontLeftLabel.Text = "F/L";
            // 
            // frontRightLabel
            // 
            frontRightLabel.AutoSize = true;
            frontRightLabel.Location = new Point(125, 43);
            frontRightLabel.Name = "frontRightLabel";
            frontRightLabel.Size = new Size(31, 20);
            frontRightLabel.TabIndex = 2;
            frontRightLabel.Text = "F/R";
            // 
            // rearRightLabel
            // 
            rearRightLabel.AutoSize = true;
            rearRightLabel.Location = new Point(125, 85);
            rearRightLabel.Name = "rearRightLabel";
            rearRightLabel.Size = new Size(33, 20);
            rearRightLabel.TabIndex = 3;
            rearRightLabel.Text = "R/R";
            // 
            // rearLeftLabel
            // 
            rearLeftLabel.AutoSize = true;
            rearLeftLabel.Location = new Point(12, 85);
            rearLeftLabel.Name = "rearLeftLabel";
            rearLeftLabel.Size = new Size(31, 20);
            rearLeftLabel.TabIndex = 4;
            rearLeftLabel.Text = "R/L";
            // 
            // frontLeftTextBox
            // 
            frontLeftTextBox.Location = new Point(68, 36);
            frontLeftTextBox.Name = "frontLeftTextBox";
            frontLeftTextBox.Size = new Size(44, 27);
            frontLeftTextBox.TabIndex = 1;
            // 
            // rearLeftTextBox
            // 
            rearLeftTextBox.Location = new Point(68, 78);
            rearLeftTextBox.Name = "rearLeftTextBox";
            rearLeftTextBox.Size = new Size(44, 27);
            rearLeftTextBox.TabIndex = 3;
            // 
            // frontRightTextBox
            // 
            frontRightTextBox.Location = new Point(181, 36);
            frontRightTextBox.Name = "frontRightTextBox";
            frontRightTextBox.Size = new Size(42, 27);
            frontRightTextBox.TabIndex = 2;
            // 
            // rearRightTextBox
            // 
            rearRightTextBox.Location = new Point(181, 78);
            rearRightTextBox.Name = "rearRightTextBox";
            rearRightTextBox.Size = new Size(42, 27);
            rearRightTextBox.TabIndex = 4;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(12, 135);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(58, 20);
            resultsLabel.TabIndex = 15;
            resultsLabel.Text = "Results:";
            // 
            // resultsTextBox
            // 
            resultsTextBox.Location = new Point(89, 128);
            resultsTextBox.Name = "resultsTextBox";
            resultsTextBox.ReadOnly = true;
            resultsTextBox.Size = new Size(125, 27);
            resultsTextBox.TabIndex = 16;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(18, 180);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(94, 29);
            calculateButton.TabIndex = 5;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(138, 180);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(253, 233);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(resultsTextBox);
            Controls.Add(resultsLabel);
            Controls.Add(rearRightTextBox);
            Controls.Add(frontRightTextBox);
            Controls.Add(rearLeftTextBox);
            Controls.Add(frontLeftTextBox);
            Controls.Add(rearLeftLabel);
            Controls.Add(rearRightLabel);
            Controls.Add(frontRightLabel);
            Controls.Add(frontLeftLabel);
            Controls.Add(tiresLabel);
            Name = "Form1";
            Text = "RaceReady";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tiresLabel;
        private Label frontLeftLabel;
        private Label frontRightLabel;
        private Label rearRightLabel;
        private Label rearLeftLabel;
        private TextBox frontLeftTextBox;
        private TextBox rearLeftTextBox;
        private TextBox frontRightTextBox;
        private TextBox rearRightTextBox;
        private Label resultsLabel;
        private TextBox resultsTextBox;
        private Button calculateButton;
        private Button exitButton;
    }
}
