using Model.Enums;
using MongoDB.Bson;

public class User
{
    public ObjectId Id { get; set; }
    public string First_Name { get; set; }
    public string Last_Name { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public Roles Role { get; set; }

    // Constructor to initialize a User object
    public User(ObjectId id, string firstName, string lastName, string username, string password, string email, Roles role)
    {
        this.Id = id;
        this.First_Name = firstName;
        this.Last_Name = lastName;
        this.Username = username;
        this.Password = password;
        this.Email = email;
        this.Role = role;
    }

    public User() { }

    // Constructor to handle BSONDocument from MongoDB
    public User(BsonDocument document)
    {
        this.Id = (ObjectId)document["_id"];
        this.First_Name = document.Contains("first_name") ? document["first_name"].AsString : "Unknown";
        this.Last_Name = document.Contains("last_name") ? document["last_name"].AsString : "Unknown";
        this.Username = document.Contains("username") ? document["username"].AsString : "Unknown";
        this.Password = document.Contains("password") ? document["password"].AsString : string.Empty;
        this.Email = document.Contains("email") ? document["email"].AsString : string.Empty;
        this.Role = document.Contains("role") ? (Roles)Enum.Parse(typeof(Roles), document["role"].AsString, true) : Roles.employee;
    }

}
