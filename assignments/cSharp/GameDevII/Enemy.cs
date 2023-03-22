// Enemy fields:
    // Name (i.e. Bandit, Boss, Guard)
    // Health
    // AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
// Constructor: 
    // When an Enemy is created, we must provide their Name upon creation
    // Health will start at a default value of 100
    // AttackList will initialize as an empty List
// Methods:
    // RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)

class Enemy {
    public string EnemyName;
    public int Health;
    public List<Attack> AttackList;
    public int MaxHealth;

    
    public Enemy(string theEnemyName){
        EnemyName = theEnemyName;
        Health = 100;
        MaxHealth = 100;
        AttackList = new List<Attack>();
    }
    public virtual Attack RandomAttack() {
        Console.WriteLine("RandomAttack");
        Random rand = new Random();
        // List<Attack> AttackOpt = AttackList; //Need to understand why my code will not work without this line
        int i = rand.Next(AttackList.Count);

        Console.WriteLine(AttackList[i]);
        return AttackList[i];
    }

    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Console.WriteLine(Target.Health);
        Target.Health = Target.Health - ChosenAttack.DamageAmount;
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.EnemyName}'s health to {Target.Health}!!");
    }
}