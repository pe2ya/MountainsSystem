using System;
using System.Collections.Generic;
using System.Linq;

namespace Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>()
            {
                -3, 1, 3, -8, 4, 1, 12, 8, -2, 26, 9, -11
            };

            int num;

            num = list.Where(x => x > 0).Count();
            Console.WriteLine(num + "\n");

            num = list.Where(x => x > 0).Min(x => x);
            Console.WriteLine(num + "\n");

            num = list.Where(x => x % 2 == 0).Max(x => x);
            Console.WriteLine(num + "\n");

            num = list.Where(x => x > 0).Sum(x => x);
            Console.WriteLine(num + "\n");

            num = (list.Where(x => x < 0).Sum(x => x)) / (list.Where(x => x < 0).Count());
            Console.WriteLine(num + "\n");

            List<int> list2 = list.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", list2));


            string krkonosskeHory = "Sněžka (1603 m) • Luční hora (1555 m) • Studniční hora (1555 m) • Vysoké kolo (1510 m) • Stříbrný hřbet (1490 m) • Violík (1472 m) • Malý Šišák (1440 m) • Kotel (1435 m) • Zadní Planina (1423 m) • Harrachovy kameny (1421 m) • Mužské kameny (1415 m) • Dívčí kameny (1414 m) • Svorová hora (1411 m) • Zlaté návrší (1411 m) • Růžová hora (1393 m) • Liščí hora (1363 m) • Lysá hora (1344 m)• Železný vrch (1321 m) • Stoh (1320 m) • Černá hora (1300 m) • Luboch (1296 m) • Skalní stůl (1284 m) • Světlá (1244 m) • Medvědín (1235 m) • Čihadlo (1216 m) • Plešivec (1209 m) • Přední Planina (1198 m) • Lysečina (1190 m) • Jelení hora (1173 m) • Slatinná stráň (1153 m) • Vlčí hřeben S (1140 m) • Lesní hora (1129 m) • Vlčí hřeben (1124 m) • Vlčí hřeben J (1119 m) • Pěnkavčí vrch (1105 m) • Dlouhý hřeben (1085 m) • Mechovinec (1081 m) • Kraví hora (1072 m) • Mrtvý vrch (1062 m) • Černá skála (1042 m) • Zadní Žalý (1036 m) • Dvorský les (1036 m) • Vlašský vrch (1037 m) • Šeřín (1036 m) • Preislerův kopec (1035 m) • Jelení vrch (1024 m) • Čertova hora (1021 m) • Přední Žalý (1019 m) • Pevnost (1012 m) • Struhadlo (1007 m) • Mravenečník (1005 m) • Javor (1002 m) • Janova skála SZ (1002 m) • Špičák (1001 m)";

            var a = krkonosskeHory.Split("•");

            Pohori pohori = new Pohori();

            String[] names = new String[a.Length];
            int[] height = new int[a.Length];

            for (int i = 0; i < a.Length; i++)
            {

                var aa = a[i].Split(" (");
                names[i] = aa[0].Trim();
                height[i] = Int32.Parse(aa[1].Replace(" m)", "").Trim());

                pohori.AddH(names[i], height[i]);

                if (aa == null)
                {
                    break;
                }
            }

            Console.WriteLine(pohori);

            Console.WriteLine("\n\n");

            foreach (var x in pohori.Heightest())
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n\n");

            foreach (var x in pohori.HeightestThree())
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine(pohori.AverageHeight());

            Console.WriteLine("\n\n");

            Console.WriteLine(pohori.Names());
            Console.WriteLine("\n\n");

            foreach (var x in pohori.GetHigher(1300))
            {
                Console.Write(x + "\n");
            }
            Console.WriteLine("\n\n");


            Console.WriteLine(pohori.Info());

        }
    }
}
