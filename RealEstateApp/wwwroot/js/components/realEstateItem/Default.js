/*$(function () {
    $(".edit").click(function () {
        $('#AddressInput').val($(this).data('address'));
        $('#PriceInput').val($(this).data('id'));
        $("#exampleModal").modal("show");
    });
});

const estates = document.querySelectorAll('.estate');
*//*alert(estates.length);*//*
estates.forEach(estate => {
    const id = estate.dataset.id;
    let editBtn = estate.querySelector('.edit');
    editBtn.addEventListener('click', () => {
*//*        alert("aboba");*//*

        var exampleModal = document.getElementById('exampleModal');
        $('.modal-body').val(id);
*//*        alert(id);*//*
        *//*exampleModal.addEventListener('show.bs.modal', function (e) {
            var button = e.target;
            alert("aboba1");
            var modalBody = exampleModal.querySelector('.modal-body input');
            modalBody.val = estate;
            alert("aboba2");
            console.log(e.target);
            $(#exampleModal).click(function(){
                $
            }
        });*//*
        alert(modalBody);*//*
    });
});
*/
$('#exampleModal').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    if (userId) {
        $.get({
            url: '/realestate/getrealestate?id=' + userId,
            success: (data) => {
                let modal = $(this)
                modal.find('#IdEstate').val(data.id)
                modal.find('#AddressInput').val(data.address)
                modal.find('#PriceInput').val(data.price)
            },
            error: (err) => {
                alert(err);
            }
        });
    }
})