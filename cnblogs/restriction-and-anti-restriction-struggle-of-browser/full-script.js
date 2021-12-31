(function (window) {
    var eventArr = ["contextmenu", "dragstart", "mouseup", "copy", "beforecopy", "selectstart", "select", "keydown"];
    function runScript(window) {

        try {
            var toItem = window.setTimeout(function () {
                do { window.clearTimeout(toItem) } while (toItem--)
            }, 0) + 1;
            var inItem = window.clearInterval(function () {
                do { window.clearInterval(inItem) } while (inItem--)
            }, 0) + 1;
        } catch (error) {
        }
        
        var document = window["document"], $ = window["jQuery"], unbind = function (ele) {
            eventArr.forEach(function (evt) {

                ele["on" + evt] = null; if ($) { $(ele).unbind(evt) }

                if (ele.style) {
                    if (ele.style.setProperty) {
                        ele.style.setProperty("user-select", "unset", "important")
                    } else {
                        ele.style.userSelect = "unset"
                    }
                }
                try {
                    if (/frame/i.test(ele.tagName)) { runScript(ele.contentWindow) }
                } catch (err) { }
            })
        };

        document.querySelectorAll("video").forEach(function (x) {
            x.remove()
        });

        [window, document].forEach(unbind);

        for (var i = 0, all = document.all, len = all.length; i < len; i++) {
            var ele = all[i];
            if (ele && ele.nodeType === 1) {
                unbind(ele)
            }
        }
    }

    runScript(window)

})(window);