using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorGithub.Models
{
    public class Student
    {

        // Denne klasse er lavet i Sprint2POHE
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name { get; set; }


    }
}
