var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var notas = [
    {nota: 0, letra: 'E'},
    {nota: 1, letra: 'D'},
    {nota: 35, letra: 'D'},
    {nota: 36, letra: 'C'},
    {nota: 60, letra: 'C'},
    {nota: 61, letra: 'B'},
    {nota: 85, letra: 'B'},
    {nota: 86, letra: 'A'},
    {nota: 100, letra: 'A'},
]

var v = lines.shift();

for(let i=0; i< 8; i++){

    if(notas[i].nota == v || notas[i].nota < v && notas[i+1].nota > v)
    console.log(notas[i].letra)
}