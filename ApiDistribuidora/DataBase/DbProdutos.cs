using System.Text.RegularExpressions;
using ApiDistribuidora.Models;
using Npgsql;
using static Npgsql.Replication.PgOutput.Messages.RelationMessage;

namespace ApiDistribuidora.DataBase
{
    public class DbProdutos
    {
        public bool Add(Produto produto)
        {
            bool result = false;

            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"INSERT INTO produtos ( nome, marca, tipo, volume, frasco ) " +
                                      @"VALUES ( @nome, @marca, @tipo, @volume, @frasco );";

                    cmd.Parameters.AddWithValue("@nome", produto.nome);
                    cmd.Parameters.AddWithValue("@marca", produto.marca);
                    cmd.Parameters.AddWithValue("@tipo", produto.tipo);
                    cmd.Parameters.AddWithValue("@volume", produto.volume);
                    cmd.Parameters.AddWithValue("@frasco", produto.frasco);
                    
                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                    }
                    result = true;
                }

            }
            catch
            { }
            return result;

        }
        public List<Produto> GetAll()
        {
            List<Produto> result = new List<Produto>();
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"SELECT id, nome, marca, tipo, volume, frasco " +
                                      @"FROM produtos " +
                                      @"ORDER BY id;";

                    using (cmd.Connection = dba.OpenConnection())
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Produto produto = new Produto();

                            produto.id = Convert.ToInt32(reader["id"]);
                            produto.nome = reader["nome"].ToString();
                            produto.marca = reader["marca"].ToString();
                            produto.tipo = reader["tipo"].ToString();
                            produto.volume = float.Parse(reader["volume"].ToString());
                            produto.frasco = reader["frasco"].ToString();
                           
                            result.Add(produto);

                        }
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public bool Delete(int id)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {
                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"DELETE FROM produtos " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", id);

                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }
            }
            catch (Exception ex)
            { }

            return result;
        }

        public bool Update(Produto produto)
        {
            bool result = false;
            DataBaseAccess dba = new DataBaseAccess();

            try
            {

                using (NpgsqlCommand cmd = new NpgsqlCommand())
                {
                    cmd.CommandText = @"UPDATE produtos " +
                                      @"SET nome = @nome, marca = @marca, tipo = @tipo, volume = @volume, frasco = @frasco " +
                                      @"WHERE id = @id;";

                    cmd.Parameters.AddWithValue("@id", produto.id);
                    cmd.Parameters.AddWithValue("@nome", produto.nome);
                    cmd.Parameters.AddWithValue("@marca", produto.marca);
                    cmd.Parameters.AddWithValue("@tipo", produto.tipo);
                    cmd.Parameters.AddWithValue("@volume", produto.volume);
                    cmd.Parameters.AddWithValue("@frasco", produto.frasco);


                    using (cmd.Connection = dba.OpenConnection())
                    {
                        cmd.ExecuteNonQuery();
                        result = true;
                    }
                }

            }
            catch (Exception ex)
            { }

            return result;
        }
    }
}
