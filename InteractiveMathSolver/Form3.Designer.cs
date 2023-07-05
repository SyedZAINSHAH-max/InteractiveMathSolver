using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;
        private Button Back;
        private Button btnLcm;
        private TextBox txtLcmInput;
        private Label lblGcdResult;
        private Label Title;
        private Label lblLcmResult;

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
            this.Back = new System.Windows.Forms.Button();
            this.btnLcm = new System.Windows.Forms.Button();
            this.txtLcmInput = new System.Windows.Forms.TextBox();
            this.lblGcdResult = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.lblLcmResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Back.Location = new System.Drawing.Point(-2, -1);
            this.Back.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(42, 25);
            this.Back.TabIndex = 10;
            this.Back.Text = "\r\n";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLcm
            // 
            this.btnLcm.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLcm.Location = new System.Drawing.Point(8, 106);
            this.btnLcm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLcm.Name = "btnLcm";
            this.btnLcm.Size = new System.Drawing.Size(309, 32);
            this.btnLcm.TabIndex = 9;
            this.btnLcm.Text = "Calculate";
            this.btnLcm.UseVisualStyleBackColor = true;
            this.btnLcm.Click += new System.EventHandler(this.btnLcm_Click);
            // 
            // txtLcmInput
            // 
            this.txtLcmInput.Location = new System.Drawing.Point(8, 60);
            this.txtLcmInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLcmInput.Multiline = true;
            this.txtLcmInput.Name = "txtLcmInput";
            this.txtLcmInput.PlaceholderText = "Enter Numbers Separated by Comma";
            this.txtLcmInput.Size = new System.Drawing.Size(311, 25);
            this.txtLcmInput.TabIndex = 8;
            // 
            // lblGcdResult
            // 
            this.lblGcdResult.AutoSize = true;
            this.lblGcdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGcdResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGcdResult.Location = new System.Drawing.Point(-6, 242);
            this.lblGcdResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGcdResult.Name = "lblGcdResult";
            this.lblGcdResult.Size = new System.Drawing.Size(2, 23);
            this.lblGcdResult.TabIndex = 7;
            this.lblGcdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(30, 26);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(261, 23);
            this.Title.TabIndex = 6;
            this.Title.Text = "Find LCM of Multiple Numbers";
            // 
            // lblLcmResult
            // 
            this.lblLcmResult.AutoSize = true;
            this.lblLcmResult.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLcmResult.Location = new System.Drawing.Point(10, 168);
            this.lblLcmResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLcmResult.Name = "lblLcmResult";
            this.lblLcmResult.Size = new System.Drawing.Size(0, 16);
            this.lblLcmResult.TabIndex = 11;
            this.lblLcmResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 322);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter numbers seperated by comma";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLcmResult);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.btnLcm);
            this.Controls.Add(this.txtLcmInput);
            this.Controls.Add(this.lblGcdResult);
            this.Controls.Add(this.Title);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LCM Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
    }
}
