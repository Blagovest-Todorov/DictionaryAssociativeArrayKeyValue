using System;

using System.Collections.Generic;

class WordCountingWithSortedDictionary
{
    static void Main()
    {
        IDictionary<int, string> numberNames = new Dictionary<int, string>();

        numberNames.Add(1, "One");  //Adding key/value using Add method
        numberNames.Add(2, "Two");
        numberNames.Add(3, "Three");

        //  numberNames.Add(3, "Fourth"); Argument Exception key 3 already added

        foreach (KeyValuePair<int, string> kvp in numberNames)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }

    }   
}