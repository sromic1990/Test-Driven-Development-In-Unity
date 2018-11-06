using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecursionTest : MonoBehaviour
{
    public List<int> Revenue;
    public Text HighestRevenueCustumer;

    public void CalculateMaximumRevenue()
    {
        int revenue = Dispatcher(Revenue.Count, Revenue);
        HighestRevenueCustumer.text = revenue.ToString() + " , "+Revenue[revenue].ToString();
    }

    private int Dispatcher(int numberOfEntries, List<int> Revenue)
    {
        //if No Revenue list available return -1. This is an error message.
        if (numberOfEntries == 0) return -1;
        //Solve 1 part of the problem. So the topmost dispatcher does look at just the last number and stores the revenue.
        int revenue = Revenue[numberOfEntries - 1];

        //The alternate entry. This is when the top level dispatcher's evaluated customer revenue is lower than the 
        //lower level dispacher's found highest revenue.
        int altEntry = Dispatcher(numberOfEntries - 1, Revenue);
        //Checking the edge case, i.e. the lower level dispatcher did not receive any revenue
        //and as a result, returned -1
        if(altEntry < 0)
        {
            //Of course if the lower level dispatcher has no files, the top level dispatcher's 
            //file has the highest revenue that the top level dispatcher has found,
            //so no comparison is required
            return numberOfEntries - 1;
        }
        else //if the lower level dispatcher were actually given files to evaluate
        {
            //if top level dispatcher's evaluated revenue is lower than the lower level dispatcher
            if (revenue < Revenue[altEntry])
            {
                //return the lower level dispatcher's evaluated higest paying customer index.
                return altEntry;
            }
            else // if the lower level dispatcher's highest paying customer has paid less than the top level dispatcher
            {
                //return the top level dispatcher's highest paying customer index.
                return numberOfEntries - 1;
            }
        }
    }

    //private int Delegator(int numberOfEntries, List<int> Revenue)
    //{
    //    int customer = -1;
    //    int revenue = -1;
    //    for (int i = 0; i < numberOfEntries; i++)
    //    {
    //        if(revenue < Revenue[i])
    //        {
    //            revenue = Revenue[i];
    //            customer = i;
    //        }
    //    }
    //
    //    return customer;
    //}
}
