using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel MainMenuLayout;
        private Label GCDLabel;
        private TableLayoutPanel tableLayoutPanel5;
        private Label LCMLabel;
        private Label Title;
        private Button GCDButton;
        private Button LCMButton;
        private Button LinearEquationButton;
        private Button QuadraticEquationButton;
        private Button DeterminantMatrixButton;
        private Button LinearEquationsByCramerRuleButton;

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
            MainMenuLayout = new TableLayoutPanel();
            GCDLabel = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            LCMLabel = new Label();
            Title = new Label();
            GCDButton = new Button();
            LCMButton = new Button();
            LinearEquationButton = new Button();
            QuadraticEquationButton = new Button();
            DeterminantMatrixButton = new Button();
            LinearEquationsByCramerRuleButton = new Button();
            SuspendLayout();

            MainMenuLayout.ColumnCount = 1;
            MainMenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainMenuLayout.Location = new Point(0, 0);
            MainMenuLayout.Name = "MainMenuLayout";
            MainMenuLayout.RowCount = 1;
            MainMenuLayout.Size = new Size(200, 100);
            MainMenuLayout.TabIndex = 0;

            GCDLabel.AutoSize = true;
            GCDLabel.BorderStyle = BorderStyle.FixedSingle;
            GCDLabel.Dock = DockStyle.Fill;
            GCDLabel.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            GCDLabel.Location = new Point(9, 0);
            GCDLabel.Margin = new Padding(9, 0, 9, 0);
            GCDLabel.Name = "GCDLabel";
            GCDLabel.Size = new Size(182, 100);
            GCDLabel.TabIndex = 3;
            GCDLabel.Text = "Find GCD of multiple numbers";
            GCDLabel.TextAlign = ContentAlignment.MiddleCenter;

            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;

            LCMLabel.AutoSize = true;
            LCMLabel.BorderStyle = BorderStyle.FixedSingle;
            LCMLabel.Dock = DockStyle.Fill;
            LCMLabel.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LCMLabel.Location = new Point(9, 0);
            LCMLabel.Margin = new Padding(9, 0, 9, 0);
            LCMLabel.Name = "LCMLabel";
            LCMLabel.Size = new Size(182, 100);
            LCMLabel.TabIndex = 4;
            LCMLabel.Text = "Find LCM of multiple numbers";
            LCMLabel.TextAlign = ContentAlignment.MiddleCenter;

            Title.AutoSize = true;
            Title.BorderStyle = BorderStyle.FixedSingle;
            Title.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(14, 7);
            Title.Name = "Title";
            Title.Size = new Size(494, 46);
            Title.TabIndex = 0;
            Title.Text = "Interactive Math Solver";

            GCDButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            GCDButton.Location = new Point(32, 66);
            GCDButton.Name = "GCDButton";
            GCDButton.Size = new Size(442, 54);
            GCDButton.TabIndex = 1;
            GCDButton.Text = "Find GCD of multiple numbers";
            GCDButton.UseVisualStyleBackColor = true;
            GCDButton.Click += button1_Click;

            LCMButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LCMButton.Location = new Point(32, 141);
            LCMButton.Name = "LCMButton";
            LCMButton.Size = new Size(442, 54);
            LCMButton.TabIndex = 2;
            LCMButton.Text = "Find LCM of multiple numbers";
            LCMButton.UseVisualStyleBackColor = true;
            LCMButton.Click += button2_Click;

            LinearEquationButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LinearEquationButton.Location = new Point(32, 293);
            LinearEquationButton.Name = "LinearEquationButton";
            LinearEquationButton.Size = new Size(442, 54);
            LinearEquationButton.TabIndex = 4;
            LinearEquationButton.Text = "Solve Quadratic equations with double coefficients";
            LinearEquationButton.UseVisualStyleBackColor = true;
            LinearEquationButton.Click += button3_Click;

            QuadraticEquationButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            QuadraticEquationButton.Location = new Point(32, 218);
            QuadraticEquationButton.Name = "QuadraticEquationButton";
            QuadraticEquationButton.Size = new Size(442, 54);
            QuadraticEquationButton.TabIndex = 3;
            QuadraticEquationButton.Text = "Solve Linear equations with double coefficients";
            QuadraticEquationButton.UseVisualStyleBackColor = true;
            QuadraticEquationButton.Click += button4_Click;

            DeterminantMatrixButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeterminantMatrixButton.Location = new Point(32, 442);
            DeterminantMatrixButton.Name = "DeterminantMatrixButton";
            DeterminantMatrixButton.Size = new Size(442, 54);
            DeterminantMatrixButton.TabIndex = 6;
            DeterminantMatrixButton.Text = "Solve a system of linear equations of 2 or 3 unknowns using Cramer’s rule";
            DeterminantMatrixButton.UseVisualStyleBackColor = true;
            DeterminantMatrixButton.Click += button5_Click;

            LinearEquationsByCramerRuleButton.Font = new Font("Britannic Bold", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LinearEquationsByCramerRuleButton.Location = new Point(32, 367);
            LinearEquationsByCramerRuleButton.Name = "LinearEquationsByCramerRuleButton";
            LinearEquationsByCramerRuleButton.Size = new Size(442, 54);
            LinearEquationsByCramerRuleButton.TabIndex = 5;
            LinearEquationsByCramerRuleButton.Text = "Find the determinant of any integer matrix up to 4x4";
            LinearEquationsByCramerRuleButton.UseVisualStyleBackColor = true;
            LinearEquationsByCramerRuleButton.Click += button6_Click;

            MainMenuLayout.ColumnCount = 1;
            MainMenuLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            MainMenuLayout.Location = new Point(0, 0);
            MainMenuLayout.Name = "MainMenuLayout";
            MainMenuLayout.RowCount = 1;
            MainMenuLayout.Size = new Size(200, 100);
            MainMenuLayout.TabIndex = 0;

            GCDLabel.AutoSize = true;
            GCDLabel.BorderStyle = BorderStyle.FixedSingle;
            GCDLabel.Dock = DockStyle.Fill;
            GCDLabel.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            GCDLabel.Location = new Point(9, 0);
            GCDLabel.Margin = new Padding(9, 0, 9, 0);
            GCDLabel.Name = "GCDLabel";
            GCDLabel.Size = new Size(182, 100);
            GCDLabel.TabIndex = 3;
            GCDLabel.Text = "Find GCD of multiple numbers";
            GCDLabel.TextAlign = ContentAlignment.MiddleCenter;

            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;

            LCMLabel.AutoSize = true;
            LCMLabel.BorderStyle = BorderStyle.FixedSingle;
            LCMLabel.Dock = DockStyle.Fill;
            LCMLabel.Font = new Font("Stencil", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LCMLabel.Location = new Point(9, 0);
            LCMLabel.Margin = new Padding(9, 0, 9, 0);
            LCMLabel.Name = "LCMLabel";
            LCMLabel.Size = new Size(182, 100);
            LCMLabel.TabIndex = 4;
            LCMLabel.Text = "Find LCM of multiple numbers";
            LCMLabel.TextAlign = ContentAlignment.MiddleCenter;

            AutoScaleDimensions = new SizeF(29F, 54F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 544);
            Controls.Add(DeterminantMatrixButton);
            Controls.Add(LinearEquationsByCramerRuleButton);
            Controls.Add(LinearEquationButton);
            Controls.Add(QuadraticEquationButton);
            Controls.Add(LCMButton);
            Controls.Add(GCDButton);
            Controls.Add(Title);
            Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(9, 6, 9, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
