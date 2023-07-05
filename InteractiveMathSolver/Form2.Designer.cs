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
            this.Title = new System.Windows.Forms.Label();
            this.lblGcdResult = new System.Windows.Forms.Label();
            this.txtGcdInput = new System.Windows.Forms.TextBox();
            this.btnGcd = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(34, 36);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(261, 23);
            this.Title.TabIndex = 1;
            this.Title.Text = "Find GCD of Multiple Numbers";
            // 
            // lblGcdResult
            // 
            this.lblGcdResult.AutoSize = true;
            this.lblGcdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGcdResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGcdResult.Location = new System.Drawing.Point(17, 166);
            this.lblGcdResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGcdResult.Name = "lblGcdResult";
            this.lblGcdResult.Size = new System.Drawing.Size(2, 23);
            this.lblGcdResult.TabIndex = 2;
            this.lblGcdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGcdInput
            // 
            this.txtGcdInput.Location = new System.Drawing.Point(17, 77);
            this.txtGcdInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtGcdInput.Multiline = true;
            this.txtGcdInput.Name = "txtGcdInput";
            this.txtGcdInput.PlaceholderText = "Enter Numbers Seperated by Comma";
            this.txtGcdInput.Size = new System.Drawing.Size(311, 25);
            this.txtGcdInput.TabIndex = 3;
            // 
            // btnGcd
            // 
            this.btnGcd.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGcd.Location = new System.Drawing.Point(17, 118);
            this.btnGcd.Margin = new System.Windows.Forms.Padding(2);
            this.btnGcd.Name = "btnGcd";
            this.btnGcd.Size = new System.Drawing.Size(309, 32);
            this.btnGcd.TabIndex = 4;
            this.btnGcd.Text = "Calculate";
            this.btnGcd.UseVisualStyleBackColor = true;
            this.btnGcd.Click += new System.EventHandler(this.btnGcd_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(2, -1);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(36, 25);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "\r\n";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(13, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter numbers seperated by comma";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.btnGcd);
            this.Controls.Add(this.txtGcdInput);
            this.Controls.Add(this.lblGcdResult);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find GCD of multiple numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label lblGcdResult;
        private TextBox txtGcdInput;
        private Button btnGcd;
        private Button BackButton;
        private Label label1;
    }
}