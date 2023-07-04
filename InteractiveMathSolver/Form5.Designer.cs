using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form5
    {
        private Label lblResult;
        private Label lblLcmResult;
        private Button BackButton;
        private Button btnSolveQuadratic;
        private TextBox CoefficientInputa;
        private Label lblGcdResult;
        private Label Title;
        private TextBox CoefficientInputb;
        private TextBox CoefficientInputc;

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
            lblResult = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(19, 389),
                Name = "lblResult",
                Size = new Size(2, 33),
                TabIndex = 25
            };

            lblLcmResult = new Label
            {
                AutoSize = true,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(-22, 334),
                Name = "lblLcmResult",
                Size = new Size(0, 22),
                TabIndex = 24,
                TextAlign = ContentAlignment.MiddleLeft
            };

            BackButton = new Button
            {
                BackgroundImage = Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo,
                BackgroundImageLayout = ImageLayout.Stretch,
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(37, 19),
                Name = "button2",
                Size = new Size(52, 33),
                TabIndex = 23,
                Text = "\r\n",
                UseVisualStyleBackColor = true
            };
            BackButton.Click += button2_Click;

            btnSolveQuadratic = new Button
            {
                Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(19, 245),
                Name = "btnSolveQuadratic",
                Size = new Size(442, 54),
                TabIndex = 22,
                Text = "Calculate",
                UseVisualStyleBackColor = true
            };
            btnSolveQuadratic.Click += btnSolveQuadratic_Click;

            CoefficientInputa = new TextBox
            {
                Location = new Point(19, 76),
                Multiline = true,
                Name = "txtA",
                PlaceholderText = "Enter Coefficient of a",
                Size = new Size(442, 39),
                TabIndex = 21
            };

            lblGcdResult = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(-44, 457),
                Name = "lblGcdResult",
                Size = new Size(2, 33),
                TabIndex = 20,
                TextAlign = ContentAlignment.MiddleLeft
            };

            Title = new Label
            {
                AutoSize = true,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Britannic Bold", 8F, FontStyle.Regular, GraphicsUnit.Point),
                Location = new Point(132, 26),
                Name = "label1",
                Size = new Size(283, 19),
                TabIndex = 19,
                Text = "Solve Quadratic Equations Coefficients"
            };

            CoefficientInputb = new TextBox
            {
                Location = new Point(19, 121),
                Multiline = true,
                Name = "txtB",
                PlaceholderText = "Enter Coefficient of b",
                Size = new Size(442, 39),
                TabIndex = 26
            };

            CoefficientInputc = new TextBox
            {
                Location = new Point(19, 166),
                Multiline = true,
                Name = "txtC",
                PlaceholderText = "Enter Coefficient of c",
                Size = new Size(442, 39),
                TabIndex = 27
            };

            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 644);
            Controls.Add(CoefficientInputc);
            Controls.Add(CoefficientInputb);
            Controls.Add(lblResult);
            Controls.Add(lblLcmResult);
            Controls.Add(BackButton);
            Controls.Add(btnSolveQuadratic);
            Controls.Add(CoefficientInputa);
            Controls.Add(lblGcdResult);
            Controls.Add(Title);
            Name = "Form5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
