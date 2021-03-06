using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mis221_lab7_ajstevenson1
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail)
        {
            this.name = tempName;
            this.gender = tempGender;
            this.email = tempEmail;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string tempName)
        {
            this.name = tempName;
        }

        public char GetGender()
        {
            return gender;
        }

        public void SetGender(char tempGender)
        {
            this.gender = tempGender;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string tempEmail)
        {
            this.email = tempEmail;
        }

        public override string ToString()
        {
            return "name = " + name + ", gender = " + gender + ", email = " + email;
        }
    }
}