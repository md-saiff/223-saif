function add(){
    var fn=parseInt(document.getElementById("Num1").value);
    var ln=parseInt(document.getElementById("Num2").value);
    var a=fn+ln;
    document.getElementById("add").innerHTML=a;
}
function sub(){
    var fn=parseInt(document.getElementById("Num1").value);
    var ln=parseInt(document.getElementById("Num2").value);
    var s=fn-ln;
    document.getElementById("sub").innerHTML=s;
}

function mul(){
    var fn=parseInt(document.getElementById("Num1").value);
    var ln=parseInt(document.getElementById("Num2").value);
    var m=fn*ln;
    document.getElementById("mul").innerHTML=m;
}
    function div(){
        var fn=parseInt(document.getElementById("Num1").value);
        var ln=parseInt(document.getElementById("Num2").value);
        var d=fn/ln;
        document.getElementById("div").innerHTML=d;
    }
