namespace GrpcClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputTextBox = new TextBox();
            upperBtn = new Button();
            outputUpper = new TextBox();
            SuspendLayout();
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(66, 64);
            inputTextBox.Margin = new Padding(3, 2, 3, 2);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(316, 23);
            inputTextBox.TabIndex = 0;
            inputTextBox.Text = "Text to upper case";
            // 
            // upperBtn
            // 
            upperBtn.Location = new Point(165, 101);
            upperBtn.Margin = new Padding(3, 2, 3, 2);
            upperBtn.Name = "upperBtn";
            upperBtn.Size = new Size(128, 43);
            upperBtn.TabIndex = 1;
            upperBtn.Text = "UPPER";
            upperBtn.UseVisualStyleBackColor = true;
            upperBtn.Click += upperBtn_click;
            // 
            // outputUpper
            // 
            outputUpper.Location = new Point(66, 167);
            outputUpper.Margin = new Padding(3, 2, 3, 2);
            outputUpper.Name = "outputUpper";
            outputUpper.ReadOnly = true;
            outputUpper.Size = new Size(316, 23);
            outputUpper.TabIndex = 2;
            outputUpper.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 278);
            Controls.Add(outputUpper);
            Controls.Add(upperBtn);
            Controls.Add(inputTextBox);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputTextBox;
        private Button upperBtn;
        private TextBox outputUpper;
    }
}
