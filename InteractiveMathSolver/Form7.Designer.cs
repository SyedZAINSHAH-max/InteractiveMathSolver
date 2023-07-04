using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form7
    {
        private TextBox CoefficientInputOf2;
        private TextBox CoefficientInputOf3;
        private Button btnSolve;
        private Label Title;
        private Button BackButton;
        private TextBox CoefficientInputOf1;
        private Label lblResult;
        private Label lblLcmResult;
        private TextBox CoefficientInputOf6;
        private TextBox CoefficientInputOf5;
        private TextBox CoefficientInputOf4;

        private void InitializeComponent()
        {
            // Input Text Box For Coefficient 2
            CoefficientInputOf2 = new TextBox
            {
                Location = new Point(42, 116),
                Multiline = true,
                Name = "txtA12",
                PlaceholderText = "Enter Coefficient of 2",
                Size = new Size(442, 39),
                TabIndex = 35
            };

            // Input Text Box For Coefficient 3
            CoefficientInputOf3 = new TextBox
            {
                Location = new Point(42, 161),
                Multiline = true,
                Name = "txtA21",
                PlaceholderText = "Enter Coefficient of 3",
                Size = new Size(442, 39),
                TabIndex = 36
            };

            // Solve Button
            btnSolve = new Button
            {
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(42, 353),
                Name = "btnSolve",
                Size = new Size(442, 54),
                TabIndex = 31,
                Text = "Calculate",
                UseVisualStyleBackColor = true
            };
            btnSolve.Click += btnSolve_Click;

            // Title Label
            Title = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(130, 14),
                Name = "label1",
                Size = new Size(322, 36),
                TabIndex = 28,
                Text = "Solve a system of linear equations of 2 or 3\r\n unknowns using Cramer’s rule",
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Back Button
            BackButton = new Button
            {
                BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(60, 14),
                Name = "button2",
                Size = new Size(52, 33),
                TabIndex = 32,
                Text = "\r\n",
                UseVisualStyleBackColor = true
            };
            BackButton.Click += button2_Click;

            // Input Text Box For Coefficient 1
            CoefficientInputOf1 = new TextBox
            {
                Location = new Point(42, 71),
                Multiline = true,
                Name = "txtA11",
                PlaceholderText = "Enter Coefficient of 1",
                Size = new Size(442, 39),
                TabIndex = 30
            };

            // Result Label
            lblResult = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(42, 431),
                Name = "lblResult",
                Size = new Size(2, 33),
                TabIndex = 29,
                TextAlign = ContentAlignment.MiddleLeft
            };
            lblResult.Click += lblGcdResult_Click;

            // LCM Result Label
            lblLcmResult = new Label
            {
                AutoSize = true,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(1, 329),
                Name = "lblLcmResult",
                Size = new Size(0, 22),
                TabIndex = 33,
                TextAlign = ContentAlignment.MiddleLeft
            };

            // Input Text Box For Coefficient 6
            CoefficientInputOf6 = new TextBox
            {
                Location = new Point(42, 296),
                Multiline = true,
                Name = "txtB2",
                PlaceholderText = "Enter Coefficient of 6",
                Size = new Size(442, 39),
                TabIndex = 39
            };

            // Input Text Box For Coefficient 5
            CoefficientInputOf5 = new TextBox
            {
                Location = new Point(42, 251),
                Multiline = true,
                Name = "txtB1",
                PlaceholderText = "Enter Coefficient of 5",
                Size = new Size(442, 39),
                TabIndex = 38
            };

            // Input Text Box For Coefficient 4
            CoefficientInputOf4 = new TextBox
            {
                Location = new Point(42, 206),
                Multiline = true,
                Name = "txtA22",
                PlaceholderText = "Enter Coefficient of 4",
                Size = new Size(442, 39),
                TabIndex = 37
            };

            // Form7
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 653);
            Controls.Add(CoefficientInputOf6);
            Controls.Add(CoefficientInputOf5);
            Controls.Add(CoefficientInputOf4);
            Controls.Add(CoefficientInputOf3);
            Controls.Add(CoefficientInputOf2);
            Controls.Add(lblLcmResult);
            Controls.Add(BackButton);
            Controls.Add(btnSolve);
            Controls.Add(lblResult);
            Controls.Add(CoefficientInputOf1);
            Controls.Add(Title);
            Name = "Form7";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Interactive Math Solver";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
