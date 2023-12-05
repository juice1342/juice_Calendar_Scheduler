using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalendarScheduler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TimerClock.Tick += TimerClock_Tick;
            TimerClock.Interval = 1000;
            TimerClock.Start();

            CurrentDateClock();
        }
        private void TimerClock_Tick(object sender, EventArgs e)
        {
            CurrentDateClock();
        }

        private void CurrentDateClock()
        {
            DateTime currentDateTime = DateTime.Now;
            string AmOrPm_TimeStr = currentDateTime.ToString("hh:mm:ss");
            string AmOrPm_Str = currentDateTime.Hour < 12 ? "오전" : "오후";

            lblTimeClock.Text = $"{AmOrPm_Str} {AmOrPm_TimeStr}";
            lblTimeDate.Text = currentDateTime.ToString(" yyyy-MM-dd");
        }
        string fileName = "";
        DirectoryInfo filePath = new DirectoryInfo(@"c:\CalendarScheduler");
        string SelectedDate = "";    // 선택된 날짜값 저장
        string filePath_str;    // 파일경로
                                // 텍스트 파일명을 날짜.txt로 할 예정, 만약 여러 일정이 들어가야 한다면 날짜+숫자.txt로 할 예정
        private void btnAddToDoList_Click_1(object sender, EventArgs e)
        {
            // 디렉토리 생성
            if (filePath.Exists == false)
            {
                filePath.Create();
            }
            // 파일이름 정하기
            fileName = GetSelectedDate() + ".txt";

            // 파일 저장하기
            // 하루 일정 최대 5개까지 저장 가능하게 할 것.
            filePath_str = @"c:\CalendarScheduler\" + fileName;
            // 계속 덮어쓰기만 되고 있음 여기 if문이 무시 되고 있음 왜지
            if (File.Exists(filePath_str))
            {
                fileName = GetSelectedDate() + ".txt";
                filePath_str = @"c:\CalendarScheduler\" + fileName;
            }
            StreamWriter writer;
            writer = File.CreateText(filePath_str);
            writer.Write(txtAddToDoList.Text);
            writer.Close();
            MessageBox.Show("일정이 저장되었습니다!");
        }

        private void monthCalendar1_DateSelected_1(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
            SelectedDate = selectedDate.ToString("yyyy-MM-dd");
        }
        public string GetSelectedDate()
        {
            return SelectedDate;
        }

        private void btnDelToDoList_Click_1(object sender, EventArgs e)
        {
            string selectedFileName = "";   // 선택된 파일 경로
            if (File.Exists(selectedFileName) == true)
            {
                File.Delete(selectedFileName);
            }
            else
            {
                MessageBox.Show("존재하지 않는 일정입니다.");
            }
        }

        
    }
}
