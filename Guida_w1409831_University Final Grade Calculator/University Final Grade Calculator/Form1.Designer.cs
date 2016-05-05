using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace University_Final_Grade_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.F
        /// </summary>
        private IContainer components = null;

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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.introPanel = new System.Windows.Forms.Panel();
            this.detailsPanel = new System.Windows.Forms.Panel();
            this.creditsLabelChange = new System.Windows.Forms.Label();
            this.labelCredits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bckBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.modulesListLevel4 = new System.Windows.Forms.ListView();
            this.clearAllbtnLevel4 = new System.Windows.Forms.Button();
            this.editButtonLevel4 = new System.Windows.Forms.Button();
            this.removeCourseLevel4 = new System.Windows.Forms.Button();
            this.addCourseLevel4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeAllLevel5 = new System.Windows.Forms.Button();
            this.editLevel5 = new System.Windows.Forms.Button();
            this.removeLevel5 = new System.Windows.Forms.Button();
            this.addLevel5 = new System.Windows.Forms.Button();
            this.modulesListLevel5 = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.clearAllLevel6 = new System.Windows.Forms.Button();
            this.editLevel6 = new System.Windows.Forms.Button();
            this.removeLevel6 = new System.Windows.Forms.Button();
            this.addLevel6 = new System.Windows.Forms.Button();
            this.modulesListLevel6 = new System.Windows.Forms.ListView();
            this.Modules = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.modulesBox = new System.Windows.Forms.ListBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.btnCreateCourse = new System.Windows.Forms.Button();
            this.courseNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStartCourse = new System.Windows.Forms.Button();
            this.startCourseLabel = new System.Windows.Forms.Label();
            this.courseListBox = new System.Windows.Forms.ListBox();
            this.chooseCourseLabel = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.loadPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar=new System.Windows.Forms.ProgressBar();
            this.introPanel.SuspendLayout();
            this.detailsPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.loadPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // introPanel
            // 
            this.introPanel.BackColor = System.Drawing.SystemColors.Highlight;
            this.introPanel.Controls.Add(this.detailsPanel);
            this.introPanel.Controls.Add(this.btnCreateCourse);
            this.introPanel.Controls.Add(this.courseNameBox);
            this.introPanel.Controls.Add(this.label3);
            this.introPanel.Controls.Add(this.btnStartCourse);
            this.introPanel.Controls.Add(this.startCourseLabel);
            this.introPanel.Controls.Add(this.courseListBox);
            this.introPanel.Controls.Add(this.chooseCourseLabel);
            this.introPanel.Controls.Add(this.splitter1);
            this.introPanel.Controls.Add(this.loadPanel);
            this.introPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.introPanel.Location = new System.Drawing.Point(0, 0);
            this.introPanel.Name = "introPanel";
            this.introPanel.Size = new System.Drawing.Size(2370, 1297);
            this.introPanel.TabIndex = 0;
            // 
            // detailsPanel
            // 
            this.detailsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detailsPanel.Controls.Add(this.creditsLabelChange);
            this.detailsPanel.Controls.Add(this.labelCredits);
            this.detailsPanel.Controls.Add(this.label1);
            this.detailsPanel.Controls.Add(this.bckBtn);
            this.detailsPanel.Controls.Add(this.tabControl1);
            this.detailsPanel.Controls.Add(this.modulesBox);
            this.detailsPanel.Controls.Add(this.splitter2);
            this.detailsPanel.Location = new System.Drawing.Point(0, 0);
            this.detailsPanel.Name = "detailsPanel";
            this.detailsPanel.Size = new System.Drawing.Size(2380, 1427);
            this.detailsPanel.TabIndex = 8;
            this.detailsPanel.Visible = false;
            // 
            // creditsLabelChange
            // 
            this.creditsLabelChange.AutoSize = true;
            this.creditsLabelChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabelChange.Location = new System.Drawing.Point(167, 200);
            this.creditsLabelChange.Name = "creditsLabelChange";
            this.creditsLabelChange.Size = new System.Drawing.Size(35, 37);
            this.creditsLabelChange.TabIndex = 18;
            this.creditsLabelChange.Text = "0";
            // 
            // labelCredits
            // 
            this.labelCredits.AutoSize = true;
            this.labelCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredits.Location = new System.Drawing.Point(12, 200);
            this.labelCredits.Name = "labelCredits";
            this.labelCredits.Size = new System.Drawing.Size(136, 37);
            this.labelCredits.TabIndex = 17;
            this.labelCredits.Text = "Credits :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 59);
            this.label1.TabIndex = 16;
            this.label1.Text = "Modules Level ";
            // 
            // bckBtn
            // 
            this.bckBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.bckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bckBtn.Location = new System.Drawing.Point(12, 12);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(190, 79);
            this.bckBtn.TabIndex = 15;
            this.bckBtn.Text = "< Back";
            this.bckBtn.UseMnemonic = false;
            this.bckBtn.UseVisualStyleBackColor = false;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(852, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1528, 1427);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabSwitch);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage1.Controls.Add(this.modulesListLevel4);
            this.tabPage1.Controls.Add(this.clearAllbtnLevel4);
            this.tabPage1.Controls.Add(this.editButtonLevel4);
            this.tabPage1.Controls.Add(this.removeCourseLevel4);
            this.tabPage1.Controls.Add(this.addCourseLevel4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(8, 59);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1512, 1360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Level 4";
            // 
            // modulesListLevel4
            // 
            this.modulesListLevel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modulesListLevel4.FullRowSelect = true;
            this.modulesListLevel4.GridLines = true;
            this.modulesListLevel4.Location = new System.Drawing.Point(6, 207);
            this.modulesListLevel4.Name = "modulesListLevel4";
            this.modulesListLevel4.Size = new System.Drawing.Size(1504, 589);
            this.modulesListLevel4.TabIndex = 6;
            this.modulesListLevel4.UseCompatibleStateImageBehavior = false;
            this.modulesListLevel4.View = System.Windows.Forms.View.List;
            this.modulesListLevel4.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // clearAllbtnLevel4
            // 
            this.clearAllbtnLevel4.Location = new System.Drawing.Point(769, 1043);
            this.clearAllbtnLevel4.Name = "clearAllbtnLevel4";
            this.clearAllbtnLevel4.Size = new System.Drawing.Size(235, 59);
            this.clearAllbtnLevel4.TabIndex = 5;
            this.clearAllbtnLevel4.Text = "Clear All";
            this.clearAllbtnLevel4.UseVisualStyleBackColor = true;
            this.clearAllbtnLevel4.Click += new System.EventHandler(this.removeAllLevel4_Click);
            // 
            // editButtonLevel4
            // 
            this.editButtonLevel4.Location = new System.Drawing.Point(542, 1043);
            this.editButtonLevel4.Name = "editButtonLevel4";
            this.editButtonLevel4.Size = new System.Drawing.Size(173, 59);
            this.editButtonLevel4.TabIndex = 4;
            this.editButtonLevel4.Text = "Edit";
            this.editButtonLevel4.UseVisualStyleBackColor = true;
            this.editButtonLevel4.Click += new System.EventHandler(this.editLevel4_Click);
            // 
            // removeCourseLevel4
            // 
            this.removeCourseLevel4.Location = new System.Drawing.Point(282, 1043);
            this.removeCourseLevel4.Name = "removeCourseLevel4";
            this.removeCourseLevel4.Size = new System.Drawing.Size(210, 59);
            this.removeCourseLevel4.TabIndex = 3;
            this.removeCourseLevel4.Text = "Remove -";
            this.removeCourseLevel4.UseVisualStyleBackColor = true;
            this.removeCourseLevel4.Click += new System.EventHandler(this.removeLevel4_Click);
            // 
            // addCourseLevel4
            // 
            this.addCourseLevel4.Location = new System.Drawing.Point(50, 1043);
            this.addCourseLevel4.Name = "addCourseLevel4";
            this.addCourseLevel4.Size = new System.Drawing.Size(173, 59);
            this.addCourseLevel4.TabIndex = 2;
            this.addCourseLevel4.Text = "Add +";
            this.addCourseLevel4.UseVisualStyleBackColor = true;
            this.addCourseLevel4.Click += new System.EventHandler(this.addLevel4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "Your Modules";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage2.Controls.Add(this.removeAllLevel5);
            this.tabPage2.Controls.Add(this.editLevel5);
            this.tabPage2.Controls.Add(this.removeLevel5);
            this.tabPage2.Controls.Add(this.addLevel5);
            this.tabPage2.Controls.Add(this.modulesListLevel5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(8, 59);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1512, 1260);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Level 5";
            // 
            // removeAllLevel5
            // 
            this.removeAllLevel5.Location = new System.Drawing.Point(769, 1043);
            this.removeAllLevel5.Name = "removeAllLevel5";
            this.removeAllLevel5.Size = new System.Drawing.Size(235, 59);
            this.removeAllLevel5.TabIndex = 5;
            this.removeAllLevel5.Text = "Clear All";
            this.removeAllLevel5.UseVisualStyleBackColor = true;
            this.removeAllLevel5.Click += new System.EventHandler(this.removeAllLevel5_Click);
            // 
            // editLevel5
            // 
            this.editLevel5.Location = new System.Drawing.Point(543, 1043);
            this.editLevel5.Name = "editLevel5";
            this.editLevel5.Size = new System.Drawing.Size(173, 59);
            this.editLevel5.TabIndex = 4;
            this.editLevel5.Text = "Edit";
            this.editLevel5.UseVisualStyleBackColor = true;
            this.editLevel5.Click += new System.EventHandler(this.editLevel5_Click);
            // 
            // removeLevel5
            // 
            this.removeLevel5.Location = new System.Drawing.Point(282, 1043);
            this.removeLevel5.Name = "removeLevel5";
            this.removeLevel5.Size = new System.Drawing.Size(210, 59);
            this.removeLevel5.TabIndex = 3;
            this.removeLevel5.Text = "Remove -";
            this.removeLevel5.UseVisualStyleBackColor = true;
            this.removeLevel5.Click += new System.EventHandler(this.removeLevel5_Click);
            // 
            // addLevel5
            // 
            this.addLevel5.Location = new System.Drawing.Point(50, 1043);
            this.addLevel5.Name = "addLevel5";
            this.addLevel5.Size = new System.Drawing.Size(173, 59);
            this.addLevel5.TabIndex = 2;
            this.addLevel5.Text = "Add +";
            this.addLevel5.UseVisualStyleBackColor = true;
            this.addLevel5.Click += new System.EventHandler(this.addLevel5_Click);
            // 
            // modulesListLevel5
            // 
            this.modulesListLevel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modulesListLevel5.FullRowSelect = true;
            this.modulesListLevel5.GridLines = true;
            this.modulesListLevel5.Location = new System.Drawing.Point(6, 207);
            this.modulesListLevel5.Name = "modulesListLevel5";
            this.modulesListLevel5.Size = new System.Drawing.Size(1511, 589);
            this.modulesListLevel5.TabIndex = 1;
            this.modulesListLevel5.UseCompatibleStateImageBehavior = false;
            this.modulesListLevel5.View = System.Windows.Forms.View.List;
            this.modulesListLevel5.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(6, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 53);
            this.label4.TabIndex = 0;
            this.label4.Text = "Your Modules";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DodgerBlue;
            this.tabPage3.Controls.Add(this.btnSubmit);
            this.tabPage3.Controls.Add(this.clearAllLevel6);
            this.tabPage3.Controls.Add(this.editLevel6);
            this.tabPage3.Controls.Add(this.removeLevel6);
            this.tabPage3.Controls.Add(this.addLevel6);
            this.tabPage3.Controls.Add(this.modulesListLevel6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(8, 59);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1512, 1260);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Level 6";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(1048, 1043);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(259, 59);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // clearAllLevel6
            // 
            this.clearAllLevel6.Location = new System.Drawing.Point(769, 1043);
            this.clearAllLevel6.Name = "clearAllLevel6";
            this.clearAllLevel6.Size = new System.Drawing.Size(235, 59);
            this.clearAllLevel6.TabIndex = 5;
            this.clearAllLevel6.Text = "Clear All";
            this.clearAllLevel6.UseVisualStyleBackColor = true;
            this.clearAllLevel6.Click += new System.EventHandler(this.clearAllLevel6_Click);
            // 
            // editLevel6
            // 
            this.editLevel6.Location = new System.Drawing.Point(542, 1043);
            this.editLevel6.Name = "editLevel6";
            this.editLevel6.Size = new System.Drawing.Size(173, 59);
            this.editLevel6.TabIndex = 4;
            this.editLevel6.Text = "Edit";
            this.editLevel6.UseVisualStyleBackColor = true;
            this.editLevel6.Click += new System.EventHandler(this.editLevel6_Click);
            // 
            // removeLevel6
            // 
            this.removeLevel6.Location = new System.Drawing.Point(282, 1043);
            this.removeLevel6.Name = "removeLevel6";
            this.removeLevel6.Size = new System.Drawing.Size(210, 59);
            this.removeLevel6.TabIndex = 3;
            this.removeLevel6.Text = "Remove -";
            this.removeLevel6.UseVisualStyleBackColor = true;
            this.removeLevel6.Click += new System.EventHandler(this.removeLevel6_Click);
            // 
            // addLevel6
            // 
            this.addLevel6.Location = new System.Drawing.Point(50, 1043);
            this.addLevel6.Name = "addLevel6";
            this.addLevel6.Size = new System.Drawing.Size(173, 59);
            this.addLevel6.TabIndex = 2;
            this.addLevel6.Text = "Add +";
            this.addLevel6.UseVisualStyleBackColor = true;
            this.addLevel6.Click += new System.EventHandler(this.addLevel6_Click);
            // 
            // modulesListLevel6
            // 
            this.modulesListLevel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modulesListLevel6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.modulesListLevel6.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Modules});
            this.modulesListLevel6.FullRowSelect = true;
            this.modulesListLevel6.GridLines = true;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.modulesListLevel6.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.modulesListLevel6.Location = new System.Drawing.Point(6, 207);
            this.modulesListLevel6.Name = "modulesListLevel6";
            this.modulesListLevel6.Size = new System.Drawing.Size(1506, 589);
            this.modulesListLevel6.TabIndex = 1;
            this.modulesListLevel6.TileSize = new System.Drawing.Size(1540, 50);
            this.modulesListLevel6.UseCompatibleStateImageBehavior = false;
            this.modulesListLevel6.View = System.Windows.Forms.View.List;
            this.modulesListLevel6.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // Modules
            // 
            this.Modules.Name = global::University_Final_Grade_Calculator.Properties.Settings.Default.Name;
            this.Modules.Width = global::University_Final_Grade_Calculator.Properties.Settings.Default.Max;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(6, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(308, 52);
            this.label5.TabIndex = 0;
            this.label5.Text = "Your Modules";
            // 
            // modulesBox
            // 
            this.modulesBox.AllowDrop = true;
            this.modulesBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modulesBox.ColumnWidth = 748;
            this.modulesBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulesBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.modulesBox.FormattingEnabled = true;
            this.modulesBox.ItemHeight = 38;
            this.modulesBox.Location = new System.Drawing.Point(0, 253);
            this.modulesBox.MultiColumn = true;
            this.modulesBox.Name = "modulesBox";
            this.modulesBox.Size = new System.Drawing.Size(852, 1144);
            this.modulesBox.TabIndex = 10;
            this.modulesBox.Click += new System.EventHandler(this.UpdateCredits);
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(852, 1427);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // btnCreateCourse
            // 
            this.btnCreateCourse.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCourse.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCourse.Location = new System.Drawing.Point(1324, 399);
            this.btnCreateCourse.Name = "btnCreateCourse";
            this.btnCreateCourse.Size = new System.Drawing.Size(213, 70);
            this.btnCreateCourse.TabIndex = 7;
            this.btnCreateCourse.Text = "Start";
            this.btnCreateCourse.UseVisualStyleBackColor = false;
            this.btnCreateCourse.Click += new System.EventHandler(this.CreateModule);
            // 
            // courseNameBox
            // 
            this.courseNameBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameBox.Location = new System.Drawing.Point(1482, 240);
            this.courseNameBox.Name = "courseNameBox";
            this.courseNameBox.Size = new System.Drawing.Size(357, 46);
            this.courseNameBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(902, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(439, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Insert your course name :";
            // 
            // btnStartCourse
            // 
            this.btnStartCourse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartCourse.Font = new System.Drawing.Font("Verdana", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartCourse.Location = new System.Drawing.Point(290, 967);
            this.btnStartCourse.Name = "btnStartCourse";
            this.btnStartCourse.Size = new System.Drawing.Size(267, 71);
            this.btnStartCourse.TabIndex = 4;
            this.btnStartCourse.Text = "Start";
            this.btnStartCourse.UseVisualStyleBackColor = true;
            this.btnStartCourse.Click += new System.EventHandler(this.button1_Click);
            // 
            // startCourseLabel
            // 
            this.startCourseLabel.AutoSize = true;
            this.startCourseLabel.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCourseLabel.Location = new System.Drawing.Point(941, 92);
            this.startCourseLabel.Name = "startCourseLabel";
            this.startCourseLabel.Size = new System.Drawing.Size(618, 52);
            this.startCourseLabel.TabIndex = 3;
            this.startCourseLabel.Text = "Create Your Custom Course";
            // 
            // courseListBox
            // 
            this.courseListBox.Font = new System.Drawing.Font("Verdana", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseListBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.courseListBox.FormattingEnabled = true;
            this.courseListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.courseListBox.ItemHeight = 45;
            this.courseListBox.Location = new System.Drawing.Point(0, 256);
            this.courseListBox.Name = "courseListBox";
            this.courseListBox.Size = new System.Drawing.Size(896, 589);
            this.courseListBox.TabIndex = 2;
            // 
            // chooseCourseLabel
            // 
            this.chooseCourseLabel.AutoSize = true;
            this.chooseCourseLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.chooseCourseLabel.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseCourseLabel.Location = new System.Drawing.Point(177, 141);
            this.chooseCourseLabel.Name = "chooseCourseLabel";
            this.chooseCourseLabel.Size = new System.Drawing.Size(571, 52);
            this.chooseCourseLabel.TabIndex = 1;
            this.chooseCourseLabel.Text = "Choose a Default  Course";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(895, 1297);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // loadPanel
            // 
            this.loadPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadPanel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.loadPanel.Controls.Add(this.label6);
            this.loadPanel.Controls.Add(this.button1);
            this.loadPanel.Location = new System.Drawing.Point(899, 627);
            this.loadPanel.Margin = new System.Windows.Forms.Padding(0);
            this.loadPanel.Name = "loadPanel";
            this.loadPanel.Size = new System.Drawing.Size(1471, 670);
            this.loadPanel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(290, 52);
            this.label6.TabIndex = 9;
            this.label6.Text = "Load Course";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.LoadData_Click);
            //
            //ProgressBar
            //
            this.progressBar.Location=new System.Drawing.Point(1200,900);
            this.progressBar.Size = new System.Drawing.Size(600, 50);
            this.progressBar.Text = "Loading ......";
            this.progressBar.Visible = false;
          
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(2370, 1297);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.introPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grade Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.introPanel.ResumeLayout(false);
            this.introPanel.PerformLayout();
            this.detailsPanel.ResumeLayout(false);
            this.detailsPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.loadPanel.ResumeLayout(false);
            this.loadPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel introPanel;
        private Splitter splitter1;
        private Label chooseCourseLabel;
        private ListBox courseListBox;
        private TextBox courseNameBox;
        private Label label3;
        private Button btnStartCourse;
        private Label startCourseLabel;
        private Button btnCreateCourse;
        private Panel detailsPanel;
        private TabControl tabControl1;
        private TabPage tabPage3;
        private ListBox modulesBox;
        private Splitter splitter2;
        private ListView modulesListLevel6;
        private Label label5;
        private TabPage tabPage1;
        private ListView modulesListLevel4;
        private Button clearAllbtnLevel4;
        private Button editButtonLevel4;
        private Button removeCourseLevel4;
        private Button addCourseLevel4;
        private Label label2;
        private TabPage tabPage2;
        private Button removeAllLevel5;
        private Button editLevel5;
        private Button removeLevel5;
        private Button addLevel5;
        private ListView modulesListLevel5;
        private Label label4;
        private Button clearAllLevel6;
        private Button editLevel6;
        private Button removeLevel6;
        private Button addLevel6;
        public ColumnHeader Modules;
        private Button btnSubmit;
        private Button button1;
        private Label label6;
        private Panel loadPanel;
        private Label creditsLabelChange;
        private Label labelCredits;
        private Label label1;
        private Button bckBtn;
        private ProgressBar progressBar;
    }
}

