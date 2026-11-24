namespace WinFormsApp1
{
    partial class MainForm
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
            CounterLabel = new Label();
            IncreaseCounterButton = new Button();
            HideButtonCheckbox = new CheckBox();
            YearOfBirthTextBox = new TextBox();
            SuspendLayout();
            // 
            // CounterLabel
            // 
            CounterLabel.AutoSize = true;
            CounterLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CounterLabel.Location = new Point(181, 9);
            CounterLabel.Name = "CounterLabel";
            CounterLabel.Size = new Size(40, 46);
            CounterLabel.TabIndex = 0;
            CounterLabel.Text = "0";
            // 
            // IncreaseCounterButton
            // 
            IncreaseCounterButton.BackColor = SystemColors.ControlDark;
            IncreaseCounterButton.Font = new Font("Segoe UI", 20F);
            IncreaseCounterButton.Location = new Point(12, 4);
            IncreaseCounterButton.Name = "IncreaseCounterButton";
            IncreaseCounterButton.Size = new Size(163, 55);
            IncreaseCounterButton.TabIndex = 1;
            IncreaseCounterButton.Text = "Click Me";
            IncreaseCounterButton.UseVisualStyleBackColor = false;
            IncreaseCounterButton.Click += IncreaseCounterButton_Click;
            // 
            // HideButtonCheckbox
            // 
            HideButtonCheckbox.AutoSize = true;
            HideButtonCheckbox.Font = new Font("Segoe UI", 20F);
            HideButtonCheckbox.Location = new Point(12, 65);
            HideButtonCheckbox.Name = "HideButtonCheckbox";
            HideButtonCheckbox.Size = new Size(374, 50);
            HideButtonCheckbox.TabIndex = 2;
            HideButtonCheckbox.Text = "Hide button checkbox";
            HideButtonCheckbox.UseVisualStyleBackColor = true;
            HideButtonCheckbox.CheckedChanged += HideButtonCheckbox_CheckedChanged;
            // 
            // YearOfBirthTextBox
            // 
            YearOfBirthTextBox.Location = new Point(226, 156);
            YearOfBirthTextBox.Name = "YearOfBirthTextBox";
            YearOfBirthTextBox.Size = new Size(308, 27);
            YearOfBirthTextBox.TabIndex = 3;
            YearOfBirthTextBox.KeyPress += YearOfBirthTextBox_KeyPress;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(YearOfBirthTextBox);
            Controls.Add(HideButtonCheckbox);
            Controls.Add(IncreaseCounterButton);
            Controls.Add(CounterLabel);
            Name = "MainForm";
            Text = "Windows Forms App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CounterLabel;
        private Button IncreaseCounterButton;
        private CheckBox HideButtonCheckbox;
        private TextBox YearOfBirthTextBox;
    }
}
