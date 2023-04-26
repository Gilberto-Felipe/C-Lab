// Debugging App


int[] nums = { 1, 2, 3, 4, 5 };


try
{
    Debug(nums);
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}



static void Debug(int[] nums)
{
    for (int i = 0; i <= nums.Length; i++)
    {
        Console.WriteLine(nums[i]);
    }
}

