using System.Threading.Channels;

Wizard wizardA = new Wizard("Mak Lampir", 5);
Wizard wizardB = new Wizard("Nirmala", 10);
 
Console.WriteLine("Permainan Dimulai...\n");
Console.WriteLine("Staistik Awal");
wizardA.ShowStats();
wizardB.ShowStats();

//wizardA.Attack(wizardB);
//wizardB.Attack(wizardA);
//wizardA.Attack(wizardB);
//wizardA.Heal();

string pilihan;
while (true)
{
    Console.WriteLine($"1.  {wizardA.Name} menyerang {wizardB.Name}");
    Console.WriteLine($"2.  {wizardB.Name} menyerang {wizardA.Name}");
    Console.WriteLine($"{wizardA.Name} Melakukan Heal");
    Console.WriteLine($"{wizardB.Name} Melakukan Heal");

    Console.WriteLine("\nPilihan myu (1/2/3/4)");
    pilihan = Console.ReadLine();

    if (pilihan == "1") wizardA.Attack(wizardB);
    else if (pilihan == "2") wizardB.Attack(wizardA);
    else if (pilihan == "3") wizardA.Heal();
    else if (pilihan == "4") wizardB.Heal();

    if (wizardA.Energy <= 0 || wizardB.Energy <= 0)
    {
        Console.WriteLine("Permainan berakhir!");
        if (wizardA.Energy > wizardB.Energy)
        {
            Console.WriteLine($"{wizardB.Name} berhasil dikalahkan");
            Console.WriteLine($"{wizardA.Name} keluar sebagai pemenangnya!");
        }
        else
        {
            Console.WriteLine($"{wizardA.Name} berhasil dikalahkan!");
            Console.WriteLine($"{wizardB.Name} keluar sebagai pemenangnya!");
        }
        break;
    }


}

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
        Console.WriteLine($"{Name} menyerang {enemyobj.Energy}");
        Console.WriteLine($"Sisa energi {enemyobj.Name} {enemyobj.Energy}\n");

    }
    public void Heal()
    {
        if (Energy > 100)
        {
            Energy += 5;
            Console.WriteLine("Gagal melakukan heal, energy suah mencapai maksimum.");
        }
        else
        {
            if (Energy > 95)
            {
                Energy = 100;
            }
            else
            {
                Energy = +5; 
            }
            Console.WriteLine($"{Name} berhasil melakukan heal. energi meningkat menjadi {Energy}"); 
        }
    
    
    }


}
