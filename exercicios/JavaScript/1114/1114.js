var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var senha = parseInt(lines.shift());

    if(senha == 2002){
        console.log("Acesso Permitido");
        break;
    }else{
        console.log("Senha Invalida");
    }
}