// double balance = 9752.12;
// int correctPassword = 242526;
// int attempt = 3;

// Console.WriteLine();
// Console.WriteLine("######################################");
// Console.WriteLine("KodBank Mobil Bankacılığa Hoşgeldiniz!");
// Console.WriteLine("---> Şifrenizi giriniz <---");

// for (int i = 3; i > 0; i--)
//     {
//         Console.WriteLine();
//         Console.Write("Password: ");
//         int toTry = int.Parse(Console.ReadLine() ?? "");
//         Console.WriteLine();

//         if (toTry != correctPassword)
//         {
//             Console.WriteLine("Şifre Yanlış! Yeniden deneyin!");
//             attempt -= 1;
//             Console.WriteLine("Kalan Deneme Hakkı " + attempt);
//         }
//         else if (toTry == correctPassword)
//         {
            
//             Console.WriteLine("XXXXXXXXXXXXXXXX");
//             Console.WriteLine("X Şifre Doğru! X");
//             Console.WriteLine("XXXXXXXXXXXXXXXX");
//             break;
//         }
            
//     }
// if (attempt == 0)
// {
//     Console.WriteLine();
//     Console.WriteLine("3 Kez Yanlış girdiniz");
//     Console.WriteLine("Banka Hesabınız bloke edildi!");
//     Console.WriteLine("Müşteri Temsilcisini Arayınız!");
// }
// else
// {
//     Console.WriteLine();
//     Console.WriteLine("Hoşgeldiniz.");
//     Console.WriteLine("Mevcut Bakiye Miktarı: " + balance);
//     Console.WriteLine();
//     Console.WriteLine("Para Çekmek için 1");
//     Console.WriteLine("Para Yatırmak için 2");
//     int result = int.Parse(Console.ReadLine() ?? "");


// switch (result)
// {
//     case 1:
//     Console.WriteLine("Çekebileceğiniz Bakiye Miktarı:" + balance);
//     break;
//     case 2:
//     Console.WriteLine("Para Yatırma ekranına yönlendiriliyorsunuz!");
//     break;
    
//     default:
//     Console.WriteLine("Böyle Bir Seçenek Yok");
//     break;
// }

// if (result == 1)
// {
//     Console.WriteLine();
//     Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
//         double request = double.Parse(Console.ReadLine() ?? "");
    
//     if (request > balance)
//     {
//         Console.WriteLine("Bakiye Yetersiz olduğu için sistem kapatıldı!");
//     }
//     else if (request <= balance)
//     {
//         balance -= request;
//         Console.WriteLine();
//         Console.WriteLine("Çekilen Miktar: " + request + "|| Kalan Bakiye: " + balance);
//         Console.WriteLine();
//         Console.WriteLine("BANKAMIZ İYİ GÜNLER DİLER!");
//     }
// }
// else if (result == 2)
// {
//     Console.WriteLine();
//     Console.WriteLine("Yatırmak istediğiniz miktarı giriniz");
//         double deposit = double.Parse(Console.ReadLine() ?? "");
    
//     balance += deposit;

//     Console.WriteLine();
//     Console.WriteLine("Yeni Bakiye: " + balance);
//     Console.WriteLine();
//     Console.WriteLine("BANKAMIZ İYİ GÜNLER DİLER!");
// }
// }