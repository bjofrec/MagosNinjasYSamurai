class Ninja : Human
{
    public Ninja(string name, int str, int intel, int hp) : base(name, str, intel, 75, hp){

    }

    public override int Attack (Human objetivo){
        int daño = Dexterity;
        Random rand = new Random();
        int chance = rand.Next(1,6);
        if(chance == 1){
            daño += 10;
            Console.WriteLine($"{Name} atacó a {objetivo.Name} causando {daño} de daño y causó 10 puntos adicionales de daño.");
        }
        else{
            Console.WriteLine($"{Name} atacó a {objetivo.Name} causando {daño} de daño.");
        }
        objetivo.Health -= daño;
        return objetivo.Health;
    }

    public void Steal (Human objetivo){
        int roboSalud = 5;
        objetivo.Health -= roboSalud;
        Health += roboSalud;
        Console.WriteLine($"{Name} robó {roboSalud} puntos de vida de {objetivo.Name}.");
    }
}