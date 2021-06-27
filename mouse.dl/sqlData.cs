using System.Data.Common;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using mouse.dl;

namespace mouse.dl
{

    class sqlData
    {
        static string connectionString = "Data Source=DESKTOP-0TAJIC3;Initial Catalog=Rotocube;Integrated Security=True";
        static SqlConnection sqlConnection = new SqlConnection(connectionString);
    }
}

