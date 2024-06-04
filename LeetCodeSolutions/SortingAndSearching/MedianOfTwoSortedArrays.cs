namespace LeetCodeSolutions.SortingAndSearching
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
                (nums1, nums2) = (nums2, nums1);

            int x = nums1.Length, y = nums2.Length;

            int low = 0, high = x;

            int partitionX, partitionY, maxLeftX, maxLeftY, minRightX, minRightY;

            while (low <= high)
            {
                partitionX = (low + high) / 2;
                partitionY = (x + y + 1) / 2 - partitionX;

                maxLeftX = partitionX == 0 ? int.MinValue : nums1[partitionX - 1];
                minRightX = partitionX == x ? int.MaxValue : nums1[partitionX];
                maxLeftY = partitionY == 0 ? int.MinValue : nums2[partitionY - 1];
                minRightY = partitionY == y ? int.MaxValue : nums2[partitionY];

                if (maxLeftX <= minRightY && maxLeftY <= minRightX) // partition is in right place. Compute median with this position
                {
                    if ((x + y) % 2 == 0) // even number of items
                        return (double.Max(maxLeftX, maxLeftY) + double.Min(minRightX, minRightY)) / 2;
                    else // odd number of items
                        return int.Max(maxLeftX, maxLeftY);
                }
                else if (maxLeftX > minRightY) // we are far too right of the partition. Move partition left
                    high = partitionX - 1;
                else // we are too far on the left, go right
                    low = partitionX + 1;

            }

            return -1;

        }


    }
}
