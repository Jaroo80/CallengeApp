

string name = "Ewa";
int age = 35;
bool Kobieta = true;

if (name == "Ewa" && age == 33 && Kobieta)

{
    Console.WriteLine("Ewa lat 33");
}

else if (Kobieta && age > 30)

    Console.WriteLine("Kobieta po 30-tce");

else if (age < 30 && Kobieta)

    Console.WriteLine("Kobieta poniżej 30 lat");


else if (!(Kobieta) && age < 18)

{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}