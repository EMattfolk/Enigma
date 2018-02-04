namespace Enigma
{
    partial class Form1
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
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.rotorPos1 = new System.Windows.Forms.NumericUpDown();
            this.rotorPos2 = new System.Windows.Forms.NumericUpDown();
            this.rotorPos3 = new System.Windows.Forms.NumericUpDown();
            this.rotorPosLabel = new System.Windows.Forms.Label();
            this.rotor1Label = new System.Windows.Forms.Label();
            this.rotorBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rotorBar2 = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.rotorBar3 = new System.Windows.Forms.TrackBar();
            this.rotor2Label = new System.Windows.Forms.Label();
            this.rotor3Label = new System.Windows.Forms.Label();
            this.plugboardLabel = new System.Windows.Forms.Label();
            this.leftPlugcomboBox = new System.Windows.Forms.ComboBox();
            this.rightPlugComboBox = new System.Windows.Forms.ComboBox();
            this.connectionListBox = new System.Windows.Forms.ListBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(325, 24);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(220, 110);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(325, 161);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(220, 110);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.Text = "";
            // 
            // rotorPos1
            // 
            this.rotorPos1.Location = new System.Drawing.Point(113, 27);
            this.rotorPos1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos1.Name = "rotorPos1";
            this.rotorPos1.Size = new System.Drawing.Size(40, 20);
            this.rotorPos1.TabIndex = 2;
            this.rotorPos1.ValueChanged += new System.EventHandler(this.rotorPos1_ValueChanged);
            // 
            // rotorPos2
            // 
            this.rotorPos2.Location = new System.Drawing.Point(67, 27);
            this.rotorPos2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos2.Name = "rotorPos2";
            this.rotorPos2.Size = new System.Drawing.Size(40, 20);
            this.rotorPos2.TabIndex = 3;
            this.rotorPos2.ValueChanged += new System.EventHandler(this.rotorPos2_ValueChanged);
            // 
            // rotorPos3
            // 
            this.rotorPos3.Location = new System.Drawing.Point(21, 27);
            this.rotorPos3.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.rotorPos3.Name = "rotorPos3";
            this.rotorPos3.Size = new System.Drawing.Size(40, 20);
            this.rotorPos3.TabIndex = 4;
            this.rotorPos3.ValueChanged += new System.EventHandler(this.rotorPos3_ValueChanged);
            // 
            // rotorPosLabel
            // 
            this.rotorPosLabel.AutoSize = true;
            this.rotorPosLabel.Location = new System.Drawing.Point(21, 8);
            this.rotorPosLabel.Name = "rotorPosLabel";
            this.rotorPosLabel.Size = new System.Drawing.Size(73, 13);
            this.rotorPosLabel.TabIndex = 5;
            this.rotorPosLabel.Text = "Rotor Position";
            // 
            // rotor1Label
            // 
            this.rotor1Label.AutoSize = true;
            this.rotor1Label.Location = new System.Drawing.Point(18, 54);
            this.rotor1Label.Name = "rotor1Label";
            this.rotor1Label.Size = new System.Drawing.Size(42, 13);
            this.rotor1Label.TabIndex = 6;
            this.rotor1Label.Text = "Rotor 1";
            // 
            // rotorBar1
            // 
            this.rotorBar1.LargeChange = 1;
            this.rotorBar1.Location = new System.Drawing.Point(12, 70);
            this.rotorBar1.Maximum = 4;
            this.rotorBar1.Name = "rotorBar1";
            this.rotorBar1.Size = new System.Drawing.Size(158, 45);
            this.rotorBar1.TabIndex = 7;
            this.rotorBar1.Scroll += new System.EventHandler(this.rotorBar1_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "1         2         3         4         5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "1         2         3         4         5";
            // 
            // rotorBar2
            // 
            this.rotorBar2.LargeChange = 1;
            this.rotorBar2.Location = new System.Drawing.Point(12, 150);
            this.rotorBar2.Maximum = 4;
            this.rotorBar2.Name = "rotorBar2";
            this.rotorBar2.Size = new System.Drawing.Size(158, 45);
            this.rotorBar2.TabIndex = 9;
            this.rotorBar2.Value = 1;
            this.rotorBar2.Scroll += new System.EventHandler(this.rotorBar2_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "1         2         3         4         5";
            // 
            // rotorBar3
            // 
            this.rotorBar3.LargeChange = 1;
            this.rotorBar3.Location = new System.Drawing.Point(12, 230);
            this.rotorBar3.Maximum = 4;
            this.rotorBar3.Name = "rotorBar3";
            this.rotorBar3.Size = new System.Drawing.Size(158, 45);
            this.rotorBar3.TabIndex = 11;
            this.rotorBar3.Value = 2;
            this.rotorBar3.Scroll += new System.EventHandler(this.rotorBar3_Scroll);
            // 
            // rotor2Label
            // 
            this.rotor2Label.AutoSize = true;
            this.rotor2Label.Location = new System.Drawing.Point(18, 134);
            this.rotor2Label.Name = "rotor2Label";
            this.rotor2Label.Size = new System.Drawing.Size(42, 13);
            this.rotor2Label.TabIndex = 13;
            this.rotor2Label.Text = "Rotor 2";
            // 
            // rotor3Label
            // 
            this.rotor3Label.AutoSize = true;
            this.rotor3Label.Location = new System.Drawing.Point(18, 214);
            this.rotor3Label.Name = "rotor3Label";
            this.rotor3Label.Size = new System.Drawing.Size(42, 13);
            this.rotor3Label.TabIndex = 14;
            this.rotor3Label.Text = "Rotor 3";
            // 
            // plugboardLabel
            // 
            this.plugboardLabel.AutoSize = true;
            this.plugboardLabel.Location = new System.Drawing.Point(215, 8);
            this.plugboardLabel.Name = "plugboardLabel";
            this.plugboardLabel.Size = new System.Drawing.Size(55, 13);
            this.plugboardLabel.TabIndex = 15;
            this.plugboardLabel.Text = "Plugboard";
            // 
            // leftPlugcomboBox
            // 
            this.leftPlugcomboBox.FormattingEnabled = true;
            this.leftPlugcomboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.leftPlugcomboBox.Location = new System.Drawing.Point(193, 27);
            this.leftPlugcomboBox.MaxLength = 1;
            this.leftPlugcomboBox.Name = "leftPlugcomboBox";
            this.leftPlugcomboBox.Size = new System.Drawing.Size(40, 21);
            this.leftPlugcomboBox.TabIndex = 16;
            // 
            // rightPlugComboBox
            // 
            this.rightPlugComboBox.FormattingEnabled = true;
            this.rightPlugComboBox.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.rightPlugComboBox.Location = new System.Drawing.Point(251, 27);
            this.rightPlugComboBox.MaxLength = 1;
            this.rightPlugComboBox.Name = "rightPlugComboBox";
            this.rightPlugComboBox.Size = new System.Drawing.Size(40, 21);
            this.rightPlugComboBox.TabIndex = 17;
            // 
            // connectionListBox
            // 
            this.connectionListBox.FormattingEnabled = true;
            this.connectionListBox.Location = new System.Drawing.Point(184, 83);
            this.connectionListBox.Name = "connectionListBox";
            this.connectionListBox.Size = new System.Drawing.Size(120, 173);
            this.connectionListBox.TabIndex = 18;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(205, 54);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 19;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(205, 262);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(325, 8);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(31, 13);
            this.inputLabel.TabIndex = 21;
            this.inputLabel.Text = "Input";
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(325, 145);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(39, 13);
            this.outputLabel.TabIndex = 22;
            this.outputLabel.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 297);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.connectionListBox);
            this.Controls.Add(this.rightPlugComboBox);
            this.Controls.Add(this.leftPlugcomboBox);
            this.Controls.Add(this.plugboardLabel);
            this.Controls.Add(this.rotor3Label);
            this.Controls.Add(this.rotor2Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rotorBar3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rotorBar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rotorBar1);
            this.Controls.Add(this.rotor1Label);
            this.Controls.Add(this.rotorPosLabel);
            this.Controls.Add(this.rotorPos3);
            this.Controls.Add(this.rotorPos2);
            this.Controls.Add(this.rotorPos1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Enigma Machine";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorPos3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotorBar3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.NumericUpDown rotorPos1;
        private System.Windows.Forms.NumericUpDown rotorPos2;
        private System.Windows.Forms.NumericUpDown rotorPos3;
        private System.Windows.Forms.Label rotorPosLabel;
        private System.Windows.Forms.Label rotor1Label;
        private System.Windows.Forms.TrackBar rotorBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar rotorBar2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar rotorBar3;
        private System.Windows.Forms.Label rotor2Label;
        private System.Windows.Forms.Label rotor3Label;
        private System.Windows.Forms.Label plugboardLabel;
        private System.Windows.Forms.ComboBox leftPlugcomboBox;
        private System.Windows.Forms.ComboBox rightPlugComboBox;
        private System.Windows.Forms.ListBox connectionListBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

