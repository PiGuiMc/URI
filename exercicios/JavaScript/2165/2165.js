var input = require('fs').readFileSync('stdin.txt','utf8');
var lines = input.split('\n');

var txt = lines.shift()

if(txt.length <= 140){
    console.log('TWEET')
}else{
    console.log('MUTE')
}