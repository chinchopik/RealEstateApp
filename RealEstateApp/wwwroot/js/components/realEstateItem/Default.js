/*alert("aboba");
const estates = document.querySelectorAll('.edit');
alert(estates.length);
estates.forEach(estate => {
    const id = estate.dataset.id
    let editBtn = estate.querySelector(".edit")

    editBtn.addEventListener('click', () => {
        alert("aboba");
        var exampleModal = document.getElementById('exampleModal')
        if (exampleModal == null) alert("huy");
        mymodal = bootstrap.Modal(exampleModal);
        mymodal.show();
    })

});*/
$(function () {
    $(".edit").click(function () {
        $('#AddressInput').val($(this).data('address'));
        $('#PriceInput').val($(this).data('id'));
        $("#exampleModal").modal("show");
    });
});

const estates = document.querySelectorAll('.estate');
alert(estates.length);
estates.forEach(estate => {
    const id = estate.dataset.id;
    let editBtn = estate.querySelector('.edit');
    editBtn.addEventListener('click', () => {
        alert("aboba");

        var exampleModal = document.getElementById('exampleModal');
        $('.modal-body').val(id);
        alert(id);
        /*exampleModal.addEventListener('show.bs.modal', function (e) {
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
        alert(modalBody);*/
    });
});
