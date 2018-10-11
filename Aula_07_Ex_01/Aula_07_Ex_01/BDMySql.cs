using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Aula_07_Ex_01
{
    class BDMySql : IDatabase
    {
        public void Delete(long codigo)
        {
            throw new NotImplementedException();
        }

        public List<Livro> ListAll()
        {
            MySqlConnection conn = null;
            List<Livro> result = new List<Livro>();

            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "Server=localhost; Database=biblioteca; Uid=root; Pwd=root;";

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = String.Format("SELECT * FROM livro");
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataReader dr = cmd.ExecuteReader();

                
                while (dr.Read())
                {
                    Livro l = new Livro();
                    l.Codigo = dr.GetInt32(0);
                    l.Autor = dr.GetString(1);
                    l.Titulo = dr.GetString(2);
                    result.Add(l);
                }
                
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();  
            }
            return result;
        }

        public Livro Read(long codigo)
        {
            throw new NotImplementedException();
        }

        public void Save(Livro l)
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection();
                conn.ConnectionString = "Server=localhost; Database=biblioteca; Uid=root; Pwd=root;";

                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();

                string sql = String.Format("INSERT INTO livro(autor,titulo) VALUES('{0}','{1}')", l.Autor, l.Titulo);
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void Update(Livro l)
        {
            throw new NotImplementedException();
        }
    }
}
