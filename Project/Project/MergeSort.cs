using System.Xml.Schema;

namespace Project
{
    public class MergeSort
    {
        public int[] Merge(int[] left, int[] right, int[] main)
        {
            int leftLength = left.Length - 1;
            int rightLength = right.Length - 1;
            int leftMin = 0;
            int rightMin = 0;
            int posFill = 0;

            while (leftMin < leftLength && rightMin < rightLength)
            {
                if (left[leftMin] <= right[rightMin])
                {
                    main[posFill] = left[leftMin];
                    leftMin++;
                }
                else
                {
                    main[posFill] = right[rightMin];
                    rightMin++;
                }
                posFill++;
            }

            while (leftMin < leftLength)
            {
                main[posFill] = left[leftMin];
                leftMin++;
                posFill++;
            }
            while (rightMin < rightLength)
            {
                main[posFill] = right[rightMin];
                rightMin++;
                posFill++;
            }
            

            return main;
        }

        public int[] MergeS(int[] main)
        {
            int mLength = main.Length;
            
            if (mLength < 2)
                return main;

            int mid = mLength / 2;
            int[] left = new int[mid];
            int[] right = new int[mLength - 1];

            for (int i = 0; i < mid - 1; i++)
                left[i] = main[i];

            for (int i = mid; i < mLength - 1; i++)
            {
                right[i - mid] = main[i];
            }

            MergeS(left);
            MergeS(right);
            Merge(left, right, main);

            return main;
        }
    }
}