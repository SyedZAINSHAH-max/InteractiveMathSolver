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
            Back = new Button();
            btnLcm = new Button();
            txtLcmInput = new TextBox();
            lblGcdResult = new Label();
            Title = new Label();
            lblLcmResult = new Label();
            SuspendLayout();

            Back.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            Back.BackgroundImageLayout = ImageLayout.Stretch;
            Back.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Back.Location = new Point(14, 41);
            Back.Name = "button2";
            Back.Size = new Size(52, 33);
            Back.TabIndex = 10;
            Back.Text = "\r\n";
            Back.UseVisualStyleBackColor = true;
            Back.Click += button2_Click;

            btnLcm.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnLcm.Location = new Point(12, 176);
            btnLcm.Name = "btnLcm";
            btnLcm.Size = new Size(442, 54);
            btnLcm.TabIndex = 9;
            btnLcm.Text = "Calculate";
            btnLcm.UseVisualStyleBackColor = true;
            btnLcm.Click += btnLcm_Click;

            txtLcmInput.Location = new Point(12, 100);
            txtLcmInput.Multiline = true;
            txtLcmInput.Name = "txtLcmInput";
            txtLcmInput.PlaceholderText = "Enter Numbers Separated by Comma";
            txtLcmInput.Size = new Size(442, 39);
            txtLcmInput.TabIndex = 8;

            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-8, 403);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 7;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;

            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(67, 41);
            Title.Name = "label1";
            Title.Size = new Size(387, 33);
            Title.TabIndex = 6;
            Title.Text = "Find LCM of Multiple Numbers";

            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(14, 280);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 11;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 621);
            Controls.Add(lblLcmResult);
            Controls.Add(Back);
            Controls.Add(btnLcm);
            Controls.Add(txtLcmInput);
            Controls.Add(lblGcdResult);
            Controls.Add(Title);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LCM Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
