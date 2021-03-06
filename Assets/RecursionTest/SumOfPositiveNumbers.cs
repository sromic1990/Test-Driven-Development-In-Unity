﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RecursionTest
{
    public class SumOfPositiveNumbers : MonoBehaviour
    {
        public int[] Numbers;
        public Text SumText;

        public void Sum()
        {
            int result = Dispatcher(Numbers.Length, Numbers);
            SumText.text = result.ToString();
        }

        private int Dispatcher(int length, int[] numbers)
        {
            if (length == 0) return 0;
            return Dispatcher(length - 1, numbers) + (numbers[length - 1] >= 0 ? numbers[length - 1] : 0);
        }
    }
}
