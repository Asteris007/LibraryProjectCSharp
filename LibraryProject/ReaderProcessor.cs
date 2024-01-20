using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class ReadersProcessor
    {
        private List<Readers> readersList;

       public int countMale = 0;
        public int countFemale = 0;
        public int to10 = 0;
        public int to18 = 0;
        public int to30 = 0;
        public int to65 = 0;
        public int up65 = 0;
        public ReadersProcessor(List<Readers> readers)
        {
            readersList = readers;
        }

        public List<ReaderStatistics> GetStatistics()
        {
            return readersList
                .Where(reader => IsValidEGN(reader.EGN))
                .GroupBy(reader => new
                {
                    AgeRange = GetAgeRange(reader.EGN),
                    Gender = GetGender(reader.EGN)
                })
                .Select(group => new ReaderStatistics
                {
                    AgeRange = group.Key.AgeRange,
                    Gender = group.Key.Gender,
                    VisitorCount = group.Count()
                })
                .ToList();
        }

        private bool IsValidEGN(string egn)
        {
            if (egn.Length != 10 || !egn.All(char.IsDigit))
            {
                
                return false;
            }

            int[] weights = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int checksum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                checksum += (egn[i] - '0') * weights[i];
            }

            int remainder = checksum % 11;
            int expectedControlDigit = remainder < 10 ? remainder : 0;

            int actualControlDigit = egn[9] - '0';

            return expectedControlDigit == actualControlDigit;
        }

        private int CalculateAgeFromEGN(string egn)
        {
            
            int birthYear = int.Parse(egn.Substring(0, 2));

           
            int currentYear = DateTime.Now.Year % 100; 

          
            int birthMonth = int.Parse(egn.Substring(2, 2));

         
            if (birthMonth >= 40)
            {
                birthYear += 2000;
            }
            else
            {
                birthYear += 1900;
            }

           
            int age = currentYear - birthYear;

       
            if (birthMonth > DateTime.Now.Month)
            {
                age--;
            }

            return age;
        }

        private string GetAgeRange(string egn)
        {
            int age = CalculateAgeFromEGN(egn);

            if (age <= 10)
            {
                to10++;
                return "Up to 10";
                
            }
            else if (age <= 18)
            {
                to18++;
                return "От 11 до 18 години";
                
            }
            else if (age <= 30)
            {
                to30++;
                return "От 19 до 30 години";
                
            }
            else if (age <= 65)
            {
                to65++;
                return "От 31 до 65 години";
                
            }
            else
            {
                up65++;
                return "Над 65 години";
                
            }
        }


       public string GetGender(string egn)
        {
            int lastDigit = int.Parse(egn.Substring(8, 1));
            
           
            if (lastDigit % 2 == 0)
            {
                countMale++;
                return "Male";
                
            }
            else
            {
                countFemale++;
                return "Female";
                
            }
            

        }
    }
}

