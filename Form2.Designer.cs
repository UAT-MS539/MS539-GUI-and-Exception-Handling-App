namespace MS539_GUI_and_Exception_Handling_App
{
    partial class Form2
    {
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
            descriptionLabel = new Label();
            totalPayLabel = new Label();
            backButton = new Button();
            SuspendLayout();
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new Point(75, 36);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(57, 15);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = "Total Pay:";
            // 
            // totalPayLabel
            // 
            totalPayLabel.BorderStyle = BorderStyle.FixedSingle;
            totalPayLabel.Location = new Point(148, 36);
            totalPayLabel.Name = "totalPayLabel";
            totalPayLabel.Size = new Size(100, 23);
            totalPayLabel.TabIndex = 1;
            totalPayLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.Location = new Point(121, 87);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 2;
            backButton.Text = "Go Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 138);
            Controls.Add(backButton);
            Controls.Add(totalPayLabel);
            Controls.Add(descriptionLabel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label descriptionLabel;
        private Label totalPayLabel;
        private Button backButton;
    }
}