namespace LeetCodeEasy448
{
    public static class Solution
    {
        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            HashSet<int> set = new(nums);
            IList<int> result = [];

            for (int i = 1; i <= nums.Length; i++)
                if (!set.Contains(i))
                    result.Add(i);

            return result;
        }
    }
}
