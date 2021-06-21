using System;
using static System.Console;
namespace Assignment2
{
    class QutChampionship
    {
        static void Main(string[] args)
        {
            // Varibles
            const double cost = 30.00;
            const int lowest_number = 0;
            const int highest_number = 40;
            const string QUIT = "Z";
            string entry;
            string entry_description = "";
            bool EndProgram = false;


            string[] description = { "Tennis", "Badminton", "Swimming", "Running", "Other" };
            string[] code = { "T", "B", "S", "R", "O" };


            WriteLine("********************** Task 2a ********************** ");
            // Prompts the user for the number of participants
            Write("Input number of participants: ");
            int numParticipants = int.Parse(ReadLine());

            // The program continues to prompt the user until a valid value is entered. 
            while (numParticipants < lowest_number || numParticipants > highest_number)
            {
                Write("Please a valid number between 0 and 40 for the number of participants: ");
                numParticipants = int.Parse(ReadLine());
            }

            //Storing Values
            string[] names = new string[numParticipants];
            string[] event_codes = new string[numParticipants];
            string[] event_description = new string[numParticipants];


            WriteLine("********************** Task 2b ********************** ");
            // The expected revenue is calculated and displayed. 
            WriteLine($"The expected revenue is: {(cost * numParticipants).ToString("C")}.");

            WriteLine("********************** Task 2c ********************** ");
            // Prompts the user for the names and event codes for each participant entered. 
            for (int x = 0; x < numParticipants; x++)
            {
                //Creates new Object
                Athlete myAthlete = new Athlete();

                Write("Enter participants name >> ");

                //Stores Athlete Name
                myAthlete.Name = ReadLine();
                names[x] = myAthlete.Name;

                //Displays the valid event categories
                WriteLine("Event codes are: ");
                for (int i = 0; i < description.Length; i++)
                {
                    WriteLine("{0,3} {1, -3}", code[i], description[i]);
                }
                

                Write("{0,27}", "Enter event code >> ");
                // Stores Athlete Code + Description
                myAthlete.Event_code = ReadLine();
                event_codes[x] = myAthlete.Event_code;
                event_description[x] = myAthlete.Event_description;


            }

            WriteLine("********************** Task 2d ********************** ");
            // Display information of all participants (names, event codes, names of events). 
            for (int x = 0; x < numParticipants; x++)
            {
                WriteLine($"Participant information: Name: {names[x]}, Event Code: {event_codes[x]}, Event Description: {event_description[x]}.");
            }

            WriteLine("********************** Task 2e ********************** ");
            //Displays the valid event categories
            WriteLine("The codes of categories are: ");
            for (int j = 0; j < description.Length; j++)
            {
                WriteLine("{0,3} {1, -3}", code[j], description[j]);
            }

            //Prompts the user for event codes names of all participants in the category.
            Write("Please enter an event code or " + QUIT + " to quit >> ");
            entry = ReadLine();


            while (!EndProgram)
            {

                // Setting the entry description
                if (entry == "T")
                {
                    entry_description = "Tennis";
                }
                else if (entry == "B")
                {
                    entry_description = "Badminton";
                }
                else if (entry == "S")
                {
                    entry_description = "Swimming";
                }
                else if (entry == "R")
                {
                    entry_description = "Running";
                }
                else if (entry == "O")
                {
                    entry_description = "Other";
                }


                if (entry == QUIT)
                {
                    //Ends Program
                    EndProgram = true;
                }


                else if (entry == "T" || entry == "B" || entry == "S" || entry == "R" || entry == "O")
                {

                    Write($"Participants with talent {entry_description} are: ");
                    WriteLine();

                    //Displays the names of all participants in the category
                    for (int i = 0; i < event_codes.Length; i++)
                    {
                        if (event_codes[i] == entry)
                        {
                            WriteLine(names[i]);
                        }
                    }
                    Write("Please enter an event code or " + QUIT + " to quit >> ");
                    entry = ReadLine();

                }

                else
                {
                    //Prompts User for valid event code.
                    WriteLine($"{entry} is not a valid event code.");
                    WriteLine();
                    Write("Please enter an event code or " + QUIT + " to quit >> ");
                    entry = ReadLine();
                }

            }

        }


    }

    class Athlete
    {

        public string Name { get; set; }

        public string Event_description { get; set; }
        private string event_code;
        public string Event_code
        {
            get { return event_code; }
            set
            {
                // Set Event Code 
                if (value == "T" || value == "B" || value == "S" || value == "R" || value == "O")
                {
                    event_code = value;
                }
                else
                {
                    event_code = "I";
                }

                // Set Event_description 
                if (value == "T")
                {
                    Event_description = "Tennis";
                }
                else if (value == "B")
                {
                    Event_description = "Badminton";
                }
                else if (value == "S")
                {
                    Event_description = "Swimming";
                }
                else if (value == "R")
                {
                    Event_description = "Running";
                }
                else if (value == "O")
                {
                    Event_description = "Other";
                }

                else
                {
                    Event_description = "Invalid";
                }
            }
        }

    }// class ends

}



