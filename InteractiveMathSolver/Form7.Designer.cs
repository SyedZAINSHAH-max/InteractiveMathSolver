using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form7
    {
        // Required designer variable
        private System.ComponentModel.IContainer components = null;

        // Clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        // Initialize the form and its components
        private void InitializeComponent()
        {
            this.txtA12 = new System.Windows.Forms.TextBox();
            this.txtA21 = new System.Windows.Forms.TextBox();
            this.txtA11 = new System.Windows.Forms.TextBox();
            this.txtA22 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLcmResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA12
            // 
            this.txtA12.Location = new System.Drawing.Point(42, 116);
            this.txtA12.Multiline = true;
            this.txtA12.Name = "txtA12";
            this.txtA12.PlaceholderText = "Enter Coefficient of 2";
            this.txtA12.Size = new System.Drawing.Size(442, 39);
            this.txtA12.TabIndex = 35;
            // 
            // txtA21
            // 
            this.txtA21.Location = new System.Drawing.Point(42, 161);
            this.txtA21.Multiline = true;
            this.txtA21.Name = "txtA21";
            this.txtA21.PlaceholderText = "Enter Coefficient of 3";
            this.txtA21.Size = new System.Drawing.Size(442, 39);
            this.txtA21.TabIndex = 36;
            // 
            // txtA11
            // 
            this.txtA11.Location = new System.Drawing.Point(42, 71);
            this.txtA11.Multiline = true;
            this.txtA11.Name = "txtA11";
            this.txtA11.PlaceholderText = "Enter Coefficient of 1";
            this.txtA11.Size = new System.Drawing.Size(442, 39);
            this.txtA11.TabIndex = 30;
            // 
            // txtA22
            // 
            this.txtA22.Location = new System.Drawing.Point(42, 206);
            this.txtA22.Multiline = true;
            this.txtA22.Name = "txtA22";
            this.txtA22.PlaceholderText = "Enter Coefficient of 4";
            this.txtA22.Size = new System.Drawing.Size(442, 39);
            this.txtA22.TabIndex = 37;
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(42, 251);
            this.txtB1.Multiline = true;
            this.txtB1.Name = "txtB1";
            this.txtB1.PlaceholderText = "Enter Coefficient of 5";
            this.txtB1.Size = new System.Drawing.Size(442, 39);
            this.txtB1.TabIndex = 38;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(42, 296);
            this.txtB2.Multiline = true;
            this.txtB2.Name = "txtB2";
            this.txtB2.PlaceholderText = "Enter Coefficient of 6";
            this.txtB2.Size = new System.Drawing.Size(442, 39);
            this.txtB2.TabIndex = 39;
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSolve.Location = new System.Drawing.Point(42, 353);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(442, 54);
            this.btnSolve.TabIndex = 31;
            this.btnSolve.Text = "Calculate";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Solve a system of linear equations of 2 or 3 unknowns using Cramer’s rule";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(1, -1);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(43, 33);
            this.Back.TabIndex = 32;
            this.Back.Text = "\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(42, 431);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(2, 23);
            this.lblResult.TabIndex = 29;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLcmResult
            // 
            this.lblLcmResult.AutoSize = true;
            this.lblLcmResult.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLcmResult.Location = new System.Drawing.Point(1, 329);
            this.lblLcmResult.Name = "lblLcmResult";
            this.lblLcmResult.Size = new System.Drawing.Size(0, 16);
            this.lblLcmResult.TabIndex = 33;
            this.lblLcmResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 653);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA22);
            this.Controls.Add(this.txtA21);
            this.Controls.Add(this.txtA12);
            this.Controls.Add(this.txtA11);
            this.Controls.Add(this.lblLcmResult);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.btnSolve);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form7";
            this.Text = "Cramer\'s Rule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtA12;
        private TextBox txtA21;
        private TextBox txtA11;
        private TextBox txtA22;
        private TextBox txtB1;
        private TextBox txtB2;
        private Button btnSolve;
        private Label label1;
        private Button Back;
        private Label lblResult;
        private Label lblLcmResult;
    }
}
