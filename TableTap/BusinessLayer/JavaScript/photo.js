(function () {
    var video = document.getElementById('video'),
        vendorURL = window.URL || window.webkitURL;

    navigator.getMedia =    navigator.getUserMedia ||
                            navigator.webkitGetUserMedia ||
                            navigator.mozGetUserMedia ||
                            navigator.msGetUserMedia;

    navigator.getMedia({
        video: true,
        audio: false
    }, function (stream) {
        video.src = vendorURL.createObjectURL(sream);
        video.play();
    }, function (error) {
        //an error occurred
        //error.code
    });
})();