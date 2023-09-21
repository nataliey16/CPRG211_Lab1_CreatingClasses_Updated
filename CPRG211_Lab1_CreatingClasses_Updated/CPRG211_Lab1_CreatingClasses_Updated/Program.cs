// Create 4 Person Objects
using Lab1_Creating_Classes;
using System;

Person person1; //Call the class Person and create an object called person1
person1 = new Person(1, "Ian", "Brooks", "Red", 30, true); //Create a new instance of that object 

Person person2;
person2 = new Person(2, "Gina", "James", "Green", 18, false);

Person person3;
person3 = new Person(3, "Mike", "Briscoe", "Blue", 45, true);

Person person4;
person4 = new Person(4, "Mary", "Beals", "Yellow", 28, true);



//Display Gina's information  
string ginasInformation = person2.DisplayPersonInfo();
Console.WriteLine(ginasInformation);


//Display all of Mike’s information as a list.

string mikesInformation = person3.ToString();
Console.WriteLine(mikesInformation);



//Change Ian’s Favorite Colour to white, and then print his information as a sentence.
string newFavoriteColour = person1.ChangeFavoriteColour();
person1.FavoriteColour = newFavoriteColour;

string iansInformation = person1.DisplayPersonInfo();
Console.WriteLine(iansInformation);




//Display Mary’s age after ten years.
string marysAgeInTenYears = person4.GetAgeInTenYears();
Console.WriteLine(marysAgeInTenYears);




//Create Relationship object 
Relation relationshipType1 = new Relation("sisters", person2, person4);
Relation relationshipType2 = new Relation("brothers", person1, person3);

string relationship1 = relationshipType1.ShowRelationShip();
Console.WriteLine(relationship1);

string relationship2 = relationshipType2.ShowRelationShip();
Console.WriteLine(relationship2);



//Add all Person Objects to  list
//Specifies the datatype Person - name of the object, then call the Person Constructor to make this list  
List<Person> people = new List<Person>();

people.Add(person1);
people.Add(person2);
people.Add(person3);
people.Add(person4);

int sum = 0;
foreach (Person person in people)
{
    sum += person.Age;
}

double avgAgeOfPersonsList = sum / 4;
Console.WriteLine($"The average age of all the people is {avgAgeOfPersonsList}.");


//Find the youngest person and the oldest person

int minAge = int.MaxValue;
string youngestPerson = null;

foreach (Person person in people)
{
    if (person.Age < minAge)
    {
        minAge = person.Age;
        youngestPerson = person.FirstName;

    }

}

Console.WriteLine($"The youngest person is {youngestPerson}.");

int maxAge = int.MinValue;
string oldestPerson = null;

foreach (Person person in people)
{
    if (person.Age > maxAge)
    {
        maxAge = person.Age;
        oldestPerson = person.FirstName;
    }
}

Console.WriteLine($"The oldest person is {oldestPerson}.");



//The names of the people whose first names start with M

var peopleWithFirstNamesM = people.Where(person => person.FirstName.StartsWith("M")).ToList();


foreach (Person person in peopleWithFirstNamesM)
{
    Console.WriteLine(person);
}



var peopleWithFavoriteColourBlue = people
    .Where(person => person.FavoriteColour != null && person.FavoriteColour.Contains("blue", StringComparison.OrdinalIgnoreCase))
.ToList();

foreach (Person person in peopleWithFavoriteColourBlue)
{
    Console.WriteLine(person);
}




Console.ReadLine();
