var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(lines.length > 1){
        var v = parseInt(lines.shift());
        
        if(v === null){
            break;
        }
        if(v === 0){
            console.log("vai ter copa!")
        }else{
            console.log("vai ter duas!")
        }
}