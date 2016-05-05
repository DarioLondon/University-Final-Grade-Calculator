

namespace University_Final_Grade_Calculator
{
    public  class CourseWork
    {
        // Getter Setter 
        public string Type { get; set; }
        public int Id { get; set; }
        public int Weight { get; set; }
        public int Mark { get; set; }


        public double CalculateValue()
        {
            return (double)(Weight * Mark) / 100;
        }

        public bool HasMark()
        {
            return Mark > 0;
  
        }



    }
}