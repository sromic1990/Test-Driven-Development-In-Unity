using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace RecursionTest
{
    public class OddParity : MonoBehaviour
    {
        public int[] Numbers;
        public Text SumText;

        public void ParityCheck()
        {
            bool result = Dispatcher(Numbers.Length, Numbers);
            SumText.text = result.ToString();
        }

        private bool Dispatcher(int length, int[] numbers)
        {
            if (Delegator(length, numbers) % 2 == 0) return false;
            else return true;
        }

        private int Delegator(int length, int[] numbers)
        {
            if (length == 0) return 0;
            return Delegator(length - 1, numbers) + (numbers[length -1] % 2 == 1 ? 1 : 0);
        }
    }
}
