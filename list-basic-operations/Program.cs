using System;

namespace list_basic_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkingHourList workingHourList = new WorkingHourList();

            Console.WriteLine("El insert debe ser menor al after");

            Console.WriteLine("¿Cual Horario quieres insertar?");
            int insert = int.Parse(Console.ReadLine());

            Console.WriteLine("¿Despues de que Horario lo quieres hacer?");
            int after = int.Parse(Console.ReadLine());

            WorkingHour H1 = new WorkingHour();
            H1.Location = "Medellin";
            H1.StartTime = 700;
            H1.FinalTime = 1600;
            H1.Id = 1;
            workingHourList.Add(H1,insert,after);

            WorkingHour H2 = new WorkingHour();
            H2.Location = "Manizales";
            H2.StartTime = 600;
            H2.FinalTime = 1700;
            H2.Id = 2;
            workingHourList.Add(H2, insert, after);

            WorkingHour H3 = new WorkingHour();
            H3.Location = "Pereira";
            H3.StartTime = 500;
            H3.FinalTime = 1500;
            H3.Id = 3;
            workingHourList.Add(H3, insert, after);

            WorkingHour H4 = new WorkingHour();
            H4.Location = "Buga";
            H4.StartTime = 500;
            H4.FinalTime = 1800;
            H4.Id = 4;
            workingHourList.Add(H4, insert, after);

            WorkingHour H5 = new WorkingHour();
            H5.Location = "Armenia";
            H5.StartTime = 800;
            H5.FinalTime = 1900;
            H5.Id = 5;
            workingHourList.Add(H5, insert, after);

            workingHourList.Print();


        }
    }
}
