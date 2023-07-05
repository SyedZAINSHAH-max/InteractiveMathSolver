using System.Drawing;
using System.Windows.Forms;

namespace InteractiveMathSolver
{
    partial class Form6
    {
        // Declare the controls
        private TextBox txtMatrixSize;            // TextBox for matrix size input
        private Label lblDeterminantResult;       // Label for determinant result display
        private Label lblLcmResult;               // Label for LCM result display
        private Button button2;                   // Button for navigation
        private Button btnFindDeterminant;        // Button to find determinant
        private TextBox txtMatrixInput;           // TextBox for matrix input
        private Label lblGcdResult;               // Label for GCD result display
        private Label label1;                     // Label for instructions

        // Method to initialize the form and its components
        private void InitializeComponent()
        {
            this.txtMatrixSize = new System.Windows.Forms.TextBox();
            this.lblDeterminantResult = new System.Windows.Forms.Label();
            this.lblLcmResult = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnFindDeterminant = new System.Windows.Forms.Button();
            this.txtMatrixInput = new System.Windows.Forms.TextBox();
            this.lblGcdResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMatrixSize
            // 
            this.txtMatrixSize.Location = new System.Drawing.Point(200, 112);
            this.txtMatrixSize.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixSize.Multiline = true;
            this.txtMatrixSize.Name = "txtMatrixSize";
            this.txtMatrixSize.PlaceholderText = "Enter the Size of Matrix";
            this.txtMatrixSize.Size = new System.Drawing.Size(311, 25);
            this.txtMatrixSize.TabIndex = 35;
            // 
            // lblDeterminantResult
            // 
            this.lblDeterminantResult.AutoSize = true;
            this.lblDeterminantResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeterminantResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDeterminantResult.Location = new System.Drawing.Point(8, 179);
            this.lblDeterminantResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeterminantResult.Name = "lblDeterminantResult";
            this.lblDeterminantResult.Size = new System.Drawing.Size(2, 23);
            this.lblDeterminantResult.TabIndex = 34;
            // 
            // lblLcmResult
            // 
            this.lblLcmResult.AutoSize = true;
            this.lblLcmResult.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLcmResult.Location = new System.Drawing.Point(-70, 250);
            this.lblLcmResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLcmResult.Name = "lblLcmResult";
            this.lblLcmResult.Size = new System.Drawing.Size(0, 16);
            this.lblLcmResult.TabIndex = 33;
            this.lblLcmResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::InteractiveMathSolver.Properties.Resources.png_transparent_computer_icons_computer_software_information_jenzabar_microsoft_button_back_angle_text_logo;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(8, 11);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 37);
            this.button2.TabIndex = 32;
            this.button2.Text = "\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFindDeterminant
            // 
            this.btnFindDeterminant.Font = new System.Drawing.Font("Britannic Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFindDeterminant.Location = new System.Drawing.Point(200, 154);
            this.btnFindDeterminant.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindDeterminant.Name = "btnFindDeterminant";
            this.btnFindDeterminant.Size = new System.Drawing.Size(309, 32);
            this.btnFindDeterminant.TabIndex = 31;
            this.btnFindDeterminant.Text = "Calculate";
            this.btnFindDeterminant.UseVisualStyleBackColor = true;
            this.btnFindDeterminant.Click += new System.EventHandler(this.btnFindDeterminant_Click);
            // 
            // txtMatrixInput
            // 
            this.txtMatrixInput.Location = new System.Drawing.Point(200, 83);
            this.txtMatrixInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtMatrixInput.Multiline = true;
            this.txtMatrixInput.Name = "txtMatrixInput";
            this.txtMatrixInput.PlaceholderText = "Enter the Matrix Value";
            this.txtMatrixInput.Size = new System.Drawing.Size(311, 25);
            this.txtMatrixInput.TabIndex = 30;
            // 
            // lblGcdResult
            // 
            this.lblGcdResult.AutoSize = true;
            this.lblGcdResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGcdResult.Font = new System.Drawing.Font("Britannic Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGcdResult.Location = new System.Drawing.Point(-36, 294);
            this.lblGcdResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGcdResult.Name = "lblGcdResult";
            this.lblGcdResult.Size = new System.Drawing.Size(2, 23);
            this.lblGcdResult.TabIndex = 29;
            this.lblGcdResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(151, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Find the Determinant of Any Integer Matrix Up To 4x4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Matrix Values will have values seperated by comma and rows seperated by \"-\".   Ex" +
    "ample: 2,2-2,2";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(151, 314);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Size will be number of rows of Square matrix. Example: 2";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 349);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMatrixSize);
            this.Controls.Add(this.lblDeterminantResult);
            this.Controls.Add(this.lblLcmResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFindDeterminant);
            this.Controls.Add(this.txtMatrixInput);
            this.Controls.Add(this.lblGcdResult);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label label2;
        private Label label3;
    }
}
