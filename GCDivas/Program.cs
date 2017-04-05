using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCDivas
{
    class Program
    {
        //create a diva prototype as our blueprint for divas
        public class Diva
        {
            //defining attributes for diva private because this is the blueprint 
            private string name;
            private int id;
            private string bestSong;
            private string homeTown;

            //define the constructor method used to instniatate a new diva
            public Diva(string name, int id, string bestSong, string homeTown)
            {
                //"this" refers to the current instance and sets the values for each diva attribute to what we pass it when we make a new diva 
                this.name = name;
                this.id = id;
                this.bestSong = bestSong;
                this.homeTown = homeTown;
            }
            //we make a getter and setter for each diva attribute so we can access it later 
            //for example diva.Name
            public string Name
            {  
                //get returns the value stored in name var 
                get { return name; }
                //set sets name equal to the value we pass for it when we make a new diva
                set { name = value; }
            }
            public int Id
            {
                get { return id; }
                set { id = value; }
            }
            public string BestSong
            {
                get { return bestSong; }
                set { bestSong = value; }
            }
            public string HomeTown
            {
                get { return homeTown; }
                set { homeTown = value; }
            }
        }
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                //store each individual into the list 
                //array must be in ame order as given in Diva class 
                List<Diva> DivaList = new List<Diva>();
                DivaList.Add(new Diva("Queen B", 1, "Everything", "Houston, TX"));
                DivaList.Add(new Diva("Annie Lennox", 2, "sweet dreams", "michigan"));
                DivaList.Add(new Diva("Brandy", 3, "Have you ever", "Atlanta"));
                DivaList.Add(new Diva("Tina Turner", 4, "Golden eye", "Indiana"));
                DivaList.Add(new Diva("Adele", 5, "Pavements", "UK"));

                //user prompt to print and see list of divas 
                Console.WriteLine("welcome! Learn about our divas! type Yass!");
                string userInput = Console.ReadLine().ToLower();
                //check to make sure user inputs "Yass" 
                if (userInput == "yass")
                {
                    //loop through each entry in the diva list
                    foreach (var diva in DivaList)
                    {
                        //print each entry to the console
                        Console.WriteLine(diva.Id + " " + diva.Name + " ");
                    }
                    //prompt user to pick a number and get added info on diva
                    Console.WriteLine("Great! pick one! enter a number");
                    //int.Parse to because you cant compare strings and chars
                    int userSelection = int.Parse(Console.ReadLine());
                    //Use .Find to get the selected diva from the list 
                    Diva divaSelected = DivaList.Find(y => y.Id == userSelection);
                    Console.WriteLine(divaSelected.Name + "'s best song is: " + divaSelected.BestSong + " and she's from " + divaSelected.HomeTown);
                    //after picking number, output will display hometown and best song 
                }
                else
                {
                    //in case user inputs invalid data 
                    Console.WriteLine("Nope! try again!");
                }
                Console.WriteLine("want to pick another?");
                input = Console.ReadLine();
            }
            while (input == "yass");
        }
    }
}

