var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var hi = parseInt(line1[0])
var mi = parseInt(line1[1])
var hf = parseInt(line1[2])
var mf = parseInt(line1[3])

var h = 0, m = 0;

if(hi < hf){
    h = hf - hi;
    if(mi < mf){
        m = mf - mi;
    }else if(mi > mf){
        h = h - 1;
        m = (60 - mi) + mf;
    }else if(mi == mf){
        m = 0;
    }
}
if(hi > hf){
    h = (24 - hi) + hf;
    if(mi < mf){
        m = mf - mi;
    }else if(mi > mf){
        h = h - 1;
        m = (60 - mi) + mf;
    }else if(mi == mf){
        m = 0;
    }
}
if(hi == hf){
    if(mi < mf){
        m = mf - mi;
        h = 0;
    }else if(mi > mf){
        m = (60 - mi ) + mf;
        h = 23;
    }else if(mi == mf){
        h = 24;
        m = 0;
    }
}

console.log("O JOGO DUROU " + h + " HORA(S) E " + m + " MINUTO(S)");
