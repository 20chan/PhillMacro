namespace PHLMACR
{
    partial class fMouseEvent
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
            this.lbMousePos = new System.Windows.Forms.Label();
            this.lbX = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnCurrentPos = new System.Windows.Forms.Button();
            this.rbLeft = new System.Windows.Forms.RadioButton();
            this.rbRight = new System.Windows.Forms.RadioButton();
            this.rbDown = new System.Windows.Forms.RadioButton();
            this.rbUp = new System.Windows.Forms.RadioButton();
            this.rbClick = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbWheel = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMove = new System.Windows.Forms.RadioButton();
            this.rbScrollUp = new System.Windows.Forms.RadioButton();
            this.rbScrollDown = new System.Windows.Forms.RadioButton();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.cursPos = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMousePos
            // 
            this.lbMousePos.AutoSize = true;
            this.lbMousePos.Font = new System.Drawing.Font("맑은 고딕", 12F);
            this.lbMousePos.Location = new System.Drawing.Point(54, 9);
            this.lbMousePos.Name = "lbMousePos";
            this.lbMousePos.Size = new System.Drawing.Size(269, 21);
            this.lbMousePos.TabIndex = 0;
            this.lbMousePos.Text = "현재 마우스 좌표 X : 0000 Y : 0000";
            // 
            // lbX
            // 
            this.lbX.AutoSize = true;
            this.lbX.Location = new System.Drawing.Point(17, 47);
            this.lbX.Name = "lbX";
            this.lbX.Size = new System.Drawing.Size(25, 15);
            this.lbX.TabIndex = 1;
            this.lbX.Text = "X : ";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(130, 47);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(25, 15);
            this.lbY.TabIndex = 2;
            this.lbY.Text = "Y : ";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(48, 43);
            this.tbX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(76, 23);
            this.tbX.TabIndex = 3;
            this.tbX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(161, 43);
            this.tbY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(76, 23);
            this.tbY.TabIndex = 4;
            this.tbY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnCurrentPos
            // 
            this.btnCurrentPos.Location = new System.Drawing.Point(243, 41);
            this.btnCurrentPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCurrentPos.Name = "btnCurrentPos";
            this.btnCurrentPos.Size = new System.Drawing.Size(131, 29);
            this.btnCurrentPos.TabIndex = 5;
            this.btnCurrentPos.Text = "F2로 현재 커서";
            this.btnCurrentPos.UseVisualStyleBackColor = true;
            // 
            // rbLeft
            // 
            this.rbLeft.AutoSize = true;
            this.rbLeft.Location = new System.Drawing.Point(17, 23);
            this.rbLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLeft.Name = "rbLeft";
            this.rbLeft.Size = new System.Drawing.Size(49, 19);
            this.rbLeft.TabIndex = 6;
            this.rbLeft.TabStop = true;
            this.rbLeft.Text = "왼쪽";
            this.rbLeft.UseVisualStyleBackColor = true;
            // 
            // rbRight
            // 
            this.rbRight.AutoSize = true;
            this.rbRight.Location = new System.Drawing.Point(17, 50);
            this.rbRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbRight.Name = "rbRight";
            this.rbRight.Size = new System.Drawing.Size(61, 19);
            this.rbRight.TabIndex = 7;
            this.rbRight.TabStop = true;
            this.rbRight.Text = "오른쪽";
            this.rbRight.UseVisualStyleBackColor = true;
            // 
            // rbDown
            // 
            this.rbDown.AutoSize = true;
            this.rbDown.Location = new System.Drawing.Point(18, 23);
            this.rbDown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbDown.Name = "rbDown";
            this.rbDown.Size = new System.Drawing.Size(49, 19);
            this.rbDown.TabIndex = 8;
            this.rbDown.TabStop = true;
            this.rbDown.Text = "누름";
            this.rbDown.UseVisualStyleBackColor = true;
            // 
            // rbUp
            // 
            this.rbUp.AutoSize = true;
            this.rbUp.Location = new System.Drawing.Point(18, 50);
            this.rbUp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbUp.Name = "rbUp";
            this.rbUp.Size = new System.Drawing.Size(37, 19);
            this.rbUp.TabIndex = 9;
            this.rbUp.TabStop = true;
            this.rbUp.Text = "뗌";
            this.rbUp.UseVisualStyleBackColor = true;
            // 
            // rbClick
            // 
            this.rbClick.AutoSize = true;
            this.rbClick.Location = new System.Drawing.Point(18, 77);
            this.rbClick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbClick.Name = "rbClick";
            this.rbClick.Size = new System.Drawing.Size(77, 19);
            this.rbClick.TabIndex = 10;
            this.rbClick.TabStop = true;
            this.rbClick.Text = "눌렀다 뗌";
            this.rbClick.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbWheel);
            this.groupBox1.Controls.Add(this.rbLeft);
            this.groupBox1.Controls.Add(this.rbRight);
            this.groupBox1.Location = new System.Drawing.Point(20, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(148, 105);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "마우스 종류";
            // 
            // rbWheel
            // 
            this.rbWheel.AutoSize = true;
            this.rbWheel.Location = new System.Drawing.Point(17, 77);
            this.rbWheel.Name = "rbWheel";
            this.rbWheel.Size = new System.Drawing.Size(37, 19);
            this.rbWheel.TabIndex = 8;
            this.rbWheel.TabStop = true;
            this.rbWheel.Text = "휠";
            this.rbWheel.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbMove);
            this.groupBox2.Controls.Add(this.rbScrollUp);
            this.groupBox2.Controls.Add(this.rbScrollDown);
            this.groupBox2.Controls.Add(this.rbDown);
            this.groupBox2.Controls.Add(this.rbUp);
            this.groupBox2.Controls.Add(this.rbClick);
            this.groupBox2.Location = new System.Drawing.Point(174, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 105);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이벤트 종류";
            // 
            // rbMove
            // 
            this.rbMove.AutoSize = true;
            this.rbMove.Location = new System.Drawing.Point(101, 77);
            this.rbMove.Name = "rbMove";
            this.rbMove.Size = new System.Drawing.Size(89, 19);
            this.rbMove.TabIndex = 13;
            this.rbMove.TabStop = true;
            this.rbMove.Text = "커서 움직임";
            this.rbMove.UseVisualStyleBackColor = true;
            // 
            // rbScrollUp
            // 
            this.rbScrollUp.AutoSize = true;
            this.rbScrollUp.Location = new System.Drawing.Point(101, 50);
            this.rbScrollUp.Name = "rbScrollUp";
            this.rbScrollUp.Size = new System.Drawing.Size(73, 19);
            this.rbScrollUp.TabIndex = 12;
            this.rbScrollUp.TabStop = true;
            this.rbScrollUp.Text = "스크롤업";
            this.rbScrollUp.UseVisualStyleBackColor = true;
            // 
            // rbScrollDown
            // 
            this.rbScrollDown.AutoSize = true;
            this.rbScrollDown.Location = new System.Drawing.Point(101, 23);
            this.rbScrollDown.Name = "rbScrollDown";
            this.rbScrollDown.Size = new System.Drawing.Size(85, 19);
            this.rbScrollDown.TabIndex = 11;
            this.rbScrollDown.TabStop = true;
            this.rbScrollDown.Text = "스크롤다운";
            this.rbScrollDown.UseVisualStyleBackColor = true;
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(247, 198);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(127, 23);
            this.btnCancle.TabIndex = 14;
            this.btnCancle.Text = "취소";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(12, 198);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(229, 23);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "완료";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // cursPos
            // 
            this.cursPos.Enabled = true;
            this.cursPos.Tick += new System.EventHandler(this.cursPos_Tick);
            // 
            // fMouseEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 232);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCurrentPos);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX);
            this.Controls.Add(this.lbMousePos);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMouseEvent";
            this.Text = "마우스 이벤트";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMousePos;
        private System.Windows.Forms.Label lbX;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnCurrentPos;
        private System.Windows.Forms.RadioButton rbLeft;
        private System.Windows.Forms.RadioButton rbRight;
        private System.Windows.Forms.RadioButton rbDown;
        private System.Windows.Forms.RadioButton rbUp;
        private System.Windows.Forms.RadioButton rbClick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer cursPos;
        private System.Windows.Forms.RadioButton rbWheel;
        private System.Windows.Forms.RadioButton rbMove;
        private System.Windows.Forms.RadioButton rbScrollUp;
        private System.Windows.Forms.RadioButton rbScrollDown;
    }
}