function fun(x) {
    document.getElementById("broj").value = x;
}

function rezervisi() {
    var x = document.getElementsByTagName("input");
    if ((x[0].value == "") || (x[1].value == "") || (x[2].value == "") || (x[3].value == "")) {
        window.alert("Молимо вас да унесете све податке!");
        return;
    }
    var a = document.getElementById("broj").value - 2;
    var b = document.getElementsByClassName("sediste");
    if (b[a].getAttribute("src") == "slike/bus_red.png")
        window.alert("Sediste je zauzeto.");
    else
        b[a].src = "slike/bus_red.png"

    document.getElementById("broj").value = "";
    document.getElementById("ime").value = "";
    document.getElementById("prezime").value = "";
    document.getElementById("email").value = "";
}