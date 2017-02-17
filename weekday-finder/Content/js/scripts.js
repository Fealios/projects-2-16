var monthNumbers = [31,29,31,30,31,30,31,31,30,31,30,31];

function checkDate(newDate) {
    var regex = /^([0-9]{2})\/[0-9]{2}\/[0-9]{4}/g;
    if(regex.test(newDate)){
        var year = parseInt(newDate.slice(6));
        var month = parseInt(newDate.slice(0,2));
        var day = parseInt(newDate.slice(3,5));
        if (year < 1700 || month > 12){
            return false;
        } else if (day > monthNumbers[month]) {
            return false;
        } else {
            return true;
        }
    } else {
        return false;
    }
}


$(function() {
    $("#date-submit").submit(function(event) {
        event.preventDefault();
    })
    $("#form-submit").click(function() {
        var submittedDate = $("#new-date").val();
        if (checkDate(submittedDate)) {
            $("#date-submit")[0].submit();
        } else {
            $("#invalid-entry").show();
        }
    });
});
