// Get 1 to 255 - Write a function that returns an array with all the numbers from 1 to 255.
function arr255(){
    let array = []
    for (i = 1; i < 256; i++){
        array.push([i])
    }
    // console.log(array)
    return array
}


// Get even 1000 - Write a function that would get the sum of all the even numbers from 1 to 1000.  You may use a modulus operator for this exercise.
function even1000 (){
    let sum = 0
    for (i = 1; i <= 1000; i++){
        if (i % 2 == 0){
            sum = i + sum
        }
    }
    // console.log(sum)
    return sum
}


// Sum odd 5000 - Write a function that returns the sum of all the odd numbers from 1 to 5000. (e.g. 1+3+5+...+4997+4999).
function odd5000 (){
    let sum = 0
    for (i = 1; i <= 5000; i++){
        if (i % 2 == 1) {
            sum = i + sum
        }
    }
    // console.log(sum)
    return sum
}
// odd5000()


// Iterate an array - Write a function that returns the sum of all the values within an array. (e.g. [1,2,5] returns 8. [-5,2,5,12] returns 14).
let arr01 = [1, 2, 5]
let arr02 = [-5, 2, 5, 12]

function arraySum (arr) {
    let sum = 0
    for (i = 0; i < arr.length; i++){
        sum = arr[i] + sum
    }
    // console.log(sum)
    return arr
}

// arraySum()

// Find max - Given an array with multiple values, write a function that returns the maximum number in the array. (e.g. for [-3,3,5,7] max is 7)
function arrMax (arr2) {
    let max = arr2[0] // has to be outside of for loop to return correctly

    for (i = 1; i < arr2.length; i++){
        if (max < arr2[i]){
            max = arr2[i] //ask about == vs =
        }
    }
    console.log(max)
    return max
}

// arrMax(arr01)

// Find average - Given an array with multiple values, write a function that returns the average of the values in the array. (e.g. for [1,3,5,7,20] average is 7.2)
let arr03 = [1, 3, 5, 7, 20]

function arrAvg (arr3){
    let sum = 0
    for (i = 0; i < arr3.length; i++){
        sum = arr3[i] + sum
    }
    avg = sum / arr3.length
    console.log (avg)
    return avg
}
// arrAvg(arr03)
// Array odd - Write a function that would return an array of all the odd numbers between 1 to 50. (ex. [1,3,5, .... , 47,49]). Hint: Use 'push' method.

function arrOdd (){
    let arrOdd = []
    for (x = 1; x <= 50; x++){
        if (x % 2 == 1){
            arrOdd.push(x)
        }
    }
    console.log(arrOdd)
    return arrOdd
}
// arrOdd();

// Greater than Y - Given value of Y, write a function that takes an array and returns the number of values that are greater than Y. For example if arr = [1, 3, 5, 7] and Y = 3, your function will return 2. (There are two values in the array greater than 3, which are 5, 7).

function gThanY (arr, Y) {
    numOfVal = 0
    for (i = 0; i < arr.length; i++){
        if (Y < arr[i]){
            numOfVal = numOfVal + 1
        }
    }
    return numOfVal
}

// console.log(gThanY (arr03, 5))


// Squares - Given an array with multiple values, write a function that replaces each value in the array with the value squared by itself. (e.g. [1,5,10,-2] will become [1,25,100,4])

function sQs (arr) {
    for (i = 0; i < arr.length; i++){
        arr[i] = arr[i] * arr[i]
    }
    return arr
}

// console.log(sQs(arr03))

// Negatives - Given an array with multiple values, write a function that replaces any negative numbers within the array with the value of 0. When the program is done the array should contain no negative values. (e.g. [1,5,10,-2] will become [1,5,10,0])

let arr05 = [1, 5, 10, -2]
function negs (arr) {
    for (i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            arr.splice (i , 1, 0)
        }
    }
    return arr
}

// console.log(negs(arr05))

// Max/Min/Avg - Given an array with multiple values, write a function that returns a new array that only contains the maximum, minimum, and average values of the original array. (e.g. [1,5,10,-2] will return [10,-2,3.5])

function mMA (arr) {
    let min = arr[0]
    let max = arr [0]
    let sum = 0
    let newR = []
    for (i = 0; i < arr.length; i++){
        if (min > arr[i]) {
            min = arr[i]
        }
        if (max < arr[i]) {
            max = arr[i]
        }
        sum = sum + arr[i]
        avg = sum / arr.length
        
        
    }
    newR.push(min)
    newR.push(max)
    newR.push(avg)
    return newR
}
// console.log(mMA (arr05))

// Swap Values - Write a function that will swap the first and last values of any given array. The default minimum length of the array is 2. (e.g. [1,5,10,-2] will become [-2,5,10,1]).

function switchR (arr) {
    let temp = arr [0] // storing the value of arr[0] in this temp
    // console.log (temp)
    arr [0] = arr [arr.length -1 ] // value of arr[0] now becomes the value to the right
    // console.log (arr [0])
    arr[arr.length -1] = temp //uses the temp to swap values because the org. arr[0] now equals something else
    // console.log (temp)
    // console.log (arr)

    return arr
}
// console.log (switchR (arr05))

// Number to String - Write a function that takes an array of numbers and replaces any negative values within the array with the string 'Dojo'. For example if array = [-1,-3,2], your function will return ['Dojo','Dojo',2].
let exArr = [-1, -3, 2]
function num2Str (arr) {
    for (i = 0; i < arr.length; i++) {
        if (arr[i] < 0) {
            arr[i] = 'Dojo'
        }
    }
    return arr
}

// console.log(num2Str(exArr))