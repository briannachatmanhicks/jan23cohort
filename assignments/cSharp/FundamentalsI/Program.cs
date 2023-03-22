// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// //Create a loop that prints all values from 1-255
// for(int i = 0; i <=255; i++) {
//     Console.WriteLine(i);
// }

// int i = 0;
// while (i <= 5) {
//     Console.WriteLine(i);
//     i++;
// }

// //Create a loop that generates 5 random numbers between 10 and 20
// Random rand = new Random();
// for (int i=1; i <= 5; i++){
//     Console.WriteLine(rand.Next(10,21));
// }

// int x = 0;
// while (x <= 4) {
//     Console.WriteLine(rand.Next(10,21));
//     x++;
// }



// // Modify the previous loop to add the random values together and print the sum when the loop finishes

// int sum = 0;
// for (int i = 1; i <= 5; i++){
//     // Console.WriteLine(rand.Next(10,21));
//     int randnum = rand.Next(10,21);
//     sum = sum + randnum;
// }
// Console.WriteLine(sum);

// int a = 0;
// int i = 1;
// while (i <= 5) {
//     int randnum = rand.Next(10,21);
//     a = a + randnum;
//     i++;
// }
// Console.WriteLine(a);

// //Create a loop that prints all values from 1-100 that are divisible by 3 or 5, but not both

// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0 || i % 5 == 0) {
//         if (i % 3 == 0 && i % 5 == 0){
//             continue;
//         }
//         Console.WriteLine(i);
//     }
// }

// int z = 1;
// while (z<= 100) {
//     if (z % 3 == 0 || z % 5 == 0) {
//         if (z % 3 == 0 && z % 5 == 0){
//             z++;
//             continue;
//         }
//         Console.WriteLine(z);
//     }
//     z++;
// }

// // create a loop that goes through 1-100
// // use if statement to grab numbers divisible by 3 AND 5 and exclude them


// //Modify the previous loop to print "fizz" for multiples of 3 and "buzz" for multiples of 5
// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0 && i % 5 == 0){
//         continue;
//     }
//     if (i % 3 == 0) {
//         Console.WriteLine("fizz" + i);
//     }
//     if (i % 5 == 0) {
//         Console.WriteLine("buzz" + i);
//     }
    
// }

// int z = 1;
// while (z <= 100) {
//     if (z % 3 == 0 && z % 5 == 0){
//         z++;
//         continue;
//     }
//     if (z % 3 == 0) {
//         Console.WriteLine("fizz" + z);
//     }
//     if (z % 5 == 0) {
//         Console.WriteLine("buzz" + z);
//     }
//     z++;
// }

// //Modify the loop once more to also print "fizzbuzz" for multiples of 3 and 5
// for (int i = 1; i <= 100; i++) {
//     if (i % 3 == 0 && i % 5 == 0){
//         Console.WriteLine($"fizzbuzz, {i}");
//         continue;
//     }
//     if (i % 3 == 0) {
//         Console.WriteLine("fizz" + i);
//     }
//     if (i % 5 == 0) {
//         Console.WriteLine($"buzz, {i}");
//     }
    
// }

// int z = 1;
// while (z <= 100) {
//     if (z % 3 == 0 && z % 5 == 0){
//         Console.WriteLine($"fizzbuzz, {z}");
//         z++;
//         continue;
//     }
//     if (z % 3 == 0) {
//         Console.WriteLine("fizz" + z);
//     }
//     if (z % 5 == 0) {
//         Console.WriteLine("buzz" + z);
//     }
//     z++;
// }