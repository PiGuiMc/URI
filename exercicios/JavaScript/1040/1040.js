var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n');

var line1 = lines.shift().split(' ');

var a = parseFloat(line1[0])
var b = parseFloat(line1[1])
var c = parseFloat(line1[2])
var d = parseFloat(line1[3])

var media = (a*2 + b*3 + c*4 + d*1)/10

console.log("Media: " + media.toFixed(1))

if(media >= 7){
    console.log("Aluno aprovado.")
}else if(media >= 5 && media < 7){
    console.log("Aluno em exame.")
    var line2 = lines.shift().split(' ');
    var n_exa =  parseFloat(line2[0])

    console.log("Nota do exame: "+ n_exa.toFixed(1))

    if(((media + n_exa) /2 ) > 5){
        console.log("Aluno aprovado.")
        console.log("Media final: " + ((media + n_exa)/2).toFixed(1))
    }else{
        console.log("Aluno reprovado.")
        console.log("Media final: " + ((media + n_exa)/2).toFixed(1))
    }
}else{
    console.log("Aluno reprovado.")
}