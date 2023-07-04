using System;
using System.Drawing;
using System.Windows.Forms;
namespace InteractiveMathSolver
{
    partial class Form2
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
            Title = new Label();
            lblGcdResult = new Label();
            txtGcdInput = new TextBox();
            btnGcd = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(79, 24);
            Title.Name = "label1";
            Title.Size = new Size(387, 33);
            Title.TabIndex = 1;
            Title.Text = "Find GCD of Multiple Numbers";
            Title.Click += label1_Click;
            // 
            // lblGcdResult
            // 
            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(24, 258);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 2;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;
            lblGcdResult.Click += lblGcdResult_Click;
            // 
            // txtGcdInput
            // 
            txtGcdInput.Location = new Point(24, 83);
            txtGcdInput.Multiline = true;
            txtGcdInput.Name = "txtGcdInput";
            txtGcdInput.PlaceholderText = "Enter Numbers Seperated by Comma";
            txtGcdInput.Size = new Size(442, 39);
            txtGcdInput.TabIndex = 3;
            txtGcdInput.TextChanged += txtGcdInput_TextChanged;
            // 
            // btnGcd
            // 
            btnGcd.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnGcd.Location = new Point(24, 159);
            btnGcd.Name = "btnGcd";
            btnGcd.Size = new Size(442, 54);
            btnGcd.TabIndex = 4;
            btnGcd.Text = "Calculate";
            btnGcd.UseVisualStyleBackColor = true;
            btnGcd.Click += btnGcd_Click;
            // 
            // button2
            // 
            BackButton.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(26, 24);
            BackButton.Name = "button2";
            BackButton.Size = new Size(52, 33);
            BackButton.TabIndex = 5;
            BackButton.Text = "\r\n";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 620);
            Controls.Add(BackButton);
            Controls.Add(btnGcd);
            Controls.Add(txtGcdInput);
            Controls.Add(lblGcdResult);
            Controls.Add(Title);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Find GCD of multiple numbers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label lblGcdResult;
        private TextBox txtGcdInput;
        private Button btnGcd;
        private Button BackButton;
    }
}