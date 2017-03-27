using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DBConnect
    {
        
        private string ConSql = ConnectString.StrCon;

        /// <summary>
        /// Select in sql 
        /// </summary>
        /// <param name="sql">Query</param>
        /// <param name="Proc">Proc or Text (True or False)</param>
        /// <param name="parameters">Parameters</param>
        /// <returns></returns>
        public DataTable Select (string sql, bool isProc, Dictionary<string, object> parameters = null)
        {
            using( SqlConnection con = new SqlConnection (ConSql) )
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    if (isProc)
                        cmd.CommandType = CommandType.StoredProcedure;
                    else
                        cmd.CommandType = CommandType.Text;

                    if (parameters != null)
                        foreach (var para in parameters)
                            cmd.Parameters.Add( new SqlParameter (para.Key, para.Value));

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            return dt;
                        }
                    }
                }
            } 
        }

        /// <summary>
        /// Insert Update Delete in sql
        /// </summary>
        /// <param name="sqlQuery">Query</param>
        /// <param name="isProc">Proc or Text (True or False)</param>
        /// <param name="parameters">Parameters</param>
        /// <returns></returns>
        public bool InsertUpdateDelete (string sqlQuery, bool isProc , Dictionary<string, object> parameters)
        {
            using (SqlConnection con = new SqlConnection(ConSql))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                {
                    if (parameters != null)
                    {
                        foreach (var para in parameters)
                            cmd.Parameters.Add(new SqlParameter (para.Key, para.Value));

                        if (isProc)
                            cmd.CommandType = CommandType.StoredProcedure;
                        else
                            cmd.CommandType = CommandType.Text;

                        if (cmd.ExecuteNonQuery() > 0)
                            return true;
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }
        }
    }
}
