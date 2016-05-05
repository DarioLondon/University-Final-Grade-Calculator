
using System.Windows.Forms;

namespace University_Final_Grade_Calculator
{
    public partial class CustomPanelSummaryTab : UserControl
    {
       
        public CustomPanelSummaryTab(Course c)
        {
           
            InitializeComponent();
            Calculate(c);
        }

        public void Calculate(Course c)
        {
            
           
            string[] result = c.CalculateFinalMark();

            avgLevel4.Text = c.AvarageYearOne+@"%";
            avgLevel5.Text = c.AvarageYearTwo + @"%";
            avgLevel6.Text = c.AvarageYearThree + @"%";

            finalMarkLabel.Text = @"You Achieved " + result[1];
            finalMark.Text = result[0];
            if (result[2].Equals("1"))
            {

              
               pictureBox.Image = Properties.Resources.firstPlace;
              
            }

            if (result[2].Equals("2"))
            {



                pictureBox.Image = Properties.Resources.secondPlace;
            
            }

            if (result[2].Equals("3"))
            {

           
                pictureBox.Image = Properties.Resources.thirdPlace;
      
            }
        }
    }
}
