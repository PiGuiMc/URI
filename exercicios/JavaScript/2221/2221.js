var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var t = parseInt(lines.shift());

for(let i=0; i<t;i++){
    var b = parseInt(lines.shift())

    var a1,d1,l1,a2,d2,l2 = 0;

    var golpe1,golpe2 = 0;

    var [a1,d1,l1] = lines.shift().split(" ").map(Number);

    var [a2,d2,l2] = lines.shift().split(" ").map(Number);


    golpe1 = ((parseInt(a1) + parseInt(d1))/2)
    golpe2 = ((parseInt(a2) + parseInt(d2))/2)

    if(l1 % 2 == 0){
        golpe1 += b;
    }if(l2 % 2 == 0){
        golpe2 += b
    }

    if(golpe1 > golpe2){
        console.log('Dabriel');
    }else if(golpe1 < golpe2){
        console.log('Guarte');
    }else{
        console.log('Empate')
    }
}