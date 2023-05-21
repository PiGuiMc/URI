var input = require("fs").readFileSync("stdin","utf-8");
var lines = input.split("\n");

/*
area = 3.14*diametro²

volume = area * altura



*/

while(lines.length > 0){
    var volume, diametro, area, altura, raio;
    
        volume = parseFloat(lines.shift()) 
        diametro = parseFloat(lines.shift());

        raio = diametro/2
        area = 3.14 * (raio * raio)
        altura = volume/area
        console.log(`ALTURA = ${parseFloat(altura).toFixed(2)}`)
        console.log(`AREA = ${parseFloat(area).toFixed(2)}`)
}