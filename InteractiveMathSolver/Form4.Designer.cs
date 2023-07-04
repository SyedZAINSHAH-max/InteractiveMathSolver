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
            lblLcmResult = new Label();
            BackButton = new Button();
            btnSolveLinear = new Button();
            txtLinearInput = new TextBox();
            lblGcdResult = new Label();
            Title = new Label();
            lblLinearResult = new Label();
            SuspendLayout();

            lblLcmResult.AutoSize = true;
            lblLcmResult.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblLcmResult.Location = new Point(-19, 337);
            lblLcmResult.Name = "lblLcmResult";
            lblLcmResult.Size = new Size(0, 22);
            lblLcmResult.TabIndex = 17;
            lblLcmResult.TextAlign = ContentAlignment.MiddleLeft;

            BackButton.BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            BackButton.BackgroundImageLayout = ImageLayout.Stretch;
            BackButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            BackButton.Location = new Point(24, 20);
            BackButton.Name = "button2";
            BackButton.Size = new Size(52, 33);
            BackButton.TabIndex = 16;
            BackButton.Text = "\r\n";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += button2_Click;

            btnSolveLinear.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnSolveLinear.Location = new Point(22, 155);
            btnSolveLinear.Name = "btnSolveLinear";
            btnSolveLinear.Size = new Size(442, 54);
            btnSolveLinear.TabIndex = 15;
            btnSolveLinear.Text = "Calculate";
            btnSolveLinear.UseVisualStyleBackColor = true;
            btnSolveLinear.Click += btnSolveLinear_Click;

            txtLinearInput.Location = new Point(22, 79);
            txtLinearInput.Multiline = true;
            txtLinearInput.Name = "txtLinearInput";
            txtLinearInput.PlaceholderText = "Add Linear Equation in the form of ax + b = 0";
            txtLinearInput.Size = new Size(442, 39);
            txtLinearInput.TabIndex = 14;

            lblGcdResult.AutoSize = true;
            lblGcdResult.BorderStyle = BorderStyle.FixedSingle;
            lblGcdResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblGcdResult.Location = new Point(-41, 460);
            lblGcdResult.Name = "lblGcdResult";
            lblGcdResult.Size = new Size(2, 33);
            lblGcdResult.TabIndex = 13;
            lblGcdResult.TextAlign = ContentAlignment.MiddleLeft;

            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(94, 29);
            Title.Name = "label1";
            Title.Size = new Size(349, 19);
            Title.TabIndex = 12;
            Title.Text = "Solve Linear Equations With Double Coefficients";

            lblLinearResult.AutoSize = true;
            lblLinearResult.BorderStyle = BorderStyle.FixedSingle;
            lblLinearResult.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinearResult.Location = new Point(24, 262);
            lblLinearResult.Name = "lblLinearResult";
            lblLinearResult.Size = new Size(2, 33);
            lblLinearResult.TabIndex = 18;

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 631);
            Controls.Add(lblLinearResult);
            Controls.Add(lblLcmResult);
            Controls.Add(BackButton);
            Controls.Add(btnSolveLinear);
            Controls.Add(txtLinearInput);
            Controls.Add(lblGcdResult);
            Controls.Add(Title);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
