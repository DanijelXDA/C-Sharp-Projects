function fun(x, y) {
        document.getElementById("naslovfot").innerHTML = y;
        var z = document.getElementsByClassName("ikona");
        document.getElementById("glavna").src = z[x].src;
}