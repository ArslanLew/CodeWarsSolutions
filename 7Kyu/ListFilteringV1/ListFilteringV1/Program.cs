using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class ListFilterer
{
    //In this kata you will create a function that takes a list of non-negative integers and strings and returns a new list with the strings filtered out.
    public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
    {
        List<int> answer = new List<int>(new int[] { });
        foreach (object thing in listOfItems)
        {
            if (thing.GetType().Name == "Int32")
            {
                answer.Add((int)thing);
            }
        }
        IEnumerable<int> enumerable = answer as IEnumerable<int>;
        return enumerable;

    }
}