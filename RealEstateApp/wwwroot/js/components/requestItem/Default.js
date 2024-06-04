
$('#exampleModal').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    let modal = $(this)
    modal.find('#hiddenInput').val(userId)
});