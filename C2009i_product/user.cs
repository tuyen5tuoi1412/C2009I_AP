using System;

public class User
{
	//private String fullName;
	//private String email;
	//private String phoneNumber;

    public int Age
    {
        get
        {
            Console.WriteLine("HAHA");
            return DateTime.Now.Year - DateOfBirth.Year;
        }
    }
    public DateTime DateOfBirth { get; set; }
    public String FullName { get; set; }
    public String Email { get; set; }
    public String PhoneNumber { get; set; }

    public override string ToString() =>
        $"name = {this.FullName}, " +
        $",email = {Email}" +
        $",phoneNumber= {PhoneNumber}";
    

}

