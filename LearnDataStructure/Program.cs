using LearnDataStructure.Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Insert();
            
        }

        public static CustomArray CustomArrayInstance(int size)
        {
            CustomArray customArray = new CustomArray(size);
            return customArray;
        }
        public static void Insert()
        {
            //In this example 
            var parentArray = CustomArrayInstance(2);
            parentArray.Add(90);
            parentArray.Add(60);
            parentArray.Add(30);
            parentArray.Add(15);
            parentArray.Add(18);
            parentArray.Add(19);
            parentArray.insertAt(110, 1);
            //parentArray.Reverse();
            //parentArray.Intersect();
            //Console.WriteLine(parentArray.Max());
            //Console.WriteLine(parentArray.IndexOf(90));
            //parentArray.removeAt(1);
            parentArray.Print();
        }
    }
}
