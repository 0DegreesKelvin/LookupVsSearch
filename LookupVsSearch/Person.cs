// -----------------------------------------------------------------------
// <copyright file="Person.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------
public class Person
{
    public Person(string firstname, string lastname)
    {
        this.Firstname = firstname;
        this.Lastname = lastname;
    }

    public string Firstname { get; set; }
    public string Lastname { get; set; }
}