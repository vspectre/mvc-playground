// Modal helper methods
function showModal(modalId) {
    $('#' + modalId).modal('show');
}

function hideModal(modalId) {
    $('#' + modalId).modal('hide');
}

function showModal() {
    showModal('myModal');
}

function hideModal() {
    hideModal('myModal');
}

// Progress-Bar infinite helper methods
function startProgress() {
    $('.bar').bind('webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend transitionEnd',
        function (e) {
            $(this).toggleClass('no-transition-width').toggleClass('active-bar');
        }).addClass('active-bar');
}

function endProgress() {
    $('.bar').unbind('webkitTransitionEnd otransitionend oTransitionEnd msTransitionEnd transitionend transitionEnd').removeClass('active-bar').removeClass('no-transition-width');
}