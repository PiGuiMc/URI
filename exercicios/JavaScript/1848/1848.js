var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n')

var s = 0;
var c = 0;

while(s != 3){
    
    var n = lines.shift()

    console.log(n)
    if(n == 'caw caw'){
        s = s + 1
        console.log(c)
        c = 0
    }else if(n == '---'){
        c = c + 0
    }else if(n == '--*'){
        c = c + 1
    }else if(n == '-*-'){
        c = c + 2
    }else if (n == '-**'){
        c = c + 3
    }else if (n == '*--'){
            c = c + 4
    }else if(n == '*-*'){
        c = c + 5
    }else if(n == '**-'){
        c = c + 6
    }else if(n == '***'){
        c = c + 7   
    }
}