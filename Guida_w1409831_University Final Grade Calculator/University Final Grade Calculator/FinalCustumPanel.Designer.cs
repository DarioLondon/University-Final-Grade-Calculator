using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Label = System.Windows.Forms.Label;

namespace University_Final_Grade_Calculator
{
   
    partial class FinalCustumPanel
    {
       List <object[]> modulesTab=new List<object[]>();
        TextBox[] avarageBoxs=new TextBox[3];
       
        private int pageIndex = 4;
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
        private TabPage[] CreateDynamicGui(Course course)

        {

            _tabsPage = new TabPage[3];

            _tabsPage[0] = CreateTabs(course.ModulesYearOne, 0);
            _tabsPage[1] = CreateTabs(course.ModulesYearTwo, 1);
            _tabsPage[2] = CreateTabs(course.ModulesYearThree, 2);


            return _tabsPage;
            
            




        }

        private void CreateModuleForm(Module module, TabPage tabPage, int cordinateY, int index)
        {

            int lenght = module.CourseWorkList.Count;
            int counter = 0;
            var label = new Label[lenght];
            weightLabel = new Label[lenght];
            markBox = new TextBox[lenght];
            Console.WriteLine(module.CourseWorkList.Count);
            var moduleName = new Label()

            {
                Location = new Point(55, cordinateY - 30),
                Text = module.Name,
                AutoSize = true,
                ForeColor = Color.CadetBlue,


            };

            var finalMarkTextxBox = new TextBox()
            {
                Anchor = AnchorStyles.Right | AnchorStyles.Top,
                //Location =new Point(1300,55),
                // Dock = DockStyle.Right,
                Location = new Point(0, 55),

                Size = new Size(100, 55),
                Text = ""+0
            };
            finalMarkTextxBox.Top = 20 + cordinateY;
            finalMarkTextxBox.Left = 2280;
            tabPage.Controls.Add(finalMarkTextxBox);


        
            foreach (var courseWork in module.CourseWorkList)
            {

                courseWork.Id = counter;
                label[counter] = new Label
                {
                    Location = new Point(55 + (counter*520), cordinateY + 20),
                    Text = courseWork.Type,
                    AutoSize = true,
                    Size = new Size(260, 55)
                };
                markBox[counter] = new TextBox()
                {
                    Location = new Point(320 + (counter*520), cordinateY + 20),
                    Size = new Size(100, 55),
                    Name = "" + counter,
                    Text = ""+courseWork.Mark

                };
                markBox[counter].TextChanged += ValidateAndCalculate;
                markBox[counter].Leave += ResetToZero;

                weightLabel[counter] = new Label
                {
                    Location = new Point(420 + (counter*520), cordinateY + 20),
                    Text = courseWork.Weight + @"%",
                    AutoSize = true
                };



                tabPage.Controls.Add(moduleName);
                tabPage.Controls.Add(label[counter]);
                tabPage.Controls.Add(markBox[counter]);
                tabPage.Controls.Add(weightLabel[counter]);
                modulesTab.Add(new object[]{module.Name, label[counter].Text, markBox[counter], courseWork.Weight, finalMarkTextxBox,counter});
                


                counter++;

            }


        }

        private Label CreateFinalMarkLabel()
        {
            var label = new Label
            {

               Dock = DockStyle.Right,
                
                Location = new Point(0, 10),
                Text = @"Final mark",
                TextAlign = ContentAlignment.MiddleCenter,
                AutoSize = true

            };

            return label;


        }

        private void PopulateTabs(List<Module> modules, TabPage tabPage)
        {
           
            int cordinateY = 155;
            int counter = 1;
            
            foreach (var module in modules)
            {
               
                if (counter > 1)
                {
                    cordinateY = 155;
                }
                CreateModuleForm(module, tabPage, cordinateY * counter,counter);
                counter++;
            }
        }


      

        private TabPage CreateTabs(List<Module> modules, int index)
        {
           Button calculatebtn=new Button();
            TextBox averageBox = new TextBox();

            calculatebtn.Text = "Calculate";
            calculatebtn.Location=new Point(20,10);
            calculatebtn.Size=new Size(300,75);
            calculatebtn.Click += CalcuateAverage;

            averageBox.Text = "0%";
            averageBox.Location=new Point(330,25);
            averageBox.Size=new Size(150,75);
            averageBox.Enabled = false;
            averageBox.Name = "AverageBox" + index;
            avarageBoxs[index] = averageBox;

            TabPage tabs = tabs = new TabPage();
            

            tabs.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            tabs.Text = @"Level " + (index + 4);
            tabs.Padding = new Padding(3);
            tabs.Size = new System.Drawing.Size(2396, 1468);
            tabs.UseVisualStyleBackColor = true;
            tabs.TabIndex = index;
            tabs.AutoScroll = true;
            tabs.Controls.Add(calculatebtn);
            tabs.Controls.Add(averageBox);
            tabs.Controls.Add(CreateFinalMarkLabel());
            PopulateTabs(modules, tabs);
       


            return tabs;

        }
        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalCustumPanel));
            this.backbtn = new System.Windows.Forms.Button();
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.summarybtn = new System.Windows.Forms.Button();
            this.summaryTabPage = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.saveBtn = new System.Windows.Forms.Button();
            this.summaryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.SystemColors.HotTrack;
            resources.ApplyResources(this.backbtn, "backbtn");
            this.backbtn.Name = "backbtn";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // courseNameLabel
            // 
            resources.ApplyResources(this.courseNameLabel, "courseNameLabel");
            this.courseNameLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.courseNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.courseNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.courseNameLabel.Name = "courseNameLabel";
            // 
            // summarybtn
            // 
            resources.ApplyResources(this.summarybtn, "summarybtn");
            this.summarybtn.Name = "summarybtn";
            this.summarybtn.Click+=new System.EventHandler(this.FinalResult);
            // 
            // summaryTabPage
            // 
            this.summaryTabPage.Controls.Add(this.summarybtn);
            resources.ApplyResources(this.summaryTabPage, "summaryTabPage");
            this.summaryTabPage.Name = "summaryTabPage";
            this.summaryTabPage.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.TabIndexChanged += new System.EventHandler(this.ChangeTab);
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Image = global::University_Final_Grade_Calculator.Properties.Resources.save_icon1;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // FinalCustumPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.courseNameLabel);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.tabControl);
            resources.ApplyResources(this, "$this");
            this.Name = "FinalCustumPanel";
            this.summaryTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage summaryTabPage;
        private System.Windows.Forms.Button summarybtn;
        private System.Windows.Forms.Label[] weightLabel;
        private System.Windows.Forms.TextBox[] markBox;
        private Button saveBtn;
    }
}
