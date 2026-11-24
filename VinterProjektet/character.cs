using System.Data.SqlTypes;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Swift;

public class Character
{

    public string _name;
    int _health;
    int _damage;    
    public List<string> inventory = [];
    int _money;

    public int Health
    {
        get => _health;
        set => _health = Math.Clamp(value, 0, 20);
    }

    public int Damage
    {
        get => _damage;
        set => _damage = Math.Clamp(value, 1, 20);
    }

    public int Money 
    {
        get => _money;
        set => _money = Math.Clamp(value, 0, 1000);
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
    }
    public void DealDamage(int enemy_health)
    {
        enemy_health -= Damage;
    }

    public void DisplayStats()
    {
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Damage: {Damage}");
        Console.WriteLine($"Money: {Money}");
        Console.WriteLine($"");
    }

} 




