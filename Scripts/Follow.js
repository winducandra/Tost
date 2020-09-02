let waktu = [100, 300, 500, 700, 900, 1100, 13000]

var tagFollow = document.getElementsByTagName('button');
var searchFollow = "Ikuti";
var foundFollow;
function ClickFollow() {
    for (var i = 0; i < tagFollow.length; i++) {
        console.log("checks " + tagFollow[i].textContent);
        if (tagFollow[i].textContent == searchFollow) {
            console.log("pass " + tagFollow[i].textContent);
            foundFollow = tagFollow[i];
            foundFollow.click(); break;
        }
    }
}

var i = 1;
function myLoop() {
    setTimeout(function () {
        console.log(new Date().toLocaleTimeString());
        ClickFollow();
        //document.getElementsByTagName("ul")[3].scrollIntoView(false)
        i++
        if (i <= 10) {
            myLoop();
        }
    }, waktu.sort((elel, elem2) => Math.random() - Math.random())[1])
}
myLoop();
