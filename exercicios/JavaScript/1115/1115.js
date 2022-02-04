var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var line1 = lines.shift().split(' ');

    var x = parseInt(line1[0]);
    var y = parseInt(line1[1]);

    if(x ==0 || y==0){
        break;
    }
    if(x > 0 && y > 0){
        console.log("primeiro");
    }else if(x < 0 && y > 0){
        console.log("segundo");
    }else if(x < 0 && y < 0){
        console.log("terceiro");
    }else if(x > 0 && y < 0){
        console.log("quarto");
    }
}