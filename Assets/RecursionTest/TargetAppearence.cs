using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RecursionTest
{
    public class TargetAppearence : MonoBehaviour
    {
        public int[] Numbers;
        public int Target;
        public Text SumText;

        public void TargetAppearenceCount()
        {
            int result = Dispatcher(Numbers.Length, Numbers, Target);
            SumText.text = result.ToString();
        }

        private int Dispatcher(int length, int[] numbers, int target)
        {
            if (length == 0) return 0;
            return Dispatcher(length - 1, numbers, target) + (numbers[length - 1] == target ? 1 : 0);
        }
    }
}
