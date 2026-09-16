Console.Write("Zadaj rok narodenia: ");
string PrveCislo = Console.ReadLine();
int číslo2 = int.Parse(PrveCislo);

int tentorok = DateTime.Now.Year;

int vysledok = tentorok - číslo2;
Console.WriteLine("Tvoj vek: " + vysledok);






