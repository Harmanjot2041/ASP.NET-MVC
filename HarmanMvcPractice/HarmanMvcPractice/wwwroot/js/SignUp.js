function handleClick() {
    //alert("hey onclick");
    //var name = $("#name").val()
   // if (name == "")
   //     alert("name is required!");
    if (ValidationForm()) {
        $("#SignUp").submit();

    }

}
$(document).ready(function () {
    alert("Welcome to SignUp !");
})
$(window).on("load", function () {
    console.log("Welcome to SignUp !");
})
$(window).resize(function () {
    console.log("Sizeed of window changed");
})
$("#target").scroll(function () {
    console.log("scrolled ");
})
 function ValidationForm()
{
    var isValid = true;
    var numberRegix = /^[0-9]$/;
    var emailRegix = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    var salaryRegix = /^\d{1,6}(?:\.\d{0,2})?$/;
    var passwordRegix = /^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$/;
    $("#id_error").text("");
    $("#name_error").text("");
    $("#salary_error").text("");
    $("#desination_error").text("");
     $("#age_error").text("");
     $("#password_error").text("");
     $("#email_error").text("");

    if ($("#name").val().trim() == "") {
        $("#name_error").text("Name is Required");
        isValid = false;
     }

    if ($("#id").val().trim() == "") {
        $("#id_error").text("Id is Required");
        isValid = false;
    }
    if ($("#salary").val().trim() == "") {
        $("#salary_error").text("Salary is Required");
        isValid = false;
     }
     if ($("#salary").val().trim() != "" && !salaryRegix.test($("#salary").val().trim())) {
         $("#salary_error").text("Salary should be number.");
     }
     if ($("#email").val().trim() == "") {
         $("#email_error").text("Email is Required");
         isValid = false;
     }
     if ($("#email").val().trim() != "" && !emailRegix.test($("#email").val().trim())) {
         $("#email_error").text("email is invalid.");
     }
     if ($("#password").val().trim() == "") {
         $("#password_error").text("password is Required");
         isValid = false;
     }
     if ($("#password").val().trim() != "" && !passwordRegix.test($("#password").val().trim())) {
         $("#password_error").text("password is invalid.");
     }
    if ($("#Age").val().trim() == "") {
        $("#age_error").text("Age is Required");
        isValid = false;
     }
     if ($("#Age").val().trim() != "" && !numberRegix.test($("#Age").val().trim())) {
         $("#age_error").text("Age is INVALID");
     }
    if ($("#desination").val().trim() == "") {
        $("#desination_error").text("Degination is Required");
        isValid = false;
    }
    return isValid;

}

function HandleKeyPress(id) {
    //var val = e.target.value();
    $("#email_error").text("");
    console.log(id);
    console.log($("#" + id).val().trim());
    var emailRegix = /^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$/;
    if ($("#"+id).val().trim() == "") {
        $("#"+id+"_error").text( id +" is Required");
        isValid = false;
    }
    if ($("#" + id).val().trim() != "" && !emailRegix.test($("#" + id).val().trim())) {
        $("#" + id + "_error").text(id+ " is invalid.");
    }
}
function HandleChange(id) {
    $("#salary_error").text("");
    console.log(id);
    var salaryRegix = /^\d{1,6}(?:\.\d{0,2})?$/;
    if ($("#" + id).val().trim() == "") {
        $("#" + id + "_error").text(id + " is Required");
        isValid = false;
    }
    if ($("#" + id).val().trim() != "" && !salaryRegix.test($("#" + id).val().trim())) {
        $("#" + id + "_error").text(id + " is invalid.");
    }
}