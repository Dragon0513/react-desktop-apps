document.documentElement.className += ' web';
window.nativeHost = {
    quit: function () {
        window.close();
    },
    showAbout: function () {
        alert("MyApp - ServiceStack + React");
    },
    ready: function () { },
    toggleFormBorder: function () { }
};
