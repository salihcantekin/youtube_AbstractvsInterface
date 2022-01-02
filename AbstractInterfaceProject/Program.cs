using System;
using System.Data;
using System.Net.Http;

namespace AbstractInterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sqlDb = new SqlServerDb();
            sqlDb.ExecuteSql("");

            var oracleDb = new OracleDb();
            oracleDb.ExecuteSql("");
            var ver = oracleDb.GetDbVersion();


            var car = new Car();
            car.Go();
            car.Stop();
            
            var plane = new Plane();
            plane.Go();
            plane.Stop();
            plane.Soar();

            var bike = new Bike();
            bike.Go();
            bike.Stop();
            bike.Ride();

            //var baseCar = new BaseVehicle();

        }
    }
}
