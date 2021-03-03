using System;

using System.Collections.Generic;

class WordCountingWithSortedDictionary
{
    static void Main()
    {
        //IDictionary<int, string> numberNames = new Dictionary<int, string>();

        //numberNames.Add(1, "One");  //Adding key/value using Add method
        //numberNames.Add(2, "Two");
        //numberNames.Add(3, "Three");

        ////  numberNames.Add(3, "Fourth"); Argument Exception key 3 already added

        //foreach (KeyValuePair<int, string> kvp in numberNames)
        //{
        //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        //}
        // Key can be unique, non repeating , key cant be null, alues can be null or repeating 
        var cities = new Dictionary<string, string>() 
        {   ///Dictionary Initializer 
            {"UK", "London, Mancghester, Birmingahm"},
            { "USA", "Chicago, New York, Washington" },
            { "India", "Mumbai, New Delchi, Pune"}          
        };

        foreach (var kvp in cities)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key , kvp.Value);
        }
    }   
}   