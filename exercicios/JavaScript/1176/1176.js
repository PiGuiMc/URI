var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var t = parseInt(lines.shift());


for(let i=0; i<t;i++){
    var x = parseInt(lines.shift());
    var f = [x+t];
    f[0] = 0;
    f[1] = 1;
                
    if(x>1){
        for(let j=2;j<=x+1;j++){ 
            f[j] = f[j-2]+f[j-1];
            }
                console.log("Fib(%d) = %d",x,f[x]);
            }else if(x<=1){
                console.log("Fib(%d) = %d",x,x);
            }
        }
