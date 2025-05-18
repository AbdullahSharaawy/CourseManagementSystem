using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

public class Database
{
    public static SqlConnection GetConnection()
    {
        return new SqlConnection("Data Source=.;Initial Catalog=StudentCourseDB;Integrated Security=True");
    }
}
