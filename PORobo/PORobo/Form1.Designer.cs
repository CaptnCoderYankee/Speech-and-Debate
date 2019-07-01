namespace PORobo
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schoolCodeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numOfSpeechHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.questionsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.billHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.repsNameLabel = new System.Windows.Forms.Label();
            this.repsSchoolCodeLabel = new System.Windows.Forms.Label();
            this.addNumberSpeechBtn = new System.Windows.Forms.Button();
            this.selectSpeaker = new System.Windows.Forms.Button();
            this.speechNumberLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stopBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.addQuestionButton = new System.Windows.Forms.Button();
            this.billCodeBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.questioningLabel = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.speechTimeLabel = new System.Windows.Forms.Label();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Represetatives Name";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(454, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(218, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Rep to List";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader,
            this.schoolCodeHeader,
            this.numOfSpeechHeader,
            this.questionsHeader,
            this.billHeader});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(34, 32);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(394, 403);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 92;
            // 
            // schoolCodeHeader
            // 
            this.schoolCodeHeader.Text = "School Code";
            this.schoolCodeHeader.Width = 77;
            // 
            // numOfSpeechHeader
            // 
            this.numOfSpeechHeader.Text = "# Of Speeches";
            this.numOfSpeechHeader.Width = 90;
            // 
            // questionsHeader
            // 
            this.questionsHeader.Text = "Questions";
            this.questionsHeader.Width = 71;
            // 
            // billHeader
            // 
            this.billHeader.Text = "Bill ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(566, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "School Code";
            // 
            // repsNameLabel
            // 
            this.repsNameLabel.AutoSize = true;
            this.repsNameLabel.Location = new System.Drawing.Point(451, 114);
            this.repsNameLabel.Name = "repsNameLabel";
            this.repsNameLabel.Size = new System.Drawing.Size(109, 13);
            this.repsNameLabel.TabIndex = 8;
            this.repsNameLabel.Text = "Represetatives Name";
            // 
            // repsSchoolCodeLabel
            // 
            this.repsSchoolCodeLabel.AutoSize = true;
            this.repsSchoolCodeLabel.Location = new System.Drawing.Point(566, 114);
            this.repsSchoolCodeLabel.Name = "repsSchoolCodeLabel";
            this.repsSchoolCodeLabel.Size = new System.Drawing.Size(96, 13);
            this.repsSchoolCodeLabel.TabIndex = 9;
            this.repsSchoolCodeLabel.Text = "Reps School Code";
            // 
            // addNumberSpeechBtn
            // 
            this.addNumberSpeechBtn.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNumberSpeechBtn.Location = new System.Drawing.Point(478, 164);
            this.addNumberSpeechBtn.Name = "addNumberSpeechBtn";
            this.addNumberSpeechBtn.Size = new System.Drawing.Size(74, 23);
            this.addNumberSpeechBtn.TabIndex = 10;
            this.addNumberSpeechBtn.Text = "Speaking";
            this.addNumberSpeechBtn.UseVisualStyleBackColor = true;
            this.addNumberSpeechBtn.Click += new System.EventHandler(this.addNumberSpeechBtn_Click);
            // 
            // selectSpeaker
            // 
            this.selectSpeaker.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectSpeaker.Location = new System.Drawing.Point(34, 441);
            this.selectSpeaker.Name = "selectSpeaker";
            this.selectSpeaker.Size = new System.Drawing.Size(394, 35);
            this.selectSpeaker.TabIndex = 11;
            this.selectSpeaker.Text = "Select Speaker";
            this.selectSpeaker.UseVisualStyleBackColor = true;
            this.selectSpeaker.Click += new System.EventHandler(this.selectSpeaker_Click);
            // 
            // speechNumberLabel
            // 
            this.speechNumberLabel.AutoSize = true;
            this.speechNumberLabel.Location = new System.Drawing.Point(504, 143);
            this.speechNumberLabel.Name = "speechNumberLabel";
            this.speechNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.speechNumberLabel.TabIndex = 13;
            this.speechNumberLabel.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // stopBtn
            // 
            this.stopBtn.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(454, 432);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(99, 35);
            this.stopBtn.TabIndex = 18;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(569, 432);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(96, 35);
            this.resetBtn.TabIndex = 19;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // addQuestionButton
            // 
            this.addQuestionButton.Font = new System.Drawing.Font("Oxygen", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestionButton.Location = new System.Drawing.Point(566, 164);
            this.addQuestionButton.Name = "addQuestionButton";
            this.addQuestionButton.Size = new System.Drawing.Size(74, 23);
            this.addQuestionButton.TabIndex = 21;
            this.addQuestionButton.Text = "Question";
            this.addQuestionButton.UseVisualStyleBackColor = true;
            this.addQuestionButton.Click += new System.EventHandler(this.addQuestionButton_Click);
            // 
            // billCodeBox
            // 
            this.billCodeBox.Location = new System.Drawing.Point(504, 193);
            this.billCodeBox.Name = "billCodeBox";
            this.billCodeBox.Size = new System.Drawing.Size(101, 20);
            this.billCodeBox.TabIndex = 23;
            this.billCodeBox.Text = "A";
            this.billCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billCodeBox.TextChanged += new System.EventHandler(this.billCodeBox_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "Questioning Time";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // questioningLabel
            // 
            this.questioningLabel.AutoSize = true;
            this.questioningLabel.Font = new System.Drawing.Font("Oxygen", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questioningLabel.Location = new System.Drawing.Point(482, 348);
            this.questioningLabel.Name = "questioningLabel";
            this.questioningLabel.Size = new System.Drawing.Size(202, 81);
            this.questioningLabel.TabIndex = 26;
            this.questioningLabel.Text = "02:00";
            this.questioningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // speechTimeLabel
            // 
            this.speechTimeLabel.AutoSize = true;
            this.speechTimeLabel.Font = new System.Drawing.Font("Oxygen", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speechTimeLabel.Location = new System.Drawing.Point(482, 348);
            this.speechTimeLabel.Name = "speechTimeLabel";
            this.speechTimeLabel.Size = new System.Drawing.Size(199, 81);
            this.speechTimeLabel.TabIndex = 27;
            this.speechTimeLabel.Text = "03:05";
            this.speechTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Location = new System.Drawing.Point(599, 143);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(13, 13);
            this.questionNumberLabel.TabIndex = 28;
            this.questionNumberLabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Bill Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 508);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.speechTimeLabel);
            this.Controls.Add(this.questioningLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.billCodeBox);
            this.Controls.Add(this.addQuestionButton);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.speechNumberLabel);
            this.Controls.Add(this.selectSpeaker);
            this.Controls.Add(this.addNumberSpeechBtn);
            this.Controls.Add(this.repsSchoolCodeLabel);
            this.Controls.Add(this.repsNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Select Speaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader schoolCodeHeader;
        private System.Windows.Forms.ColumnHeader questionsHeader;
        private System.Windows.Forms.ColumnHeader numOfSpeechHeader;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label repsNameLabel;
        private System.Windows.Forms.Label repsSchoolCodeLabel;
        private System.Windows.Forms.Button addNumberSpeechBtn;
        private System.Windows.Forms.Button selectSpeaker;
        private System.Windows.Forms.Label speechNumberLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button addQuestionButton;
        private System.Windows.Forms.ColumnHeader billHeader;
        private System.Windows.Forms.TextBox billCodeBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label questioningLabel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label speechTimeLabel;
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label label3;
    }
}

