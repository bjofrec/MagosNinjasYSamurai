class Human
{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }
     
 
     
    public Human(string name, int str, int intel, int dex, int hp)
    {
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
     

    public virtual int Attack(Human objetivo)
    {
        int dmg = Strength * 3;
        objetivo.Health -= dmg;
        Console.WriteLine($"{Name} atacó a {objetivo.Name} causandole {dmg} de daño!");
        return objetivo.Health;
    }
}