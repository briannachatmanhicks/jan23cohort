// Sigma - Implement function sigma(num) that, given a number, returns the sum of all positive integers up to the given number (inclusive).  Ex: sigma(3) = 6 (or 1+2+3); sigma(5) = 15 (or 1+2+3+4+5).
function sigma (a) {
    let sum = 0
    for (let x = 1; x <= a; x++){
        sum = x + sum
        // console.log(sum)
    }
    return sum
}
// console.log(sigma(5))

// Factorial - Write a function factorial(num) that, given a number, returns the product (multiplication) of all positive integers from 1 up to the given number (inclusive).  For example, factorial(3) = 6 (or 1*2*3); factorial(5) = 120 (or 1*2*3*4*5).
function factorial (a) {
    let product = 1
    for (let x= 1; x <= a; x++){
        product = product * x
        // console.log(product)
    }
    return product
}
// console.log(factorial(5))

// Fibonacci - Create a function to generate Fibonacci numbers.  In this famous mathematical sequence, each number is the sum of the previous two, starting with values 0 and 1.  Your function should accept one argument, an index into the sequence (where 0 corresponds to the initial value, 4 corresponds to the value four later, etc).  Examples: fibonacci(0) = 0 (given), fibonacci(1) = 1 (given), fibonacci(2) = 1 (fib(0)+fib(1), or 0+1), fibonacci(3) = 2 (fib(1) + fib(2)3, or 1+1), fibonacci(4) = 3 (1+2), fibonacci(5) = 5 (2+3), fibonacci(6) = 8 (3+5), fibonacci(7) = 13 (5+8).  
function fibonacci(f) {
    let fib = 0
    let n = 2
    if(f >= 0) {
        fib = f*(n-1) + f  ///////////////////////////////////////////////////////////////////////

 

        return fib
    }
}
console.log(fibonacci(4))
// Array: Second-to-Last: Return the second-to-last element of an array. Given [42, true, 4, "Liam", 7], return "Liam".  If array is too short, return null.
let giveR = [42, true , 4, "Liam"]
let shortR = [3]
function second2last(arr) {
    for (i = 0; i < arr.length; i++) {
        if (arr[arr.length - 2]) {
            return arr[arr.length-1]
        }
        else {
            return null
        }
    }
}
// console.log(second2last(shortR))

// Array: Nth-to-Last: Return the element that is N-from-array's-end.  Given ([5,2,3,6,4,9,7],3), return 4.  If the array is too short, return null.
function nth2last (arr, num) {
    for (i = 0; i < arr.length; i++){
        if (arr[i] == num){
            let nth = 0
            nth = arr.length - 1 - i
            return nth
        }
        if (arr.length < 2) { 
            return null
        }
    }
}
// console.log(nth2last([5,2,3,6,4,9,7],5))

// Array: Second-Largest: Return the second-largest element of an array. Given [42,1,4,3.14,7], return 7.  If the array is too short, return null.
function secondLar (arr) {
    for (i = 0; i < arr.length; i ++) {
        let lar = arr[0]
        if (lar < arr[i]) {
            arr[i] = 0
            lar = arr [i] 
            return lar
        } 
    } 
}
// console.log(secondLar([1,4,45,3.14,7]))

function secondLarr (arr) {
    let lar = arr[0]
    let twoLar = arr[1]
    for (i = 0; i < arr.length; i ++){
        if (arr[i]> lar) {
            lar = arr[i]
        }      
    }
    arr.splice(arr.indexOf(lar),1)

    for (i = 0; i< arr.length; i ++) {
        if (arr[i] > twoLar) {
            twoLar = arr[i]
        }
    }
    return twoLar
}
console.log(secondLarr([1,4,45,3.14,7]))


// Double Trouble: Create a function that changes a given array to list each existing element twice, retaining original order.  Convert [4, "Ulysses", 42, false] to [4,4, "Ulysses", "Ulysses", 42, 42, false, false].
function doubleTrouble (arr) {
    for (i = 0; i < arr.length; i++) {
        arr.splice(i , 0, arr[i])         //// this one is wrong but I don't understand why!! It is an infinate loop because I am a
    }
    console.log(arr)
}
// console.log(doubleTrouble([4, "Ulysses", 42, false]))

function doubleT (arr) {
    let arr2 = []
    for (i = 0; i < arr.length; i++){
        arr2.push(arr[i],arr[i])
    }
    return arr2
}
// console.log(doubleT([4, "Ulysses", 42, false]))