using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Defining_Classes_Exercise_2
{
    public class Team
    {
        private List<Developers> _developersList = new List<Developers>();

        public List<Developers> DeveloperList
        {
            get { return _developersList; }
            set { _developersList = value; }
        }

        public List<Developers> AddDeveloper(Developers developer)
        {
            _developersList.Add(developer);
            return _developersList;
        }

        public int GetListCount()
        {
            return _developersList.Count();
        }
    }
}
