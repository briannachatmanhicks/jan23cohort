// Health starts at a default of 120
// Attacks:
        // Punch, 20 damage
        // Kick, 15 damage
        // Tackle, 25 damage
// Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
// Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?

class Melee : Enemy
{

    public Melee (string theEnemyName) : base (theEnemyName)
    {
        Health = 120;
        MaxHealth = 120;
        AttackList = new List<Attack> {
            new Attack ("Punch", 20),
            new Attack ("Kick", 15),
            new Attack ("Tackle", 25)
        };
    }

    public void RageMethod(Enemy Target) {
        Attack Inst = base.RandomAttack();
        Console.WriteLine($"Random attack chosen {Inst.Name}");
        Console.WriteLine($"Damage amount of attack chosen {Inst.DamageAmount}");
        Console.WriteLine($"Current Health Status of Target {Target.Health}");

        Inst.DamageAmount = Inst.DamageAmount + 10;
        Target.Health = Target.Health - Inst.DamageAmount;
        Console.WriteLine($"New Health Status of Target {Target.Health}");

        // Console.WriteLine(Opponent.Damage)
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack){
        base.PerformAttack(Target, ChosenAttack);
        Console.WriteLine("I GOT HANDS!");
    }

}