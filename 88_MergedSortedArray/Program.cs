// See https://aka.ms/new-console-template for more information

Merge(new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3);

static void Merge(int[] nums1, int m, int[] nums2, int n)
{
    int p1 = m - 1;
    int p2 = n - 1;
    int i = m + n - 1;

    while (p2 >= 0)
    {
        if (p1 >= 0 && nums1[p1] > nums2[p2])
        {
            nums1[i--] = nums1[p1--];
        }
        else
        {
            nums1[i--] = nums2[p2--];
        }
    }

    Console.WriteLine($"The arrays we are merging are " +
            $"[{string.Join(", ", new int[] { 1, 2, 3, 0, 0, 0 })}] and [{string.Join(", ", new int[] { 2, 5, 6 })}]." +
            $"\r\nThe result of the merge is [{string.Join(", ", nums1)}] with " +
            $"the underlined elements coming from nums1.");
}