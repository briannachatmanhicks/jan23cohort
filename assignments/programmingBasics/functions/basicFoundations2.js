// Biggie Size - Given an array, write a function that changes all positive numbers in the array to the string "big".  Example: makeItBig([-1,3,5,-5]) returns that same array, changed to [-1, "big", "big", -5].
let makeItBig = [-1, 3, 5, -5]
function bigge (arr) {
    for (i = 0; i < arr.length; i++) {
        if (arr[i] > 0) {
            arr[i] = 'big'
        }
    }
    return arr
}
// console.log(bigge(makeItBig))

// Print Low, Return High - Create a function that takes in an array of numbers.  The function should print the lowest value in the array, and return the highest value in the array.

function printLowRtnHi (arr) {
    let low = arr[0]
    let high = arr[0]
    for (i = 0; i < arr.length; i++) {
        if (arr[i] > high) {
            high = arr[i]
        }
        if (arr[i] < low) {
            low = arr[i]
        }
    }
    console.log(low)
    return high
}
// console.log(printLowRtnHi (makeItBig))

// Print One, Return Another - Build a function that takes in an array of numbers.  The function should print the second-to-last value in the array, and return the first odd value in the array.
// let randoArr = [4, 10, 12, 14, 6, 9, -7, -9]
function printOneRtnano (arr) {
    let holdarr = []
    for (i = 0; i < arr.length; i++) {
        if (arr[i] % 2 != 0 ){
            holdarr.push(arr[i])
        }
    }
    console.log (arr[arr.length - 2])
    return holdarr[0]
}
// console.log(printOneRtnano(randoArr)) 

// Double Vision - Given an array (similar to saying 'takes in an array'), create a function that returns a new array where each value in the original array has been doubled.  Calling double([1,2,3]) should return [2,4,6] without changing the original array.
function doublevision(arr) {
    for (i = 0; i < arr.length; i++) {
        arr[i] = arr[i] * 2
    }
    return arr
}
// console.log(doublevision(randoArr))

// Count Positives - Given an array of numbers, create a function to replace the last value with the number of positive values found in the array.  Example, countPositives([-1,1,1,1]) changes the original array to [-1,1,1,3] and returns it.
function countpos(arr) {
    let count = 0
    for (i = 0; i < arr.length; i++) {
        if ( arr[i] > 0) {
            count = count + 1
        }    
    }
    arr[arr.length-1] = count
    return count
}
// console.log(countpos(randoArr))

// Evens and Odds - Create a function that accepts an array.  Every time that array has three odd values in a row, print "That's odd!".  Every time the array has three evens in a row, print "Even more so!".
let randoArr = [4, 10, 12, 14, 6, 9, -7, -9]
function evenNdOdd (arr) {
    let veryOdd = 0
    let evenSo = 0
    for (i = 0; i < arr.length; i++) {
        if (arr[i] % 2 != 0) {
            veryOdd = veryOdd + 1
            if (veryOdd % 3 == 0){
                console.log ("That's odd!")
            }
        }
        else if (arr[i] % 2 == 0) {
            evenSo = evenSo + 1
            // console.log("evenSo", evenSo)
            if (evenSo % 3 == 0) {
                console.log("Even more so!")
            }
        }
    }
}
// evenNdOdd(randoArr)


// Increment the Seconds - Given an array of numbers arr, add 1 to every other element, specifically those whose index is odd (arr[1], arr[3], arr[5], etc).  Afterward, console.log each array value and return arr.
function increments(arr) {
    for (i = 0; i < arr.length ; i++){
        if (i % 2 == 1){
            arr[i] = arr[i] + 1
        }
        console.log(arr[i])
    }
    return arr
}
// console.log(increments(randoArr))

// Previous Lengths - You are passed an array (similar to saying 'takes in an array' or 'given an array') containing strings.  Working within that same array, replace each string with a number - the length of the string at the previous array index - and return the array.  For example, previousLengths(["hello", "dojo", "awesome"]) should return ["hello", 5, 4]. Hint: Can for loops only go forward?
let arrStr = ['hello', 'dojo', 'awesome', 'goodbye']
function previousLengths (arr) {
    for (let i = arr.length -1; i >= 0; i--) {
        if (i != 0) {
        // console.log(arr[arr[i-1].length]) // length is coming back as undefined??
        // console.log(arr[i - 1].length)
        arr[i] = arr[i - 1].length
    }
    }
    return arr
}
console.log(previousLengths(arrStr))
// let str = 'hello'
// console.log(arrStr[1 -1].length)
// Remember when you optimized the code the if statement wasn’t needed. This is what you had me to code and it works:
// function previousLengths(arr){
//   for(let i = arr.length - 1; i > 0; i--){
//     arr[i] = arr[i - 1].length
//   }
//   return arr
// }

// Add Seven - Build a function that accepts an array. Return a new array with all the values of the original, but add 7 to each. Do not alter the original array.  Example, addSeven([1,2,3]) should return [8,9,10] in a new array.
function addSeven (arr) {
    let newArr = []
    for (i = 0; i < arr.length; i++) {
        arr[i] = arr[i] + 7
        newArr.push(arr[i])
    }
    return newArr
}
// console.log(addSeven(randoArr))

// Reverse Array - Given an array, write a function that reverses its values, in-place.  Example: reverse([3,1,6,4,2]) returns the same array, but now contains values reversed like so... [2,4,6,1,3].  Do this without creating an empty temporary array.  (Hint: you'll need to swap values).
let rvr = [3, 1, 6, 4, 2]
function reverseArr (arr) {
    let leftSide = 0
    let rightSide = arr.length - 1
    while (leftSide < rightSide){
        let temp = arr[leftSide]
        arr[leftSide] = arr[rightSide]
        arr[rightSide] = temp

        leftSide ++ //moves the index towards the center to compare
        rightSide --
    }
    return arr
}

function reverseArrEasy (arr) {
    arr.reverse()
    return arr
}
// console.log(reverseArr(rvr))

// Outlook: Negative - Given an array, create and return a new one containing all the values of the original array, but make them all negative (not simply multiplied by -1). Given [1,-3,5], return [-1,-3,-5].
function allNegs (arr) {
    for(i = 0; i < arr.length; i++){
        if (arr[i] > 0){
            arr[i] = arr[i] * -1
        }
    }
    return arr
}
// console.log(allNegs(randoArr))

// Always Hungry - Create a function that accepts an array, and prints "yummy" each time one of the values is equal to "food".  If no array values are "food", then print "I'm hungry" once.
let gettingFat = [1 ,3 ,4 ,5, 'food', 'food']
function alwaysHungry (arr) {
    let hangry =0
    for (i = 0; i< arr.length; i++) {
        if (arr[i] == 'food'){
            console.log("yummy")
        }
        if (arr[i] != 'food') {
            hangry = hangry + 1
            if (hangry == arr.length -1){ 
            console.log("I'm hungry")
            }
        }
    } //when something is being printed, there usually isn't a return statement
}
// console.log(alwaysHungry(gettingFat)) -- this has the right answer, but undefined is right underneth it because nothing has been returned
// alwaysHungry(gettingFat)


// Swap Toward the Center - Given an array, swap the first and last values, third and third-to-last values, etc.  Example: swapTowardCenter([true,42,"Ada",2,"pizza"]) turns the array into ["pizza", 42, "Ada", 2, true].  swapTowardCenter([1,2,3,4,5,6]) turns the array into [6,2,4,3,5,1].  No need to return the array this time.
function swapTwCen (arr) {
    for (i = 0; i < arr.length; i++){
        if (i == 0) {
            let temp = arr[i]
            arr[i] = arr[arr.length-1]
            arr[arr.length-1] = temp
        }
        if (i == 2) {
            let temp = arr[i]
            arr[i] = arr[arr.length-3]
            arr[arr.length-3] = temp
        }
    }
    console.log(arr)
}
// swapTwCen ([1,2,3,4,5,6])

// Scale the Array - Given an array arr and a number num, multiply all values in the array arr by the number num, and return the changed array arr.  For example, scaleArray([1,2,3], 3) should return [3,6,9].

function scaleArr (arr, numN) {
    for (i = 0; i < arr.length; i++) {
        arr[i] = arr[i] * numN
    }
    return arr
}
// console.log(scaleArr(randoArr, 2))