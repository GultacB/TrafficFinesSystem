using System.Text.Json;
using TrafficFinesSystem.SystemComponent;
while (true) { 
List <Cars> NumberList=new List <Cars> ()
{
    new Cars() { CarsNumber = "10AA001" },
    new Cars() { CarsNumber = "10AA002" },
    new Cars() { CarsNumber = "10AA003" },
    new Cars() { CarsNumber = "10AA004" },
    new Cars() { CarsNumber = "10AA005" },
    new Cars() { CarsNumber = "10AA006" },
    new Cars() { CarsNumber = "10AA007" },
    new Cars() { CarsNumber = "10AA008" },
    new Cars() { CarsNumber = "10AA009" },
    new Cars() { CarsNumber = "10AA019" },
    new Cars() { CarsNumber = "10AA011" },
    new Cars() { CarsNumber = "10AA015" },
};

Dictionary<string,Owners> info= new Dictionary<string,Owners> ();
info.Add("10AA001", new Owners() { Name = "Lale", Fines = new List<Fines> { new Fines { FineAmount = 123 }, new Fines { FineAmount = 143 } } });
info.Add("10AA002", new Owners() { Name = "Lale", Fines = new List<Fines> { new Fines { FineAmount = 50 }, new Fines { FineAmount = 190 } } });
info.Add("10AA003", new Owners() { Name = "Lale", Fines = new List<Fines> { new Fines { FineAmount = 200 }, new Fines { FineAmount = 500 } } });
info.Add("10AA004", new Owners() { Name = "Samir", Fines = new List<Fines> { new Fines { FineAmount = 170 }, new Fines { FineAmount = 180 } } });
info.Add("10AA005", new Owners() { Name = "Samir", Fines = new List<Fines> { new Fines { FineAmount = 145 }, new Fines { FineAmount = 149 } } });
info.Add("10AA015", new Owners() { Name = "Yusura", Fines = new List<Fines> { new Fines { FineAmount = 193 }, new Fines { FineAmount = 141 } } });
info.Add("10AA019", new Owners() { Name = "Sadiq", Fines = new List<Fines> { new Fines { FineAmount = 103 }, new Fines { FineAmount = 443 } } });
info.Add("10AA011", new Owners() { Name = "Sevda", Fines = new List<Fines> { new Fines { FineAmount = 789 }, new Fines { FineAmount = 176 } } });
info.Add("10AA009", new Owners() { Name = "Sevda", Fines = new List<Fines> { new Fines { FineAmount = 167 }, new Fines { FineAmount = 189 } } });
info.Add("10AA008", new Owners() { Name = "Mehriban", Fines = new List<Fines> { new Fines { FineAmount = 300 }, new Fines { FineAmount = 350} } });
info.Add("10AA006", new Owners() { Name = "Mehriban", Fines = new List<Fines> { new Fines { FineAmount = 123 }, new Fines { FineAmount = 143 } } });
info.Add("10AA007", new Owners() { Name = "Samir", Fines = new List<Fines> { new Fines { FineAmount = 873 }, new Fines { FineAmount = 140 } } });
    
    Console.WriteLine("Avtomobillerin siyahisini gormek ucun:1");
    Console.WriteLine("Siyahidaki avtomobilin sahibini bilmek ucun:2");
    Console.WriteLine("Siyahidaki avtomobilin cerimesini bilmek ucun:3");
    Console.WriteLine("Avtomobilin nomrelerini faylda gormek ucun:4");
    Console.WriteLine("Avtomobilin cerimesini faylda gormek ucun:5");
    Console.Write("Secimi daxil edin:"); int choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            foreach (var cars in NumberList)
            {
                Console.WriteLine($"Avtomobilin nomresi:{cars.CarsNumber}");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case 2:
            Console.Write("Avtomobilin nomresini daxil edin:"); string number1 = Console.ReadLine().ToUpper();
            Console.WriteLine($"Bu {number1}-li avtomobil {info[number1].Name}-indir");
            Console.ReadKey();
            Console.Clear();
            break;
        case 3:
            Console.Write("Avtomobilin nomresini daxil edin:"); string number2 = Console.ReadLine().ToUpper();
            Console.WriteLine($"Bu {number2}-li avtomobil {info[number2].Name}indir ve cerimeleri");
            foreach (var fine in info[number2].Fines)
            {
                Console.WriteLine($"{fine.FineAmount}azn dir");
            }
            Console.ReadKey();
            Console.Clear();
            break;
        case 4:
           var json = JsonSerializer.Serialize(NumberList);
            File.WriteAllText("AutoNumbers.txt",json);
            Console.ReadKey();
            Console.Clear();
            break;
        case 5:
            Console.Write("Avtomobilin nomresini daxil edin:"); string number3 = Console.ReadLine().ToUpper();
            var json1 = JsonSerializer.Serialize(info[number3].Fines.ToString());
            File.WriteAllText("AutoFines.txt",json1);
            Console.ReadKey();
            Console.Clear();
            break;
    }
 }

