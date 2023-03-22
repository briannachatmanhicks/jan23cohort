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
    public string Name;
    public int Health;
    public List<string> AttackList;
    
    public Enemy(string name){
        Name = name;
        Health = 100;
        AttackList = new List<string>();
    }
    public void RandomAttack() {
        Console.WriteLine("RandomAttack");
        Random rand = new Random();
        List<string> AttackOpt = AttackList; //Need to understand why my code will not work without this line
        int i = rand.Next(AttackOpt.Count);

        Console.WriteLine(AttackOpt[i]);
    }
}