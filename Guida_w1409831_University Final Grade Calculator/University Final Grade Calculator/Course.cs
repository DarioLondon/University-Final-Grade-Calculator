using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Final_Grade_Calculator
{ ///<Summary>
  /// This Class holds informations about modules that the  user dacide to take each year .
  /// </Summary>
    public class Course
{
        public string Name { get; set; }
        public double AvarageYearOne { set; get; }
        public double AvarageYearTwo { set; get; }
        public double AvarageYearThree { set; get; }
        public static  int MaxTotalCredit = 120;
        public static int TotalCreditLevel4;
        public static int TotalCreditLevel5;
        public static int TotalCreditLevel6;
        public List<Module> ModulesYearOne= new List<Module>();
        public List<Module> ModulesYearTwo = new List<Module>();
        public List<Module> ModulesYearThree = new List<Module>();
        public const int Lenght = 3;
       
        ///<Summary>
        /// Getter and Setter 
        /// </Summary>
       
      


        ///<Summary>
        /// This method add  a module object into a List . Based on the int passed as parameter , the method decide wich list the module will be inserted .
        /// </Summary>
        public void AddModules(Module module, int year)
        {
            switch (year)
            {
                case 4:
                  
                    ModulesYearOne.Add(module);
                    break;
                case 5:
                  
                    ModulesYearTwo.Add(module);
                    break;
                case 6:
                    
                    ModulesYearThree.Add(module);
                    break;
                default: Console.WriteLine(@"Wrong Year");
                    break;
            }
           
        }

        public void RemoveModule( int year,int index)
        {
            switch (year)
            {
                case 4:
                   // TotalCreditLevel4 -= ModulesYearOne.Find(m => m.Id-1 ==index ).Credits;
                    ModulesYearOne.RemoveAt(index);
                    break;
                case 5:
                    //TotalCreditLevel5 -= ModulesYearTwo.Find(m => m.Id - 1 == index).Credits;
                    ModulesYearTwo.RemoveAt(index);
                    break;
                case 6:
                    //TotalCreditLevel6 -= ModulesYearThree.Find(m => m.Id - 1 == index).Credits;
                    ModulesYearThree.RemoveAt(index);
                    break;
                default:
                    Console.WriteLine(@"Wrong year");
                    break;
            }

        }


   

    public Module GetModuleByName(int year, string name)
        {
            Module result =null;
            
            switch (year)
            {
                case 4:
                    result = ModulesYearOne.Find(m=> m.Name.Equals(name) );
                    
                    break;
                case 5:
                    result = ModulesYearTwo.Find(m => m.Name.Equals(name));
                  
                    break;
                case 6:
                    result = ModulesYearThree.Find(m => m.Name.Equals(name));
                    
                    break;

            }
            return result;


        }

    public void RemoveAll(int level)
    {
        switch (level)
        {
                case 4:  ModulesYearOne.Clear();
                         TotalCreditLevel4=0;
                break;
                case 5: ModulesYearTwo.Clear();
                TotalCreditLevel5 = 0;
                    break;
                case 6: ModulesYearThree.Clear();
                TotalCreditLevel6 = 0;
                    break;
            }
    }

        public double CalculateFianlAvarage(int level)
        {
            double total = 0;
            switch (level)
            {
                case 4:
                    foreach (var m in ModulesYearOne)
                    {
                        total += m.CalculateTotalMark();
                    }
                    if (CheckIfModuleHasMark(ModulesYearOne) == 0)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = total/CheckIfModuleHasMark(ModulesYearOne);
                    }
                    
                    break;


                case 5:
                    foreach (var m in ModulesYearTwo)
                    {
                        total += m.CalculateTotalMark();
                    }
                    if (CheckIfModuleHasMark(ModulesYearTwo) == 0)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = total / CheckIfModuleHasMark(ModulesYearTwo);
                    }
                   
                    break;
                case 6:
                    foreach (var m in ModulesYearThree)
                    {
                        total += m.CalculateTotalMark();
                    }
                    if (CheckIfModuleHasMark(ModulesYearThree) == 0)
                    {
                        total = 0;
                    }
                    else
                    {
                        total = total / CheckIfModuleHasMark(ModulesYearThree);
                    }
                    break;
            }
            return total;
        }

    

    private int CheckIfModuleHasMark(List<Module>list )
    {
        List<CourseWork> l;
        int lenght = 0;
        foreach (var m in list)
        {
           l= m.CourseWorkList.FindAll(c => c.HasMark()) ;
            if (l.Count > 0)
            {
                    lenght += 1;
                }
            
            }
        
        Console.WriteLine(@"lenght of  modules with mark"+lenght);
        return lenght;
    }

//Method to Calculate Final Mark

    private float[] GetMarkFromModule(Module m)
    {
      
        int credits = m.Credits;
        float mark = (float) m.CalculateTotalMark();
        int checktheWeight = credits/15;
        var result = new float[checktheWeight];
            if (checktheWeight == 0)
        {
            result[0] = mark;
        }
        else
        {
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = mark;
        }
    }
        return result;


    }

    private List<float> CollectAllMarks(List<Module> list)
    {
        List<float> result=new List<float>();
        foreach (var m in list)
        {
            float[] tmp = GetMarkFromModule(m);
            foreach (var mark in tmp)
            {
               result.Add(mark); 
            }

        }
        return result;

    }

    private float GetTheBest7Mark(List<Module> l,  bool isLevelfive )
    {
        var list = CollectAllMarks(l);
        float result;
        if (!isLevelfive)
        {
            var tmpList = list.OrderByDescending(m => m).ToArray();
            float total = 0;

            for (int n = 0; n < 8; n++)
            {
                total += tmpList[n];
            }
            result = total/7;
        }
        else
        {
                list.Add(GetLowestMarkLevel6(CollectAllMarks(ModulesYearThree)));
                var tmpList = list.OrderByDescending(m => m).ToArray();
                float total = 0;

                for (int n = 0; n < 8; n++)
                {
                    total += tmpList[n];
                }
                result = total / 7;
            }
        return result;
    }

         private float GetLowestMarkLevel6(List<float> list)
        {
            var tmpList = list.OrderByDescending(m => m).ToArray();

             return tmpList[tmpList.Length-1];
        }

    public string[] CalculateFinalMark()
    {
            float level6 =GetTheBest7Mark(ModulesYearThree,false);
            float level5 = GetTheBest7Mark(ModulesYearTwo, true);
          
            if (level6 >= 70 && level5 >= 60 || level6 >= 60 && level5 >= 60) return new []{"1st", "First class degree","1" };
            if (level6 >= 70 && level5 >= 50 && level5 <60|| level6 >= 60 && level5 >= 50 && level5 < 60)return new[] { "2.1", "Upper Second class degree","2" };
            if (level6 >= 70 && level5 >= 40 && level5 <50 || level6 >= 60 && level5 >= 40 && level5<50|| level6 >= 50 && level5 >= 40 && level5 < 50) return new[] { "2.2", "Lower Second class deegre","3" };
            if (level6 >= 70 && level5 < 40 || level6 >= 60 && level5 < 40 || level6 >= 50 && level5 <40 || level6 >= 40 && level5 < 40 )return  new[] { "Pass", "Third class deegre" };
       
      
        return null;
    }

}
}