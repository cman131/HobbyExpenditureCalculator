
function showUserInfo1() {
    var nextPartial = document.getElementById('userinfo1');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'block'
        document.getElementById('userinfo2').style.display = 'none'
        document.getElementById('Rent').style.display = 'none'
        document.getElementById('Buy').style.display = 'none'
        document.getElementById('Hobbies').style.display = 'none'
        document.getElementById('Results').style.display = 'none'
    }
}

function showUserInfo2() {
    var nextPartial = document.getElementById('userinfo2');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'none'
        document.getElementById('userinfo2').style.display = 'block'
        document.getElementById('Rent').style.display = 'none'
        document.getElementById('Buy').style.display = 'none'
        document.getElementById('Hobbies').style.display = 'none'
        document.getElementById('Results').style.display = 'none'
    }
}

function showRent() {
    var nextPartial = document.getElementById('Rent');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'none'
        document.getElementById('userinfo2').style.display = 'none'
        document.getElementById('Rent').style.display = 'block'
        document.getElementById('Buy').style.display = 'none'
        document.getElementById('Hobbies').style.display = 'none'
        document.getElementById('Results').style.display = 'none'
    }
}

function showBuy() {
    var nextPartial = document.getElementById('Buy');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'none'
        document.getElementById('userinfo2').style.display = 'none'
        document.getElementById('Rent').style.display = 'none'
        document.getElementById('Buy').style.display = 'Buy'
        document.getElementById('Hobbies').style.display = 'none'
        document.getElementById('Results').style.display = 'none'
    }
}

function showHobbie() {
    var nextPartial = document.getElementById('Hobbies');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'none'
        document.getElementById('userinfo2').style.display = 'none'
        document.getElementById('Rent').style.display = 'none'
        document.getElementById('Buy').style.display = 'none'
        document.getElementById('Hobbies').style.display = 'block'
        document.getElementById('Results').style.display = 'none'
    }
}

function showResults() {
    var nextPartial = document.getElementById('Results');
    if (nextPartial.style.display == 'none') {
        document.getElementById('userinfo1').style.display = 'none'
        document.getElementById('userinfo2').style.display = 'none'
        document.getElementById('Rent').style.display = 'none'
        document.getElementById('Buy').style.display = 'none'
        document.getElementById('Hobbies').style.display = 'none'
        document.getElementById('Results').style.display = 'block'
    }
}