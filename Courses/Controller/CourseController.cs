using Courses.Model;
using System;

namespace Courses.Controller
{
    public class CourseController
    {
        CourseRepository _courseRep;
        public CourseController()
        {
            _courseRep = new CourseRepository();
        }
        public string Insert(string code, string name, string credit)
        {
            if (code == "" || name == "" || credit == "")
            {
                return "Code, name and credit cannot be empty";
            }
            else if (!int.TryParse(credit, out int Credit))
            {
                return "Credit must be a positive number";
            }
            else if (Convert.ToInt32(credit) > 33)
            {
                return "Credit must be less than or equals to 33";
            }
            else
            {
                Course course = new Course()
                {
                    Code = code,
                    Name = name,
                    Credit = Convert.ToInt32(credit)
                };
                CourseRepository _courseRep = new CourseRepository();
                var res = _courseRep.InsertCourse(course);
                if (!res)
                {
                    return "Code already exist. Please enter another code!";
                }
                else
                {
                    return "Success";
                }
            }
        }

        public string GetCourses()
        {
            var res = "";
            var courses = _courseRep.GetListCourse();
            for (int i = 0; i < courses.Count; i++)
            {
                res += courses[i].Code + " | " + courses[i].Name + " | " + courses[i].Credit;
                res += "\n";
            }
            return res;
        }
        public Course Search(string code)
        {
            if (code == "")
                return null;
            else
                return _courseRep.GetCourse(code);
        }
    }
}
