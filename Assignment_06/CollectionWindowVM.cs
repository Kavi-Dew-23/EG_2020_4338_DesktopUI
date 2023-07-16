using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Assignment_06
{
    public class CollectionWindowVM : ObservableObject
    {
        public List<people> Persons { get; set; }

        
        public CollectionWindowVM()
        {
            Persons = new List<people>()
            {
                new people("Tom", "Black", "12 / 04 / 1997", "1.png", 3.12),
                new people("Jim", "Blue", "25 / 01 / 2000", "2.png", 2.12),
                new people("Tommy", "Red", "10 / 03 / 1998", "3.png", 3.02),
                new people("Anne", "Green", "02 / 07 / 2001", "4.png", 3.09),
                new people("Bin", "Grey", "22 / 12 / 1999", "5.png", 3.19),
                new people("Linda", "Yellow", "26 / 09 / 1998", "6.png", 3.82),
            };

        }
    }
}
