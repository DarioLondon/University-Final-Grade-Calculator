
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace University_Final_Grade_Calculator
{
    public partial class FinalCustumPanel : UserControl
    {
        private Panel _panel;
        public CustomModulesPanel customPanel;
        private Course _course;
        private  bool _isSummaryTabPopulated;
        private TabPage[] _tabsPage;
        private CustomPanelSummaryTab _panelSummary;
        delegate void CreateDynamicGyuiDelegate();
        
        private int type;
        delegate void PopulateSummaryTabDelegate();

        public FinalCustumPanel()
        {
            InitializeComponent();
            
        }



        public FinalCustumPanel(Panel p ,Course c) : this()
        {
            _course = c;
            _panel = p;
            type = 0;
            courseNameLabel.Text = _course.Name;
            Thread t = new Thread(PopulateTabscontroller);
            t.Start();

        }
        public FinalCustumPanel(CustomModulesPanel p, Course c):this()
        {
            _course = c;
            customPanel = p;
            type = 1;
            courseNameLabel.Text = _course.Name;
            Thread t = new Thread(PopulateTabscontroller);
            t.Start();


        }
        public FinalCustumPanel(Panel p, Course c,int status) : this()
        {
            _course = c;
            _panel = p;
            type = status;
            courseNameLabel.Text = _course.Name;
            Thread t = new Thread(PopulateTabscontroller);
            t.Start();


        }




        private void PopulateTabscontroller()
        {
            if (tabControl.InvokeRequired)
            {
                CreateDynamicGyuiDelegate d = PopulateTabscontroller;
                Invoke(d);
            }
            else
            {
                TabPage[] t= CreateDynamicGui(_course);
                tabControl.Controls.Add(t[0]);
                tabControl.Controls.Add(t[1]);
                tabControl.Controls.Add(t[2]);
                tabControl.Controls.Add(summaryTabPage);
                
            }
         

        }


        private void PopulateSummaryTab()
        {
            if (summaryTabPage.InvokeRequired)
            {
                PopulateSummaryTabDelegate d = PopulateSummaryTab;
                Invoke(d);
            }
            else
            {
                 _panelSummary = new CustomPanelSummaryTab(_course);
                _panelSummary.Location = new Point(0, 250);
                _panelSummary.Anchor = AnchorStyles.Left;
                summaryTabPage.Controls.Add(_panelSummary);
            }
        }

       

        private void Closethis()
        {
            
            _course = null;
            Dispose();
        }

        private void ValidateAndCalculate(object sender, EventArgs e)
        {
           
            var box = (TextBox) sender;
            object[] tmp={};
            foreach (object[] t in modulesTab)
            {
                foreach (var f  in t)
                {
                    if (f.GetHashCode()==box.GetHashCode())
                    {
                        tmp = t;
                    }
                }
            }
            string module = tmp[0].ToString();
            string text = box.Text;
            int id = int.Parse(tmp[5].ToString());
            TextBox finalMarkBox = (TextBox)tmp[4];
            if(string.IsNullOrEmpty(text))return;
            if (text.All(char.IsDigit))
            {
                if (int.Parse(text) <= 30)
                {
                    _course.GetModuleByName(pageIndex,module).CourseWorkList.Find(c => c.Id ==id).Mark =int.Parse(text);
                    Console.WriteLine(_course.GetModuleByName(pageIndex, module).CourseWorkList.Find(c => c.Id == id).Mark);
                    box.ForeColor = Color.Red;
                   
                    
                }
                if (int.Parse(text) >=31 && int.Parse(text)<=70)
                {
                    box.ForeColor = Color.Green;
                    _course.GetModuleByName(pageIndex, module).CourseWorkList.Find(c => c.Id == id).Mark = int.Parse(text);
                    Console.WriteLine(_course.GetModuleByName(pageIndex, module).CourseWorkList.Find(c => c.Id == id).Mark);

                }
                if (int.Parse(text) >=71 && int.Parse(text)<=100)
                {
                    box.ForeColor = Color.DeepSkyBlue;
                    _course.GetModuleByName(pageIndex, module).CourseWorkList.Find(c => c.Id == id).Mark = int.Parse(text);
                    Console.WriteLine(_course.GetModuleByName(pageIndex, module).CourseWorkList.Find(c => c.Id == id).Mark);

                }

                Console.WriteLine(_course.GetModuleByName(pageIndex, module).CalculateTotalMark());

                if (_course.GetModuleByName(pageIndex, module).CalculateTotalMark() <= 30)
                {

                    finalMarkBox.ForeColor = Color.Red;
                    finalMarkBox.Text = "" + _course.GetModuleByName(pageIndex, module).CalculateTotalMark();


                }
                if (_course.GetModuleByName(pageIndex, module).CalculateTotalMark() >= 31 && _course.GetModuleByName(pageIndex, module).CalculateTotalMark() <= 70)
                {
                   finalMarkBox.ForeColor = Color.Green;
                    finalMarkBox.Text = "" + _course.GetModuleByName(pageIndex, module).CalculateTotalMark();

                }
                if (_course.GetModuleByName(pageIndex, module).CalculateTotalMark() >= 71 && _course.GetModuleByName(pageIndex, module).CalculateTotalMark() <= 100)
                {
                    finalMarkBox.ForeColor = Color.DeepSkyBlue;
                    finalMarkBox.Text = "" + _course.GetModuleByName(pageIndex, module).CalculateTotalMark();


                }



                
            }



        }

       
        private void ChangeTab(object sender, EventArgs e)
        {
            TabControl t = (TabControl) sender;
            pageIndex = t.SelectedIndex+4;
            Console.WriteLine(@"Page Index ==> "+pageIndex);
        }
        private void backbtn_Click(object sender, EventArgs e)
        {
            if (type == 0)
            {
                _panel.Visible = true;
                Closethis();
            }
            if(type==1)
            {
                customPanel.Visible = true;
                Closethis();
            }
            if (type == 2)
            {
                _panel.Visible = true;
                Closethis();
            }

        }

        private void CalcuateAverage(object sender, EventArgs e)
        {
            double total = _course.CalculateFianlAvarage(pageIndex);
            avarageBoxs[pageIndex - 4].Text = Math.Round(total, 1) + @"%";
            switch (pageIndex)
            {
                case 4:
                  
                    _course.AvarageYearOne = Math.Round(total,1);
                  
                    break;
                case 5:
                   
                    _course.AvarageYearTwo = Math.Round(total,1);
                    break;
                case 6:
                    
                    _course.AvarageYearThree = Math.Round(total,1);
                    break;

            }
        }

        private void ResetToZero(object sender, EventArgs e)
        {
            TextBox box = (TextBox) sender;
            if (box.Text.Length == 0)
            {
                box.Text = "" + 0;
            }
           
        }

        private void FinalResult(object sender, EventArgs e)
        {
            
            if (ValidateMarksLevel5AndLevel6())
            {
                if (CheckIfAverageBoxAreEmpty())
                {
                    
                    if (!_isSummaryTabPopulated)
                    {

                        Thread t = new Thread(PopulateSummaryTab);
                        t.Start();
                        _isSummaryTabPopulated = true;
                    }
                    else
                    {
                        _panelSummary.Calculate(_course);
                    }
                }
                else
                {
                    MessageBox.Show(@"Please press Calculate Button in each tab ");
                }
            }
            else
            {
                MessageBox.Show(@"Some Modules miss marks. Please Fill up each module to have an accurate dinal Mark  ");
            }
            


        }

        private bool ValidateMarksLevel5AndLevel6()
        {
            bool status =false ;
            foreach (var m in _course.ModulesYearTwo)
            {
                if (m.CheckIfAllCourseWorkHasMarks())
                {
                    status = true;
                }
            }
            foreach (var m in _course.ModulesYearThree)
            {
                if (m.CheckIfAllCourseWorkHasMarks())
                {
                    status = true;
                }
            }
            return status;

        }
        private bool CheckIfAverageBoxAreEmpty()
        {
            //TextBox level4 = (TextBox) tabControl.TabPages[0].Controls["AverageBox0"];
            TextBox level5 = (TextBox)tabControl.TabPages[1].Controls["AverageBox1"];
            TextBox level6 = (TextBox)tabControl.TabPages[2].Controls["AverageBox2"];
            double  avgLevel5 = double.Parse(TrimLastCharacter(level5.Text));
            double avgLevel6 = double.Parse(TrimLastCharacter(level6.Text));
            if (avgLevel5 > 0 && avgLevel6 > 0) return true;
            return false;

        }

        private string TrimLastCharacter(string s)
        {
            int lastIndex = s.Length-1;
            return s.Substring(0, lastIndex);
        }
        private void SaveData()
        {
            StreamWriter file = null;
            string result = "";
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}/Data.txt";
            try
            {
                result = JsonConvert.SerializeObject(_course, Formatting.Indented);
                file = new StreamWriter(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Somenthing went wrong . Please Retry!", @"Warning");
                Console.WriteLine(e);
            }
            finally
            {
                if (file != null)
                {
                    file.Write(result);
                    file.Close();
                }
            }

            Console.WriteLine(result);
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
