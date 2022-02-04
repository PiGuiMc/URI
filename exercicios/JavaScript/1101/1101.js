var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

while(true){
    var teste = []
    var maior=0, menor=0, soma=0;
    var line1 = lines.shift().split(' ');
    var x = parseInt(line1[0]);
    var y = parseInt(line1[1]);

    if(x <= 0 || y <= 0){
        break;
    }

    if(x > y){
        maior = x;
        menor = y;
    }else{
        maior = y;
        menor = x;
    }

    for(let i=menor; i<=maior; i++){
        teste.push(i);
        soma += i;
    }

    console.log(teste.join(' ') + " Sum=" + soma)
}