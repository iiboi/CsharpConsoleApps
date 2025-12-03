#region Basic Bank System

// int balance = 0;

// void Deposit(int amountOfMoney)
// {
//     balance += amountOfMoney;

//     Console.WriteLine($"Yatırılan: {amountOfMoney} | Yeni bakiye: {balance}");
//     Console.WriteLine();
// }

// void WithDraw(int withdrawnMoney)
// {
//     if (withdrawnMoney > balance)
//     {
//         Console.WriteLine($"Yetersiz Bakiye! Çekilmek istenen: {withdrawnMoney}, Mevcut {balance}");
//         Console.WriteLine();
//     }
//     else
//     {
//         balance -= withdrawnMoney;

//         Console.WriteLine($"Çekilen: {withdrawnMoney} | Kalan Bakiye: {balance}");
//         Console.WriteLine();
//     }
// }

// Deposit(500);
// WithDraw(200);
// WithDraw(400);
// Deposit(100);
// WithDraw(400);

#endregion

#region The Alchemist

// int heroHealth = 50;

// int GetPotionPower(string plantName)
// {
//     if (plantName == "Mantar")
//     {
//         return 10; 
//     }
//     else if (plantName == "Papatya")
//     {
//         return 20;
//     }

//     return 0;
// }

// Console.WriteLine("Kazanmak istediğiniz can");
// Console.WriteLine("10 ise Mantar, 20 ise Papatya yazınız.");
// string answer = Console.ReadLine() ?? "";

// heroHealth += GetPotionPower(answer);

// Console.WriteLine($"Can Yenilendi. Son Can: {heroHealth}");

#endregion
#region Damage Calculator

// int CalculateDamage(int rawDamage, bool isCritical)
// {
//     if (isCritical)
//     {
//         return rawDamage * 3;
//     }
//     else
//     {
//         return rawDamage;
//     }
// }

// int enemyHealth = 100;

// enemyHealth -= CalculateDamage(10, false);
// enemyHealth -= CalculateDamage(10, true);

// Console.WriteLine($"Düşmanın Kalan Canı: {enemyHealth}");

#endregion