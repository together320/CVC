$(document).ready(function () {
    $('.anger').hide();
    $('.Mac').hide();
});

function GetTerminalName() {
    var name = $("#terminalname").val();

    $.ajax({
        url: '/terminaltab/CheckTerminalName/' + name,
        type: 'GET',
        success: function (d) {
            if (d) {
                $('.anger').text("Terminal name is already exist");
                $('.anger').show();
            } else {
                $('.anger').hide();
            }
        }
    });
}

function GetMacAddress() {
    var Macname = $("#MacAddress").val();

    $.ajax({
        url: '/terminaltab/CheckMackaddress/' + Macname,
        type: 'GET',
        success: function (d) {
            if (d) {
                $('.Mac').text("Mac Address is already exist");
                $('.Mac').show();
            } else {
                $('.Mac').hide();
            }
        }
    });
}    