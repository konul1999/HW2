//1.İstifadəçi ay adı daxil edəcək, daxil olunan ayın günlərinin sayını ekrana çıxaran alqoritmi yazın(Məsələn: input "October", output 31)
//QEYD:Fevral ayının günlərini 28 kimi qeyd edin.

//Console.WriteLine("Ayın adını daxil edin:");
//string month = Console.ReadLine();
//switch (month)
//{
//    case "January":
//    case "March":
//    case "May":
//    case "July":
//    case "August":
//    case "October":
//    case "December":
//        Console.WriteLine("31 gündür");
//        break;
//    case "April":
//    case "June":
//    case "September":
//    case "November":
//        Console.WriteLine("30 gündür");
//        break;
//    case "February":
//        Console.WriteLine("28 gündür");
//        break;
//    default:
//        Console.WriteLine("Düzgün ay adı daxil edin.");
//        break;
//}




//2. 1 ile 100 araligindaki cüt ededlerin cemini tapan algorithm 

//int sum = 0;
//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("1 ilə 100 arası cüt ədədlərin cəmi: " + sum);





//3.Verilmish ededin sade ve ya murekkeb oldugunu tapan alqoritm: Misal input 25 output "Murekkebdir"
//Console.WriteLine("Eded daxil edin:");
//int number = int.Parse(Console.ReadLine());

//bool sade = true;

//if (number <= 1)
//{
//    Console.WriteLine("Ne sade, ne de mürekkeb ededdir.");
//    return;
//}
//else
//{
//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            sade = false;
//            break;
//        }
//    }
//}

//if (sade)
//{
//    Console.WriteLine("Sade ededdir.");
//}
//else
//{
//    Console.WriteLine("Mürekkeb ededdir.");
//}






