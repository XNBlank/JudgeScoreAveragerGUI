namespace JudgeScoreAveragerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.judgesNum = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setupBtn = new System.Windows.Forms.Button();
            this.topscoreText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveLink = new System.Windows.Forms.LinkLabel();
            this.resetLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.outputText = new System.Windows.Forms.RichTextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.judgesNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // judgesNum
            // 
            this.judgesNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.judgesNum.Location = new System.Drawing.Point(104, 34);
            this.judgesNum.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.judgesNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.judgesNum.Name = "judgesNum";
            this.judgesNum.Size = new System.Drawing.Size(78, 22);
            this.judgesNum.TabIndex = 0;
            this.judgesNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.judgesNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JudgeScoreAveragerGUI.Properties.Resources.gavel_icon_300x300;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setupBtn);
            this.groupBox1.Controls.Add(this.topscoreText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.judgesNum);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // setupBtn
            // 
            this.setupBtn.Location = new System.Drawing.Point(48, 92);
            this.setupBtn.Name = "setupBtn";
            this.setupBtn.Size = new System.Drawing.Size(100, 35);
            this.setupBtn.TabIndex = 4;
            this.setupBtn.Text = "Set";
            this.setupBtn.UseVisualStyleBackColor = true;
            this.setupBtn.Click += new System.EventHandler(this.setupBtn_Click);
            // 
            // topscoreText
            // 
            this.topscoreText.Location = new System.Drawing.Point(104, 62);
            this.topscoreText.MaxLength = 3;
            this.topscoreText.Name = "topscoreText";
            this.topscoreText.Size = new System.Drawing.Size(61, 22);
            this.topscoreText.TabIndex = 3;
            this.topscoreText.Text = "0";
            this.topscoreText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Top Score";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Judges";
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(51, 227);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(161, 22);
            this.inputText.TabIndex = 4;
            this.inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputText_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saveLink);
            this.groupBox2.Controls.Add(this.resetLink);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.outputText);
            this.groupBox2.Controls.Add(this.inputText);
            this.groupBox2.Controls.Add(this.confirmBtn);
            this.groupBox2.Location = new System.Drawing.Point(216, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 264);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // saveLink
            // 
            this.saveLink.AutoSize = true;
            this.saveLink.Location = new System.Drawing.Point(333, 230);
            this.saveLink.Name = "saveLink";
            this.saveLink.Size = new System.Drawing.Size(74, 17);
            this.saveLink.TabIndex = 7;
            this.saveLink.TabStop = true;
            this.saveLink.Text = "Save to txt";
            this.saveLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saveLink_LinkClicked);
            // 
            // resetLink
            // 
            this.resetLink.AutoSize = true;
            this.resetLink.Location = new System.Drawing.Point(413, 230);
            this.resetLink.Name = "resetLink";
            this.resetLink.Size = new System.Drawing.Size(45, 17);
            this.resetLink.TabIndex = 6;
            this.resetLink.TabStop = true;
            this.resetLink.Text = "Reset";
            this.resetLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Input";
            // 
            // outputText
            // 
            this.outputText.BackColor = System.Drawing.SystemColors.InfoText;
            this.outputText.Font = new System.Drawing.Font("Consolas", 10.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputText.ForeColor = System.Drawing.SystemColors.Info;
            this.outputText.Location = new System.Drawing.Point(9, 21);
            this.outputText.Name = "outputText";
            this.outputText.ReadOnly = true;
            this.outputText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.outputText.Size = new System.Drawing.Size(460, 190);
            this.outputText.TabIndex = 5;
            this.outputText.Text = "Welcome to the score average calculator.";
            // 
            // confirmBtn
            // 
            this.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.confirmBtn.Location = new System.Drawing.Point(218, 221);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 35);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 281);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Judge Score Averager GUI";
            ((System.ComponentModel.ISupportInitialize)(this.judgesNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown judgesNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topscoreText;
        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox outputText;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button setupBtn;
        private System.Windows.Forms.LinkLabel resetLink;
        private System.Windows.Forms.LinkLabel saveLink;
    }
}

