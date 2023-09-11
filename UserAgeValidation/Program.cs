//rakendus küsib kasutajal valida tema sugu (m/f)
//rakendus küsib kasutajal sisestada tema perekonnanime
//lähtudes kasutaja valikust, rakendus tervitab kasutajat järgmiselt:
//"Welcome, Mr. [kasutaja perekonnanimi] / "Welcome, Ms. [kasutaja perekonnanimi]"

Console.WriteLine("Please, select your gender (m/f):");

char userGender = char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid stringe (sõne)

Console.WriteLine("Please, enter your name: ");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}

else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms.{userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}


