// string vehicleType;

// int speedLimit = 0;
// int vehicleSpeed;
// int ticket = 500;
// int speedDifference;

// Console.WriteLine("#########################");
// Console.WriteLine("Akıllı Radar Ceza Sistemi");
// Console.WriteLine("#########################");
// Console.WriteLine();
// Console.WriteLine("Araç tipi nedir?");
// Console.WriteLine();
// Console.WriteLine("Araba için a'yı");
// Console.WriteLine("Motorsiklet için m'yi");
// Console.WriteLine("Kamyon için k'yi tuşlayınız!");
// Console.WriteLine("");
// vehicleType = Console.ReadLine() ?? "";




// switch(vehicleType)
// {
//     case "a":
//     speedLimit = 110;
//     break;

//     case "m":
//     speedLimit = 100;
//     break;

//     case "k":
//     speedLimit = 90;
//     break;
    
//     default:
//     Console.WriteLine("");
//     Console.WriteLine("Geçersiz Tuşlama!");
//     return;
    
// }

// Console.WriteLine();
// Console.WriteLine("Hızınızı tuşlayınız.");
// vehicleSpeed = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine();

// speedDifference = vehicleSpeed - speedLimit;

// if (vehicleSpeed <= speedLimit)
// {
//     Console.WriteLine("Kurallara Uyduğunuz için teşekkür ederiz.");
// }
// else
// {
//     if (speedDifference <= 30)
//     {
//         Console.WriteLine("Hız Sınırı: " + speedLimit +
//         " Sizin Hızınız: " + vehicleSpeed + " Ceza Miktarı: " + ticket);
//     }
//     else
//     {
//         ticket *= 2;
//         Console.WriteLine("Hız Sınırı: " + speedLimit +
//         " Sizin Hızınız: " + vehicleSpeed + " Ceza Miktarı: " + ticket);
//     }
// }