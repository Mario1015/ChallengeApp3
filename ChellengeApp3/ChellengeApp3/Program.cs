var name = "Ewa";
bool isWoman = true;
var Age = 33;

if (Age < 30 && isWoman == true)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (Age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (Age < 18 && isWoman == false)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}