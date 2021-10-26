using System;
using System.Collections.Generic;

namespace NumberOfPeopleInBus
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              There is a bus moving in the city, and it takes and drop some people in each bus stop.
              You are provided with a list (or array) of integer pairs. Elements of each pair represent number of people get into bus (The first item) and number of people get off the bus (The second item) in a bus stop.
              Your task is to return number of people who are still in the bus after the last bus station (after the last array). Even though it is the last bus stop, the bus is not empty and some people are still in the bus, and they are probably sleeping there :D
              Take a look on the test cases.
              Please keep in mind that the test cases ensure that the number of people in the bus is always >= 0. So the return integer can't be negative.
              The second value in the first integer array is 0, since the bus is empty in the first bus stop.
            */

            List<int[]> peopleList = new List<int[]>() { new[] { 10, 0 }, new[] { 3, 5 }, new[] { 5, 8 } };
            int people = 0;
            foreach (var item in peopleList)
            {
                people -= item[1];
                people += item[0];
            }
            Console.WriteLine(people);
        }
    }
}
