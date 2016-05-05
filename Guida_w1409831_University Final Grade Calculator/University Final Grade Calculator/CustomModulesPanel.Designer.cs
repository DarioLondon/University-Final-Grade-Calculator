namespace University_Final_Grade_Calculator
{
    partial class CustomModulesPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent(Course c)
        {
            this.courseNameLabel = new System.Windows.Forms.Label();
            this.moduleLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.creditLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.levelLabel = new System.Windows.Forms.Label();
            this.levelBox = new System.Windows.Forms.ComboBox();
            this.addModuleBtn = new System.Windows.Forms.Button();
            this.levelFourLabel = new System.Windows.Forms.Label();
            this.level4Box = new System.Windows.Forms.ListBox();
            this.level5Box = new System.Windows.Forms.ListBox();
            this.level6Box = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeLevel4 = new System.Windows.Forms.Button();
            this.clearAllLevel4 = new System.Windows.Forms.Button();
            this.removeLevel5 = new System.Windows.Forms.Button();
            this.clearAllLevel5 = new System.Windows.Forms.Button();
            this.removeLevel6 = new System.Windows.Forms.Button();
            this.clearAllLevel6 = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.editLevel4=new System.Windows.Forms.Button();
            this.editLevel5 = new System.Windows.Forms.Button();
            this.editLevel6 = new System.Windows.Forms.Button();
            this.bckBtn=new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // bckBtn
            //
            this.bckBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.bckBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bckBtn.Location = new System.Drawing.Point(20, 20);
            this.bckBtn.Size = new System.Drawing.Size(100, 75);
            this.bckBtn.Text = "<< Back";
            this.bckBtn.UseVisualStyleBackColor = false;
            this.bckBtn.Click += BackHome;
            // 
            // courseNameLabel
            // 
            this.courseNameLabel.AutoSize = true;
            this.courseNameLabel.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNameLabel.Location = new System.Drawing.Point(585, 66);
            this.courseNameLabel.Name = "courseNameLabel";
            this.courseNameLabel.Size = new System.Drawing.Size(0, 59);
            this.courseNameLabel.TabIndex = 0;
            this.courseNameLabel.Text = Course.Name;
            // 
            // moduleLabel
            // 
            this.moduleLabel.AutoSize = true;
            this.moduleLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduleLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.moduleLabel.Location = new System.Drawing.Point(118, 195);
            this.moduleLabel.Name = "moduleLabel";
            this.moduleLabel.Size = new System.Drawing.Size(213, 35);
            this.moduleLabel.TabIndex = 1;
            this.moduleLabel.Text = "Module Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(391, 187);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(759, 43);
            this.textBox1.TabIndex = 2;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.creditLabel.Location = new System.Drawing.Point(1244, 195);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(102, 35);
            this.creditLabel.TabIndex = 3;
            this.creditLabel.Text = "Credit";
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "15";
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "15",
            "30",
            "45"});
            this.comboBox1.Location = new System.Drawing.Point(1352, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 41);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "15";
            this.comboBox1.SelectedIndex = 0;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Font = new System.Drawing.Font("Verdana", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.levelLabel.Location = new System.Drawing.Point(1543, 195);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(91, 35);
            this.levelLabel.TabIndex = 5;
            this.levelLabel.Text = "Level";
            // 
            // levelBox
            // 
            this.levelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelBox.FormattingEnabled = true;
            this.levelBox.Items.AddRange(new object[] {
            "Level 4",
            "Level 5",
            "Level 6"});
            this.levelBox.Location = new System.Drawing.Point(1682, 189);
            this.levelBox.Name = "levelBox";
            this.levelBox.Size = new System.Drawing.Size(213, 41);
            this.levelBox.TabIndex = 6;
            this.levelBox.SelectedIndex = 0;
            // 
            // addModuleBtn
            // 
            this.addModuleBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.addModuleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addModuleBtn.Location = new System.Drawing.Point(2014, 186);
            this.addModuleBtn.Name = "addModuleBtn";
            this.addModuleBtn.Size = new System.Drawing.Size(150, 44);
            this.addModuleBtn.TabIndex = 7;
            this.addModuleBtn.Text = "+ Add ";
            this.addModuleBtn.UseVisualStyleBackColor = false;
            this.addModuleBtn.Click += AddModule;

            // 
            // levelFourLabel
            // 
            this.levelFourLabel.AutoSize = true;
            this.levelFourLabel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.levelFourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelFourLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.levelFourLabel.Location = new System.Drawing.Point(153, 442);
            this.levelFourLabel.Name = "levelFourLabel";
            this.levelFourLabel.Size = new System.Drawing.Size(118, 37);
            this.levelFourLabel.TabIndex = 8;
            this.levelFourLabel.Text = "Level 4";
            // 
            // level4Box
            // 
            this.level4Box.FormattingEnabled = true;
            this.level4Box.ItemHeight = 25;
            this.level4Box.Location = new System.Drawing.Point(147, 498);
            this.level4Box.Name = "level4Box";
            this.level4Box.Size = new System.Drawing.Size(517, 504);
            this.level4Box.TabIndex = 9;
            // 
            // level5Box
            // 
            this.level5Box.FormattingEnabled = true;
            this.level5Box.ItemHeight = 25;
            this.level5Box.Location = new System.Drawing.Point(819, 498);
            this.level5Box.Name = "level5Box";
            this.level5Box.Size = new System.Drawing.Size(517, 504);
            this.level5Box.TabIndex = 10;
            // 
            // level6Box
            // 
            this.level6Box.FormattingEnabled = true;
            this.level6Box.ItemHeight = 25;
            this.level6Box.Location = new System.Drawing.Point(1487, 498);
            this.level6Box.Name = "level6Box";
            this.level6Box.Size = new System.Drawing.Size(517, 504);
            this.level6Box.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(822, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Level 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(1490, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Level 6";
            // 
            // removeLevel4
            // 
            this.removeLevel4.Location = new System.Drawing.Point(147, 1040);
            this.removeLevel4.Name = "removeLevel4";
            this.removeLevel4.Size = new System.Drawing.Size(121, 55);
            this.removeLevel4.TabIndex = 14;
            this.removeLevel4.Text = "Remove -";
            this.removeLevel4.UseVisualStyleBackColor = true;
            this.removeLevel4.Click += RemoveOne;


            // 
            // clearAllLevel4
            // 
            this.clearAllLevel4.Location = new System.Drawing.Point(306, 1040);
            this.clearAllLevel4.Name = "clearAllLevel4";
            this.clearAllLevel4.Size = new System.Drawing.Size(121, 55);
            this.clearAllLevel4.TabIndex = 15;
            this.clearAllLevel4.Text = "Clear All";
            this.clearAllLevel4.UseVisualStyleBackColor = true;
            this.clearAllLevel4.Click += ClearAll;
            // 
            // editLevel4
            // 

            this.editLevel4.Location = new System.Drawing.Point(465, 1040);
            this.editLevel4.Name = "editLevel4";
            this.editLevel4.Size = new System.Drawing.Size(121, 55);
            this.editLevel4.TabIndex = 15;
            this.editLevel4.Text = "Edit";
            this.editLevel4.UseVisualStyleBackColor = true;
            this.editLevel4.Click += Edit;


            // 
            // removeLevel5
            // 
            this.removeLevel5.Location = new System.Drawing.Point(819, 1040);
            this.removeLevel5.Name = "removeLevel5";
            this.removeLevel5.Size = new System.Drawing.Size(121, 55);
            this.removeLevel5.TabIndex = 16;
            this.removeLevel5.Text = "Remove -";
            this.removeLevel5.UseVisualStyleBackColor = true;
            this.removeLevel5.Click += RemoveOne;
            // 
            // clearAllLevel5
            // 
            this.clearAllLevel5.Location = new System.Drawing.Point(982, 1040);
            this.clearAllLevel5.Name = "clearAllLevel5";
            this.clearAllLevel5.Size = new System.Drawing.Size(121, 55);
            this.clearAllLevel5.TabIndex = 17;
            this.clearAllLevel5.Text = "Clear All";
            this.clearAllLevel5.UseVisualStyleBackColor = true;
            this.clearAllLevel5.Click += ClearAll;

            // 
            // editLevel5
            // 

            this.editLevel5.Location = new System.Drawing.Point(1145, 1040);
            this.editLevel5.Name = "editLevel5";
            this.editLevel5.Size = new System.Drawing.Size(121, 55);
            this.editLevel5.TabIndex = 15;
            this.editLevel5.Text = "Edit";
            this.editLevel5.UseVisualStyleBackColor = true;
            this.editLevel5.Click += Edit;



            // 
            // removeLevel6
            // 
            this.removeLevel6.Location = new System.Drawing.Point(1487, 1040);
            this.removeLevel6.Name = "removeLevel6";
            this.removeLevel6.Size = new System.Drawing.Size(121, 55);
            this.removeLevel6.TabIndex = 18;
            this.removeLevel6.Text = "Remove -";
            this.removeLevel6.UseVisualStyleBackColor = true;
            this.removeLevel6.Click += RemoveOne;

            // 
            // clearAllLevel6
            // 
            this.clearAllLevel6.Location = new System.Drawing.Point(1648, 1040);
            this.clearAllLevel6.Name = "clearAllLevel6";
            this.clearAllLevel6.Size = new System.Drawing.Size(121, 55);
            this.clearAllLevel6.TabIndex = 19;
            this.clearAllLevel6.Text = "Clear All";
            this.clearAllLevel6.UseVisualStyleBackColor = true;
            this.clearAllLevel5.Click += ClearAll;

            // 
            // editLevel6
            // 

            this.editLevel6.Location = new System.Drawing.Point(1809, 1040);
            this.editLevel6.Name = "editLevel6";
            this.editLevel6.Size = new System.Drawing.Size(121, 55);
            this.editLevel6.TabIndex = 15;
            this.editLevel6.Text = "Edit";
            this.editLevel6.UseVisualStyleBackColor = true;
            this.editLevel6.Click += Edit;



            // 
            // submitBtn
            // 
            this.submitBtn.BackColor = System.Drawing.SystemColors.Desktop;
            this.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBtn.Location = new System.Drawing.Point(2087, 686);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(180, 109);
            this.submitBtn.TabIndex = 20;
            this.submitBtn.Text = "Submit >>";
            this.submitBtn.UseVisualStyleBackColor = false;
            this.submitBtn.Click += Submit;

            // 
            // CustomModulesPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.editLevel4);
            this.Controls.Add(this.editLevel5);
            this.Controls.Add(this.editLevel6);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.clearAllLevel6);
            this.Controls.Add(this.removeLevel6);
            this.Controls.Add(this.clearAllLevel5);
            this.Controls.Add(this.removeLevel5);
            this.Controls.Add(this.clearAllLevel4);
            this.Controls.Add(this.removeLevel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.level6Box);
            this.Controls.Add(this.level5Box);
            this.Controls.Add(this.level4Box);
            this.Controls.Add(this.levelFourLabel);
            this.Controls.Add(this.addModuleBtn);
            this.Controls.Add(this.levelBox);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.moduleLabel);
            this.Controls.Add(this.courseNameLabel);
            this.Name = "CustomModulesPanel";
            this.Size = new System.Drawing.Size(2296, 1168);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label courseNameLabel;
        private System.Windows.Forms.Label moduleLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label creditLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.ComboBox levelBox;
        private System.Windows.Forms.Button addModuleBtn;
        private System.Windows.Forms.Label levelFourLabel;
        private System.Windows.Forms.ListBox level4Box;
        private System.Windows.Forms.ListBox level5Box;
        private System.Windows.Forms.ListBox level6Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeLevel4;
        private System.Windows.Forms.Button clearAllLevel4;
        private System.Windows.Forms.Button removeLevel5;
        private System.Windows.Forms.Button clearAllLevel5;
        private System.Windows.Forms.Button removeLevel6;
        private System.Windows.Forms.Button clearAllLevel6;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Button editLevel4;
        private System.Windows.Forms.Button editLevel5;
        private System.Windows.Forms.Button editLevel6;
        private System.Windows.Forms.Button bckBtn;

    }
}
