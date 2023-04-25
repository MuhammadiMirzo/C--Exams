public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }



    public string GetInfo()
    {
        return FirstName+" "+LastName+" "+Username;
    }

    public string Login(string username,string password)
    {
        if (Username==username && Password==password)
        {
            return "YES";
        }
        else
        {
            return "NO";
        } 
    }
}