for(var num = 0; num < 15; num++){
    console.log(num);
}
//Predictions: 
// 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14

for(var i = 1; i < 10; i+=2){
    if(i % 3 == 0){
        console.log(i);
    }
}
//Predictions:
// 3, 9

for(var j = 1; j <= 15; j++){
    if(j % 2 == 0){
        j+=2;
    }
    else if(j % 3 == 0){
        j++;
    }
    console.log(j);
}
// 1, 4, 5, 8, 10, 11, 14, 16 
// 16 would not be included because when the initial condition of the statement is false, the loop has to end. Review Melissa notes on loops and the "checkpoints" for the loop