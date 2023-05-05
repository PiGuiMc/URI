var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

while (lines.length > 0) {
    m = 0;
    classific = 0;

    var n = lines.shift()

    var v = lines.shift().split(' ')

    
    for(let i=0; i<n; i++){
        var val = parseInt(v[i])
        
        if(val>m){
            m=val
        }

        if(m < 10){
            classific = 1;
        }else if(m >= 10 && m < 20){
            classific = 2;
        }else{
            classific = 3;
        }
    }
    console.log(classific);
}