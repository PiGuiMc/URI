const input = require("fs").readFileSync("stdin","utf8")
const line = input.split("\n");

var km = parseInt(line.shift());
var l =  parseFloat(line.shift());

var media = parseFloat(km / l);

console.log(media.toFixed(3) + " km/l"); 