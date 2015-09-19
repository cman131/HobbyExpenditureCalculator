function showDiv2() {
    if (document.getElementById('userinfo1').style.display == 'block') {
        document.getElementById('userinfo1').style.display = 'none';
        document.getElementById('userinfo2').style.display = 'block';
        document.getElementById('usersubmit').style.display = 'none';
    }
}

function showSubmit() {
    if (document.getElementById('userinfo2').style.display == 'block') {
        document.getElementById('userinfo1').style.display = 'none';
        document.getElementById('userinfo2').style.display = 'none';
        document.getElementById('userSubmit').style.display = 'block';
    }
}

function selectHousing(type) {
    document.getElementById('userinfo2');
    document.getElementById(type).style.display = 'block';
}