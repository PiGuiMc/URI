const { parse } = require('path/posix');

var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var valor = parseFloat(lines.shift());

var n_Salario = parseFloat(0);
var reajuste = parseFloat(0);

if(valor > 0 && valor <= 400){
    reajuste = valor * 0.15;
    n_Salario = reajuste + valor;
    console.log("Novo salario: " + n_Salario.toFixed(2));
    console.log("Reajuste ganho: " + reajuste.toFixed(2));
    console.log("Em percentual: 15 %")
}else if(valor > 400 && valor <= 800){
    reajuste = valor * 0.12;
    n_Salario = reajuste + valor;
    console.log("Novo salario: " + n_Salario.toFixed(2));
    console.log("Reajuste ganho: " + reajuste.toFixed(2));
    console.log("Em percentual: 12 %")
}else if(valor > 800 && valor <= 1200){
    reajuste = valor * 0.10;
    n_Salario = reajuste + valor;
    console.log("Novo salario: " + n_Salario.toFixed(2));
    console.log("Reajuste ganho: " + reajuste.toFixed(2));
    console.log("Em percentual: 10 %")
}else if(valor > 1200 && valor <= 2000){
    reajuste = valor * 0.07;
    n_Salario = reajuste + valor;
    console.log("Novo salario: " + n_Salario.toFixed(2));
    console.log("Reajuste ganho: " + reajuste.toFixed(2));
    console.log("Em percentual: 7 %")
}else if(valor > 2000){
    reajuste = valor * 0.04;
    n_Salario = reajuste + valor;
    console.log("Novo salario: " + n_Salario.toFixed(2));
    console.log("Reajuste ganho: " + reajuste.toFixed(2));
    console.log("Em percentual: 4 %")
}