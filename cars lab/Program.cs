using System;
using System.Reflection.Metadata;

namespace cars_lab
{
    public class Program
    {
        static void Main(string[] args)
        {               
               Cars cars = new Cars();
                UsedCars Ucars = new UsedCars();
                List<Cars> carInventory = new List<Cars>();


                carInventory.Add(new Cars("Ford", "Bronco", 2023, 40000.00m));
                carInventory.Add(new Cars("Ford", "Ranger", 2023, 45000.00m));
                carInventory.Add(new Cars("Ford", "F-150", 2023, 60000.00m));
                carInventory.Add(new UsedCars("Ford", "Escape", 2020, 20000.00m, 50000));
                carInventory.Add(new UsedCars("Ford", "Focus", 2015, 5000.00m, 90000));
                carInventory.Add(new UsedCars("Ford", "Taurus", 2015, 5000.00m, 100000));

            static void listCars(List<Cars> carInventory)
            {
                for (int i = 0; i < carInventory.Count; i++)
                {
                    Console.WriteLine($"Item at Index {i}; {carInventory[i].ToString()}");
                }
            }


            Console.WriteLine("Welcome to our Car Lot! Here is a list of our inventory:");
            listCars(carInventory);
            Console.WriteLine("Which car would you like to buy? Please enter the car's number");
            int userCar = int.Parse(Console.ReadLine());
            Console.WriteLine("Great selection! We'll get our finance department to help you complete your purchase");
            Console.WriteLine($"Here are the details: {carInventory[userCar]}");
            carInventory.RemoveAt(userCar);

            Console.WriteLine("Here are the cars left in our inventory");
            listCars(carInventory);



                }


            }


        }
