namespace PhillMacro
{
    partial class fMacro
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
            System.Windows.Forms.Button btnEdit;
            this.lvEvents = new System.Windows.Forms.ListView();
            this.Time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Detail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.Location = new System.Drawing.Point(339, 54);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(153, 36);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "이벤트 수정";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // lvEvents
            // 
            this.lvEvents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Time,
            this.Type,
            this.Detail});
            this.lvEvents.FullRowSelect = true;
            this.lvEvents.GridLines = true;
            this.lvEvents.Location = new System.Drawing.Point(12, 12);
            this.lvEvents.Name = "lvEvents";
            this.lvEvents.Size = new System.Drawing.Size(321, 321);
            this.lvEvents.TabIndex = 0;
            this.lvEvents.UseCompatibleStateImageBehavior = false;
            this.lvEvents.View = System.Windows.Forms.View.Details;
            // 
            // Time
            // 
            this.Time.Text = "시각";
            this.Time.Width = 64;
            // 
            // Type
            // 
            this.Type.Text = "이벤트";
            this.Type.Width = 81;
            // 
            // Detail
            // 
            this.Detail.Text = "내용";
            this.Detail.Width = 166;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(339, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(153, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "이벤트 추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(339, 96);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(153, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "이벤트 제거";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(339, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "저장 및 닫기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fMacro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lvEvents);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "fMacro";
            this.ShowInTaskbar = false;
            this.Text = "매크로";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvEvents;
        private System.Windows.Forms.ColumnHeader Time;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Detail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
    }
}