using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, 7, 11, 15 };
            int target = 9;

            int[] result = TwoSum(nums, target);
            foreach (int i in result)
                Console.WriteLine(i);

            Console.ReadLine();

        }
        //algorism 1
        //static public int[] TwoSum(int[] nums, int target)
        //{
        //    int[] output = new int[2];
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        for (int idx = 0; idx < nums.Length; idx++)
        //        {
        //            if (i != idx)
        //            {
        //                if ((nums[i] + nums[idx]) == target)
        //                {
        //                    output[0] = i;
        //                    output[1] = idx;
        //                    return output;
        //                }

        //            }
        //        }
        //    }
        //    return output;
        //}

        //static public int[] TwoSum(int[] nums, int target)
        //{
        //    int[] output = new int[2];
        //    int otherindex;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        otherindex = target - nums[i];

        //        for (int idx = 0; idx < nums.Length; idx++)
        //        {
        //            if (i != idx)
        //            {
        //                if ((nums[i] + nums[idx]) == target)
        //                {
        //                    output[0] = i;
        //                    output[1] = idx;
        //                    return output;
        //                }

        //            }
        //        }
        //    }
        //    return output;
        //}
    }
}
