using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using FlyWeight.Sample1;
using FlyWeight.Sample2;

namespace FlyWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            //sample 2
            //var repo = new DepartmentRepository();
            //var department1 = repo.GetDepartment(1);

            //var department2 = repo.GetDepartment(1);

            //Console.WriteLine(department1.GetHashCode() == department2.GetHashCode());

            //sample 1
            FlyWeightFactory flyWeightFactory = new FlyWeightFactory();

            IAlphabet alphabet = flyWeightFactory.GetObject(typeof(A).Name);
            alphabet.Render("Arial");
            Console.WriteLine();

            alphabet = flyWeightFactory.GetObject(typeof(B).Name);
            alphabet.Render("Tahoma");
            Console.WriteLine();

            alphabet = flyWeightFactory.GetObject(typeof(A).Name);
            alphabet.Render("Time is New Roman");
            Console.WriteLine();

            alphabet = flyWeightFactory.GetObject(typeof(A).Name);
            alphabet.Render("B Nazanin");
            Console.WriteLine();

            Console.WriteLine("Total new alphabet count:" + flyWeightFactory.Count);


            Console.ReadKey();
        }
    }
}
