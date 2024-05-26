namespace Zadanie2
{

    class Program
        {
            static void Main()
            {
                int[] myArray = { 2, 5, 7, 12, 8 };

                int[] sortedArray = QuickSort(myArray, 0, myArray.Length - 1);

                Console.WriteLine($"Отсортированный массив: {string.Join(", ", sortedArray)}");

        }

            private static int[] QuickSort(int[] array, int minIndex, int maxIndex)
            {
                if (minIndex >= maxIndex)
                {
                    return array;
                }

                int pivotIndex = GetPivotIndex(array, minIndex, maxIndex);

                QuickSort(array, minIndex, pivotIndex - 1);

                QuickSort(array, pivotIndex + 1, maxIndex);

                return array;
            }

            private static int GetPivotIndex(int[] array, int minIndex, int maxIndex)
            {
                int pivot = minIndex - 1;

                for (int i = minIndex; i <= maxIndex; i++)
                {
                    if (array[i] < array[maxIndex])
                    {
                        pivot++;
                        Swap(ref array[pivot], ref array[i]);
                    }
                }

                pivot++;
                Swap(ref array[pivot], ref array[maxIndex]);

                return pivot;
            }

            private static void Swap(ref int leftItem, ref int rightItem)
            {
                int temp = leftItem;

                leftItem = rightItem;

                rightItem = temp;
            }
        }
    }
