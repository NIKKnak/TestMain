using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary
{
    internal class BinarySearch
    {
        // Метод для выполнения бинарного поиска в массиве
        public int BinarySearchElement(int[] arr, int x)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                // Проверяем, если x находится в середине массива
                if (arr[mid] == x)
                    return mid;

                // Если x больше, чем элемент в середине массива, игнорируем левую часть
                if (arr[mid] < x)
                    left = mid + 1;
                // Иначе игнорируем правую часть
                else
                    right = mid - 1;
            }

            // Если x не найден в массиве
            return -1;
        }
    }
}
