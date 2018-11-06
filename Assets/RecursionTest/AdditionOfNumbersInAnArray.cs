using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RecursionTest
{
    public class AdditionOfNumbersInAnArray : MonoBehaviour
    {
        public int[] Numbers;
        public Text SumText;

        public void CalculateSum()
        {
            int result = Dispatcher(Numbers.Length, Numbers);
            SumText.text = result.ToString();
        }

        private int Dispatcher(int length, int[] numbers)
        {
            if (length == 0) return 0;
            return numbers[length - 1] + Dispatcher(length - 1, numbers);
        }

        //private int Sum(int length, int[] numbers)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < length; i++)
        //    {
        //        sum += numbers[i];
        //    }
        //    return sum;
        //}
    }
}