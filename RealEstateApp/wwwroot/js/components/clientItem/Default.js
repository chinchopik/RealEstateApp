$('#exampleModal').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    if (userId) {
        $.get({
            url: '/client/getclient?id=' + userId,
            success: (data) => {
                let modal = $(this)
                modal.find('#IdClient').val(data.id)
                modal.find('#LastNameInput').val(data.lastName)
                modal.find('#FirstNameInput').val(data.firstName)
                modal.find('#PatronymicInput').val(data.patronymic)
                modal.find('#PhoneInput').val(data.phone)
                modal.find('#EmailInput').val(data.email)
            },
            error: (err) => {
                alert(err);
            }
        });
    }
});
