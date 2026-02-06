Wizard wizardA = new Wizard("Mak Lampir", 5);
Wizard wizardB = new Wizard("Nirmala", 10);
 
Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Staistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

wizardA.Attack(wizardB);
wizardB.Attack(wizardA);
wizardA.Attack(wizardB);

Console.WriteLine("Permainan Selesai....\n");
Console.WriteLine("Statistik Akhir");
wizardA.ShowStats();
wizardB.ShowStats();


public class Wizard
{
    //deklarasi field 
    public string Name;
    public int Energy;
    public int Damage;

    //constructor

    public Wizard(string name, int damage)
    {
        Name = name;
        Energy = 100;
        Damage = damage;
    }

    // deklarasi method 
    public void ShowStats()
    { 
        Console.WriteLine($"Nmae: {Name}");
        Console.WriteLine($"Energy: {Energy}\n");
    }

    public void Attack(Wizard enemyobj)
    {
        enemyobj.Energy -= Damage;
        Console.WriteLine($"{Name}menyerang{enemyobj.Energy}");
        Console.WriteLine($"Sisa energi {enemyobj.Name} {enemyobj.Energy}\n");

    }


}
