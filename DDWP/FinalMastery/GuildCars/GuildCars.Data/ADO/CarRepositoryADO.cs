using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GuildCars.Data.ADO
{
    public class CarRepositoryADO : ICarRepository
    {
        public List<Car> GetAll()
        {
            List<Car> cars = new List<Car>();

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("CarSelectAll", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while(dr.Read())
                    {
                        Car currentRow = new Car();
                        currentRow.CarId = (int)dr["CarId"];
                        currentRow.Type = dr["Type"].ToString();

                        cars.Add(currentRow);
                    }
                }
            }
            return cars;
        }

    }
}
