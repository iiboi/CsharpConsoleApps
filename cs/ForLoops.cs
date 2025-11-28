#region Case1


// double mainMoney = 1000;
// double initialMoney = mainMoney;
// for (int i = 1; i <= 15; i++)
// {
//     mainMoney *= 1.05f;
//     Console.WriteLine(i + ". gün para miktarı: " + mainMoney.ToString("0.00"));
    
//     if (mainMoney >= 1500)
//     {
//         Console.WriteLine("---> DİKKAT: K0ritik seviye aşıldı, kar satış yapılabilir!");
//     }
// }

// double profit = mainMoney - initialMoney;


// Console.WriteLine();
// Console.WriteLine("15 Gün Sonunda Toplam Net Kar: " + profit.ToString("0.00") + " TL");

#endregion

#region Case2

// int totalPotions = 0;

// for (int i = 1; i <= 10; i++)
// {   
//     int productionRate = 20;

//     if (i > 7)
//     {
//         productionRate = 10;
//         Console.WriteLine("---> Büyücü Yorulduğu için verim düştü!.");
//     }
//     else if (i == 5)
//     {
//         productionRate = 50;
//         Console.WriteLine("---> İlham Perisi tarafından kutsandığın için üretim arttı!.");
//     }

//     totalPotions += productionRate;

//     Console.WriteLine("Saat " + i + ". " + productionRate +
//      " Adet üretildi" + " Toplam: " + totalPotions);
// }

// Console.WriteLine("--------------------------------");
// Console.WriteLine("Toplanan İksir Sayısı: " + totalPotions);


#endregion

#region case 3 


// int TotalScore = 0;

// for (int i = 1; i <= 10; i++ )
// {
//     int hitPoint = 100;

//     if (i % 3 == 0)
//     {
//         hitPoint = 300;
//             Console.Write("----> COMBO!  ");
//     }
//     else if (i == 7)
//     {
//         hitPoint = -50;
//         Console.Write("----> MISS!!  ");
//     }

//     TotalScore += hitPoint;
    
//     Console.WriteLine(i +  ". Hit! Your Damage: " + hitPoint 
//     + " Total Score: " + TotalScore);
// }

// Console.WriteLine("-------------------------------");
// Console.WriteLine("Your Total Hit Point: " + TotalScore);

#endregion
