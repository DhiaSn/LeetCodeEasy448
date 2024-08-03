namespace LeetCodeEasy448
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            IList<int> result1 = Solution.FindDisappearedNumbers([4, 3, 2, 7, 8, 2, 3, 1]);
            if (!(new List<int>([5, 6])).SequenceEqual(result1))
            {
                Console.WriteLine($"result1 is: {result1} instead of [5, 6]");
                return;
            }
            IList<int> result2 = Solution.FindDisappearedNumbers([1, 1]);
            if (!(new List<int>([2])).SequenceEqual(result2))
            {
                Console.WriteLine($"result2 is: {result2} instead of [2]");
                return;
            }
            IList<int> result3 = Solution.FindDisappearedNumbers([1, 1, 2]);
            if (!(new List<int>([3])).SequenceEqual(result3))
            {
                Console.WriteLine($"result3 is: {result3} instead of [2]");
                return;
            }
            */
            IList<int> result4 = Solution.FindDisappearedNumbers([4, 3, 2, 7, 7, 2, 3, 1]);
            if (!(new List<int>([5, 6, 8])).SequenceEqual(result4))
            {
                Console.WriteLine($"result4 is: {result4} instead of [2]");
                return;
            }

            Console.WriteLine($"it works perfectly!");
        }
    }
}
