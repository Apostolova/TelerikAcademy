function inStrict() {
    "use strict";

    var browserName = navigator.appName;
    var theLayer;
    var addScroll = false;
    var pX = 0;
    var pY = 0;
    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }
    document.onmousemove = mouseMove;

    if (browserName === "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function mouseMove(evn) {
        if (browserName === "Netscape") {
            pX = evn.pageX - 5;
            pY = evn.pageY;
        }
        else {
            pX = event.x - 5;
            pY = event.y;
        }

        if (browserName === "Netscape") {

            if (document.getElementById.ToolTip.visibility === 'show') {
                new PopTip();
            }
        } else {

            if (document.getElementById.ToolTip.style.visibility === 'visible') {
                new PopTip();
            }
        }
    }

    function PopTip() {
        if (browserName === "Netscape") {
            theLayer = document.getElementById('ToolTip');

            if ((pX + 120) > window.innerWidth) {
                pX = window.innerWidth - 150;
            }
            theLayer.left = pX + 10;
            theLayer.top = pY + 15;
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.getElementById('ToolTip');

            if (theLayer) {
                pX = event.x - 5;
                pY = event.y;

                if (addScroll) {
                    pX = pX + document.body.scrollLeft;
                    pY = pY + document.body.scrollTop;
                }

                if ((pX + 120) > document.body.clientWidth) {
                    pX = pX - 150;
                }
                theLayer.style.pixelLeft = pX + 10;
                theLayer.style.pixelTop = pY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function hideTip() {
        if (browserName === "Netscape") {
            document.getElementById.ToolTip.visibility = 'hide';
        }
        else {
            document.getElementById.ToolTip.style.visibility = 'hidden';
        }
    }

    function hideMenu1() {
        if (browserName === "Netscape") {
            document.getElementById.menu1.visibility = 'hide';
        }
        else {
            document.getElementById.menu1.style.visibility = 'hidden';
        }
    }

    function showMenu1() {
        if (browserName === "Netscape") {
            theLayer = document.getElementById('menu1');
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.getElementById('menu1');
            theLayer.style.visibility = 'visible';
        }
    }

    function hideMenu2() {
        if (browserName === "Netscape") {
            document.getElementById.menu2.visibility = 'hide';
        }
        else {
            document.getElementById.menu2.style.visibility = 'hidden';
        }
    }
    function showMenu2() {
        if (browserName === "Netscape") {
            theLayer = document.getElementById('menu2');
            theLayer.visibility = 'show';
        }
        else {
            theLayer = document.getElementById('menu2');
            theLayer.style.visibility = 'visible';
        }
    }
}