public class Contact
{
    private string _firstName;
    private string _lastName;
    private int _number;

    public Contact(string firstName, string lastName, int number)
    {
        FirstName = firstName;
        LastName = lastName;
        Number = number;
    }

    public Contact() { }
    
    public string FirstName
    {
        get => _firstName;
        set => _firstName = value;
    }

    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    public int Number
    {
        get => _number;
        set => _number = value;
    }
}