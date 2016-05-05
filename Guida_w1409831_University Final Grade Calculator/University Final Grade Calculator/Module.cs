using System;
using System.Collections.Generic;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Web.UI.WebControls;

namespace University_Final_Grade_Calculator
{
    public class Module
    {
        public List<CourseWork> CourseWorkList { get; set; } = new List<CourseWork>();
       
        public  Module()
       {
           
            Edit = false;

       }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int Id { get; set; }
        public bool Edit { get; set; }
        
        public void AddCourseWork(CourseWork c)
        {
            CourseWorkList.Add(c);
            Edit = true;
        }

        public void RemoveCourseworks()
        {
            CourseWorkList.Clear();
            Edit = false;
        }

        public double CalculateTotalMark()
        {
            double finalmark = 0;
            for (int index = 0; index < CourseWorkList.Count; index++)
            {
                var c = CourseWorkList[index];
                if (c.HasMark())
                {
                   
                    finalmark += c.CalculateValue();
                    Console.WriteLine(finalmark);
                }
            }
            return finalmark;
        }
        public bool CheckIfAllCourseWorkHasMarks()
        {
            int lenght = CourseWorkList.Count;
            int counter = 0;
            foreach (var m in CourseWorkList)
            {
                if (m.HasMark()) counter++;
        
            }
            if (counter == lenght) return true;
            return false;
        }

      


    }
}