using System;
using System.Collections.Generic;

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            // I have a list of 10 people, each with their own phone number.
            // There are 2 Jebediah's
            var persons = new List<Person>();
            persons.Add(new Person("Patricia", "915-888-4444"));
            persons.Add(new Person("Amy", "915-888-7777"));
            persons.Add(new Person("Frank", "915-888-5555"));
            persons.Add(new Person("Jebediah", "915-888-1111"));
            persons.Add(new Person("Zackary", "915-888-3333"));
            persons.Add(new Person("Selma", "915-888-6666"));
            persons.Add(new Person("Benedict", "915-888-2222"));
            persons.Add(new Person("Russell", "915-888-9999"));
            persons.Add(new Person("Jebediah", "915-888-1111"));
            
            Console.WriteLine("Does my list of people contain any Duplicates?: " + AnyDuplicates(persons));

            Console.WriteLine("My people before sorting: ");
            foreach(var person in persons)
            {
                Console.WriteLine("\t" + person.ToString());
            }

            InsertionSort(persons);

            Console.WriteLine("My people after sorting: ");
            foreach(var person in persons)
            {
                Console.WriteLine("\t" + person.ToString());
            }
        }
        // Insertion sort looks at every item in a collection, starting at index 1.
        // It compares the item at the current index with every other item to its left.
        // If it finds an item that is "greater than" the item at current index, it moves the current item into that index.
        // Every item to the right of the insert index is "shifted" 1 space to the right.
        // Insertion sort keeps everything to the left of the current index sorted, and can move and insert items.
        // Bubble sort only swaps adjacent items until its list is sorted.
        static void InsertionSort(List<Person> myPeople)
        {
            for (int i = 1; i < myPeople.Count; i++)
            {
                Person personAtIndex = myPeople[i];
                for (int j = 0; j < i; j++)
                {
                    // Person.ToString() return the name of that person.
                    // Essentially testing if( personAtIndex < mypeople[j] )
                    if(personAtIndex.ToString().CompareTo(myPeople[j].ToString()) < 0)
                    {
                        // When we have found the new index for personAtIndex,
                        // remove that person from its original index,
                        // then insert them at their new index.
                        myPeople.Remove(personAtIndex);
                        myPeople.Insert(j, personAtIndex);
                        break;
                    }
                }
            }
        }
        // This method uses a list of strings to keep track of the names it has seen to check for duplicates.
        static Boolean AnyDuplicates(List<Person> myPeople)
        {
            var seen = new List<string>();
            foreach(var person in myPeople)
            {
                string personName = person.ToString();
                if(seen.Contains(personName))
                {
                    return true;
                }
                seen.Add(personName);
            }
            return false;
        }
    }
}
