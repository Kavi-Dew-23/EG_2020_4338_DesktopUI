using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06
{
    public class Person
    {
        public Person(string v1, string v2, string v3, string v4, double v5)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            V4 = v4;
            V5 = v5;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Image { get; set; }
        public double GpaValue { get; set; }

        public string FullName => $"{FirstName} {LastName}";
        
        public string ImageURL
        {
            get
            {
                return $"/images/{Image}";
            
            }
        }

        public string V1 { get; }
        public string V2 { get; }
        public string V3 { get; }
        public string V4 { get; }
        public double V5 { get; }
      /*  
public people(string firstName, string lastName, string dateOfBirth, string image, double gpaValue)
{
FirstName = firstName;
LastName = lastName;
DateOfBirth = dateOfBirth;
Image = image;
GpaValue = gpaValue;
}
*/

    }
}
