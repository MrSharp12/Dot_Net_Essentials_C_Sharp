using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_Encapsulation_Exercise_4
{
    public class DevTrainingRepo
    {
        private List<UdemyCourse> _udemyMasterCourseList = new List<UdemyCourse>();

        public void PurchaseCourse(UdemyCourse course, Developer developer)
        {
            var balance = developer.Balance -= course.Price;

            //try
            //{

            //}
            //catch (Exception)
            //{

            //    throw;
            //}

            if (balance < 0)
            {
                throw new ArgumentException("You do not have enough money to purchase course.");
            }
            else
            {
                AddUdemyCourseToList(course);
                developer.HasPurchasedCourse = true;
                developer.ListOfCourses.Add(course);
            }
        }

        private List<UdemyCourse> AddUdemyCourseToList(UdemyCourse course)
        {
            if (_udemyMasterCourseList.Contains(course))
            {
                return _udemyMasterCourseList;
            }
            else
            {
                _udemyMasterCourseList.Add(course);
                return _udemyMasterCourseList;
            }
        }

        public string ViewMasterList()
        {
            var listItems = "";
            foreach (var course in _udemyMasterCourseList)
            {
                listItems += course.ToString() + "\n";
            }
            return listItems;
        }

        public string ViewDevList(Developer developer)
        {
            var listItems = "";
            if (developer.HasPurchasedCourse == true)
            {
                foreach (var course in developer.ListOfCourses)
                {
                    listItems += course.ToString() + developer.ToString() + "\n";
                }
            }
            else
            {
                throw new ArgumentException("Developer has not purchased any courses.");
            }
            return listItems;
        }

        public int GetListCount()
        {
            return _udemyMasterCourseList.Count();
        }
    }
}
