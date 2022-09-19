using System;
using System.Collections.Generic;
using System.Linq;

namespace _5KuyLeastCommonMultiple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

    }
    public static class Kata
    {
        public static int Lcm(List<int> nums)
        {
            if (nums.Contains(0)) return 0;
            if (nums.Count == 0) return 1;
            nums = nums.Distinct().OrderBy(x => x).ToList();
            //if (nums.Count == 1) return nums[0];
            


            int commonDivided = nums.Max();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                int tempNum = nums[i];
                int tempDivided = commonDivided;
                if (commonDivided % tempNum == 0) continue;

                for (int j = 2; j <= tempNum; j++)
                {

                    if (tempDivided % j == 0 && tempNum % j == 0)
                    {
                        tempNum /= j;
                        tempDivided /= j;
                        j = 1;
                    }
                    else if (tempNum % j == 0)
                    {
                        commonDivided *= j;
                        tempNum /= j;
                        j = 1;

                    }
                }
            }
            return commonDivided;
        }
    }
}
