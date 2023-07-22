var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var x = parseInt(lines.shift());

for(let i=0; i<x; i++){

    var [h,m,o] = lines.shift().split(' ').map(Number)

    if(o == 1){
        if(h < 10 && m < 10){
            console.log(`0${h}:0${m} - A porta abriu!`)
        }else if(h > 9 && m < 10){
            console.log(`${h}:0${m} - A porta abriu!`)
        }else if(h < 10 && m > 9){
            console.log(`0${h}:${m} - A porta abriu!`)
        }else if(h > 9 && m > 9){
            console.log(`${h}:${m} - A porta abriu!`)
        }
    }else if(o == 0){
        if(h < 10 && m < 10){
            console.log(`0${h}:0${m} - A porta fechou!`)
        }else if(h > 9 && m < 10){
            console.log(`${h}:0${m} - A porta fechou!`)
        }else if(h < 10 && m > 9){
            console.log(`0${h}:${m} - A porta fechou!`)
        }else if(h > 9 && m > 9){
            console.log(`${h}:${m} - A porta fechou!`)
        }
    }
}