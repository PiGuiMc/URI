var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var val1 = lines.shift().split(' ')

var x = parseInt(val1[0])
var y = parseInt(val1[1])

var val = lines.shift().split(' ')

var a = []
var sum = 0;
for(let i=0; i<y; i++){
    a[i] = val[i]
}

for(let i=1;i<y;i++)
{
    if(a[i]>a[i-1])
    sum = (a[i] - a[i-1]);
    else
    sum = (a[i-1] - a[i]);
    if(sum<=x)
    flag=1;
    else
    {
        flag=0;
        break;
    }
}
if(flag==1){
    console.log("YOU WIN");
}else{
    console.log("GAME OVER");
    }
