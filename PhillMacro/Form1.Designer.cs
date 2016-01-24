namespace PhillMacro
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.wbAds = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(93, 11);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "녹화 중지";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(174, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(12, 40);
            this.tbText.Multiline = true;
            this.tbText.Name = "tbText";
            this.tbText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbText.Size = new System.Drawing.Size(318, 201);
            this.tbText.TabIndex = 3;
            this.tbText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbText_KeyPress);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(93, 247);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(237, 23);
            this.btnHide.TabIndex = 4;
            this.btnHide.Text = "숨기기 F9, 다시 보이기 Shift F9";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(255, 11);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "실행";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "녹화 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 247);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "편집";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // wbAds
            // 
            this.wbAds.Location = new System.Drawing.Point(12, 276);
            this.wbAds.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbAds.Name = "wbAds";
            this.wbAds.Size = new System.Drawing.Size(316, 71);
            this.wbAds.TabIndex = 7;
            this.wbAds.Url = new System.Uri("http://phillyai.dothome.co.kr", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 359);
            this.Controls.Add(this.wbAds);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "필리 매크로";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.WebBrowser wbAds;
    }
}

