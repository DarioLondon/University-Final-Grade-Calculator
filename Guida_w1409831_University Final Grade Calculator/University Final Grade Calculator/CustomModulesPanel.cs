using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace University_Final_Grade_Calculator
{
    public partial class CustomModulesPanel : UserControl
    {
        private int _totalcreditLevel4;
        private int _totalcreditLevel5 ;
        private int _totalcreditLevel6 ;
        public  Course Course;
        public CourseWork Coursework = new CourseWork();
        public Form2 Form2;
        public Module Module;
        public Form1 form1;
        private FinalCustumPanel _custumPanel;
        public CustomModulesPanel(Course c,Form1 f)
        {
            Course = c;
            form1 = f;
            InitializeComponent(c);
        }

        private void AddModule(object sender, EventArgs e)
        {
            string moduleName = textBox1.Text;
           
            int level = levelBox.SelectedIndex;
            
            if (moduleName.Length > 0)
            {
                switch (level)
                {
                    case 0:
                        if (_totalcreditLevel4 + int.Parse(comboBox1.SelectedItem.ToString()) > Course.MaxTotalCredit)
                        {
                            MessageBox.Show(@"You reached the maximun credits for this year or you have to choose a module with less credit");
                        }
                        else
                        {
                            Course.AddModules(new Module
                            {
                                Name = moduleName,
                                Credits = int.Parse(comboBox1.SelectedItem.ToString()),
                                
                            },4);
                            _totalcreditLevel4 += int.Parse(comboBox1.SelectedItem.ToString());
                            Console.WriteLine(_totalcreditLevel4);
                            level4Box.Items.Add(moduleName);
                        }
                        break;
                    case 1:
                        if (_totalcreditLevel5 + int.Parse(comboBox1.SelectedItem.ToString()) > Course.MaxTotalCredit)
                        {
                            MessageBox.Show(@"You reached the maximun credits for this year or you have to choose a module with less credit");
                        }
                        else
                        {
                            Course.AddModules(new Module
                            {
                                Name = moduleName,
                                Credits = int.Parse(comboBox1.SelectedItem.ToString()),
                                
                            },5);
                            _totalcreditLevel5 += int.Parse(comboBox1.SelectedItem.ToString());
                            level5Box.Items.Add(moduleName);
                        }
                        break;
                    case 2:
                        if (_totalcreditLevel6 + int.Parse(comboBox1.SelectedItem.ToString()) > Course.MaxTotalCredit)
                        {
                            MessageBox.Show(@"You reached the maximun credits for this year or you have to choose a module with less credit");
                        }
                        else
                        {

                            Course.AddModules(new Module
                            {
                                Name = moduleName,
                                Credits = int.Parse(comboBox1.SelectedItem.ToString()),
                               
                            },6);
                            _totalcreditLevel6 += int.Parse(comboBox1.SelectedItem.ToString());
                            level6Box.Items.Add(moduleName);
                        }
                        break;
                }
            }
            else
            {
                MessageBox.Show(@"Please type a valid Module Name");
            }

        }

        private void ClearAll(object sender, EventArgs e )
        {
            Button btn = (Button) sender;
            if (btn.Name =="clearAllLevel4")
            {   Course.RemoveAll(4);
                level4Box.Items.Clear();
                _totalcreditLevel4 = 0;
            }
            if (btn.Name == "clearAllLevel5")
            {
                Course.RemoveAll(5);
                level5Box.Items.Clear();
                _totalcreditLevel5 = 0;
            }
            if (btn.Name == "clearAllLevel6")
            {
                Course.RemoveAll(6);
                level6Box.Items.Clear();
                _totalcreditLevel6 = 0;
            }
        }

        private void RemoveOne(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "removeLevel4")
            {
                
                var index = level4Box.SelectedIndex;
                var credit = Course.GetModuleByName(4, level4Box.SelectedItem.ToString()).Credits;
                Console.WriteLine(credit);
                _totalcreditLevel4 -= credit;
                level4Box.Items.RemoveAt(index);
                Course.RemoveModule(4, index);
            }
            if (btn.Name == "removeLevel5")
            {
               
                var index = level5Box.SelectedIndex;
                var credit = Course.GetModuleByName(5, level5Box.SelectedItem.ToString()).Credits;
                Console.WriteLine(credit);
                _totalcreditLevel5 -= credit;

                level5Box.Items.RemoveAt(index);
                Course.RemoveModule(5, index);
            }
            if (btn.Name == "removeLevel6")
            {
                
                var index = level6Box.SelectedIndex;
                var credit = Course.GetModuleByName(6, level6Box.SelectedItem.ToString()).Credits;
                Console.WriteLine(credit);
                _totalcreditLevel6 -= credit;
                level5Box.Items.RemoveAt(index);
                Course.RemoveModule(6, index);
            }
        }

        private void Edit(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "editLevel4")
            {
                if (level4Box.SelectedIndex> -1)
                {
                    Module = Course.GetModuleByName(4, level4Box.SelectedItem.ToString());
                    Form2 = new Form2(Course, level4Box, Module,Coursework, level4Box.SelectedIndex);
                    Form2.ShowDialog();


                }
                else
                {
                    MessageBox.Show(@"Select a Module to Edit it ");
                }
            }
            if (btn.Name == "editLevel5")
            {
                if (level5Box.SelectedIndex > -1)
                {
                    Module = Course.GetModuleByName(5, level5Box.SelectedItem.ToString());
                    Form2 = new Form2(Course, level5Box, Module, Coursework, level5Box.SelectedIndex);
                    Form2.ShowDialog();


                }
                else
                {
                    MessageBox.Show(@"Select a Module to Edit it ");
                }
            }
            if (btn.Name == "editLevel6")
            {
                if (level6Box.SelectedIndex > -1)
                {
                    Module = Course.GetModuleByName(6, level6Box.SelectedItem.ToString());
                    Form2 = new Form2(Course, level6Box, Module, Coursework, level6Box.SelectedIndex);
                    Form2.ShowDialog();


                }
                else
                {
                    MessageBox.Show(@"Select a Module to Edit it ");
                }
            }
        }

        private void Submit(object sender, EventArgs e)
        {

            if (CheckModuleHasCourseworkEdited(Course.ModulesYearOne, Course.ModulesYearTwo, Course.ModulesYearThree))
            {
                Thread d = new Thread(SaveData);
                d.Start();
             
                Visible = false;
                _custumPanel = new FinalCustumPanel(this, Course);
                _custumPanel.Dock = DockStyle.Fill;
                _custumPanel.Visible = true;
                form1.Controls.Add(_custumPanel);
            }
            else
            {
                MessageBox.Show(@"Some Modules have not been edited  or Some module has the same name",@"Warning");
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

        private void BackHome(object sender, EventArgs e)
        {
            form1.Controls["introPanel"].Visible = true;
            Course = null;
           
            
            Coursework = null;
            

        }
        private void SaveData()
        {
            StreamWriter file = null;
            string result = "";
            var path = $"{AppDomain.CurrentDomain.BaseDirectory}/Data.txt";
            try
            {
                result = JsonConvert.SerializeObject(Course, Formatting.Indented);
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

    }
}
