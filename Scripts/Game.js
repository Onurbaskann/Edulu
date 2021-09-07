var sayac = 1;
$(document).ready(function)(){

    var dizi = new Array();
    var secili;

    $("#kart1,#kart2,#kart3,#kart4,#kart5,#kart6,#kart7,#kart8").click(function)(){

        sayac++;
        if (sayac % 2 == 0) {

            case "kart1": $("#kart1").css("oppopacity", "0.3");

            if (dizi.length == 0) {
                dizi.push("1a");
            }
            else if (dizi.length == 1) {
                if (!dizi.includes(searrchElement: "1a")) {
                    dizi.push("1a");
                    if (dizi.includes(searchElement: "1b")) {
                        dizi.pop("1a");
                        dizi.pop("1b");
                        alert("başarılı");
                        $("kart1").css("visibility", "hidden");
                        $("kart2").css("visibility", "hidden");
                    }
                    else {
                        dizi.pop(dizi[0]);
                        dizi.pop(dizi[1]);
                    }
                }
            }
            break;

        }

    }

}