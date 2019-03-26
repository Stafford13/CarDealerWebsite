using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using GuildCars.Data.Interfaces;
using GuildCars.Models.Tables;

namespace GuildCars.Data.ADO
{
    public class CarRepositoryADO : ICarRepository
    {
        public void Delete(int CarId)
        {
            throw new NotImplementedException();
        }

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

        public Car GetById(int CarId)
        {
            Car car = null;

            using (var cn = new SqlConnection(Settings.GetConnectionString()))
            {
                SqlCommand cmd = new SqlCommand("CarSelect", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@CarId", CarId);
                cn.Open();


                //select CarId, Body, Year, ExColor, IntColor, Mileage, Transmission, Type, MSRP, Price, MakeId, ModelId, ImageFileName
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        car = new Car();
                        car.CarId = (int)dr["CarId"];
                        car.Body = dr["Body"].ToString();
                        car.Year = (int)dr["Year"];
                        car.ExColor = dr["ExColor"].ToString();
                        car.IntColor = dr["IntColor"].ToString();
                        car.Mileage = (int)dr["Mileage"];
                        car.Transmission = (bool)dr["Transmission"];
                        car.Type = dr["Type"].ToString();
                        car.MSRP = (int)dr["MSRP"];
                        car.Price = (int)dr["Price"];
                        car.MakeName.MakeId = (int)dr["MakeId"];
                        car.ModelName.ModelId = (int)dr["ModelId"];
                        car.ImageFileName = dr["ImageFileName"].ToString();
                    }
                }
            }

            return car;
        }

        public void Insert(Car car)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
