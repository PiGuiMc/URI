var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

//var dm = [1 31,2 29,3 31,4 30,5 31,6 30,7 31,8 31,9 30,10 31,11 30, 12 31]

var dm = {
    1: 0,
    2: 31,
    3: 60,
    4: 91,
    5: 121,
    6: 152,
    7: 182,
    8: 213,
    9: 244,
    10: 274,
    11: 305,
    12: 335,
};

while(lines.length > 0){
    var op = lines.shift().split(' ')

    var mes = parseInt(op[0])
    var dia = parseInt(op[1])
    var totalDays = dm[mes] + dia;
    var diasFalta = 360 - totalDays;

    if(diasFalta == 0){
        console.log('E natal!');
    }else if(diasFalta == 1){
        console.log('E vespera de natal!')
    }else if(diasFalta < 0){
        console.log('Ja passou!');
    }else if(diasFalta > 1){
        console.log("Faltam " + diasFalta + " dias para o natal!");
    }
}
