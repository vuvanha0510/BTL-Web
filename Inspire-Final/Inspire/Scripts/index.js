function myFunction() {
    var menu = document.getElementById("myMenu");
    if (menu.className === "menu") {
        menu.className += " responsive";
    }
    else {
        menu.className = "menu";
    }
}
function checkForm() {

    var txtPassword = document.getElementById('myPassword').value;
    var txtRePassword = document.getElementById('myRePassword').value;
    
    if (txtPassword != txtRePassword) {
        alert('Chưa khớp mật khẩu');
        return false;
    }

    if (txtPassword.length < 6) {
        alert('Vui lòng nhập password trên 6 kí tự');
        return false;
    }
    
    if (checkUpperCase(txtPassword) === false) {
        alert('Phải có 1 kí tự viết hoa');
        return false;
    }
    return true;
}
function checkUpperCase(txtPassword) {
    
    for (var i = 0; i < txtPassword.length; i++) {
        if ((/[A-Z]/.test(txtPassword[i])) === true) {
            return true;
        }
    }
    return false;
}