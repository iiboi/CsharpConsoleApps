#region RPG Arena
// int[] score = [0, 0, 0, 0, 0];

// for (int i = 0; i < score.Length; i++)
// {
//     Console.Write(i + 1 + ". Oyuncunun Skorunu Giriniz: ");
//     score[i] = int.Parse(Console.ReadLine() ?? "");
//     Console.WriteLine();
// }

// Array.Sort(score);
// Array.Reverse(score);

// Console.WriteLine("-------------------------------");
// Console.WriteLine("------RPG ARENA SONUÇLARI------");
// Console.WriteLine();
// Console.WriteLine("En yüksek Puan: " + score[0]);
// Console.WriteLine("En Düşük Puan: " + score[^1]);
// Console.WriteLine();
// Console.WriteLine("-------LİDERLİK TABLOSU--------");
// for (int i = 0; i < score.Length; i++)
// {
//     Console.WriteLine(i + 1 + ". " + score[i]);
// }
#endregion
#region Alan etkili Saldırı Sistemi

// int[] health = [50, 25, 100, 10, 80];
// int death = 0;

// for (int i = 0; i < health.Length; i++)
// {   
//     health[i] -= 30;
    
//     if (health[i] <= 0)
//     {
//         death += 1;
//         health[i] = 0;
//         Console.WriteLine(1 + i + ". DÜşmanın canı: " + health[i] + " ÖLDÜ");
//     }
//     else if (health[i] > 0)
//     {
//         Console.WriteLine(1 + i + ". Düşmanın canı: " + health[i]);
//     }

// }

// Console.WriteLine("---------------------");
// Console.WriteLine("Toplam Ölen Sayısı: " + death);

#endregion
#region Meydan Savaşı

// int[] health = [50, 60, 70, 40];
// int poisonDmg = 15;

// for (int i = 1; i <= 3; i++)
// {
//     Console.WriteLine();
//     Console.WriteLine($"--- TUR {i} BAŞLADI ---");
//     Console.WriteLine();

//         for (int k = 0; k < health.Length; k++)
//         {
//             health[k] -= poisonDmg;
//             if (health[k] <= 0)
//             {
//                 health[k] = 0;
//                 Console.WriteLine(k + 1 + ". Düşman: " + health[k] + " HP (ÖLDÜ)");
//             }
//             else
//             {
//                 Console.WriteLine(k + 1 + ". Düşman: " + health[k] + " HP");
//             }
//         }
    
// }

// Console.WriteLine();
// Console.WriteLine("Savaş Sona Erdi!");

#endregion