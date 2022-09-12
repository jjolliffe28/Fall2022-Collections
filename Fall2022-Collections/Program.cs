 // Collections

// Arrays!
// Fixed size and of a particular size
// Indexed at 0 - meaning numbered starting at 0
// In C# - an arrays length and type cannot change. period. . 

var students = new string[13]; // creates an empty array with 13 slots to fill
// variable = new type [length]; generic template

var instructors = new string[] {"Davis", "Gavin", "El", "Rickie", "Cliff" }; // because there are 5 things listed, the array's LENGTH is 5
// variable = new type [] {comma seperated values}; 

// Change the value at a slot in an array
// name = value; typically w variables
// array[index] = value; - how we do it with arrays
students[7] = "Jack";
// Student at index 7 is updated to say "Jack"
// student at index 7 is not the seventh student -> 8th student
// first thing in the list -> array[0]
// last thing in the list -> array [array.Length - 1]

Console.WriteLine(students.Length); // prints the number of slots that the student array has
Console.WriteLine(students[7]); // prints the 7th value of the array -> should print "Jack"






// Lists!
// Dynamic size, still must be of one type
// Indexed at 0
var groceries = new List<string>(); // Sets up our new list, starting with no values within, its count is 0
groceries.Add("Pizza"); // our list contains 1 item, (Pizza has an index = 0)
groceries.Add("Bananas"); //our list now contains two items and now (banana has an index = 1)
groceries.Add("Grapes"); // Grapes index = 2
groceries.Add("Potatoes"); // Potatoes index = 3 
Console.WriteLine(groceries[0]);

// Remove items 
// list.Remove(Item);
groceries.Remove("Bananas"); // Grapes and Potatoes would shift down in the index. Grapes -> 1, Potatoes -> 2
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

// RemoveAt - gives index to remove
// groceries.RemoveAt(1); // removes the second item in a list

groceries.Insert(1, "Bananas"); // shift items after this index up by 1, adds bananas to list
Console.WriteLine(groceries.Count);
Console.WriteLine(groceries[1]);

Console.WriteLine(groceries); // Doesnt really work? There is a way to do this - 

// How do we print out this list?!?!
// Foreach Loops!
// Loops that run once for each item in a collection
// rather than specifically having an index (i) like previous loops, we have an object that we can look at and engage with
// foreach(type item in collection){ code we want to run on the item}
foreach(var grocery in groceries)
{
    Console.WriteLine(grocery);

}

foreach(var teacher in instructors)
{
    Console.WriteLine(teacher);
}

// sometimes its nice to have access to the index of a particular item as well as the item itself. So, we can replicate the foreach loop using a for loop

for(var i = 0; i < instructors.Length; i++)  // collection.Length if its an array- collection.Count if its a list
{
    Console.WriteLine(instructors[i]); // Wanna use i (or the variable) or else it will print out the same instructor 13 times etc.
}

// instructors [i] in a for loop is the same as the var instructor in a for each loop





// Dictionaries!!!!! 
// collections of key value pairs
// keys - how we access elements
// values - the values we get in return

var weather = new Dictionary<string, float>();
weather["Atlanta"] = 82.3f; //key is atlanta, and the value is 82.3f
weather["Cleveland"] = 71f;
Console.WriteLine(weather["Atlanta"]); // accessing the value at "Atlanta"

Console.WriteLine(weather.Count);

foreach(var  report in weather)
{
    Console.WriteLine(report);
}
