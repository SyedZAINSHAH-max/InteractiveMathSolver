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
            this.MainMenuLayout = new System.Windows.Forms.TableLayoutPanel();
            this.GCDLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.LCMLabel = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.GCDButton = new System.Windows.Forms.Button();
            this.LCMButton = new System.Windows.Forms.Button();
            this.LinearEquationButton = new System.Windows.Forms.Button();
            this.QuadraticEquationButton = new System.Windows.Forms.Button();
            this.DeterminantMatrixButton = new System.Windows.Forms.Button();
            this.LinearEquationsByCramerRuleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainMenuLayout
            // 
            this.MainMenuLayout.ColumnCount = 1;
            this.MainMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainMenuLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainMenuLayout.Location = new System.Drawing.Point(0, 0);
            this.MainMenuLayout.Name = "MainMenuLayout";
            this.MainMenuLayout.RowCount = 1;
            this.MainMenuLayout.Size = new System.Drawing.Size(200, 100);
            this.MainMenuLayout.TabIndex = 0;
            // 
            // GCDLabel
            // 
            this.GCDLabel.AutoSize = true;
            this.GCDLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GCDLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GCDLabel.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GCDLabel.Location = new System.Drawing.Point(9, 0);
            this.GCDLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.GCDLabel.Name = "GCDLabel";
            this.GCDLabel.Size = new System.Drawing.Size(182, 100);
            this.GCDLabel.TabIndex = 3;
            this.GCDLabel.Text = "Find GCD of multiple numbers";
            this.GCDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // LCMLabel
            // 
            this.LCMLabel.AutoSize = true;
            this.LCMLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCMLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCMLabel.Font = new System.Drawing.Font("Stencil", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LCMLabel.Location = new System.Drawing.Point(9, 0);
            this.LCMLabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.LCMLabel.Name = "LCMLabel";
            this.LCMLabel.Size = new System.Drawing.Size(182, 100);
            this.LCMLabel.TabIndex = 4;
            this.LCMLabel.Text = "Find LCM of multiple numbers";
            this.LCMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(86, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(333, 32);
            this.Title.TabIndex = 0;
            this.Title.Text = "Interactive Math Solver";
            // 
            // GCDButton
            // 
            this.GCDButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GCDButton.Location = new System.Drawing.Point(32, 66);
            this.GCDButton.Name = "GCDButton";
            this.GCDButton.Size = new System.Drawing.Size(442, 54);
            this.GCDButton.TabIndex = 1;
            this.GCDButton.Text = "Find GCD of multiple numbers";
            this.GCDButton.UseVisualStyleBackColor = true;
            this.GCDButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LCMButton
            // 
            this.LCMButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LCMButton.Location = new System.Drawing.Point(32, 141);
            this.LCMButton.Name = "LCMButton";
            this.LCMButton.Size = new System.Drawing.Size(442, 54);
            this.LCMButton.TabIndex = 2;
            this.LCMButton.Text = "Find LCM of multiple numbers";
            this.LCMButton.UseVisualStyleBackColor = true;
            this.LCMButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // LinearEquationButton
            // 
            this.LinearEquationButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinearEquationButton.Location = new System.Drawing.Point(32, 293);
            this.LinearEquationButton.Name = "LinearEquationButton";
            this.LinearEquationButton.Size = new System.Drawing.Size(442, 54);
            this.LinearEquationButton.TabIndex = 4;
            this.LinearEquationButton.Text = "Solve Quadratic equations with double coefficients";
            this.LinearEquationButton.UseVisualStyleBackColor = true;
            this.LinearEquationButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuadraticEquationButton
            // 
            this.QuadraticEquationButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QuadraticEquationButton.Location = new System.Drawing.Point(32, 218);
            this.QuadraticEquationButton.Name = "QuadraticEquationButton";
            this.QuadraticEquationButton.Size = new System.Drawing.Size(442, 54);
            this.QuadraticEquationButton.TabIndex = 3;
            this.QuadraticEquationButton.Text = "Solve Linear equations with double coefficients";
            this.QuadraticEquationButton.UseVisualStyleBackColor = true;
            this.QuadraticEquationButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // DeterminantMatrixButton
            // 
            this.DeterminantMatrixButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeterminantMatrixButton.Location = new System.Drawing.Point(32, 442);
            this.DeterminantMatrixButton.Name = "DeterminantMatrixButton";
            this.DeterminantMatrixButton.Size = new System.Drawing.Size(442, 54);
            this.DeterminantMatrixButton.TabIndex = 6;
            this.DeterminantMatrixButton.Text = "Solve a system of linear equations of 2 or 3 unknowns using Cramer’s rule";
            this.DeterminantMatrixButton.UseVisualStyleBackColor = true;
            this.DeterminantMatrixButton.Click += new System.EventHandler(this.button6_Click);
            // 
            // LinearEquationsByCramerRuleButton
            // 
            this.LinearEquationsByCramerRuleButton.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinearEquationsByCramerRuleButton.Location = new System.Drawing.Point(32, 367);
            this.LinearEquationsByCramerRuleButton.Name = "LinearEquationsByCramerRuleButton";
            this.LinearEquationsByCramerRuleButton.Size = new System.Drawing.Size(442, 54);
            this.LinearEquationsByCramerRuleButton.TabIndex = 5;
            this.LinearEquationsByCramerRuleButton.Text = "Find the determinant of any integer matrix up to 4x4";
            this.LinearEquationsByCramerRuleButton.UseVisualStyleBackColor = true;
            this.LinearEquationsByCramerRuleButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 544);
            this.Controls.Add(this.DeterminantMatrixButton);
            this.Controls.Add(this.LinearEquationsByCramerRuleButton);
            this.Controls.Add(this.LinearEquationButton);
            this.Controls.Add(this.QuadraticEquationButton);
            this.Controls.Add(this.LCMButton);
            this.Controls.Add(this.GCDButton);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(9, 6, 9, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}
