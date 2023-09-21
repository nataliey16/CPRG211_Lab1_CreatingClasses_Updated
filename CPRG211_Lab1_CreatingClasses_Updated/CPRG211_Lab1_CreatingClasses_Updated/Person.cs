using System;

public class Person
{
    //Constants

    //Fields (private)

    private int personId;
    private string firstName;
    private string lastName;
    private string favoriteColour;
    private int age;
    private bool isWorking;



    //Properties (public)

    public int PersonId
    {
        get { return personId; }
        set { personId = value; }

    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }

    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }

    }

    public string FavoriteColour
    {
        get { return favoriteColour; }
        set { favoriteColour = value; }

    }

    public int Age
    {
        get { return age; }
        set
        {

            if (age < 0 && age > 122)
            {
                throw new Exception("Not a valid age.");
            }

            age = value;
        }
    }

    public bool IsWorking
    {
        get { return isWorking; }
        set { isWorking = value; }

    }

    //Constructor
    public Person(int personId, string firstName, string lastName, string favoriteColour, int age, bool isWorking)
    {
        PersonId = personId;
        FirstName = firstName;
        LastName = lastName;
        FavoriteColour = favoriteColour;
        Age = age;
        IsWorking = isWorking;
    }


    //Methods

    public string DisplayPersonInfo()
    {

        string displayPersonInfo = $"{personId}: {firstName} {lastName}'s favorite colour is {favoriteColour}.";

        return displayPersonInfo;

    }

    public string ChangeFavoriteColour()
    {
        string newfavoriteColour = "White";

        return newfavoriteColour;
    }

    public string GetAgeInTenYears()
    {
        int ageInTenYears = age + 10;

        string displayAgeInTenYears = $"{firstName} {lastName} age in 10 years is {ageInTenYears}.";

        return displayAgeInTenYears;

    }

    public override string ToString()
    {
        string personInfoList = $"Person Id: {personId} \n First Name: {firstName} \n Last Name: {lastName} \n Favorite Colour: {favoriteColour} \n Age: {age} \n Working: {isWorking}";
        return personInfoList;

    }
}
