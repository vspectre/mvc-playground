//general client-side document manipulation methods
function reloadWindow() {
    window.location.reload();
}

function submitForm(formId) {
    $form = $('#' + formId);

    if ($form.prop('tagName') == 'FORM') {
        $form.submit();
    }
}

