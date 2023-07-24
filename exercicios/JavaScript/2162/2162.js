var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var m = parseInt(lines.shift());
var mm = lines.shift().split(' ').map(Number);

var v = []

for(let i=1; i<m; i++){
    if(parseInt(mm[i - 1]) > parseInt(mm[i])){
        v+=[1]
        console.log(v)
    }else if(parseInt(mm[i-1]) < parseInt(mm[i])){
        v+=[0]
    }else{
        v+=[2]
    }
}
    
var st = 1

for(let i=0;i<m;i++){
    if(parseInt(v[i]) == parseInt(v[i + 1]) || parseInt(v[i]) == 2 || parseInt(v[i + 1]) == 2){
        st = 2
        break;
    }
}
if( st == 1){
    console.log(1)
}else{
    console.log(0)
}