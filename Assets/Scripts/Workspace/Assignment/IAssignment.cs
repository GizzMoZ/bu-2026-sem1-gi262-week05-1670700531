using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{

    public interface IAssignment
    {
        #region Lecture 
        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากน้อยไปมาก</returns>
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[minIndex])
                        minIndex = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[minIndex];
                numbers[minIndex] = temp;
            }

            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากน้อยไปมาก</returns>
        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    // สลับถ้าตัวซ้ายมากกว่าตัวขวา (ให้ค่ามากลอยไปทางขวา)
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }

                // ถ้ารอบนี้ไม่มีการสลับ แปลว่าเรียงเสร็จแล้ว
                if (!swapped) break;
            }

            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากน้อยไปมาก</returns>
        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                // เลื่อนตัวที่มากกว่า key ไปทางขวา เพื่อเปิดช่องให้ key
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            return numbers;
        }

        #endregion

        #region Assignment

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากมากไปน้อย</returns>
        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] > numbers[maxIndex])
                        maxIndex = j;
                }

                int temp = numbers[i];
                numbers[i] = numbers[maxIndex];
                numbers[maxIndex] = temp;
            }

            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากมากไปน้อย</returns>
        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    // สลับถ้าตัวซ้ายน้อยกว่าตัวขวา (ให้ค่ามากไปทางซ้าย)
                    if (numbers[j] < numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                        swapped = true;
                    }
                }

                // ถ้ารอบนี้ไม่มีการสลับ แปลว่าเรียงเสร็จแล้ว
                if (!swapped) break;
            }

            return numbers;
        }

        /// <summary>
        /// เรียงลำดับตัวเลขจากมากไปน้อยโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการเรียง</param>
        /// <returns>อาร์เรย์ที่เรียงจากมากไปน้อย</returns>
        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int key = numbers[i];
                int j = i - 1;

                // เลื่อนตัวที่น้อยกว่า key ไปทางขวา เพื่อเปิดช่องให้ key
                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }

                numbers[j + 1] = key;
            }

            return numbers;
        }

        /// <summary>
        /// หาตัวเลขที่มีค่ามากเป็นอันดับสองใน array (ข้ามค่าซ้ำของค่าสูงสุด)
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการค้นหา</param>
        /// <returns>ค่าที่มากเป็นอันดับสอง</returns>
        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
            // เรียงจากน้อยไปมาก แล้วกลับเป็นมากไปน้อย
            Array.Sort(numbers);
            Array.Reverse(numbers);

            // หาค่าแรกที่น้อยกว่าค่าสูงสุด (ข้าม duplicates)
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[0])
                    return numbers[i];
            }

            // กรณีทุกตัวเท่ากันหมด ไม่มีอันดับสอง
            throw new InvalidOperationException("ไม่มีค่ามากเป็นอันดับสอง");
        }

        #endregion

        #region Extra

        /// <summary>
        /// หาความยาวของชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด
        /// </summary>
        /// <param name="numbers">อาร์เรย์ที่ต้องการตรวจสอบ</param>
        /// <returns>ความยาวของชุดที่ต่อเนื่องยาวที่สุด</returns>
        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            if (numbers.Length == 0)
                return 0;

            // เรียงจากน้อยไปมาก (copy ไว้ ไม่แก้ array ต้นฉบับ)
            int[] sorted = (int[])numbers.Clone();
            Array.Sort(sorted);

            int longest = 1;
            int current = 1;

            for (int i = 1; i < sorted.Length; i++)
            {
                if (sorted[i] == sorted[i - 1] + 1)
                {
                    current++;
                }
                else if (sorted[i] != sorted[i - 1])
                {
                    // ไม่ต่อเนื่องและไม่ใช่ค่าซ้ำ -> รีเซ็ต
                    current = 1;
                }
                // ถ้าเท่ากับตัวก่อนหน้า (ค่าซ้ำ) ไม่ทำอะไร คง current เดิมไว้

                if (current > longest)
                    longest = current;
            }

            Console.WriteLine($"The longest consecutive sequence is: {longest}");
            return longest;
        }

        #endregion 
    }
}
