let a = parseFloat(1), b = parseFloat(2), c = parseFloat(3), i = parseFloat(0);

while(i.toFixed(1) <= 2.0){
    if( i == 0 || i == 1 || i > 1.8){
        console.log("I=" + i.toFixed(0) + " J=" + a.toFixed(0));
        console.log("I=" + i.toFixed(0) + " J=" + b.toFixed(0));
        console.log("I=" + i.toFixed(0) + " J=" + c.toFixed(0));

    }else{   
        console.log("I=" + i.toFixed(1) + " J=" + a.toFixed(1));
        console.log("I=" + i.toFixed(1) + " J=" + b.toFixed(1));
        console.log("I=" + i.toFixed(1) + " J=" + c.toFixed(1));
    }
    a += 0.2;
    b += 0.2;
    c += 0.2;
    i += 0.2;
}