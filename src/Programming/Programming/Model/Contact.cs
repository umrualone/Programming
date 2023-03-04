public class Contact
{
    private string firstName;
    private string lastName;
    private int number;

    public Contact(string firstName, string lastName, int number)
    {
        FirstName = firstName;
        LastName = lastName;
        Number = number;
    }

    public Contact()
    {
        FirstName = null;
        LastName = null;
        Number = 0;
    }
    public string FirstName
    {
        get => firstName;
        set => firstName = value;
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value;
    }

    public int Number
    {
        get => number;
        set => number = value;
    }
}
