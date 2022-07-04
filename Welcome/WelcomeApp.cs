using System;

namespace Welcome
{
    internal class WelcomeApp
    {
        private string _name;
        private string _city;
        private int _year;
        private int _month;
        private int _day;

        public WelcomeApp()
        {
            GetData();
        }

        private void GetData()
        {
            Console.WriteLine("Please type your name:");
            _name = Console.ReadLine();
            Console.WriteLine("Please type your city:");
            _city = Console.ReadLine();
            Console.WriteLine("Please type year of your birthday:");
            _year = GetYear();
            Console.WriteLine("Please type month of your birthday:");
            _month = GetMonth();
            Console.WriteLine("Please type day of your birthday:");
            _day = GetDay();
        }

        private int CalculateAge()
        {
            var date = new DateTime(_year, _month, _day);
            var today = DateTime.Now;
            var userAge = today.Year - date.Year;
            if (today.DayOfYear < date.DayOfYear)
            {
                userAge --;
            }
            else if (today.DayOfYear == date.DayOfYear)
            {
                Console.WriteLine("Happy Birthday");
            }

            return userAge;
        }

        private int GetYear()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    if (year < DateTime.Now.Year && year > 1900)
                    {
                        return year;
                    }
                    else if (year > DateTime.Now.Year)
                    {
                        Console.WriteLine("Year of your birth can't be greater than current year. Try Again.");
                    }
                    else if (year < 1900)
                    {
                        Console.WriteLine("Nobody live that long. Try Again");
                    }

                }
                else
                {
                    Console.WriteLine("The input data is invalid. Please try again with 4 digits, e.g. '1999'");
                }
            }

        }

        private int GetMonth()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int month))
                {
                    if (month >= 1 && month <= 12)
                    {
                        return month;
                    }
                    else
                    {
                        Console.WriteLine("Month must be digit between 01-12. Try Again.");
                    }

                }
                else
                {
                    Console.WriteLine("The input data is invalid. Please try again with 2 digits, e.g. '01-12'");
                }
            }
        }

        private int GetDay()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int day))
                {
                    if (day >= 1 && day <= 31)
                    {
                        return day;
                    }
                    else
                    {
                        Console.WriteLine("Day must be digit between 01-31. Try Again.");
                    }

                }
                else
                {
                    Console.WriteLine("The input data is invalid. Please try again with 2 digits, e.g. '01-31'");
                }
            }

        }

        public void ShowResult()
        {
            Console.WriteLine($"Your name is {char.ToUpper(_name[0]) + _name.Substring(1)}.\n" +
                $"You was born in {_city}\n" +
                $"and you are {CalculateAge()} old.");

        }
    }
}
        