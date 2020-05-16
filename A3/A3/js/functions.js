function fun() {
    var x = document.getElementById("selectgrad").value;
    var url = "https://naslovi.net/vremenska-prognoza/" + x;
    document.getElementById("prognoza").src = url;
}