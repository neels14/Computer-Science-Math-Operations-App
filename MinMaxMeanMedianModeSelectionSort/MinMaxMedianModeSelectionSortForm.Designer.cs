namespace SelectionSort
{
    partial class MinMaxMedianModeSelectionSortForm
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
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SubmitButtonTwo = new System.Windows.Forms.Button();
            this.numberListBox = new System.Windows.Forms.ListBox();
            this.numberListBoxTwo = new System.Windows.Forms.ListBox();
            this.nValueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxButton = new System.Windows.Forms.Button();
            this.MinButton = new System.Windows.Forms.Button();
            this.MeanButton = new System.Windows.Forms.Button();
            this.MedianButton = new System.Windows.Forms.Button();
            this.ModeButton = new System.Windows.Forms.Button();
            this.SortButton = new System.Windows.Forms.Button();
            this.RandomButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SumFirstNumbersButton = new System.Windows.Forms.Button();
            this.SumNumbersWithStartingPositionButton = new System.Windows.Forms.Button();
            this.OddIndexedListButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.ScrambleButton = new System.Windows.Forms.Button();
            this.BinarySearchButton = new System.Windows.Forms.Button();
            this.LinearSearchButton = new System.Windows.Forms.Button();
            this.AscendingRadioButton = new System.Windows.Forms.RadioButton();
            this.DescendingRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(131, 12);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(75, 20);
            this.numberTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter a number:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(212, 12);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(115, 22);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Add to List";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SubmitButtonTwo
            // 
            this.SubmitButtonTwo.Location = new System.Drawing.Point(330, 12);
            this.SubmitButtonTwo.Name = "SubmitButtonTwo";
            this.SubmitButtonTwo.Size = new System.Drawing.Size(115, 22);
            this.SubmitButtonTwo.TabIndex = 2;
            this.SubmitButtonTwo.Text = "Add to Second List";
            this.SubmitButtonTwo.UseVisualStyleBackColor = true;
            this.SubmitButtonTwo.Click += new System.EventHandler(this.SubmitButtonTwo_Click);
            // 
            // numberListBox
            // 
            this.numberListBox.FormattingEnabled = true;
            this.numberListBox.Location = new System.Drawing.Point(12, 164);
            this.numberListBox.Name = "numberListBox";
            this.numberListBox.Size = new System.Drawing.Size(96, 290);
            this.numberListBox.TabIndex = 3;
            // 
            // numberListBoxTwo
            // 
            this.numberListBoxTwo.FormattingEnabled = true;
            this.numberListBoxTwo.Location = new System.Drawing.Point(109, 164);
            this.numberListBoxTwo.Name = "numberListBoxTwo";
            this.numberListBoxTwo.Size = new System.Drawing.Size(96, 290);
            this.numberListBoxTwo.TabIndex = 3;
            // 
            // nValueTextBox
            // 
            this.nValueTextBox.Location = new System.Drawing.Point(74, 43);
            this.nValueTextBox.Name = "nValueTextBox";
            this.nValueTextBox.Size = new System.Drawing.Size(37, 20);
            this.nValueTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Find sum of:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "consecutive numbers!";
            // 
            // xValueTextBox
            // 
            this.xValueTextBox.Location = new System.Drawing.Point(74, 79);
            this.xValueTextBox.Name = "xValueTextBox";
            this.xValueTextBox.Size = new System.Drawing.Size(37, 20);
            this.xValueTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Start at item:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "in the list!";
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(212, 161);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(115, 27);
            this.MaxButton.TabIndex = 4;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(212, 194);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(115, 31);
            this.MinButton.TabIndex = 5;
            this.MinButton.Text = "Min";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            this.MinButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.SubmitButton_MouseUp);
            // 
            // MeanButton
            // 
            this.MeanButton.Location = new System.Drawing.Point(212, 231);
            this.MeanButton.Name = "MeanButton";
            this.MeanButton.Size = new System.Drawing.Size(115, 38);
            this.MeanButton.TabIndex = 6;
            this.MeanButton.Text = "Mean (Average)";
            this.MeanButton.UseVisualStyleBackColor = true;
            this.MeanButton.Click += new System.EventHandler(this.MeanButton_Click);
            // 
            // MedianButton
            // 
            this.MedianButton.Location = new System.Drawing.Point(212, 275);
            this.MedianButton.Name = "MedianButton";
            this.MedianButton.Size = new System.Drawing.Size(115, 31);
            this.MedianButton.TabIndex = 7;
            this.MedianButton.Text = "Median";
            this.MedianButton.UseVisualStyleBackColor = true;
            this.MedianButton.Click += new System.EventHandler(this.MedianButton_Click);
            // 
            // ModeButton
            // 
            this.ModeButton.Location = new System.Drawing.Point(212, 312);
            this.ModeButton.Name = "ModeButton";
            this.ModeButton.Size = new System.Drawing.Size(115, 31);
            this.ModeButton.TabIndex = 8;
            this.ModeButton.Text = "Mode";
            this.ModeButton.UseVisualStyleBackColor = true;
            this.ModeButton.Click += new System.EventHandler(this.ModeButton_Click);
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(212, 349);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(115, 29);
            this.SortButton.TabIndex = 9;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // RandomButton
            // 
            this.RandomButton.Location = new System.Drawing.Point(12, 460);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(150, 23);
            this.RandomButton.TabIndex = 5;
            this.RandomButton.Text = "Fill List With Random Values";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(330, 161);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(115, 27);
            this.ReverseButton.TabIndex = 5;
            this.ReverseButton.Text = "Reverse List";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // SumFirstNumbersButton
            // 
            this.SumFirstNumbersButton.Location = new System.Drawing.Point(330, 194);
            this.SumFirstNumbersButton.Name = "SumFirstNumbersButton";
            this.SumFirstNumbersButton.Size = new System.Drawing.Size(115, 30);
            this.SumFirstNumbersButton.TabIndex = 5;
            this.SumFirstNumbersButton.Text = "Sum of First n Numbers";
            this.SumFirstNumbersButton.UseVisualStyleBackColor = true;
            this.SumFirstNumbersButton.Click += new System.EventHandler(this.SumFirstNumbersButton_Click);
            // 
            // SumNumbersWithStartingPositionButton
            // 
            this.SumNumbersWithStartingPositionButton.Location = new System.Drawing.Point(330, 231);
            this.SumNumbersWithStartingPositionButton.Name = "SumNumbersWithStartingPositionButton";
            this.SumNumbersWithStartingPositionButton.Size = new System.Drawing.Size(115, 38);
            this.SumNumbersWithStartingPositionButton.TabIndex = 5;
            this.SumNumbersWithStartingPositionButton.Text = "Sum of Numbers With Starting Position";
            this.SumNumbersWithStartingPositionButton.UseVisualStyleBackColor = true;
            this.SumNumbersWithStartingPositionButton.Click += new System.EventHandler(this.SumNumbersWithStartingPositionButton_Click);
            // 
            // OddIndexedListButton
            // 
            this.OddIndexedListButton.Location = new System.Drawing.Point(330, 275);
            this.OddIndexedListButton.Name = "OddIndexedListButton";
            this.OddIndexedListButton.Size = new System.Drawing.Size(115, 31);
            this.OddIndexedListButton.TabIndex = 5;
            this.OddIndexedListButton.Text = "Odd-Indexed List";
            this.OddIndexedListButton.UseVisualStyleBackColor = true;
            this.OddIndexedListButton.Click += new System.EventHandler(this.OddIndexedListButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(165, 460);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(162, 23);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Remove All Numbers From List";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 490);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 10;
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.Location = new System.Drawing.Point(212, 420);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(115, 31);
            this.ScrambleButton.TabIndex = 11;
            this.ScrambleButton.Text = "Scramble";
            this.ScrambleButton.UseVisualStyleBackColor = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // BinarySearchButton
            // 
            this.BinarySearchButton.Location = new System.Drawing.Point(17, 140);
            this.BinarySearchButton.Name = "BinarySearchButton";
            this.BinarySearchButton.Size = new System.Drawing.Size(90, 22);
            this.BinarySearchButton.TabIndex = 12;
            this.BinarySearchButton.Text = "Search (Binary)";
            this.BinarySearchButton.UseVisualStyleBackColor = true;
            this.BinarySearchButton.Click += new System.EventHandler(this.BinarySearchButton_Click);
            // 
            // LinearSearchButton
            // 
            this.LinearSearchButton.Location = new System.Drawing.Point(110, 140);
            this.LinearSearchButton.Name = "LinearSearchButton";
            this.LinearSearchButton.Size = new System.Drawing.Size(90, 22);
            this.LinearSearchButton.TabIndex = 12;
            this.LinearSearchButton.Text = "Search (Linear)";
            this.LinearSearchButton.UseVisualStyleBackColor = true;
            this.LinearSearchButton.Click += new System.EventHandler(this.LinearSearchButton_Click);
            // 
            // AscendingRadioButton
            // 
            this.AscendingRadioButton.AutoSize = true;
            this.AscendingRadioButton.Checked = true;
            this.AscendingRadioButton.Location = new System.Drawing.Point(212, 382);
            this.AscendingRadioButton.Name = "AscendingRadioButton";
            this.AscendingRadioButton.Size = new System.Drawing.Size(75, 17);
            this.AscendingRadioButton.TabIndex = 13;
            this.AscendingRadioButton.TabStop = true;
            this.AscendingRadioButton.Text = "Ascending";
            this.AscendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // DescendingRadioButton
            // 
            this.DescendingRadioButton.AutoSize = true;
            this.DescendingRadioButton.Location = new System.Drawing.Point(212, 399);
            this.DescendingRadioButton.Name = "DescendingRadioButton";
            this.DescendingRadioButton.Size = new System.Drawing.Size(82, 17);
            this.DescendingRadioButton.TabIndex = 14;
            this.DescendingRadioButton.Text = "Descending";
            this.DescendingRadioButton.UseVisualStyleBackColor = true;
            // 
            // MinMaxMedianModeSelectionSortForm
            // 
            this.AcceptButton = this.SubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 520);
            this.Controls.Add(this.DescendingRadioButton);
            this.Controls.Add(this.AscendingRadioButton);
            this.Controls.Add(this.BinarySearchButton);
            this.Controls.Add(this.LinearSearchButton);
            this.Controls.Add(this.ScrambleButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.SortButton);
            this.Controls.Add(this.RandomButton);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.SumFirstNumbersButton);
            this.Controls.Add(this.SumNumbersWithStartingPositionButton);
            this.Controls.Add(this.OddIndexedListButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ModeButton);
            this.Controls.Add(this.MedianButton);
            this.Controls.Add(this.MeanButton);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.MaxButton);
            this.Controls.Add(this.numberListBox);
            this.Controls.Add(this.numberListBoxTwo);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.SubmitButtonTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nValueTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xValueTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberTextBox);
            this.Name = "MinMaxMedianModeSelectionSortForm";
            this.Text = "Basic Operations Implemented with Lists";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button SubmitButtonTwo;
        private System.Windows.Forms.TextBox nValueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox xValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox numberListBox;
        private System.Windows.Forms.ListBox numberListBoxTwo;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.Button MeanButton;
        private System.Windows.Forms.Button MedianButton;
        private System.Windows.Forms.Button ModeButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button SumFirstNumbersButton;
        private System.Windows.Forms.Button SumNumbersWithStartingPositionButton;
        private System.Windows.Forms.Button OddIndexedListButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button ScrambleButton;
        private System.Windows.Forms.Button BinarySearchButton;
        private System.Windows.Forms.Button LinearSearchButton;
        private System.Windows.Forms.RadioButton AscendingRadioButton;
        private System.Windows.Forms.RadioButton DescendingRadioButton;
    }
}

