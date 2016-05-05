using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace University_Final_Grade_Calculator
{
    public partial class Form1 : Form
    {
        public int ModuleChosen = -1;
        private int _creditToRemove;
        public int Level = 4;
        public  Course Course;
        private Thread _t;
        private DataTable[] _source;
        public Module Module;
        private string _moduleNameSelected = "";
        private List<object[]> modulesLevel4 = new List<object[]>();
        private List<object[]> modulesLevel5 = new List<object[]>();
        private List<object[]> modulesLevel6 = new List<object[]>();
        public CourseWork Coursework =new CourseWork();
        public  CustomModulesPanel Panel;
        private FinalCustumPanel _custumPanel;


        private Form2 _form2;

        public Form1()
        {
       
            InitializeComponent();
        }

        //Delegates
        delegate void PopulateListDelegate(DataTable source);

        delegate void CreateModulePanelDelegate();
        delegate void PopulateModuleListDelegate(DataTable[] source);
        delegate void RestorePreviewsStateDelegate();
        private void button1_Click(object sender, EventArgs e)
        {

            if (courseListBox.SelectedItem != null)
            {
                Course = new Course();
                DataRowView drv = (DataRowView) courseListBox.SelectedItem;
                string courseName = drv["Name"].ToString();
                Course.Name = courseName;
                introPanel.Visible = false;
                detailsPanel.Visible = true;
                Controls.Add(detailsPanel);
                _t = new Thread(PopulateModules);

                _t.Start();

            }
            else
            {
                MessageBox.Show(@"Select a course");
            }
        }

        //Methods
        private void PopulateList(DataTable source)
        {

            if (courseListBox.InvokeRequired)
            {
                PopulateListDelegate d = PopulateList;
                Invoke(d, source);
            }
            else
            {

                courseListBox.DisplayMember = "Name";
                courseListBox.ValueMember = "Id";
                courseListBox.DataSource = source;
            }


        }

        private void PopulateModuleList(DataTable[] source)
        {
            FillModulesList(source);

            if (modulesBox.InvokeRequired)
            {

                PopulateModuleListDelegate d = PopulateModuleList;
                Invoke(d, new object[] {source});
            }
            else
            {

                modulesBox.DisplayMember = "Name";
                modulesBox.ValueMember = "Id";
                modulesBox.DataSource = source[0];
                creditsLabelChange.Text = "" + (int)_source[0].Rows[0][2];
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            _t = new Thread(Populate);

            _t.Start();
            

        }

        private void Populate()
        {

            PopulateList(new DataBase().GetCourseList());
        }

        private void PopulateModules()
        {
            _source = new DataBase().GetModulesList(Course.Name);

            PopulateModuleList(_source);
       
        }

        private void TabSwitch(object sender, EventArgs e)
        {

            TabControl tabControll = (TabControl) sender;
            TabPage page = tabControll.SelectedTab;
            int index = page.TabIndex;
            ModuleChosen = -1;
            switch (index)
            {
                case 0:
                    Level = 4;
                    break;
                case 1:
                    Level = 5;
                    break;
                case 2:
                    Level = 6;
                    break;
            }

            modulesBox.DisplayMember = "Name";
            modulesBox.ValueMember = "Id";
            modulesBox.DataSource = _source[index];
            creditsLabelChange.Text = "" + (int)_source[index].Rows[0][2];

        }

        //       //Level 4 EventsHandler
        private void addLevel4_Click(object sender, EventArgs e)
        {
            if (Course.TotalCreditLevel4 <= Course.MaxTotalCredit)
            {
                int index = modulesBox.SelectedIndex;
                object[] row = modulesLevel4[index];
                int id = int.Parse(row[0].ToString());
                string moduleName = row[1].ToString();
                int credit = int.Parse(row[2].ToString());
               
                Console.WriteLine(moduleName + @"  => credit " + credit);


                if (!CheckIfNotSelected(modulesListLevel4, moduleName))
                {
                    Module = new Module
                    {
                        Name = moduleName,
                        Credits = credit,
                        Id = id
                    };

                    Course.AddModules(Module, Level);
                    Course.TotalCreditLevel4 += credit;
                    modulesListLevel4.Items.Add(moduleName);
                    Console.WriteLine(moduleName);
                    Console.WriteLine(Course.TotalCreditLevel4);

                }
                else
                {
                    MessageBox.Show(@"Module has been already selected" ,@"Warning");
                }

            }
            else
            {
                MessageBox.Show(@"The maximum creditis available per year are 120 
        Please remove a module if you want add a new one ", @"Warning");
            }
            ModuleChosen = -1;
        }

        private void removeLevel4_Click(object sender, EventArgs e)
        {



            if (ModuleChosen > -1)
            {

                Course.RemoveModule(Level, ModuleChosen);
                modulesListLevel4.Items.RemoveAt(ModuleChosen);
                Course.TotalCreditLevel4 -= _creditToRemove;
                Console.WriteLine(Course.TotalCreditLevel4);
                ModuleChosen = -1;

            }
            else
            {
                if (modulesListLevel4.Items.Count == 0)
                {
                    MessageBox.Show(@"There are not module to remove ", @"Warning");
                }
                else
                {
                    MessageBox.Show(@"Select the module you want to remove ", @"Warning");
                }

            }
        }

        private void editLevel4_Click(object sender, EventArgs e)
        {

            if (ModuleChosen > -1)
            {
                Module = Course.GetModuleByName(Level, _moduleNameSelected);
                _form2 = new Form2(Course, this, modulesListLevel4, Module,Coursework);
                _form2.ShowDialog();


            }
            else
            {
                MessageBox.Show(@"Select a Module to Edit it ", @"Warning");
            }
        }

        private void removeAllLevel4_Click(object sender, EventArgs e)
        {
            modulesListLevel4.Items.Clear();
            Course.RemoveAll(Level);
            ModuleChosen = -1;
        }


        //Level 5 EventsHandler
        private void addLevel5_Click(object sender, EventArgs e)
        {

            if (Course.TotalCreditLevel5 <= Course.MaxTotalCredit)
            {
                int index = modulesBox.SelectedIndex;
                object[] row = modulesLevel5[index];
                int id = int.Parse(row[0].ToString());
                string moduleName = row[1].ToString();
                int credit = int.Parse(row[2].ToString());
                Console.WriteLine(moduleName + @"  => credit " + credit);


                if (!CheckIfNotSelected(modulesListLevel5, moduleName))
                {
                    Module = new Module
                    {
                        Name = moduleName,
                        Credits = credit,
                        Id = id
                    };
                    Course.AddModules(Module, Level);
                    Course.TotalCreditLevel5 += credit;
                    modulesListLevel5.Items.Add(moduleName);
                    Console.WriteLine(Course.TotalCreditLevel5);
                }
                else
                {
                    MessageBox.Show(@"Module has been already selected ", @"Warning");
                }
            }
            else
            {
                MessageBox.Show(@"The maximum creditis available per year are 120 
        Please remove a module if you want add a new one ", @"Warning");
            }

        }

        private void removeLevel5_Click(object sender, EventArgs e)
        {


            if (ModuleChosen > -1)
            {
                Course.TotalCreditLevel5 -= _creditToRemove;
                Course.RemoveModule(Level, ModuleChosen);
                modulesListLevel5.Items.RemoveAt(ModuleChosen);
                Console.WriteLine(Course.TotalCreditLevel5);

            }
            else
            {
                if (modulesListLevel5.Items.Count == 0)
                {
                    MessageBox.Show(@"There are not module to remove ", @"Warning");
                }
                else
                {
                    MessageBox.Show(@"Select the module you want to remove ", @"Warning");
                }
            }
        }

        private void editLevel5_Click(object sender, EventArgs e)
        {


            if (ModuleChosen > -1)
            {
                Module = Course.GetModuleByName(Level, _moduleNameSelected);
                _form2 = new Form2(Course, this, modulesListLevel5, Module,Coursework);
                _form2.ShowDialog();

            }
            else
            {
                MessageBox.Show(@"Select a Module to Edit it ", @"Warning");
            }
        }

        private void removeAllLevel5_Click(object sender, EventArgs e)
        {
            Course.RemoveAll(Level);
            modulesListLevel5.Items.Clear();
        }


        //Level 6 EventsHandler
        private void addLevel6_Click(object sender, EventArgs e)
        {
            if (Course.TotalCreditLevel6 <= Course.MaxTotalCredit)
            {
                int index = modulesBox.SelectedIndex;
                object[] row = modulesLevel6[index];
                int id = int.Parse(row[0].ToString());
                string moduleName = row[1].ToString();
                int credit = int.Parse(row[2].ToString());
                Console.WriteLine(moduleName + @"  => credit " + credit);


                if (!CheckIfNotSelected(modulesListLevel6, moduleName))
                {
                    Module = new Module
                    {
                        Name = moduleName,
                        Credits = credit,
                        Id = id
                    };
                    Course.AddModules(Module, Level);
                    Course.TotalCreditLevel6 += credit;
                    modulesListLevel6.Items.Add(moduleName);
                    modulesListLevel6.Columns[0].Width = 1540;
                    Console.WriteLine(Course.TotalCreditLevel6);
                }
                else
                {
                    MessageBox.Show(@"Module has been already selected ", @"Warning");
                }
            }
            else
            {
                MessageBox.Show(@"The maximum creditis available per year are 120 
 Please remove a module if you want add a new one ", @"Warning");
            }
        }

        private void removeLevel6_Click(object sender, EventArgs e)
        {


            if (ModuleChosen > -1)
            {
                Course.TotalCreditLevel6 -= _creditToRemove;
                Course.RemoveModule(Level, ModuleChosen);
                modulesListLevel6.Items.RemoveAt(ModuleChosen);
                Console.WriteLine(Course.TotalCreditLevel6);

            }
            else
            {
                if (modulesListLevel6.Items.Count == 0)
                {
                    MessageBox.Show(@"There are not module to remove ", @"Warning");
                }
                else
                {
                    MessageBox.Show(@"Select the module you want to remove ", @"Warning");
                }
            }
        }

        private void editLevel6_Click(object sender, EventArgs e)
        {


            if (ModuleChosen > -1)
            {
                Module = Course.GetModuleByName(Level, _moduleNameSelected);
                _form2 = new Form2(Course, this, modulesListLevel6, Module,Coursework);
                _form2.ShowDialog();

            }
            else
            {
                MessageBox.Show(@"Select a Module to Edit it ", @"Warning");
            }
        }

        private void clearAllLevel6_Click(object sender, EventArgs e)
        {
            Course.RemoveAll(Level);
            modulesListLevel6.Items.Clear();
        }



        //Helper Methods

        private void addModuleData(List<object[]> list, object[] row)
        {

            list.Add(row);
        }

        private bool CheckIfNotSelected(ListView list, string module)
        {
            bool status = false;
            for (int i = 0; i < list.Items.Count; i++)
            {
                if (list.Items[i].Text.Equals(module))
                {
                    status = true;
                }
            }
            return status;
        }

        private void FillModulesList(DataTable[] source)
        {
            for (var r = 0; r < source[0].Rows.Count; r++)
            {

                addModuleData(modulesLevel4, new[] {source[0].Rows[r][0], source[0].Rows[r][1], source[0].Rows[r][2]});

            }
            
            for (var r = 0; r < source[1].Rows.Count; r++)
            {

                addModuleData(modulesLevel5, new[] {source[1].Rows[r][0], source[1].Rows[r][1], source[1].Rows[r][2]});

            }
            for (var r = 0; r < source[2].Rows.Count; r++)
            {

                addModuleData(modulesLevel6, new[] {source[2].Rows[r][0], source[2].Rows[r][1], source[2].Rows[r][2]});

            }
            

        }



        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView items = (ListView) sender;
            var i = items.SelectedIndices;

            if (items.SelectedItems.Count > 0)
            {
                _moduleNameSelected = items.Items[i[0]].Text;
                _creditToRemove = Course.GetModuleByName(Level,_moduleNameSelected).Credits;
                ModuleChosen = i[i.Count - 1];
                Console.WriteLine(ModuleChosen);
                Console.WriteLine(_moduleNameSelected);
            }
            else
            {
                ModuleChosen = -1;
            }
        }

        private bool CheckModuleHasCourseworkEdited(List<Module> list, List<Module> list2, List<Module> list3)
        {
            return (ValidateModule(list) && ValidateModule(list2) &&
                    ValidateModule(list3));
        }

        private bool ValidateModule(List<Module> list)
        {
            bool status = false;
            int length = list.Count;
            int counter = 0;
            foreach (Module m in list)
            {
                if (m.Edit)
                {
                    counter++;
                }
            }
            if (counter == length)
            {
                status = true;
            }
            return status;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            detailsPanel.Visible = false;

            if (CheckModuleHasCourseworkEdited(Course.ModulesYearOne,Course.ModulesYearTwo,Course.ModulesYearThree))
            {
               Thread t=new Thread(SaveData);
                t.Start();
                detailsPanel.Visible = false;
                FinalCustumPanel custumPanel = new FinalCustumPanel(detailsPanel, Course);
                Controls.Add(custumPanel);
                custumPanel.Dock = DockStyle.Fill;
            }
            else
            {
                MessageBox.Show(@"Some Modules have not been edited ", @"Warning");
            }
        }

        private void UpdateCredits(object sender,EventArgs e)
        {
            
            ListBox list = (ListBox) sender;
             int index=  list.SelectedIndex;
            object[] row;
            switch (Level)
            {
              
                case 4:
                    if (modulesLevel4.Count > 0)
                    {
                        row = modulesLevel4[index];
                        creditsLabelChange.Text = row[2].ToString();
                    }
                    break;
                case 5:
                    if (modulesLevel5.Count > 0)
                    {
                        row = modulesLevel5[index];
                        creditsLabelChange.Text = row[2].ToString();
                    }
                    break;
                case 6:
                    if (modulesLevel6.Count > 0)
                    {
                        row = modulesLevel6[index];
                        creditsLabelChange.Text = row[2].ToString();
                    }
                    break;
            }
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            Course = null;
            detailsPanel.Visible = false;
            introPanel.Visible = true;
        }

        private void CreateModule(object sender, EventArgs e)
        {
            if (courseNameBox.Text.Length != 0)
            {
                Course = new Course {Name = courseNameBox.Text};
                introPanel.Visible = false;
                Thread t= new Thread(CreateModulePanel);
                t.Start();
            }
            else
            {
                MessageBox.Show(@"Please Insert a valid course Name ",@"Warning");

            }
        }

        private void CreateModulePanel()
        {
            if (InvokeRequired)
            {
                CreateModulePanelDelegate d = CreateModulePanel;
                Invoke(d);
            }
            else
            {
                Panel = new CustomModulesPanel(Course, this) { Dock = DockStyle.Fill };
                Controls.Add(Panel);
            }
        }

        private void SaveData()
        {
            StreamWriter file=null;
            string result="";
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}/Data.txt";
            try
            {
                 result= JsonConvert.SerializeObject(Course,Formatting.Indented);
                 file = new StreamWriter(path);
            }
            catch (Exception e)
            {
                MessageBox.Show(@"Somenthing went wrong . Please Retry!");
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

        private void LoadData_Click(object sender, EventArgs e)
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
           
            Thread t= new Thread(RestorePreviewsState);
            t.Start();

        }

        private void  LoadData()
        {
            
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}/Data.txt";
            if (File.Exists(path))
            {
                TextReader reader = null;
                try
                {
                    reader = new StreamReader(path);
                    var fileContents = reader.ReadToEnd();
                    Console.WriteLine(fileContents);
                    Course = JsonConvert.DeserializeObject<Course>(fileContents);
                }
                catch (Exception error)
                {
                    MessageBox.Show(@"Sorry something went wrong . Please Reatry ");
                    Console.WriteLine(error);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
                _custumPanel = new FinalCustumPanel(introPanel, Course, 2);
                _custumPanel.Dock = DockStyle.Fill;
                Controls.Add(_custumPanel);
                progressBar.Visible = false;
              
                
            }
            else
            {
                MessageBox.Show(@"You do not have any course saved ");

            }
            
        }
        private void RestorePreviewsState()
        {
           
            
            if (introPanel.InvokeRequired)

            {
                Thread.Sleep(10000);
                RestorePreviewsStateDelegate d = RestorePreviewsState;
                Invoke(d);
            }
            else
            {
                LoadData();

                
                introPanel.Visible = false;
                progressBar.Visible = false;




            }
        }
      
    }
}
