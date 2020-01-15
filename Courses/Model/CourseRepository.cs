using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courses.Model
{
    public class CourseRepository
    {
        string connectionString = @"Data Source=DESKTOP-EV0T18T\SQLEXPRESS;Initial Catalog=CoursesManagement;Integrated Security=True";

        public bool InsertCourse(Course course)
        {
            var Course = GetCourse(course.Code);
            if (Course != null)
            { 
                return false; 
            }
            var insert = "Insert into Courses values('" + course.Code + "', '" + course.Name + "', " + course.Credit + ")";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand com = new SqlCommand(insert, con);
                com.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public Course GetCourse(string code)
        {
            Course course = new Course();
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand com = new SqlCommand("Select * from Courses where Code like '%"+code+"%'", con);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    DataRow dr = dt.Rows[0];
                    course.Code = dr["Code"].ToString();
                    course.Name = dr["Name"].ToString();
                    course.Credit = dr["Credit"].ToString() != "" ? Convert.ToInt32(dr["Credit"].ToString()) : 0;
                }
            }
            return course;
        }
        public List<Course> GetListCourse()
        {
            List<Course> courses = new List<Course>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand com = new SqlCommand("Select * from Courses", con);
                SqlDataAdapter sda = new SqlDataAdapter(com);
                sda.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    courses.Add(new Course()
                    {
                        Code = dr["Code"].ToString(),
                        Name = dr["Name"].ToString(),
                        Credit = dr["Credit"].ToString() != "" ? Convert.ToInt32(dr["Credit"].ToString()) : 0
                    });

                }
            }
            return courses;
        }
    }
}
