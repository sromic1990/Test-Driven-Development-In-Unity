using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RecursionTest
{
    public class CountNumberOfZeroes : MonoBehaviour
    {
        public int[] Numbers;
        public Text SumText;

        public void CountZeroes()
        {
            int result = Dispatcher(Numbers.Length, Numbers);
            SumText.text = result.ToString();
        }

        private int Dispatcher(int length, int[] numbers)
        {
            if (length == 0) return 0;
            int count = Dispatcher(length - 1, numbers);
            if (numbers[length - 1] == 0) count++;
            return count;
        }
    }
}
