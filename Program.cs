// See https://aka.ms/new-console-template for more information

class Program {
    static void Main(){
        Human human1 = new Human("Guerrero", 10, 100, 5, 100);
        Wizard wizard1 = new Wizard("Mago", 5, 5);
        Samurai samurai1 = new Samurai("samuraix", 20, 15, 30);

        Console.WriteLine("Estado inicial:");
        Console.WriteLine($"{human1.Name}: Salud = {human1.Health}");
        Console.WriteLine($"{wizard1.Name}: Salud = {wizard1.Health}");
        Console.WriteLine($"{samurai1.Name}: Salud = {samurai1.Health}");

        wizard1.Attack(human1);
        human1.Attack(wizard1);
        wizard1.Heal(wizard1);
        human1.Attack(samurai1);
        samurai1.Attack(human1);
        samurai1.Meditate();
        

        Console.WriteLine("\nEstado después de las acciones:");
        Console.WriteLine($"{human1.Name}: Salud = {human1.Health}");
        Console.WriteLine($"{wizard1.Name}: Salud = {wizard1.Health}");
        Console.WriteLine($"{samurai1.Name}: Salud = {samurai1.Health}");



        Ninja ninja = new Ninja("AlexisSanchez", 10, 5, 100);
        Human objetivo = new Human("Enemigo", 10, 15, 12, 100);

        ninja.Steal(objetivo);

        Console.WriteLine($"Salud de {ninja.Name}: {ninja.Health}");
        Console.WriteLine($"Salud de {objetivo.Name}: {objetivo.Health}");

    }

}