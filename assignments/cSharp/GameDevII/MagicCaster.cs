// Health starts at a default of 80
// Attacks:
    // Fireball, 25 damage
    // Lightning Bolt, 20 damage
    // Staff Strike, 10 damage
// Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end

class MagicCaster : Enemy 
{
    public MagicCaster (string theEnemyName) : base (theEnemyName) 
    {
        Health = 80;
        MaxHealth = 80;
        AttackList = new List<Attack> {
            new Attack ("Fireball", 25),
            new Attack ("Lightning Bolt", 20),
            new Attack ("Staff Strike", 10)
        };
    }

    public int Heal(Enemy Target){
        Console.WriteLine ($"Original Target Health: {Target.Health}");
        Console.WriteLine ($"Target Max Health {Target.MaxHealth}");
        int NewHealthStatus = Target.Health += 40;
        if (NewHealthStatus > Target.MaxHealth){
            Target.Health = Target.MaxHealth;
        } else {
            Target.Health += 40;
        }
        Console.WriteLine($"New Target Health: {Target.Health}");
        return Target.Health;
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack){
        base.PerformAttack(Target, ChosenAttack);
        Console.WriteLine("THE POWER OF MAGIC");
    }
}