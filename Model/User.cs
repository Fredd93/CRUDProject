using System;

public class User
{
    public int Id { get; set; }
    public string Name { get { return firstName + " " + lastName; } }
    public string firstName;
    public string lastName;
    public string username; //this probably doesn't need to be stored here
    public Role role;
    public string email;
    public string password; //this probably doesn't need to be stored here
    public User()
	{

	}
}
