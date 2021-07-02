using System;
using System.Collections.Generic;
using System.Linq;

namespace NameSOrter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = System.IO.File.ReadAllLines(@"C:\Users\USER\source\repos\NameSorter\unsorted_names_list.txt");// Reading Text file 
           
          //Printing the data(names) of the text file after reading
            for (int i=0;i<text.Length;i++)
            {
                Console.WriteLine(text[i]);     
            }
            
            
           
            string lastName=""; // initializing string lastname. I will contain all the lastnames separated by new line
           
            string last; //Declaring string last. I will contain Lastname
            
            // Fetching lastname 
            foreach (string i in text)
                {
                     string[] names = i.Split(' '); // Separating names with delimiter Space
                   
                     last = names.Last(); // Fetching lastname
                
                     lastName += "\n" + last;  // Putting lastnames in new string Lastname Separating them with new line(Entry in a new line)
            }
            
           // Console.WriteLine(lastName); // Printing last names only
            
            string[] Sortedlastt = lastName.Split("\n"); // Creating string array of lastName
           
            Array.Sort(Sortedlastt); // Sorted lastName 

           for(int k=0; k<Sortedlastt.Length;k++)
            {
                Console.WriteLine(Sortedlastt[k]); // Printing Sorted lastnames 
            }

            Console.WriteLine("\n");
            string lastnamenew; // Declaring new string lastnamenew
            bool results;       // Declaring bool variable results. It will compare two lastnames
            string sortedlist=""; // Initialising string sortedlist with empty space
            
           //Fetching name whose lastname matched with Sorted lastname 
            for (int m=0;m<Sortedlastt.Length;m++)
            {
                for (int l = 0; l < text.Length; l++)
                {
                    string[] newlast = text[l].Split(' ');// Separating actual names with spaces in between 
                    lastnamenew = newlast.Last(); // fetching lastname of actual names in the array

                    results = String.Equals(Sortedlastt[m], lastnamenew);// Comparing Sorted lastname and fetched lastname
                    //Console.WriteLine(results);
                    if (results)// if true,then that name would be displayed. A LastName in Sorted list is compared against all the lastnames in the actual list.   
                    {
                        //Console.WriteLine(text[l]); // Printing the corresponding Actual Name
                        sortedlist +=text[l]+"\n"; // Creating String of SortedNames
                        
                    }
                }

            }

            Console.WriteLine("\n"); // Adding new line
            Console.WriteLine(sortedlist); // Printing Sorted Name list

            string[] sortedlistt = sortedlist.Split('\n'); // Creating a string array of SortedNames

            System.IO.File.WriteAllLines(@"C:\Users\USER\source\repos\NameSorter\sorted_names_list.txt", sortedlistt);// Writing content of Sorted Names to the Text file with the path provided
        }


    }
}
