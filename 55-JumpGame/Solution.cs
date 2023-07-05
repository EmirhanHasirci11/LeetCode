namespace JumpGame
{
    internal class Solution
    {
        public bool CanJump(int[] nums)
        {
            int endcase = nums.Length - 1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (i + nums[i] >= endcase)
                    endcase = i;
            }
            return endcase == 0;
        }
    }
}