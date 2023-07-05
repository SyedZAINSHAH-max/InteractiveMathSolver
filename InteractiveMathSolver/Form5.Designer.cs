using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form5
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
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLcmResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSolveQuadratic = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblGcdResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(11, 253);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 23);
            this.lblResult.TabIndex = 25;
            // 
            // lblLcmResult
            // 
            this.lblLcmResult.AutoSize = true;
            this.lblLcmResult.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLcmResult.Location = new System.Drawing.Point(-13, 443);
            this.lblLcmResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLcmResult.Name = "lblLcmResult";
            this.lblLcmResult.Size = new System.Drawing.Size(0, 16);
            this.lblLcmResult.TabIndex = 24;
            this.lblLcmResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(2, 1);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 25);
            this.button2.TabIndex = 23;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSolveQuadratic
            // 
            this.btnSolveQuadratic.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolveQuadratic.Location = new System.Drawing.Point(23, 183);
            this.btnSolveQuadratic.Margin = new System.Windows.Forms.Padding(2);
            this.btnSolveQuadratic.Name = "btnSolveQuadratic";
            this.btnSolveQuadratic.Size = new System.Drawing.Size(265, 28);
            this.btnSolveQuadratic.TabIndex = 22;
            this.btnSolveQuadratic.Text = "Calculate";
            this.btnSolveQuadratic.UseVisualStyleBackColor = true;
            this.btnSolveQuadratic.Click += new System.EventHandler(this.btnSolveQuadratic_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(23, 74);
            this.txtA.Margin = new System.Windows.Forms.Padding(2);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.PlaceholderText = "Enter Coeffiecient of a";
            this.txtA.Size = new System.Drawing.Size(267, 22);
            this.txtA.TabIndex = 21;
            // 
            // lblGcdResult
            // 
            this.lblGcdResult.AutoSize = true;
            this.lblGcdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGcdResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGcdResult.Location = new System.Drawing.Point(-27, 237);
            this.lblGcdResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGcdResult.Name = "lblGcdResult";
            this.lblGcdResult.Size = new System.Drawing.Size(2, 23);
            this.lblGcdResult.TabIndex = 20;
            this.lblGcdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 19);
            this.label1.TabIndex = 19;
            this.label1.Text = "Solve Quadratic Equations Coefficients";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(23, 110);
            this.txtB.Margin = new System.Windows.Forms.Padding(2);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.PlaceholderText = "Enter Coeffiecient of b";
            this.txtB.Size = new System.Drawing.Size(267, 22);
            this.txtB.TabIndex = 26;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(23, 146);
            this.txtC.Margin = new System.Windows.Forms.Padding(2);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.PlaceholderText = "Enter Coeffiecient of c";
            this.txtC.Size = new System.Drawing.Size(267, 22);
            this.txtC.TabIndex = 27;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 335);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblLcmResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSolveQuadratic);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblGcdResult);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblResult;
        private Label lblLcmResult;
        private Button button2;
        private Button btnSolveQuadratic;
        private TextBox txtA;
        private Label lblGcdResult;
        private Label label1;
        private TextBox txtB;
        private TextBox txtC;
    }
}