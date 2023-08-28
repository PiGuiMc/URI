var input = require('fs').readFileSync('stdin','utf8');
var lines = input.split('\n');

let n = lines.shift();
let soma = 0;

while(n != 0){
    for(let i=0;i<n;i++){
        let [qt,fruta] = lines.shift().trim().split(' ');

        switch(fruta){
            case "suco":
                soma += parseInt(qt) * 120;
                break;
            
            case "morango":
                soma += parseInt(qt) * 85;
                break;

            case "mamao":
                soma += parseInt(qt) * 85
                break;

            case "goiaba":
                soma += parseInt(qt) * 70;
                break;

            case "laranja":
                soma += parseInt(qt) * 50;
                break;

            case "manga":
                soma += parseInt(qt) * 56;
                break;

            case "brocolis":
                soma += parseInt(qt) * 34;
                break;
        }
    }
    if(soma >= 110 && soma <= 130){
        console.log(`${soma} mg`);
    }else if( soma > 130){
        console.log(`Menos ${(130 - soma) * -1} mg`);
    }else if(soma < 110){
        console.log(`Mais ${110 - soma} mg`);
    }

    soma = 0;
    n = lines.shift();
}