using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblLcmResult;
        private Button BackButton;
        private Button btnSolveLinear;
        private TextBox txtLinearInput;
        private Label lblGcdResult;
        private Label Title;
        private Label lblLinearResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblLcmResult = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.btnSolveLinear = new System.Windows.Forms.Button();
            this.txtLinearInput = new System.Windows.Forms.TextBox();
            this.lblGcdResult = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.lblLinearResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLcmResult
            // 
            this.lblLcmResult.AutoSize = true;
            this.lblLcmResult.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLcmResult.Location = new System.Drawing.Point(-13, 202);
            this.lblLcmResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLcmResult.Name = "lblLcmResult";
            this.lblLcmResult.Size = new System.Drawing.Size(0, 16);
            this.lblLcmResult.TabIndex = 17;
            this.lblLcmResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackButton
            // 
            this.BackButton.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.BackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackButton.Location = new System.Drawing.Point(0, 2);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(45, 30);
            this.BackButton.TabIndex = 16;
            this.BackButton.Text = "\r\n";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // btnSolveLinear
            // 
            this.btnSolveLinear.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolveLinear.Location = new System.Drawing.Point(17, 149);
            this.btnSolveLinear.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolveLinear.Name = "btnSolveLinear";
            this.btnSolveLinear.Size = new System.Drawing.Size(309, 32);
            this.btnSolveLinear.TabIndex = 15;
            this.btnSolveLinear.Text = "Calculate";
            this.btnSolveLinear.UseVisualStyleBackColor = true;
            this.btnSolveLinear.Click += new System.EventHandler(this.btnSolveLinear_Click);
            // 
            // txtLinearInput
            // 
            this.txtLinearInput.Location = new System.Drawing.Point(17, 99);
            this.txtLinearInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtLinearInput.Multiline = true;
            this.txtLinearInput.Name = "txtLinearInput";
            this.txtLinearInput.PlaceholderText = "Add Linear Equation in the form of ax + b = 0";
            this.txtLinearInput.Size = new System.Drawing.Size(311, 25);
            this.txtLinearInput.TabIndex = 14;
            // 
            // lblGcdResult
            // 
            this.lblGcdResult.AutoSize = true;
            this.lblGcdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGcdResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGcdResult.Location = new System.Drawing.Point(-29, 276);
            this.lblGcdResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGcdResult.Name = "lblGcdResult";
            this.lblGcdResult.Size = new System.Drawing.Size(2, 23);
            this.lblGcdResult.TabIndex = 13;
            this.lblGcdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(9, 59);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(320, 18);
            this.Title.TabIndex = 12;
            this.Title.Text = "Solve Linear Equations With Double Coefficients";
            // 
            // lblLinearResult
            // 
            this.lblLinearResult.AutoSize = true;
            this.lblLinearResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLinearResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLinearResult.Location = new System.Drawing.Point(17, 213);
            this.lblLinearResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinearResult.Name = "lblLinearResult";
            this.lblLinearResult.Size = new System.Drawing.Size(2, 23);
            this.lblLinearResult.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 325);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Linear Equation in the form of ax + b = 0";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLinearResult);
            this.Controls.Add(this.lblLcmResult);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.btnSolveLinear);
            this.Controls.Add(this.txtLinearInput);
            this.Controls.Add(this.lblGcdResult);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
    }
}
