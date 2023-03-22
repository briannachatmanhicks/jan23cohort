// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Build the Attack class
    //Shown in Attack.cs
// Build the Enemy class

// // Create an instance of an Enemy in Program.cs
// Enemy Fireball = new Enemy("Fireball");
// Console.WriteLine($"I am a new enemy named {Fireball.Name}");

// // Create 3 instances of Attacks in Program.cs
// Attack Kick = new Attack("Kick", 5);
// Attack Punch = new Attack ("Punch", 15);
// Attack NeckTwist = new Attack ("Neck Twist", 25);
// Console.WriteLine(Kick.Name);

// // Add these Attacks to your Enemy instance's Attack List
// Fireball.AttackList.Add(Kick.Name);
// Fireball.AttackList.Add(Punch.Name);
// Fireball.AttackList.Add(NeckTwist.Name);

// // Call on your Enemy's RandomAttack method to test that they can now perform the given Attacks
// Fireball.RandomAttack();
// Bonus: Practice good programming by making the Enemy's Health attribute private and adding a Public version that lets us just see the value of private health

// Bonus: Write a method for adding Attacks to your Enemy's AttackList rather than having to call on the List's Add method in Program.

Attack Spit = new Attack("Spit", 5);

Melee Me = new Melee ("Me");
Melee Zelda = new Melee ("Zelda");
Zelda.PerformAttack(Me, Spit);
Console.WriteLine("-----------------------------------------");
Console.WriteLine(Me);
Console.WriteLine(Me.Health);
Console.WriteLine(Me.AttackList[1].Name);
Console.WriteLine("-----------------------------------------");
Me.RageMethod(Zelda);

Console.WriteLine("--------Assignment Questions------------");
// Create instances of the Melee, Ranged, and Magic Caster classes
Melee GirlBoss = new Melee ("Girl Boss");
RangedFighter Shooter = new RangedFighter ("Shooter");
MagicCaster Five = new MagicCaster ("Five");
// Perform the Kick Attack from your Melee class character on your Ranged character
GirlBoss.PerformAttack(Shooter, GirlBoss.AttackList[1]);
// Perform the Rage method from your Melee class character on your Magic Caster character
GirlBoss.RageMethod(Five);
// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint) 
Shooter.PerformAttack(GirlBoss, Shooter.AttackList[0]);
// Have your Ranged character perform the Dash method
Shooter.Dash();
// Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
Shooter.PerformAttack(GirlBoss, Shooter.AttackList[0]);
// Perform a Fireball Attack from your Magic Caster on your Melee character
Five.PerformAttack(GirlBoss, Five.AttackList[0]);
// Have the Magic Caster perform the Heal method on the Ranged character
Five.Heal(Shooter);
// Have the Magic Caster perform the Heal method on themselves
Five.Heal(Five);


Console.WriteLine("-----------------------------BONUS");

// Write special Console messages for each fighter's PerformAttack method
    //Melee.cs line 34 - 37
    //RangedFighter.cs line 27-30
    //MagicCaster.cs line 27-30
// You can add even more detail by considering what types of messages would appear for specific attacks
    //RangedFighter.cs line 29-33
// You may have noticed that when you Heal a character they can end up with more health than they started with. Can you think of a clever way to ensure that your character does not go above their maximum health?
    //MagicCaster.cs line 24-32
// Conversely, do you think a character should be able to attack another character who has 0 health? Or that a character with 0 health should be capable of attacking? How can you ensure that a character can only be attacked/perform attacks so long as their health is a positive value?