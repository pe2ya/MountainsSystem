using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exer
{
    class Pohori
    {
        private string name = "Aboba";
        private List<Hora> hory = new List<Hora>();

        public void AddH(string name, int height)
        {
            hory.Add(new Hora(name, height));
        }

        public IEnumerable<Hora> Heightest()
        {
            int maxheight = hory.Max(x => x.Height);
            return hory.Where(x => x.Height == maxheight);
        }

        public double AverageHeight()
        {
            return hory.Average(x => x.Height);
        }

        public IEnumerable<Hora> HeightestThree()
        {
            List<Hora> result = hory.OrderByDescending(x => x.Height).Take(3).ToList();
            return result;
        }

        public string Names()
        {
            string result = "";
            foreach (var x in hory.OrderBy(x => x.Height))
            {
                result += x.Name + "\n";
            }
            return result;
        }

        public IEnumerable<Hora> GetHigher(int height)
        {
            return hory.Where(x => x.Height > height).OrderBy(x => x.Height);
        }

        public string Info()
        {
            int count = hory.Count();
            int sum = hory.Sum(x => x.Height);

            return "Count: "+ count + "\nSum: " + sum;
        }

        public override string ToString()
        {
            string result = name + ": \n";

            foreach (var x in hory)
            {
                result += x.ToString() + "\n";
            }

            return result;
        }
    }
}
