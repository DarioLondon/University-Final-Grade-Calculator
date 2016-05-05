using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace University_Final_Grade_Calculator
{
    public class DataBase
    {
        private SqlConnection _connection;

        public DataTable GetCourseList()
        {
            DataTable coursesList;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["Connection"];

            using (_connection = new SqlConnection(settings.ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Name FROM Courses", _connection))
            {
                coursesList = new DataTable();
                adapter.Fill(coursesList);

            }
            return coursesList;
        }

        public DataTable[] GetModulesList(string name)
        {
            DataTable[] moduleList =new DataTable[3];
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["Connection"];

            using (_connection = new SqlConnection(settings.ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT m.Id, m.Name , m.Credit from ModulesLevel4 m" +
                         " INNER JOIN Courses c on  m.CourseId=c.Id where c.Name= '" + name + "'", _connection)) 
            {
                DataTable moduleListLevel4 = new DataTable();
                adapter.Fill(moduleListLevel4);
                moduleList[0] = moduleListLevel4;

            }
            using (_connection = new SqlConnection(settings.ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT m.Id ,m.Name , m.Credit from ModulesLevel5 m" +
                        " INNER JOIN Courses c on  m.CourseId=c.Id where c.Name= '" + name + "'", _connection))
            {
                DataTable moduleListLevel5 = new DataTable();
                adapter.Fill(moduleListLevel5);
                moduleList[1] = moduleListLevel5;
            }
            using (_connection = new SqlConnection(settings.ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT m.Id, m.Name , m.Credit from ModulesLevel6 m" +
                       " INNER JOIN Courses c on  m.CourseId=c.Id where c.Name= '" + name + "'", _connection))
            {
                DataTable moduleListLevel6 = new DataTable();
                adapter.Fill(moduleListLevel6);
                moduleList[2] = moduleListLevel6;
            }
            return moduleList;
        }

        public DataTable GetCourseWorkTypeList()
        {
            DataTable data;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings["Connection"];

            using (_connection = new SqlConnection(settings.ConnectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT Type FROM CourseWork", _connection))
            {
                data = new DataTable();
                adapter.Fill(data);

            }
            return data;
        }

    }
}