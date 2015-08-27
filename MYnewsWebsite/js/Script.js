
var i = 0;
for (i = 0; i < 35; i++) {
    $(document).ready(function () {
        $('body').append('<div id="div' + (i++) + '" runat="server" />');
    });
}

//<script src="../js/libs/jquery-1.11.1.js"></script>
//    <script src="../js/Script.js"></script>;