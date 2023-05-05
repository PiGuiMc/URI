var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var i = 1;
var x = parseInt(lines.shift())

while(i<=x){
    var p1,p2 = 0;
    if(i<x){op = lines.shift().split(' ')
    p1 = op[0]
    p2 = op[1].slice(0,op[1].length - 1)
    }else{op = lines.shift().split(' ')
        p1 = op[0]
        p2 = op[1]}
    
    r1 = 'Caso #' + (i) + ': Bazinga!'
    r2 = 'Caso #' + (i) + ': Raj trapaceou!'
    r3 = 'Caso #' + (i) + ': De novo!'

    if(p1 !== p2){
        if(p1 == 'tesoura' && p2 == 'papel'){
            console.log(r1)
        }else if(p1 == 'papel' && p2 == 'tesoura'){
            console.log(r2)}

        if(p1 == 'papel' && p2 == 'pedra'){
            console.log(r1)
        }else if( p1 == 'pedra' && p2 == 'papel'){
            console.log(r2)}

        if(p1 == 'pedra' && p2 == 'lagarto'){
            console.log(r1)
        }else if( p1 == 'lagarto' && p2 == 'pedra'){
            console.log(r2)}
        if(p1 == 'lagarto' && p2 == 'Spock'){
            console.log(r1)
        }else if( p1 == 'Spock' && p2 == 'lagarto'){
            console.log(r2)}

        if(p1 == 'Spock' && p2 == 'tesoura'){
            console.log(r1)
        }else if( p1 == 'tesoura' && p2 == 'Spock'){
            console.log(r2)}
    
        if(p1 == 'tesoura' && p2 == 'lagarto'){
            console.log(r1)
        }else if( p1 == 'lagarto' && p2 == 'tesoura'){
            console.log(r2)}
    
        if(p1 == 'lagarto' && p2 == 'papel'){
            console.log(r1)
        }else if( p1 == 'papel' && p2 == 'lagarto'){
            console.log(r2)}
    
        if(p1 == 'papel' && p2 == 'Spock'){
            console.log(r1)
        }else if( p1 == 'Spock' && p2 == 'papel'){
            console.log(r2)}

        if(p1 == 'Spock' && p2 == 'pedra'){
            console.log(r1)}
        else if( p1 == 'pedra' && p2 == 'Spock'){
            console.log(r2)}

        if(p1 == 'pedra' && p2 == 'tesoura'){
            console.log(r1)
        }else if( p1 == 'tesoura' && p2 == 'pedra'){
            console.log(r2)}
            i++
    }else{
        console.log(r3);
        i++
    }
}
console.log('\n')
