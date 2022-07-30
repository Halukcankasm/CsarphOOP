using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationProperty
{
    public class Student
    {
        private string name;
        public string Name 
        {
            get
            {
                string firstCharacter = name.Substring(0, 1).ToUpper();
                string contuinesCharacters = name.Substring(1, (name.Length - 1)).ToLower();
                return firstCharacter+contuinesCharacters;
            }
            set
            {
                name = value;
            }
        }

        private string surName;
        public string SurName 
        {
            get
            {
                return surName.ToUpper();
            }
            set
            {
                surName = value;
            }
        }

        public string IDNumber 
        {
            get
            {
                return CreateIDNumber();
            }
        }

        public string EmailAddress 
        {
            get
            {
                return Name.ToLower() + "." + SurName.ToLower() + "@universty.com";
            }
        }



        private string CreateIDNumber()
        {
            Random rnd = new Random();
            decimal idNumberFirstPart = rnd.Next(100, 999);
            decimal idNumberSecondPart = rnd.Next(100, 999);
            decimal idNumberThirdPart = rnd.Next(100, 999);
            decimal idNumberFourthPart = rnd.Next(10, 99);

            return idNumberFirstPart + " " + idNumberSecondPart + " " + idNumberThirdPart + " " + idNumberFourthPart;
        }
    }
}
