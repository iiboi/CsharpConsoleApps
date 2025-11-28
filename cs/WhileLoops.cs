#region Scrap Shredder

// int totalIron = 0;
// int totalCopper = 0;

// Console.WriteLine("Atık Öğütücüye Hoşgeldiniz");
// Console.WriteLine("Öğütmek istediğiniz rakamı giriniz!");
// int scrapID = int.Parse(Console.ReadLine() ?? "");


// while (scrapID > 0)
// {
//     int currentScrap = scrapID % 10;

//     if (currentScrap % 2 == 0)
//     {
//         Console.WriteLine();
//         totalIron += currentScrap;    
//         Console.WriteLine(currentScrap + " Rakamı İşlendi -> Demir Kazanıldı!" );
//     }
//     else
//     {
//         Console.WriteLine();
//         totalCopper += currentScrap;
//         Console.WriteLine(currentScrap + " Rakamı İşlendi -> Bakır kazanıldı!");

//     }

//     scrapID /= 10;
// }

// Console.WriteLine("---------------------");
// Console.WriteLine("Toplam Demir: " + totalIron 
// + " | Toplam Bakır : " + totalCopper);

#endregion

#region Mine

// int capacity =  50;
// int currentLoad = 0;

// Console.WriteLine();

// while (currentLoad < capacity)
// {
// Console.WriteLine("Kaç adet altın satmak istiyorsun.");
// int gold = int.Parse(Console.ReadLine() ?? "");
// Console.WriteLine();
    

//     if (currentLoad + gold > capacity)
//     {
//         Console.WriteLine("Bu altın çok ağır! bunu alırsan kese yırtılır!");
//         Console.WriteLine();
        
//     }
//     else
//     {
//         currentLoad += gold;
//         Console.WriteLine("Altın eklendi! Şu anki yük: " + currentLoad);
//         Console.WriteLine();
//     }

// }

// Console.WriteLine();
// Console.WriteLine("Kese doldu! Dönebiliriz.");

#endregion

#region DragonFight

// int dragonHP = 100;
// int arrows = 5;

// while (dragonHP > 0 && arrows > 0)
// {
//     Console.WriteLine();
//     Console.WriteLine("Vuruş gücünüz nedir?");
//     int hitPower = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine();

//     dragonHP -= hitPower;
//     arrows --;
//     Console.WriteLine("Ejderhanın canı Şuan: " + dragonHP);
//     Console.WriteLine();
    

//     Console.WriteLine("Ejderhanın Canı: " + dragonHP 
//     + " | Kalan Ok: " + arrows);
    
// }

// if (dragonHP <= 0)
// {
//     Console.WriteLine();
//     Console.WriteLine("ZAFER! Ejderhayı yendin.");
// }
// else
// {
//     Console.WriteLine();
//     Console.WriteLine("Yenilgi. Okların bitti ve ejderha seni yedi!");
    
// }

#endregion