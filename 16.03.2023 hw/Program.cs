using Coree.Entities;
using Utilss.Exeptions;

User User= new User("magoo_everywhere@mail.ru", "Salam123");

try
{
	Console.WriteLine(User.PasswordChecker("salam1245"));
}
catch (IncorrectPasswordException ex)
{ 
	Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}