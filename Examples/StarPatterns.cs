#region Alt alta 10 yıldız
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine("*");
// }
#endregion
#region Yan yana 10 yıldız
// for (int i = 0; i <= 10; i++)
// {
//     Console.Write("*");
// }
#endregion
#region Her satırda 10
// for (int i = 0; i <= 10; i++)
// {
//     Console.WriteLine("**********");
// }
#endregion
#region Dik Üçgen 
// for (int i = 0; i <= 10; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }
#endregion
#region Ters Dik Üçgen
// for (int i = 10; i >= 0; i--)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }
#endregion
#region Dik ve Ters Üçgen
// for (int i = 0; i <= 10; i++)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }

// for (int i = 9; i >= 0; i--)
// {
//     for (int j = 0; j <= i; j++)
//     {
//         Console.Write("*");
//     }

//     Console.WriteLine();
// }
#endregion
#region Üçgen
// int n = 10;

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(".");
//     }

//     for (int k = 1; k <= (2 * i) - 1; k++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
#endregion
#region Kare
// int n = 5;

// for (int i = 1; i <= n; i++)
// {
//     for (int j = 1; j <= n; j++)
//     {
//         if ( i == 1 || i == n || j == 1 || j == n)
//         {
//             Console.Write("0");
//         }
//         else
//         {
//             Console.Write(" ");
//         }
//     }

//     Console.WriteLine();
// }
#endregion