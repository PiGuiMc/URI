var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

var nomes = []
var total_saque,total_bloqueio, total_ataque = 0;
var saque_certo1,bloqueio_certo1,ataque_certo1 = parseInt(0);

saque_certo1 = parseInt(0)
bloqueio_certo1 = parseInt(0)
ataque_certo1 = parseInt(0)
total_saque = parseInt(0)
total_bloqueio = parseInt(0)
total_ataque= parseInt(0)

var n = parseInt(lines.shift());

for(let i=0; i<n; i++){
     var nome = lines.shift();
     nomes.push(nome);
     
     var [saque,bloqueio,ataque] = lines.shift().split(' ').map(Number);

     var [saque_certo,bloqueio_certo,ataque_certo] = lines.shift().split(' ').map(Number);


     total_saque += saque;
     total_bloqueio += bloqueio;
     total_ataque += ataque;
 
     saque_certo1 += saque_certo;
     bloqueio_certo1 += bloqueio_certo;
     ataque_certo1 += ataque_certo;

}

console.log(`Pontos de Saque: ${(saque_certo1/total_saque * 100).toFixed(2)} %.`);
console.log(`Pontos de Bloqueio: ${(bloqueio_certo1/total_bloqueio * 100).toFixed(2)} %.`);
console.log(`Pontos de Ataque: ${(ataque_certo1/total_ataque * 100).toFixed(2)} %.`);