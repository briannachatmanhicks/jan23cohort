// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Build the Attack class
    //Shown in Attack.cs
// Build the Enemy class

// Create an instance of an Enemy in Program.cs
Enemy Fireball = new Enemy("Fireball");
Console.WriteLine($"I am a new enemy named {Fireball.Name}");

// Create 3 instances of Attacks in Program.cs
Attack Kick = new Attack("Kick", 5);
Attack Punch = new Attack ("Punch", 15);
Attack NeckTwist = new Attack ("Neck Twist", 25);
Console.WriteLine(Kick.Name);

// Add these Attacks to your Enemy instance's Attack List
Fireball.AttackList.Add(Kick.Name);
Fireball.AttackList.Add(Punch.Name);
Fireball.AttackList.Add(NeckTwist.Name);

// Call on your Enemy's RandomAttack method to test that they can now perform the given Attacks
Fireball.RandomAttack();
// Bonus: Practice good programming by making the Enemy's Health attribute private and adding a Public version that lets us just see the value of private health

// Bonus: Write a method for adding Attacks to your Enemy's AttackList rather than having to call on the List's Add method in Program.cs