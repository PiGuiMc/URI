var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var [a,b,c] = lines.shift().split(' ').map(Number);

a = parseInt(a)
b = parseInt(b)
c = parseInt(c)

if((a-b == 0) || (a-c == 0) || (b-c == 0)){
    console.log('S')}

else{
    if((a+b-c == 0) || (b-a+c == 0) || (c-a+b == 0)){
        console.log('S')}
    else if((a-b-c == 0) || (b-a-c == 0) || (c-a-b == 0)){
        console.log('S')
    }else{
        console.log('N')
    }
}
