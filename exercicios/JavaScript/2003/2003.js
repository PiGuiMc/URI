var input = require("fs").readFileSync("stdin",'utf8');
var lines = input.split('\n')

console.log(lines.length)
while(lines.length > 0){
    var v = lines.shift().split(':')

    var hmax = parseInt(v[0]) + 1, mmax = parseInt(v[1])

    var hh = hmax - 8
 
    if(hh < 0){
        console.log('Atraso maximo: 0')
    }else{
        mmax += 60 * hh
        console.log('Atraso maximo: ' + mmax)
    }
}
