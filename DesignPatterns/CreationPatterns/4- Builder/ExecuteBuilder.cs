using CreationPatterns._4__Builder.Example_1.Builders;
using CreationPatterns._4__Builder.Example_1.Directors;
using CreationPatterns._4__Builder.Example_1.Products;
using System;

namespace DesignPatterns._1__Creational._1._2_Builder
{
    public class ExecuteBuilder
    {
        public void Vehicle()
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            director.ConstructTruck();
            //director.ConstructSUV();

            Vehicle sedan = builder.GetVehicle();
            Vehicle truck = builder.GetVehicle();
            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Created an vehicle of type: {sedan.VehicleType}");
            Console.WriteLine($"Created an vehicle of type: {truck.VehicleType}");
            Console.WriteLine($"Created an vehicle of type: {suv.VehicleType}");
            Console.Read();
        }
    }
}
