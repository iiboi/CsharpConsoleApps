// //String Degiskenler
// string userName;
// string menuChoice;
// string foodMenuChoice;
// string drinkMenuChoice;
// string hotChoice;
// string coldChoice;
// string waffleChoice;
// string riceChoice;
// string selected = "";

// //int Degiskenler
// int price = 0;
// int check;
// int change;


// Console.WriteLine("Hoşgeldiniz Efendim. Adınız nedir?");
// Console.WriteLine();
//     userName = Console.ReadLine() ?? "";
// Console.WriteLine();

// Console.WriteLine("Merhaba " + userName);
// Console.WriteLine();
// Console.WriteLine("İçecek mi alırdınız yoksa yemek mi? ");
// Console.WriteLine();
//     menuChoice = Console.ReadLine() ?? "";

// if (menuChoice == "yemek" || menuChoice == "Yemek")
// {
//     Console.WriteLine("Harikai! Elimde Peki Gözleme mi istersiniz Yoksa Pilav mı?");
//     foodMenuChoice = Console.ReadLine() ?? "";
//         if (foodMenuChoice == "gözleme" || foodMenuChoice == "Gözleme")
//         {
//             Console.WriteLine();
//             Console.WriteLine("*** Gözleme Çeşitleri ***");
//             Console.WriteLine();
//             Console.WriteLine("1-Patatesli Gözleme");
//             Console.WriteLine("2-Kaşarlı Gözleme ");
//             Console.WriteLine("3-Kavurmalı Gözleme");
//             Console.WriteLine("4-Sucuklu Gözleme");
//             Console.WriteLine("5-Ispanaklı Gözleme ");
//             Console.Write("Seçiminiz 1-5: ");
//             waffleChoice = Console.ReadLine() ?? "";

//             switch (waffleChoice)
//             {
//                 case "1":
//                 selected = "Patatesli Gözleme";
//                 price = 120;
//                 break;

//                 case "2":
//                 selected = "Kaşarlı gözleme";
//                 price = 140;
//                 break;

//                 case "3":
//                 selected = "Kavurmalı Gözleme";
//                 price = 230;
//                 break;

//                 case "4":
//                 selected = "Sucuklu Gözleme";
//                 price = 180;
//                 break;

//                 case "5":
//                 selected = "Ispanaklı Gözleme";
//                 price = 155;
//                 break;

//                 default:
//                 selected = "Boş Hamur";
//                 price = 20;
//                 break;
//             }
//         }
//         else if (foodMenuChoice == "pilav" || foodMenuChoice == "Pilav")
//         {
//             Console.WriteLine();
//             Console.WriteLine("*** Pilav Çeşitleri ***");
//             Console.WriteLine();
//             Console.WriteLine("1-Tavuklu Pilav");
//             Console.WriteLine("2-Ciğerli Pilav");
//             Console.WriteLine("3-Kavurmalı Pilav");
//             Console.WriteLine("4-Karışık Pilav");
//             Console.WriteLine("5-Sade Pilav");
//             Console.Write("Seçiminiz 1-5: ");
//             riceChoice = Console.ReadLine() ?? "";

//             switch (riceChoice)
//             {
//                 case "1":
//                 selected = "Tavuklu Pilav";
//                 price = 120;
//                 break;

//                 case "2":
//                 selected = "Ciğerli Pilav";
//                 price = 150;
//                 break;

//                 case "3":
//                 selected = "Kavurmalı Pilav";
//                 price = 280;
//                 break;

//                 case "4":
//                 selected = "Karışık Pilav";
//                 price = 250;
//                 break;

//                 case "5":
//                 selected = "Sade Pilav";
//                 price = 80;
//                 break;

//                 default:
//                 selected = "Maalesef";
//                 price = 0;
//                 break;
//             }
//         }
// }
// else if (menuChoice == "İçecek" || menuChoice == "içecek")
// {
//     Console.WriteLine("Harika, elimde sıcak ve soğuk içecek çeşitleri var. Hangisini istersiniz?");
//     drinkMenuChoice = Console.ReadLine() ?? "";
//     if (drinkMenuChoice == "Sıcak" || drinkMenuChoice == "sıcak" )
//     {
//         Console.WriteLine();
//         Console.WriteLine("*** Sıcak İçecek Fiyatları ***");
//         Console.WriteLine();
//         Console.WriteLine("1-Çay");
//         Console.WriteLine("2-Latte");
//         Console.WriteLine("3-Türk Kahvesi");
//         Console.WriteLine("4-Salep");
//         Console.WriteLine("5-Sıcak Çikolata");
//         Console.Write("Seçiminiz 1-5: ");
//         hotChoice = Console.ReadLine() ?? "";

//         switch(hotChoice)
//         {
//             case "1":
//             selected = "Çay";
//             price = 30;
//             break;

//             case "2":
//             selected = "Latte";
//             price = 130;
//             break;

//             case "3":
//             selected = "Türk Kahvesi";
//             price = 80;
//             break;

//             case "4":
//             selected = "Salep";
//             price = 95;
//             break;

//             case "5":
//             selected = "Sıçak Çikolata";
//             price = 110;
//             break;
//         }
//     }
//     else if (drinkMenuChoice == "Soğuk" || drinkMenuChoice == "soğuk" )
//     {
//         Console.WriteLine();
//         Console.WriteLine("*** Soğuk İçecek Fiyatları ***");
//         Console.WriteLine();
//         Console.WriteLine("1-Su");
//         Console.WriteLine("2-Maden Suyu");
//         Console.WriteLine("3-Kola");
//         Console.WriteLine("4-Fanta");
//         Console.WriteLine("5-Soğuk Çay");
//         Console.Write("Seçiminiz 1-5: ");
//         coldChoice = Console.ReadLine() ?? "";

//         switch(coldChoice)
//         {
//             case "1":
//             selected = "Su";
//             price = 20;
//             break;

//             case "2":
//             selected = "Maden Suyu";
//             price = 25;
//             break;

//             case "3":
//             selected = "Kola";
//             price = 60;
//             break;

//             case "4":
//             selected = "Fanta";
//             price = 60;
//             break;

//             case "5":
//             selected = "Soğuk Çay";
//             price = 60;
//             break;
//         }
//     }
    
// }
// else
// {
//     Console.WriteLine("Üzgünüm, elimizde öyle bir seçenek yok :/");
//     return;
// }


// Console.WriteLine(selected + " Aldınız ve toplam ödemeniz: " + price);
// Console.WriteLine();
// Console.WriteLine("(Kaç para verdiğinizi yazınız)");
// Console.WriteLine();

// check = int.Parse(Console.ReadLine() ?? "");

// change = check - price;


// Console.WriteLine();
// Console.WriteLine("Para üstünüz: " + change + " TL Afiyet olsun.");

