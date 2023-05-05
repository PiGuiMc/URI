var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var x = parseInt(lines.shift())

for(let i=0; i<x; i++){
  
    var val = lines.shift().split(' ')
    var p1 = val[0]
    var op1 = val[1]
    var p2 = val[2]
    
    var qt = lines.shift().split(' ')

    var qt1 = parseInt(qt[0])
    var qt2 = parseInt(qt[1])

    if(qt1 >= 1 && qt1 <= 1000000000 && qt2 >= 1 && qt2 <= 1000000000){
    if((qt1 + qt2)%2 == 0){
        if(op1 === 'PAR'){
            console.log(p1)
        }else{
            console.log(p2)
        }
    }if((qt1 + qt2)%2 !=0 ){
        if(op1 === 'IMPAR'){
            console.log(p1)
        }else{
            console.log(p2)
        }
    }
}
}