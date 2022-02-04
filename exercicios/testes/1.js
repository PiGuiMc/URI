var input = require('fs').readFileSync('stdin','utf8')
let lines = input.split('\n');

const [precoAlcool, precoGasolina, rendimentoAlcool, rendimentoGasolina] = 
  lines[0].split(' ').map(x => parseFloat(x));

const precoPorKmAlcool =    precoAlcool       /         rendimentoAlcool   ;
const precoPorKmGasolina =  rendimentoGasolina     /     precoGasolina      ;

const maisEconomico = precoPorKmGasolina <= precoPorKmAlcool ? 'G' : 'A';

console.log(maisEconomico);