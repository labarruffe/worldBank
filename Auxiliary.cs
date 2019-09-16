using System;

namespace worldBank
{
    public static class Auxiliary
    {
        public static int CalculateAge(DateTime date)
        {
            DateTime today = DateTime.Today;
            return today.Year - date.Year;
        }

        public static string TranslateAgeRange(int age)
        {
            if(age <= 11)
            {
                return "Child";
            }
            else if(age >= 12 && age <= 21)
            {
                return "Young";
            }
            else if(age >= 22 && age <= 59)
            {
                return "Adult";
            }
            else if(age >= 60)
            {
                return "Elderly";
            }
            else
            {
                return "Invalid age = " + age;
            }                    
        }
    }
}
