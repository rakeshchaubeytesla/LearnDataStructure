using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LearnDataStructure.Array
{
    public class CustomArray
    {
        private int[] parentArray { get; set; }
        private int[] childArray { get; set; }
        private int count = 0;
        public CustomArray(int size)
        {
            parentArray = new int[size];
        }

        public void Add(int item)
        {
            //if count == prentarry.lenght then
            //create a new array of double size and save the data in it
            if (parentArray.Length == count)
            {
                childArray = new int[count * 2];
                for (int i = 0; i < count; i++)
                {
                    childArray[i] = parentArray[i];
                }
                parentArray = childArray;
            }
            parentArray[count++] = item;
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
                throw new ArgumentOutOfRangeException("index");
            //[10,20,30.40.50.60]i Want to remove 20 . Then 30 should move one step front
            //Lets say index = 1
            for (int i = index; i <= count; i++)
            {
                parentArray[i] = parentArray[i + 1];
            }
        }

        public int IndexOf(int item)
        {
            int returnIndex = -1;
            for (int i = 0; i < count; i++)
            {
                if (parentArray[i] == item)
                    return returnIndex = i;
            }

            return returnIndex;
        }

        public int Max()
        {
            //[10,30,60,15,18,19]
            //int[] findMaxArray = new int[parentArray.Length];
            // We declared a paremeter set the value as first element
            // now loop through each item if the current value is bigger then findMaxArray.
            //If yes assign findMaxArray with that value. So findMaxArray will always have largest value.
            int findMaxArray = parentArray[0];
            for (int i = 0; i < count; i++)
            {
                if (parentArray[i] > findMaxArray)
                    findMaxArray = parentArray[i];
                //Take First Item 10 and iterate through the loop and check if any value
                //is greater then that .If yes Add to new array else return that item
                //var getSelectedRowValue = parentArray[i];
                //if (getSelectedRowValue > parentArray[j])
                //{
                //    findMaxArray = getSelectedRowValue;
                //}
                //for (int j = i; j < count; j++)
                //{
                //    if (getSelectedRowValue > parentArray[j])
                //    {
                //        findMaxArray = getSelectedRowValue;
                //    }
                //}
            }


            return findMaxArray;
        }

        public void Intersect()
        {
            int[] firstArray = new int[4] { 12, 16, 19, 11 };
            int[] secondArray = new int[4] { 24, 19, 11, 55 };
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < firstArray.Length; i++)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if (firstArray[i] == secondArray[j])
                        sb.Append(secondArray[j]);
                }
            }
            Console.WriteLine(sb.ToString());
            Console.Read();
        }

        public void Reverse()
        {
            int[] mainArray = new int[] { 12, 16, 19, 11 };
            int[] reversedArray = new int[mainArray.Length];
            int loopCount = 0;
            for (int i = mainArray.Length; i >= 1; i--)
            {
                reversedArray[loopCount] = mainArray[i - 1];
                loopCount++;
            }
            for (int j = 0; j < reversedArray.Count(); j++)
            {
                Console.WriteLine(reversedArray[j]);
            }
            Console.Read();
        }

        public void insertAt(int item, int index)
        {
            for (int i = index; i < parentArray.Count(); i++)
            {
                if(parentArray[i] == 0) return;
                if (i == index)
                    parentArray[i] = item;
                else
                    parentArray[i] = parentArray[i + 1];
            }
        }
        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(parentArray[i]);
            }
            Console.Read();
        }

    }
}
