using System;
using System.Drawing;
using System.Windows.Forms;

namespace University_Final_Grade_Calculator
{
    public partial class Form2 : Form
    {
        //Variables
        private ComboBox[] _courseWorkType;
        private TrackBar[] _trackBars;
        private TextBox[] _weightBox;
        public Form1 Frm1;
        public Course Course;
        public  ListView List;
        public Module Module;
        public CourseWork Coursework;
        private bool _status;
        public ListBox list;
        private int index;
        private int type;

        //Methods
        public Form2()
        {
            InitializeComponent();
            new DataBase().GetCourseWorkTypeList();
            numericPicker.Minimum = 0;
            numericPicker.Maximum = 4;

        }
        public Form2(Course course, Form1 form,ListView list, Module m,CourseWork c) : this()
        {
            Course = course;
            Frm1 = form;
            List = list;
            Module = m;
            Coursework = c;
            type = 0;
            
            Console.WriteLine(Frm1.Course.Name);
            Console.WriteLine(Frm1.Level);
            Console.WriteLine(Module.Name);



        }
        public Form2(Course course,ListBox l,Module m,CourseWork c,int i) : this()
        {
            Course = course;
            Module = m;
            Coursework = c;
            list = l;
            index = i;
            type = 1;

        }
        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (LenghtIsNotZero())
            {
                var number = GetPickerValue();
                CreateGui(number);
                _status = true;
            }
            else
            {
                MessageBox.Show(@"You have to insert a value greater than zero in the CourseWork type field", @"Warning");
            }

        }
        private void CreateGui(int number)
        {

            var labelType = new Label[number];
            _courseWorkType = new ComboBox[number];
            var weightLabel = new Label[number];
            _weightBox = new TextBox[number];
            _trackBars = new TrackBar[number];

            for (var g = 0; g < number; g++)
            {

                labelType[g] = new Label();
                _courseWorkType[g] = new ComboBox();
                _trackBars[g] = new TrackBar();
                weightLabel[g] = new Label();
                _weightBox[g] = new TextBox();


                labelType[g].Location = new Point(55, 149 + g*100);
                _courseWorkType[g].Location = new Point(400, 149 + g*100);
                _trackBars[g].Location = new Point(790, 149 + g*100);
                weightLabel[g].Location = new Point(600, 149 + g*100);
                _weightBox[g].Location = new Point(710, 149 + g*100);

                _courseWorkType[g].Size = new Size(150, 50);
                _courseWorkType[g].Items.Add("CourseWork");
                _courseWorkType[g].Items.Add("Exam");
                _courseWorkType[g].Items.Add("Portfolio");
                _courseWorkType[g].SelectedItem = "Exam";

                labelType[g].Name = "label1";
                labelType[g].Size = new Size(310, 25);
                labelType[g].TabIndex = 0;
                labelType[g].Text = @"Choose CourseWork Type  :";

                _trackBars[g].SetRange(0, 100);
                _trackBars[g].Size = new Size(200, 60);
                _trackBars[g].TickStyle = TickStyle.TopLeft;
                _trackBars[g].SmallChange = 6;
                _trackBars[g].Minimum = 1;
                _trackBars[g].Maximum = 100;
                _trackBars[g].Text = @"CourseWork Weight";

                _trackBars[g].Scroll += Slide;

                weightLabel[g].Text = @"Weight";

                _weightBox[g].Size = new Size(60, 40);
                _weightBox[g].Text = _trackBars[g].Value.ToString();
                _weightBox[g].TextChanged += ChangeSlideValue;

                Controls.Add(labelType[g]);
                Controls.Add(_courseWorkType[g]);
                Controls.Add(weightLabel[g]);
                Controls.Add(_weightBox[g]);
                Controls.Add(_trackBars[g]);

            }
        }
        private int GetPickerValue()
        {
            var number = 0;
            try
            {
                number = (int) numericPicker.Value;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            return number;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!LenghtIsNotZero()|| _status==false)
            {
                if (_status == false)
                {
                    MessageBox.Show(@"Click Submit Button ", @"Warning");
                }
                else
                {
                    MessageBox.Show(@"You have to insert a value greater than zero in the CourseWork type field", @"Warning");
                }
            }
            else
            {


                if (Validate(_weightBox))
                {
                  
                    ClearCorsework();
                    
                    SaveData();
                    if (type == 0)
                    {
                        MarkModuleAsEdited(List);
                    }
                    else
                    {

                        MarkMaduleAsEditedICustomPanel(list);
                    }

                    Console.WriteLine(Module.Edit);
                    Close();
                }
                else
                {
                    if (GetErrorWeightValue(_weightBox) > 100)
                    {
                        MessageBox.Show(@"The Total sum of the weight must be less than 100", @"Warning");
                    }
                    else
                    {
                        MessageBox.Show(@"The Total sum of the weight must be equal  to 100", @"Warning");
                    }
                }
            }

        }
        private void Slide(object sender, EventArgs e)
        {
            TrackBar bar = (TrackBar) sender;
            int val = Array.FindIndex(_trackBars, b => b == bar);
            int value = bar.Value;
            _weightBox[val].Text = "" + value;

        }
        private void ChangeSlideValue(object sender, EventArgs e)
        {
            TextBox box = (TextBox) sender;
            int findIndex = Array.FindIndex(_weightBox, b => b == box);

            int value;
            if (int.TryParse(box.Text, out value))

            {
                if (value > 0 && value <= 100)
                {
                    _trackBars[findIndex].Value = value;
                }
                else
                {
                    MessageBox.Show(@"Value must be greater than zero and less the 100", @"Warning");
                }
            }

        }
        private void SaveData()
        {

                var length = GetPickerValue();
                for (var count = 0; count < length; count++)
                {
                    string courseType = _courseWorkType[count].Text;
                    int weight;
                    if (int.TryParse(_weightBox[count].Text, out weight))
                    {
                        Coursework = new CourseWork { Type=courseType, Weight = weight};
                        Module.AddCourseWork(Coursework);
                      

                    }
                }
           
           
        }
        private bool LenghtIsNotZero()
        {
            return GetPickerValue() > 0;
        }
        private bool Validate(TextBox[] input)
        {
            int counter = 0;
            foreach (TextBox t in input)
            {
                counter += int.Parse(t.Text);
            }
            
            return counter==100;
        }
        private int GetErrorWeightValue(TextBox[] input)
        {
            
            int counter = 0;
            foreach (TextBox t in input)
            {
                counter += int.Parse(t.Text);
            }

            return counter;
        }
        private void ClearCorsework()
        {
          Module.RemoveCourseworks();
        }

        private void MarkModuleAsEdited(ListView l)
        {
            l.Items[Frm1.ModuleChosen].ForeColor = Color.DarkGreen;
        }

        private void MarkMaduleAsEditedICustomPanel(ListBox l)
        {
            string s = Module.Name + @"                [edited]";
            l.Items.RemoveAt(index);
            l.Items.Insert(index,s);
        }

    }


   
}