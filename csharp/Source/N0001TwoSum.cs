namespace Source;

public class N0001TwoSum
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> res_cache = new();

        for (int i = 0; i < nums.Length; i++)
        {
            // temp 为当前项相对应的数
            int temp = target - nums[i];

            // 如果res_cache有 temp, 即找到结果, 返回两个数的位置
            if (res_cache.ContainsKey(temp))
            {
                return new int[] { i, res_cache[temp] };
            }

            // 如果res_cache中无当前值, 则添加值至res_cache, 主要用于排除nums中的重复值
            if (!res_cache.ContainsKey(nums[i]))
            {
                res_cache.Add(nums[i], i);
            }
        }
        return new int[] { 0, 0 };
    }
}
