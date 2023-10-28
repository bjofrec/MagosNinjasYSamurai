class Samurai : Human 
{
    public Samurai(string name, int str, int intel, int dex): base(name, str, intel, dex, 200){

    }

    public override int Attack(Human objetivo){
        base.Attack(objetivo);
        if(objetivo.Health < 50){
            objetivo.Health = 0;
        }
        Console.WriteLine($"{objetivo.Name} ahora tiene {objetivo.Health} puntos de salud.");
        return objetivo.Health;
    }

    public void Meditate(){
        Health = 100;
        Console.WriteLine($"{Name} usó la meditación para restaurar su vida al máximo");
    }

}

