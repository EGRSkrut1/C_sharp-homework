public interface I_Weapon { string Name { get; } int Damage { get; } void Attack(); }
public interface I_Ranged_weapon : I_Weapon { int Range { get; } void Shoot(); }
public interface I_Melee_weapon : I_Weapon { void Swing(); }
public class Pistol : I_Ranged_weapon
{
    public string Name { get; } = "Pistol";
    public int Damage { get; } = 10;
    public int Range { get; } = 20;
    public void Attack() { Shoot(); }
    public void Shoot() { Console.WriteLine($"{Name} shoots at a range of {Range}!"); }
}
public class Sword : I_Melee_weapon
{
    public string Name { get; } = "Sword";
    public int Damage { get; } = 15;
    public void Attack() { Swing(); }
    public void Swing() { Console.WriteLine($"{Name} swings!"); }
}
public class Bow : I_Ranged_weapon
{
    public string Name { get; } = "Bow";
    public int Damage { get; } = 12;
    public int Range { get; } = 30;
    public void Attack() { Shoot(); }
    public void Shoot() { Console.WriteLine($"{Name} shoots an arrow!"); }
}

public class Program
{
    public static void Main()
    {
        Pistol pistol = new Pistol(); Console.WriteLine($"Weapon: {pistol.Name}, Damage: {pistol.Damage}"); pistol.Attack();
        Sword sword = new Sword(); Console.WriteLine($"Weapon: {sword.Name}, Damage: {sword.Damage}"); sword.Attack();
        Bow bow = new Bow(); Console.WriteLine($"Weapon: {bow.Name}, Damage: {bow.Damage}"); sword.Attack();
    }
}