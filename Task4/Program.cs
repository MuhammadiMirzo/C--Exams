var userss = new User[5];

var user1 = new User();
user1.FirstName = "Mancho";
user1.LastName = "Safariyon";
user1.Password = "pas";
user1.Username="log";
userss[0]=user1;

var user2 = new User();
user2.FirstName = "Said";
user2.LastName = "Majid";
user2.Password = "pass";
user2.Username="logi";
userss[1] = user2;

var user3 = new User();
user3.FirstName = "Zafar";
user3.LastName = "Jura";
user3.Password = "parol";
user3.Username="login";
userss[2] = user3;

while (true)
{
    System.Console.Write("username: ");
  string username = Console.ReadLine();
  System.Console.Write("password: ");
  string password = Console.ReadLine();

  for (int i=0; i<3;i++)
  {
      if(username == userss[i].Username && password==userss[i].Password)
      {
        System.Console.WriteLine(userss[i].GetInfo());
      }      
  }
  
}