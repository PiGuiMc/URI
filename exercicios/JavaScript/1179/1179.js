var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var p=0, im=0, j=0;

var par = [], impar = [];

for(let i=0; i<15;i++){
    var valor = parseInt(lines.shift());

    if(valor % 2 == 0){
        par[p] = valor;
        p += 1;
    }else if(valor % 2 !== 0){
        impar[im] = valor;
        im += 1;
    }

    if(par.length == 5 && p == 5){
        while(j<5){
            console.log(`par[${j}] = ${par[j]}`);
            j += 1;
        }
        j = 0;
        p = 0;
        par = [];
    }else if(impar.length == 5 && im == 5){
        while(j<5){
            console.log(`impar[${j}] = ${impar[j]}`);
            j += 1;
        }
        j = 0;
        im = 0;
        impar = [];
    }
}
for(let i=0; i<im; i++){
    if(impar[i] !== undefined){
        console.log(`impar[${i}] = ${impar[i]}`);
    }
}
for(let i=0; i<im; i++){
    if(par[i] != undefined){
        console.log(`par[${i}] = ${par[i]}`);
    }
}