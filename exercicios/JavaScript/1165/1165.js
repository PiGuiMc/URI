var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var n = parseInt(lines.shift());


for(let i=0;i<n;i++){

    var num = parseInt(lines.shift()),s=0,j=1;

    while(j<=num){
        if(num%j==0){
            s+=1;
        }
        j+=1;
    }
    if(s > 2){
        console.log("%d nao eh primo",num);
    }else{
       console.log("%d eh primo",num);
    }
}