#region Auto-Loot System

// string[] lootItems = ["Gold", "Stone", "Gold", "Diamond", "Stone", "Health Potion", "Stone", "Sword"];
// int valuableLoots = 0;
// foreach (string item in lootItems)
// {
//     if (item == "Stone")
//     {
//         Console.WriteLine("Ignored: " + item);
//         Console.WriteLine();
//     }
//     else if (item == "Diamond" || item == "Gold")
//     {
//         Console.WriteLine("Valuable item found: " + item);
//         Console.WriteLine();
//         valuableLoots++;
//     }
//     else
//     {
//         Console.WriteLine("Added to inventory: " + item);
//         Console.WriteLine();
//     }
// }
// Console.WriteLine("Total valuable items found: " + valuableLoots);
#endregion
#region RPG Compat Log Calculator

// int[] rawDamages = [120, 40, 250, 80, 300, 15, 90, 210];
// int critCount = 0;
// int totalDamage = 0;

// foreach (int damage in rawDamages)
// {
//     if (damage < 50)
//     {
//         Console.WriteLine();
//         Console.WriteLine($"Miss! (Raw: {damage})");
//         Console.WriteLine();
//     }
//     else if (damage >= 200)
//     {
//         int critHit = damage * 2;
//         critCount++;
//         totalDamage += critHit;
//         Console.WriteLine($"Critical Hit! Dealt: {critHit} (Raw: {damage})");
//         Console.WriteLine();
//     }
//     else
//     {
//         totalDamage += damage;
//         Console.WriteLine($"Normal Hit. Dealt: {damage}");
//     }
// }
// Console.WriteLine($"Total Damage Dealt: {totalDamage}");
// Console.WriteLine();
// Console.WriteLine($"Total Critical Hits: {critCount}" );

#endregion
#region Survival Inventory System

// int[] itemWeights = [ 5, 12, 3, 25, 8, 10, 15, 4, 60 ];
// int maxCapacity = 50;
// int itemCollected = 0;
// int heaviest = 0;

// foreach (int weights in itemWeights)
// {
    
//     if ( itemCollected >= maxCapacity || weights + itemCollected >= maxCapacity)
//     {
//         Console.WriteLine($"Item skipped. Too heavy: {weights}");
//         Console.WriteLine();
//     }
//     else
//     {
//         itemCollected += weights;
//         Console.WriteLine($"Item Taken: {weights} - Current load: {itemCollected}");
//         Console.WriteLine();

//         if ( weights >= heaviest )
//         {
//             heaviest = weights;
//         }
//     }

// }

// Console.WriteLine($"Final Load: {itemCollected} / {maxCapacity}");
// Console.WriteLine();
// Console.WriteLine("Heaviest item: " + heaviest);

#endregion