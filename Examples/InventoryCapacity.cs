// string userName;

// float moveSpeed;
// float penalty;
// float distance = 100f;

// //item weights
// float swordWeight = 4.2f, armorWeight = 7.5f, potionWeight = 0.8f;
// //item count
// int swordCount, armorCount, potionCount;


// Console.WriteLine();
// Console.Write("Name?: ");
// userName = Console.ReadLine() ?? "";

// Console.WriteLine();
// //hız öğrenilir
// Console.Write(userName + " Speed? (m/s): ");
// moveSpeed = float.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();
// //kılıç sayısı öğrenilir
// Console.Write("Sword Count?: ");
// swordCount = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();
// //zırh sayısı öğrenilir
// Console.Write("Armor Count?: ");
// armorCount = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();
// //iksir sayısı öğrenilir
// Console.Write("Elixir Count?: ");
// potionCount = int.Parse(Console.ReadLine() ?? "");

// // TW = Total Weight \\ toplam ağırlık hesaplanır.
// float swordTW = swordCount * swordWeight;
// float armorTW = armorCount * armorWeight;
// float elixirTW = potionCount * potionWeight;

// //toplam item ağırlığı hesaplanır
// float totalWeight = swordTW + armorTW + elixirTW;
// //hız düşürme cezasını hesaplamak için ağırlıkla 0.2 çarpılır.
// //çıkan sonuç hareket hızından düşülür ve gerçek hız bulunur.
// penalty = totalWeight * 0.3f;
// //ağırlık çıkınca kalan hız miktarı hesaplanır
// float finalSpeed = moveSpeed - penalty;
// //mesafe son hıza bölünür ve süre ortaya çıkar
// float time = distance / finalSpeed;

// Console.WriteLine();
// Console.WriteLine("Press Enter!");
// Console.ReadLine();


// Console.WriteLine();
// Console.WriteLine("--- RPG INVENTORY SYSTEM ---");
// Console.WriteLine();
// Console.WriteLine("Hero Name: " + userName);
// Console.WriteLine("Hero Speed: " + moveSpeed);
// Console.WriteLine();
// Console.WriteLine("Inventory Status:");
// Console.WriteLine("Number of Swords: " + swordCount);
// Console.WriteLine("Number of Armors: " + armorCount);
// Console.WriteLine("Number of Potions: " + potionCount);
// Console.WriteLine("--- CALCULATED ---");
// Console.WriteLine("Total Weight: " + totalWeight);
// Console.WriteLine("Penalty: " + penalty);
// Console.WriteLine();
// Console.WriteLine("Previous Speed: " + moveSpeed);
// Console.WriteLine("Current Speed: " + finalSpeed);
// Console.WriteLine();
// Console.WriteLine("--- SIMULATION ---");
// Console.WriteLine("The " + userName + " Can run 100 meters in " + time + " seconds with current charge.");