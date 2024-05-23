using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinal
{
    public class UseDB
    {
        SqlConnection sql;
        DataSet sds;
        string table = "[User]";

        public UseDB()
        {
            this.sql = new SqlConnection(@"Data Source=RONO;Initial Catalog=PCComponentManagementDB;Persist Security Info=True;User ID=sa;Password=rono7666");
            sql.Open();

            SqlCommand cmd = new SqlCommand($"select * from {this.table};", sql);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            sds = ds;
        }

        internal DataSet getInfo(string command)
        {
            SqlCommand cmd = new SqlCommand(command, sql);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            return ds;
        }

        public int executeQuery(string command)
        {
            SqlCommand cmd = new SqlCommand(command, sql);
            int val = cmd.ExecuteNonQuery();
            return val;
        }

        public DataTable getQueryTable(string command)
        {
            DataSet ds = new DataSet();

            if (String.IsNullOrEmpty(command))
            {
                command = $"select * from item";
            }
            else
            {
                SqlCommand cmd = new SqlCommand(command, sql);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(ds);
            }
            return ds.Tables[0];
        }

        internal string getNewId(string table, string id)
        {
            DataTable dt = this.getQueryTable($"select {id} from {table} order by {id} desc;");

            string newId;

            if (dt.Rows.Count != 0)
            {
                int value = Int32.Parse(dt.Rows[0][0].ToString().Remove(0, 2));
                newId = $"{id.Substring(0,1)}-{(++value).ToString("D3")}";
            }
            else
                newId = $"{id.Substring(0, 1)}-001";

            return newId;
        }

        public User getUser(string id, out string name, out string pass, out string phone, out string email, out string address, out string role)
        {
            DataTable dt = this.getQueryTable($"select uid, uname, upassword, uphoneno, email, uaddress, role from [user] where uid = '{id}';");
            User u;
            if (dt.Rows.Count != 0)
            {
                name = dt.Rows[0]["uname"].ToString();
                pass = dt.Rows[0]["upassword"].ToString();
                phone = dt.Rows[0]["uphoneno"].ToString();
                email = dt.Rows[0]["email"].ToString();
                address = dt.Rows[0]["uaddress"].ToString();
                role = dt.Rows[0]["role"].ToString();

                u = new User(dt.Rows[0]["uid"].ToString(), dt.Rows[0]["uname"].ToString(), dt.Rows[0]["upassword"].ToString(), dt.Rows[0]["uphoneno"].ToString(), dt.Rows[0]["email"].ToString(), dt.Rows[0]["uaddress"].ToString(), dt.Rows[0]["role"].ToString());
            }
            else
            {
                name = null;
                pass = null;
                phone = null;
                email = null;
                address = null;
                role = null;
                u = null;
            }
            return u;
        }
    }
}
