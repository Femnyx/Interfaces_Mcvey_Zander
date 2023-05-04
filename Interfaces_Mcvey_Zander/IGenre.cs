using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Mcvey_Zander
{
    interface IGenre
    {
        //The strings "Esrb", "Genre", and "Title" has a get and set for those strings.
        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        //describes the strings above.
        public string Describe();



    }
}
