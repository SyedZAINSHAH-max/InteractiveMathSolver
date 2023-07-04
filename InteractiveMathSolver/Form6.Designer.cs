using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form6
    {
        private TextBox txtMatrixSize;
        private Label lblDeterminantResult;
        private Label lblLcmResult;
        private Button BackButton;
        private Button btnFindDeterminant;
        private TextBox txtMatrixInput;
        private Label lblGcdResult;
        private Label Title;

        private void InitializeComponent()
        {
            txtMatrixSize = new TextBox
            {
                Location = new Point(12, 154),
                Multiline = true,
                Name = "txtMatrixSize",
                PlaceholderText = "Enter the Size of Matrix",
                Size = new Size(442, 39),
                TabIndex = 35
            };

            lblDeterminantResult = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(12, 298),
                Name = "lblDeterminantResult",
                Size = new Size(2, 33),
                TabIndex = 34
            };

            lblLcmResult = new Label
            {
                AutoSize = true,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(-29, 367),
                Name = "lblLcmResult",
                Size = new Size(0, 22),
                TabIndex = 33,
                TextAlign = ContentAlignment.MiddleLeft
            };

            BackButton = new Button
            {
                BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(12, 52),
                Name = "button2",
                Size = new Size(52, 33),
                TabIndex = 32,
                Text = "\r\n",
                UseVisualStyleBackColor = true
            };
            BackButton.Click += button2_Click;

            btnFindDeterminant = new Button
            {
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(12, 214),
                Name = "btnFindDeterminant",
                Size = new Size(442, 54),
                TabIndex = 31,
                Text = "Calculate",
                UseVisualStyleBackColor = true
            };
            btnFindDeterminant.Click += btnFindDeterminant_Click;

            txtMatrixInput = new TextBox
            {
                Location = new Point(12, 109),
                Multiline = true,
                Name = "txtMatrixInput",
                PlaceholderText = "Enter the Matrix Value",
                Size = new Size(442, 39),
                TabIndex = 30
            };

            lblGcdResult = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(-51, 490),
                Name = "lblGcdResult",
                Size = new Size(2, 33),
                TabIndex = 29,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Title = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(70, 61),
                Name = "label1",
                Size = new Size(392, 19),
                TabIndex = 28,
                Text = "Find the Determinant of Any Integer Matrix Up To 4x4"
            };

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(477, 582);
            Controls.Add(txtMatrixSize);
            Controls.Add(lblDeterminantResult);
            Controls.Add(lblLcmResult);
            Controls.Add(BackButton);
            Controls.Add(btnFindDeterminant);
            Controls.Add(txtMatrixInput);
            Controls.Add(lblGcdResult);
            Controls.Add(Title);
            Name = "Form6";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
