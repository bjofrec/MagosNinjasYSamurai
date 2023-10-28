class Wizard : Human
{
    public Wizard(string name, int str, int dex) : base(name, str, 25, dex, 50)
    {
    }

    public override int Attack(Human objetivo)
    {
        int daño = Intelligence * 3;
        objetivo.Health -= daño;
        Health += daño;
        Console.WriteLine($"{Name} lanzó un poder a {objetivo.Name} causando {daño} de daño y curándose por {daño}.");
        return objetivo.Health;
    }

    public void Heal(Human objetivo)
    {
        int cura = Intelligence * 3;
        objetivo.Health += cura;
        Console.WriteLine($"{Name} curó a {objetivo.Name} por {cura} puntos de salud.");
    }
}