namespace Challenge_Lab_5._1
{
    //Given a non-empty array of integers nums, every element appears twice except for one.
    //Find that single one.
    //Status: Complete.  Using Dictionary.
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 1, 2, 1, 2 };

            int answer = FindSingleton(MakeDictionary(nums));
            
            Console.WriteLine(answer);

            Console.ReadKey();
        }

        static Dictionary<int, int> MakeDictionary(int[] nums)
        {
            Dictionary<int, int> countingDict = new();
            foreach (int number in nums)
            {
                if (countingDict.ContainsKey(number))
                {
                    countingDict[number]++;
                }
                else
                {
                    countingDict.Add(number, 1);
                }
            }
            return countingDict;
        }

        static int FindSingleton(Dictionary<int, int> dict)
        {
            int singleton = 0;
            foreach (int number in dict.Keys)
            {
                if (dict[number] == 1)
                {
                    singleton =  number;
                    break;
                }
            }

            return singleton;
                
        }
    }
}
