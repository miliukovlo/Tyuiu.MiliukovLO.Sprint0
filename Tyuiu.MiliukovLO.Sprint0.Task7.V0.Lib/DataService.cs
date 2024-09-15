namespace Tyuiu.MiliukovLO.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] nums1, int[] nums2) 
        {
            int[] nums = new int[nums1.Length];
            for (int i = 0; i < nums1.Length; i++) 
            {
                nums[i] = nums1[i] + nums2[i];
            }
            return nums;
        }
    }
}
