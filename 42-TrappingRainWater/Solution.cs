namespace TrappingRainWater
{
    internal class Solution
    {        
        public int Trap(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int leftMax = height[0], rightMax = height[height.Length - 1];
            int water = 0;
            while (left < right)
            {
                if (leftMax < rightMax)
                {
                    left++;
                    if (leftMax < height[left])                    
                        leftMax = height[left];                    
                    else                    
                        water += leftMax - height[left];
                    
                }
                else
                {
                    right--;
                    if (rightMax < height[right])                    
                        rightMax = height[right];                    
                    else                    
                        water += rightMax - height[right];
                    
                }
            }
            return water;
        }
    }
}
