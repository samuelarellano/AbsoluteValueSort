namespace AbsoluteValueSort.Utils
{
    public class Operations : IOperations
    {
        public int[] AbsSort(int[] nums)
        {
            Array.Sort(nums, (a, b) =>
            {
                int absA = Math.Abs(a);
                int absB = Math.Abs(b);

                if (absA != absB)
                    return absA.CompareTo(absB);

                return a.CompareTo(b);
            });

            return nums;
        }
    }
}
