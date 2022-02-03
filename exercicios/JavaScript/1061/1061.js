var input = require('fs').readFileSync('stdin','utf8')
var lines = input.split('\n');

var dia1 = lines.shift().split(' ')
var Data1 = parseInt(dia1[1])

var tempo1 = lines.shift().split(' ')
var Hora1 = parseInt(tempo1[0])
var Min1 = parseInt(tempo1[2])
var Seg1 = parseInt(tempo1[4])

var dia2 = lines.shift().split(' ')
var Data2 = parseInt(dia2[1])

var tempo2 = lines.shift().split(' ')
var Hora2 = parseInt(tempo2[0])
var Min2 = parseInt(tempo2[2])
var Seg2 = parseInt(tempo2[4])

var minuto_seg= 60;
var hora_seg = minuto_seg * 60;
var dia_seg = hora_seg * 24;

var tempo_1 = Seg1 + Min1*minuto_seg + Hora1*hora_seg + Data1*dia_seg;
var tempo_2 = Seg2 + Min2*minuto_seg + Hora2*hora_seg + Data2*dia_seg;
            
if (tempo_1 < tempo_2){
    var tempo = tempo_2 - tempo_1;
    var dias = parseInt(tempo/dia_seg);

    tempo = tempo%dia_seg;
    var horas = parseInt(tempo/hora_seg);

    tempo = tempo%hora_seg;
    var minutos = parseInt(tempo/minuto_seg);
                
    tempo = tempo% minuto_seg;
    var segundos = tempo;

    console.log(dias + " dia(s)\n" + horas + " hora(s)\n" + minutos + " minuto(s)\n" + segundos + " segundo(s)");
}