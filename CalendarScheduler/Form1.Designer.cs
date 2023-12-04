namespace CalendarScheduler
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblTodoList = new System.Windows.Forms.Label();
            this.lblAddToDoList = new System.Windows.Forms.Label();
            this.txtAddToDoList = new System.Windows.Forms.TextBox();
            this.btnAddToDoList = new System.Windows.Forms.Button();
            this.btnDelToDoList = new System.Windows.Forms.Button();
            this.listViewToDoList = new System.Windows.Forms.ListView();
            this.columnSchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTimeDate = new System.Windows.Forms.Label();
            this.lblTimeSecond = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 81);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblTodoList
            // 
            this.lblTodoList.AutoSize = true;
            this.lblTodoList.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTodoList.Location = new System.Drawing.Point(250, 81);
            this.lblTodoList.Name = "lblTodoList";
            this.lblTodoList.Size = new System.Drawing.Size(67, 13);
            this.lblTodoList.TabIndex = 1;
            this.lblTodoList.Text = "오늘 할 일";
            // 
            // lblAddToDoList
            // 
            this.lblAddToDoList.AutoSize = true;
            this.lblAddToDoList.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblAddToDoList.Location = new System.Drawing.Point(15, 261);
            this.lblAddToDoList.Name = "lblAddToDoList";
            this.lblAddToDoList.Size = new System.Drawing.Size(63, 13);
            this.lblAddToDoList.TabIndex = 3;
            this.lblAddToDoList.Text = "일정 추가";
            // 
            // txtAddToDoList
            // 
            this.txtAddToDoList.Location = new System.Drawing.Point(18, 279);
            this.txtAddToDoList.Multiline = true;
            this.txtAddToDoList.Name = "txtAddToDoList";
            this.txtAddToDoList.Size = new System.Drawing.Size(528, 41);
            this.txtAddToDoList.TabIndex = 4;
            // 
            // btnAddToDoList
            // 
            this.btnAddToDoList.Location = new System.Drawing.Point(484, 326);
            this.btnAddToDoList.Name = "btnAddToDoList";
            this.btnAddToDoList.Size = new System.Drawing.Size(62, 23);
            this.btnAddToDoList.TabIndex = 5;
            this.btnAddToDoList.Text = "추가";
            this.btnAddToDoList.UseVisualStyleBackColor = true;
            // 
            // btnDelToDoList
            // 
            this.btnDelToDoList.Location = new System.Drawing.Point(484, 220);
            this.btnDelToDoList.Name = "btnDelToDoList";
            this.btnDelToDoList.Size = new System.Drawing.Size(62, 23);
            this.btnDelToDoList.TabIndex = 6;
            this.btnDelToDoList.Text = "삭제";
            this.btnDelToDoList.UseVisualStyleBackColor = true;
            // 
            // listViewToDoList
            // 
            this.listViewToDoList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSchedule});
            this.listViewToDoList.HideSelection = false;
            this.listViewToDoList.Location = new System.Drawing.Point(250, 100);
            this.listViewToDoList.Name = "listViewToDoList";
            this.listViewToDoList.OwnerDraw = true;
            this.listViewToDoList.Size = new System.Drawing.Size(296, 114);
            this.listViewToDoList.TabIndex = 8;
            this.listViewToDoList.UseCompatibleStateImageBehavior = false;
            // 
            // columnSchedule
            // 
            this.columnSchedule.DisplayIndex = 0;
            this.columnSchedule.Text = "일정";
            this.columnSchedule.Width = 120;
            // 
            // lblTimeDate
            // 
            this.lblTimeDate.AutoSize = true;
            this.lblTimeDate.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimeDate.Location = new System.Drawing.Point(17, 53);
            this.lblTimeDate.Name = "lblTimeDate";
            this.lblTimeDate.Size = new System.Drawing.Size(72, 15);
            this.lblTimeDate.TabIndex = 9;
            this.lblTimeDate.Text = "현재 날짜";
            // 
            // lblTimeSecond
            // 
            this.lblTimeSecond.AutoSize = true;
            this.lblTimeSecond.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTimeSecond.Location = new System.Drawing.Point(15, 23);
            this.lblTimeSecond.Name = "lblTimeSecond";
            this.lblTimeSecond.Size = new System.Drawing.Size(96, 19);
            this.lblTimeSecond.TabIndex = 10;
            this.lblTimeSecond.Text = "현재 시각";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 405);
            this.Controls.Add(this.lblTimeSecond);
            this.Controls.Add(this.lblTimeDate);
            this.Controls.Add(this.listViewToDoList);
            this.Controls.Add(this.btnDelToDoList);
            this.Controls.Add(this.btnAddToDoList);
            this.Controls.Add(this.txtAddToDoList);
            this.Controls.Add(this.lblAddToDoList);
            this.Controls.Add(this.lblTodoList);
            this.Controls.Add(this.monthCalendar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "일정 관리";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblTodoList;
        private System.Windows.Forms.Label lblAddToDoList;
        private System.Windows.Forms.TextBox txtAddToDoList;
        private System.Windows.Forms.Button btnAddToDoList;
        private System.Windows.Forms.Button btnDelToDoList;
        private System.Windows.Forms.ListView listViewToDoList;
        private System.Windows.Forms.ColumnHeader columnSchedule;
        private System.Windows.Forms.Label lblTimeDate;
        private System.Windows.Forms.Label lblTimeSecond;
    }
}

