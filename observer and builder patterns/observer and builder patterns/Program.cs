public interface I_weapon { string Name { get; } int Damage { get; } void Attack(); }
public interface I_ranged_weapon : I_weapon { int Range { get; } void Shoot(); }
public interface I_melee_weapon : I_weapon { void Swing(); }
public class Pistol : I_ranged_weapon
{
    public string Name { get; } = "Pistol";
    public int Damage { get; } = 10;
    public int Range { get; } = 20;
    public void Attack() => Shoot();
    public void Shoot() => Console.WriteLine($"{Name} shoots at a range of {Range}!");
}
public abstract class Weapon_decorator : I_weapon
{
    protected I_weapon weapon;
    public Weapon_decorator(I_weapon weapon) => this.weapon = weapon;
    public virtual string Name => weapon.Name;
    public virtual int Damage => weapon.Damage;
    public virtual void Attack() => weapon.Attack();
}
public class Add_percent_damage_decorator : Weapon_decorator
{
    private double damage_percent;
    public Add_percent_damage_decorator(I_weapon weapon, double damagePercent) : base(weapon) => damage_percent = damagePercent;
    public override int Damage => (int)(weapon.Damage * (1 + damage_percent));
    public override void Attack() { Console.WriteLine("Enhanced attack!"); weapon.Attack(); }
}
public class Program
{
    public static void Main()
    {
        I_weapon pistol = new Pistol(); Console.WriteLine($"Original Pistol Damage: {pistol.Damage}"); pistol.Attack();
        I_weapon enhanced_pistol = new Add_percent_damage_decorator(pistol, 0.5); Console.WriteLine($"Enhanced Pistol Damage: {enhanced_pistol.Damage}"); enhanced_pistol.Attack();
    }
}