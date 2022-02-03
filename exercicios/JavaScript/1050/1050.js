var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var op = {61:"Brasilia", 71:"Salvador", 11:"Sao Paulo", 21:"Rio de Janeiro", 32:"Juiz de Fora", 19:"Campinas", 27:"Vitoria", 31:"Belo Horizonte"}

var cod = lines.shift()

if(op[cod]){
    console.log(op[cod])
}else{
    console.log("DDD nao cadastrado")
}