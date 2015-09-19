function swapDivDisplayed(elements) {
    var formParts = document.getElementsByClassName('form-part');
    for (var i = 0; i < formParts.length; i++) {
        formParts[i].style.display = 'none';
    }
    for (var i = 0; i < elements; i++) {
        elements[i].style.display = 'block'
    }
}