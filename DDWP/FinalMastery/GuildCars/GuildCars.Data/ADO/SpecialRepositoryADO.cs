using System;
using GuildCars.Data.Interfaces;
using System.Collections.Generic;
using System.Text;
using GuildCars.Models.Tables;
using System.Data.SqlClient;
using System.Data;

namespace GuildCars.Data.ADO
{
    public class SpecialRepositoryADO : ISpecialRepository
    {
        public List<Special> GetAll()
        {
            List<Special> specials = new List<Special>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("SpecialSelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Special currentRow = new Special();
                        currentRow.SpecialId = (int)dr["SpecialId"];
                        currentRow.SpecialName = dr["SpecialName"].ToString();
                        currentRow.SpecialText = dr["SpecialText"].ToString();

                        specials.Add(currentRow);
                    }
                }
            }
            return specials;
        }
    }
}
