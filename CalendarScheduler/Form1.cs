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
using System.Globalization;
using System.Reflection;

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
            filePath_str = @"c:\CalendarScheduler\" + fileName;
            // 파일 중복 화인, 중복일 경우 파일이름(숫자).txt로 저장됨
            bool fileExist = true;
            int fileCnt = 0;
            while (fileExist)
            {
                if (File.Exists(filePath_str))
                {
                    fileCnt++;
                    fileName = GetSelectedDate() + "(" + fileCnt + ")" + ".txt";
                    filePath_str = @"c:\CalendarScheduler\" + fileName;
                }
                else
                {
                    fileExist = false;
                }
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

            // 선택된 날짜를 기반으로 해당 날짜를 포함하는 파일들을 가져와서 리스트뷰에 출력
            DisplayFilesInListView(GetMatchingFiles(filePath.FullName, SelectedDate));
        }
        private void DisplayFilesInListView(string[] files)
        {
            // 리스트뷰를 초기화합니다.
            listViewToDoList.Items.Clear();

            // 파일들을 리스트뷰에 추가합니다.
            foreach (string filePath in files)
            {
                // 파일 정보를 가져오기
                FileInfo fileInfo = new FileInfo(filePath);

                // 파일 이름에서 날짜를 추출
                DateTime dateFromFileName;
                if (DateTime.TryParseExact(fileInfo.Name, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateFromFileName))
                {
                    // ListViewItem을 생성하고 파일 이름을 추가합니다.
                    ListViewItem item = new ListViewItem(dateFromFileName.ToString("yyyy-MM-dd"));

                    // 추가적인 열이 필요한 경우 아래와 같이 추가할 수 있습니다.
                    item.SubItems.Add(fileInfo.Name); // 파일 이름 전체
                    item.SubItems.Add(fileInfo.Length.ToString()); // 크기
                    item.SubItems.Add(fileInfo.LastWriteTime.ToString()); // 수정한 날짜

                    // ListViewItem을 ListView에 추가합니다.
                    listViewToDoList.Items.Add(item);
                }
            }
        }
        private string[] GetMatchingFiles(string folderPath, string selectedDate)
        {
            // 해당 날짜를 포함하는 파일들을 찾아 반환합니다.
            string[] files = Directory.GetFiles(folderPath, "*" + selectedDate + "*.txt");
            return files;
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
