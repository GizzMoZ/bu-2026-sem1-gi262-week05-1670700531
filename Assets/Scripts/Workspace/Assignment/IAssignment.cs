using UnityEngine;
using System.Collections.Generic;

namespace Assignment
{

    public interface IAssignment
    {
        #region Lecture 
        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Selection Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT01_SelectionSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Bubble Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT02_BubbleSortAscending(int[] numbers);

        /// <summary>
        /// เรียงลำดับตัวเลขจากน้อยไปมากโดยใช้ Insertion Sort
        /// </summary>
        /// <param name="numbers"></param>
        public int[] LCT03_InsertionSortAscending(int[] numbers);

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
        /// ค้นหาตัวเลขที่มีค่ามากเป็นอันดับสองใน array
        /// ให้เขียนโปรแกรมเพื่อค้นหาตัวเลขที่มีค่ามากเป็นอันดับสองจาก array ที่ได้รับเป็น input
        /// เช่น input ที่ได้รับมาคือ[1 2 3 4 5] ตัวเลขที่มีค่ามากเป็นอันดับสองคือ 4
        /// </summary>
        /// <param name="numbers"></param>
        public int AS04_FindTheSecondLargestNumber(int[] numbers);

        #endregion

        #region Extra

        /// <summary>
        /// ค้นหาความยาวชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด
        /// ให้เขียนโปรแกรมเพื่อค้นหาความยาวของชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุดจาก array ที่ได้รับเป็น input
        /// ตัวอย่างความยาวชุดตัวเลขที่เรียงลำดับติดต่อกันที่ยาวที่สุด เช่น input ที่ได้รับมาคือ[1 9 3 10 4 20 2] เมื่อนำมาเรียงจากน้อยไปมากแล้วจะได้เป็น[1 2 3 4 9 10 20]
        /// ซึ่งเราจะได้ชุดตัวเลขย่อยๆที่เรียง 3 ชุดคือ
        /// [1 2 3 4]
        /// [9 10]
        /// [20]
        /// จะเห็นว่า[1 2 3 4] มีความยาวเท่ากับ4 ซึ่งเป็นชุดตัวเลขที่ยาวที่สุดเมื่อเทียบกับ 2 ชุดที่เหลือ
        /// ดังนั้นเราสามารถบอกได้ว่าชุดตัวเลขนี้[1 9 3 10 4 20 2] มี longest consecutive sequence ความยาวเท่ากับ 4
        /// </summary>
        /// <param name="numbers"></param>
        public int EX01_FindLongestConsecutiveSequence(int[] numbers);

        #endregion 
    }
}
