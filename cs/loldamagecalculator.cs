// string line = ("#################################");
// string userName;

// float abilityPower;
// float qApRatio = 0.5f, wApRatio = 0.9f, eApRatio = 0.7f, rApRatio = 1.2f;

// int abilityQ, abilityW, abilityE, abilityR;
// ///////////////////////////////////////////////////////////////////////////////


// Console.WriteLine();
// Console.WriteLine("League of Legends Savaş Hasar Hesaplayicisina Hoşgeldiniz!");
// Console.WriteLine();

// //Karakter ismi öğrenilir ve userName değişkenine atanır.
// Console.Write("Karakter ismi: ");
// userName = Console.ReadLine() ?? "";

// Console.WriteLine();
// //karakterin ap değeri öğrenilir ve abilityPower değişkenine atanır.
// Console.Write(userName + " Karakterin yetenek Gücü nedir?: ");
// abilityPower = float.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();

// //Karakterin savaşta Q yeteneğini kaç kez kullandığı öğrenilir.
// Console.Write(userName + " Bu savaşta Q yeteneğini kaç kez kullandi?: " );
// abilityQ = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();

// //Karakterin savaşta W yeteneğini kaç kez kullandığı öğrenilir.
// Console.Write(userName + " Bu savaşta W yeteneğini kaç kez kullandi?: " );
// abilityW = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();

// //Karakterin savaşta E yeteneğini kaç kez kullandığı öğrenilir.
// Console.Write(userName + " Bu savaşta E yeteneğini kaç kez kullandi?: " );
// abilityE = int.Parse(Console.ReadLine() ?? "");

// Console.WriteLine();

// //Karakterin savaşta R yeteneğini kaç kez kullandığı öğrenilir.
// Console.Write(userName + " Bu savaşta R yeteneğini kaç kez kullandi?: " );
// abilityR = int.Parse(Console.ReadLine() ?? "");

// //Karakterin Yetenek Gücü, Skillerin Yetenek gücü oranıyla çarpılır Ve Temelde skill'in ne kadar hasar vurduğunu hesaplar.
// float qBaseDamage = qApRatio * abilityPower;
// float wBaseDamage = wApRatio * abilityPower;
// float eBaseDamage = eApRatio * abilityPower;
// float rBaseDamage = rApRatio * abilityPower;
// ////////////////////////////////////////////
// float qFightDamage = qBaseDamage * abilityQ;
// float wFightDamage = wBaseDamage * abilityW;
// float eFightDamage = eBaseDamage * abilityE;
// float rFightDamage = rBaseDamage * abilityR;

// //Karakterin o savaşta toplam kaç Yetenek Gücü hasarı vurduğu hesaplanır.
// float totalFightDamage = qFightDamage + wFightDamage + eFightDamage + rFightDamage;
// Console.WriteLine();

// Console.WriteLine("Hesaplama yapildi. Sonucu görmek için Enter'a basiniz");
// Console.ReadLine();

// Console.WriteLine(line);
// Console.WriteLine("####### HESAPLAMA SONUCU #######");
// Console.WriteLine(line);
// Console.WriteLine();
// Console.WriteLine(userName + " Yetenek gücü: " + abilityPower + ", ve Q yeteneğinin Yetenek Gücü Orani: " + qApRatio + ", Q ile bu savaşta vurulan toplam hasar:"  + qFightDamage);
// Console.WriteLine();
// Console.WriteLine(userName + " Yetenek gücü: " + abilityPower + ", ve W yeteneğinin Yetenek Gücü Orani: " + wApRatio + ", W ile bu savaşta vurulan toplam hasar:"  + wFightDamage);
// Console.WriteLine();
// Console.WriteLine(userName + " Yetenek gücü: " + abilityPower + ", ve E yeteneğinin Yetenek Gücü Orani: " + eApRatio + ", E ile bu savaşta vurulan toplam hasar:"  + eFightDamage);
// Console.WriteLine();
// Console.WriteLine(userName + " Yetenek gücü: " + abilityPower + ", ve R yeteneğinin Yetenek Gücü Orani: " + rApRatio + ", R ile bu savaşta vurulan toplam hasar:"  + rFightDamage);
// Console.WriteLine();
// Console.WriteLine(userName + " ------Toplam Vurulan Hasar: " + totalFightDamage);
// Console.WriteLine("Program bitmiştir, Yeniden başlatabilirsiniz");