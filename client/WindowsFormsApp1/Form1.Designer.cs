namespace AttendanceCheck
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputAC = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.room1 = new System.Windows.Forms.RadioButton();
            this.room2 = new System.Windows.Forms.RadioButton();
            this.room3 = new System.Windows.Forms.RadioButton();
            this.room4 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allclass = new System.Windows.Forms.RadioButton();
            this.grade = new System.Windows.Forms.GroupBox();
            this.grade3 = new System.Windows.Forms.RadioButton();
            this.grade2 = new System.Windows.Forms.RadioButton();
            this.grade1 = new System.Windows.Forms.RadioButton();
            this.sign = new System.Windows.Forms.Label();
            this.mail = new System.Windows.Forms.Label();
            this.notattenNum = new System.Windows.Forms.TextBox();
            this.Inner = new System.Windows.Forms.GroupBox();
            this.backStudent = new System.Windows.Forms.RadioButton();
            this.frontStudent = new System.Windows.Forms.RadioButton();
            this.allStudent = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Ebs = new System.Windows.Forms.RadioButton();
            this.Google = new System.Windows.Forms.RadioButton();
            this.notdifinedname = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.grade.SuspendLayout();
            this.Inner.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputAC
            // 
            this.InputAC.Location = new System.Drawing.Point(44, 170);
            this.InputAC.Name = "InputAC";
            this.InputAC.Size = new System.Drawing.Size(313, 472);
            this.InputAC.TabIndex = 1;
            this.InputAC.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(665, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "분석";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(665, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 417);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // room1
            // 
            this.room1.AutoSize = true;
            this.room1.Location = new System.Drawing.Point(26, 34);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(58, 16);
            this.room1.TabIndex = 4;
            this.room1.Text = "room1";
            this.room1.UseVisualStyleBackColor = true;
            // 
            // room2
            // 
            this.room2.AutoSize = true;
            this.room2.Checked = true;
            this.room2.Location = new System.Drawing.Point(108, 34);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(58, 16);
            this.room2.TabIndex = 5;
            this.room2.TabStop = true;
            this.room2.Text = "room2";
            this.room2.UseVisualStyleBackColor = true;
            // 
            // room3
            // 
            this.room3.AutoSize = true;
            this.room3.Location = new System.Drawing.Point(198, 34);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(58, 16);
            this.room3.TabIndex = 6;
            this.room3.Text = "room3";
            this.room3.UseVisualStyleBackColor = true;
            // 
            // room4
            // 
            this.room4.AutoSize = true;
            this.room4.Location = new System.Drawing.Point(290, 34);
            this.room4.Name = "room4";
            this.room4.Size = new System.Drawing.Size(58, 16);
            this.room4.TabIndex = 7;
            this.room4.Text = "room4";
            this.room4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.allclass);
            this.groupBox1.Controls.Add(this.room4);
            this.groupBox1.Controls.Add(this.room1);
            this.groupBox1.Controls.Add(this.room2);
            this.groupBox1.Controls.Add(this.room3);
            this.groupBox1.Location = new System.Drawing.Point(44, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 69);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "반";
            // 
            // allclass
            // 
            this.allclass.AutoSize = true;
            this.allclass.Location = new System.Drawing.Point(381, 34);
            this.allclass.Name = "allclass";
            this.allclass.Size = new System.Drawing.Size(47, 16);
            this.allclass.TabIndex = 8;
            this.allclass.TabStop = true;
            this.allclass.Text = "전부";
            this.allclass.UseVisualStyleBackColor = true;
            // 
            // grade
            // 
            this.grade.Controls.Add(this.grade3);
            this.grade.Controls.Add(this.grade2);
            this.grade.Controls.Add(this.grade1);
            this.grade.Location = new System.Drawing.Point(44, 10);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(444, 58);
            this.grade.TabIndex = 9;
            this.grade.TabStop = false;
            this.grade.Text = "학년";
            // 
            // grade3
            // 
            this.grade3.AutoSize = true;
            this.grade3.Location = new System.Drawing.Point(211, 21);
            this.grade3.Name = "grade3";
            this.grade3.Size = new System.Drawing.Size(53, 16);
            this.grade3.TabIndex = 2;
            this.grade3.Text = "3학년";
            this.grade3.UseVisualStyleBackColor = true;
            // 
            // grade2
            // 
            this.grade2.AutoSize = true;
            this.grade2.Checked = true;
            this.grade2.Location = new System.Drawing.Point(124, 21);
            this.grade2.Name = "grade2";
            this.grade2.Size = new System.Drawing.Size(53, 16);
            this.grade2.TabIndex = 1;
            this.grade2.TabStop = true;
            this.grade2.Text = "2학년";
            this.grade2.UseVisualStyleBackColor = true;
            // 
            // grade1
            // 
            this.grade1.AutoSize = true;
            this.grade1.Location = new System.Drawing.Point(26, 21);
            this.grade1.Name = "grade1";
            this.grade1.Size = new System.Drawing.Size(53, 16);
            this.grade1.TabIndex = 0;
            this.grade1.Text = "1학년";
            this.grade1.UseVisualStyleBackColor = true;
            // 
            // sign
            // 
            this.sign.AutoSize = true;
            this.sign.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sign.Location = new System.Drawing.Point(523, 590);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(136, 14);
            this.sign.TabIndex = 10;
            this.sign.Text = "Developed by SHSongs";
            // 
            // mail
            // 
            this.mail.AutoSize = true;
            this.mail.Font = new System.Drawing.Font("나눔바른고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.mail.Location = new System.Drawing.Point(450, 613);
            this.mail.Name = "mail";
            this.mail.Size = new System.Drawing.Size(209, 14);
            this.mail.TabIndex = 11;
            this.mail.Text = "simpledeveloper.songs@gmail.com";
            // 
            // notattenNum
            // 
            this.notattenNum.Location = new System.Drawing.Point(665, 200);
            this.notattenNum.Name = "notattenNum";
            this.notattenNum.Size = new System.Drawing.Size(100, 21);
            this.notattenNum.TabIndex = 12;
            // 
            // Inner
            // 
            this.Inner.Controls.Add(this.backStudent);
            this.Inner.Controls.Add(this.frontStudent);
            this.Inner.Controls.Add(this.allStudent);
            this.Inner.Location = new System.Drawing.Point(514, 86);
            this.Inner.Name = "Inner";
            this.Inner.Size = new System.Drawing.Size(276, 58);
            this.Inner.TabIndex = 10;
            this.Inner.TabStop = false;
            this.Inner.Text = "학생";
            // 
            // backStudent
            // 
            this.backStudent.AutoSize = true;
            this.backStudent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.backStudent.Location = new System.Drawing.Point(211, 21);
            this.backStudent.Name = "backStudent";
            this.backStudent.Size = new System.Drawing.Size(65, 17);
            this.backStudent.TabIndex = 2;
            this.backStudent.Text = "뒷번호";
            this.backStudent.UseVisualStyleBackColor = true;
            // 
            // frontStudent
            // 
            this.frontStudent.AutoSize = true;
            this.frontStudent.Location = new System.Drawing.Point(124, 21);
            this.frontStudent.Name = "frontStudent";
            this.frontStudent.Size = new System.Drawing.Size(59, 16);
            this.frontStudent.TabIndex = 1;
            this.frontStudent.Text = "앞번호";
            this.frontStudent.UseVisualStyleBackColor = true;
            // 
            // allStudent
            // 
            this.allStudent.AutoSize = true;
            this.allStudent.Checked = true;
            this.allStudent.Location = new System.Drawing.Point(26, 21);
            this.allStudent.Name = "allStudent";
            this.allStudent.Size = new System.Drawing.Size(47, 16);
            this.allStudent.TabIndex = 0;
            this.allStudent.TabStop = true;
            this.allStudent.Text = "전부";
            this.allStudent.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Ebs);
            this.groupBox2.Controls.Add(this.Google);
            this.groupBox2.Location = new System.Drawing.Point(514, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 44);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Platform";
            // 
            // Ebs
            // 
            this.Ebs.AutoSize = true;
            this.Ebs.Location = new System.Drawing.Point(100, 19);
            this.Ebs.Name = "Ebs";
            this.Ebs.Size = new System.Drawing.Size(47, 16);
            this.Ebs.TabIndex = 1;
            this.Ebs.Text = "EBS";
            this.Ebs.UseVisualStyleBackColor = true;
            // 
            // Google
            // 
            this.Google.AutoSize = true;
            this.Google.Checked = true;
            this.Google.Location = new System.Drawing.Point(28, 19);
            this.Google.Name = "Google";
            this.Google.Size = new System.Drawing.Size(63, 16);
            this.Google.TabIndex = 0;
            this.Google.TabStop = true;
            this.Google.Text = "Google";
            this.Google.UseVisualStyleBackColor = true;
            // 
            // notdifinedname
            // 
            this.notdifinedname.Location = new System.Drawing.Point(526, 482);
            this.notdifinedname.Name = "notdifinedname";
            this.notdifinedname.Size = new System.Drawing.Size(135, 96);
            this.notdifinedname.TabIndex = 13;
            this.notdifinedname.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 655);
            this.Controls.Add(this.notdifinedname);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Inner);
            this.Controls.Add(this.notattenNum);
            this.Controls.Add(this.mail);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.InputAC);
            this.Name = "Form1";
            this.Text = "출책안한사람";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grade.ResumeLayout(false);
            this.grade.PerformLayout();
            this.Inner.ResumeLayout(false);
            this.Inner.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox InputAC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton room1;
        private System.Windows.Forms.RadioButton room2;
        private System.Windows.Forms.RadioButton room3;
        private System.Windows.Forms.RadioButton room4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grade;
        private System.Windows.Forms.RadioButton grade3;
        private System.Windows.Forms.RadioButton grade2;
        private System.Windows.Forms.RadioButton grade1;
        private System.Windows.Forms.Label sign;
        private System.Windows.Forms.Label mail;
        private System.Windows.Forms.RadioButton allclass;
        private System.Windows.Forms.TextBox notattenNum;
        private System.Windows.Forms.GroupBox Inner;
        private System.Windows.Forms.RadioButton backStudent;
        private System.Windows.Forms.RadioButton frontStudent;
        private System.Windows.Forms.RadioButton allStudent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Ebs;
        private System.Windows.Forms.RadioButton Google;
        private System.Windows.Forms.RichTextBox notdifinedname;
    }
}

