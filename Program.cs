
using System.Text.RegularExpressions;
object[] Users = new object[0];
Console.WriteLine(" \t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t                                              Creat the registr");
string username, name, surname, age, email, password, phone_number;
username = Console.ReadLine();
Console.Write(" Please enter username ");
name = Console.ReadLine();
Console.Write(" Please enter name ");
surname = Console.ReadLine();
Console.Write(" Please enter surname ");
age = Console.ReadLine();
Console.Write(" Please enter age ");
email = Console.ReadLine();
Console.Write(" Please enter email ");
password = Console.ReadLine();
Console.Write(" Please enter password ");
phone_number = Console.ReadLine();
Console.Write(" Please enter phone_number ");


Regex username_Regex = new Regex(@"^[a-z]\S");
Regex name_Regex = new Regex(@"^[A-Z]{1}[a-z]{1,14}$");
Regex age_Regex = new Regex(@"\d");
Regex email_Regex = new Regex(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$");
Regex password_Regex = new Regex(@"\w");
Regex phone_number_Regex = new Regex(@"^\+994\-[0-9]{2}\-[0-9]{3}\-[0-9]{2}\-[0-9]{2}");

Match username_1 = username_Regex.Match(username);
Match name_2 = name_Regex.Match(name);
Match surname_3 = name_Regex.Match(surname);
Match age_4 = age_Regex.Match(age);
Match email_5 = email_Regex.Match(email);
Match password_6 = password_Regex.Match(password);
Match phone_number_7 = phone_number_Regex.Match(phone_number);

if (username_1.Success && name_2.Success && surname_3.Success && age_4.Success && email_5.Success && password_6.Success && phone_number_7.Success)
{
    var User = new { username = username, name = name, surname = surname, age = age, email = email, password = password, phone_number = phone_number };
    Array.Resize(ref Users, Users.Length + 1);
    Users[Users.Length - 1] = User;
    Console.WriteLine("User created !");

}
else
{
    Console.WriteLine(" Users not created !");
}



