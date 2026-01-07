***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***

***REMOVED***

***REMOVED***
***REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***

***REMOVED***

***REMOVED***

***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***

***REMOVED*** new SqlCommand(
***REMOVED***$"INSERT INTO Student(id, name, email, join_date) VALUES (***REMOVED***idliteral:using System.Data;, ***REMOVED***nameliteral:using System.Data;, ***REMOVED***emailliteral:using System.Data;, ***REMOVED***joinDateliteral:using System.Data;)",
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***

***REMOVED***

***REMOVED***

***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***"data source=.;" +
***REMOVED******REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED******REMOVED***);
***REMOVED*** new SqlCommand("delete from student where id = '101'", con);

***REMOVED***

***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***

***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***"data source=.;" +
***REMOVED******REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED******REMOVED***);
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED*** new SqlCommand($"UPDATE Student SET name = '***REMOVED***nameliteral:using System.Data;' WHERE id = '***REMOVED***idliteral:using System.Data;'", con);
***REMOVED******REMOVED***
***REMOVED******REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED*** new SqlCommand($"UPDATE Student SET email = '***REMOVED***emailliteral:using System.Data;' WHERE id = '***REMOVED***idliteral:using System.Data;'", con);
***REMOVED******REMOVED***
***REMOVED******REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED*** new SqlCommand($"UPDATE Student SET join_date='***REMOVED***joinDateliteral:using System.Data;' WHERE id = '***REMOVED***idliteral:using System.Data;'", con);
***REMOVED******REMOVED***
***REMOVED******REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***"data source=.;" +
***REMOVED******REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED******REMOVED***);

***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***SqlCommand cm = new SqlCommand($"Delete from student where id = '***REMOVED***idliteral:using System.Data;'", con);
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***Console.WriteLine($"DataTable has ***REMOVED***dt.Rows.Countliteral:using System.Data; rows.");

***REMOVED***Console.WriteLine("Using Data Table");

***REMOVED***foreach (DataRow dr in dt.Rows)
***REMOVED******REMOVED***
***REMOVED******REMOVED***Console.WriteLine(dr["Name"] + " " + dr["Email"] + " " + dr["Join_Date"]);
***REMOVED******REMOVED***

***REMOVED***Console.WriteLine("----------------------------------");

***REMOVED***DataSet ds = new DataSet();

***REMOVED***da.Fill(ds, "Student");
***REMOVED***
***REMOVED***Console.WriteLine($"DataSet has ***REMOVED***ds.Tables["Student"].Rows.Countliteral:using System.Data; rows.");

***REMOVED***Console.WriteLine("Using Data Set");

***REMOVED***foreach (DataRow dr in ds.Tables["Student"].Rows)
***REMOVED******REMOVED***
***REMOVED******REMOVED***Console.WriteLine(dr["Name"] + " " + dr["Email"] + " " + dr["Join_Date"]);
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***CommandType = CommandType.StoredProcedure
***REMOVED******REMOVED***;

***REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***Console.WriteLine(sdr["Id"] + " " + sdr["Name"] + " " + sdr["Email"] + " " + sdr["Join_Date"]);
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***CommandType = CommandType.StoredProcedure
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***SqlParameter idParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Id",
***REMOVED***SqlDbType = SqlDbType.Int,
***REMOVED***Value = id,
***REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***cmd.Parameters.Add(idParameter);

***REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***Console.WriteLine(sdr["Id"] + " " + sdr["Name"] + " " + sdr["Email"] + " " + sdr["Join_Date"]);
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***var cmd = new SqlCommand("spCreateStudent", con)
***REMOVED******REMOVED***
***REMOVED***CommandType = CommandType.StoredProcedure
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***SqlParameter idParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Id",
***REMOVED***SqlDbType = SqlDbType.Int,
***REMOVED***Value = id,
***REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***var nameParemeter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Name",
***REMOVED***SqlDbType = SqlDbType.VarChar,
***REMOVED***Value = name,
***REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;

***REMOVED***var emailParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Email",
***REMOVED***SqlDbType = SqlDbType.VarChar,
***REMOVED***Value = email,
***REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;

***REMOVED***var joinDate = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Join_Date",
***REMOVED***SqlDbType = SqlDbType.DateTime,
***REMOVED***Direction = ParameterDirection.Output
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***cmd.Parameters.Add(idParameter);
***REMOVED***cmd.Parameters.Add(nameParemeter);
***REMOVED***cmd.Parameters.Add(emailParameter);
***REMOVED***cmd.Parameters.Add(joinDate);

***REMOVED***
***REMOVED***cmd.ExecuteNonQuery();
***REMOVED***
***REMOVED***Console.WriteLine(joinDate.SqlValue);

***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***

***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***   var cmd = new SqlCommand("spDeleteStudentByID", con)
***REMOVED***   ***REMOVED***
***REMOVED***  CommandType = CommandType.StoredProcedure
***REMOVED***   ***REMOVED***;
***REMOVED***
***REMOVED***   var idParameter = new SqlParameter
***REMOVED***   ***REMOVED***
***REMOVED***   ParameterName = "@Id",
***REMOVED***   SqlDbType = SqlDbType.Int,
***REMOVED***   Value = id,
***REMOVED***   Direction = ParameterDirection.Input
***REMOVED***   ***REMOVED***;
***REMOVED***
***REMOVED***   var nameParameter = new SqlParameter
***REMOVED***   ***REMOVED***
***REMOVED***   ParameterName = "@Name",
***REMOVED***   Size = 50,
***REMOVED***   SqlDbType = SqlDbType.VarChar,
***REMOVED***   Direction = ParameterDirection.Output
***REMOVED***   ***REMOVED***;
***REMOVED***
***REMOVED***   cmd.Parameters.Add(idParameter);
***REMOVED***   cmd.Parameters.Add(nameParameter);

***REMOVED***   con.Open();

   ***REMOVED***
***REMOVED***   ***REMOVED***
***REMOVED***   cmd.ExecuteNonQuery();
***REMOVED***   ***REMOVED***
   ***REMOVED***
***REMOVED***   ***REMOVED***
   ***REMOVED***
***REMOVED***   ***REMOVED***
***REMOVED***
***REMOVED***   Console.WriteLine(nameParameter.SqlValue);
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED***
***REMOVED***public void UpdateStudentById(int id, string? name, string? email, DateTime? joinDate)
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***using var con = new SqlConnection(_connectionString);
***REMOVED***
***REMOVED***var cmd = new SqlCommand("spUpdateStudentByID", con)
***REMOVED******REMOVED***
***REMOVED***CommandType = CommandType.StoredProcedure
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***var idParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED***ParameterName = "@Id",
***REMOVED***SqlDbType = SqlDbType.Int,
***REMOVED***Value = id,
***REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***cmd.Parameters.Add(idParameter);

***REMOVED***if (name is not null)
***REMOVED******REMOVED***
***REMOVED***var nameParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED******REMOVED***ParameterName = "@Name",
***REMOVED******REMOVED***Size = 50,
***REMOVED******REMOVED***SqlDbType = SqlDbType.VarChar,
***REMOVED******REMOVED***Value = name,
***REMOVED******REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***
***REMOVED***cmd.Parameters.Add(nameParameter);
***REMOVED******REMOVED***

***REMOVED***if (email is not null)
***REMOVED******REMOVED***
***REMOVED***var emailParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED******REMOVED***ParameterName = "@Email",
***REMOVED******REMOVED***Size = 50,
***REMOVED******REMOVED***SqlDbType = SqlDbType.VarChar,
***REMOVED******REMOVED***Value = email,
***REMOVED******REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***cmd.Parameters.Add(emailParameter);
***REMOVED******REMOVED***

***REMOVED***if (joinDate is not null)
***REMOVED******REMOVED***
***REMOVED***var joinDateParameter = new SqlParameter
***REMOVED******REMOVED***
***REMOVED******REMOVED***ParameterName = "@Join_Date",
***REMOVED******REMOVED***SqlDbType = SqlDbType.DateTime,
***REMOVED******REMOVED***Value = joinDate,
***REMOVED******REMOVED***Direction = ParameterDirection.Input
***REMOVED******REMOVED***;
***REMOVED***cmd.Parameters.Add(joinDateParameter);
***REMOVED******REMOVED***
***REMOVED***

***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***cmd.ExecuteNonQuery();
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
***REMOVED******REMOVED***
***REMOVED***
literal:using System.Data;