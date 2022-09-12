double bt = int.Parse(Console.ReadLine());
double nb = int.Parse(Console.ReadLine());
double t;
string g;
double w = 0;
double f = 0;
double sf = 0;

for (int i = 0; i < bt; i++)
{
    g = Console.ReadLine();
    if (g == "W")
    {
        w++;
    }
    else if (g == "F")
    {
        f++;
    }
    else if (g == "SF")
    {
        sf++;
    }
}
double pr =( w+f+sf )/ 100;
Console.WriteLine(nb + (w * 2000) + (f * 1200) + (sf * 720));
Console.WriteLine(((w * 2000) + (f * 1200) + (sf * 720)) / bt);
Console.WriteLine(w/pr);
