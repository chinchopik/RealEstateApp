$('#exampleModal').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    if (userId) {
        $.get({
            url: '/editrealestate/getrealestate?id=' + userId,
            success: (data) => {
                let modal = $(this)
                modal.find('#IdEstate').val(data.id)
                modal.find('#AddressInput').val(data.address)
                modal.find('#PriceInput').val(data.price)
                modal.find('#AreaInput').val(data.totalArea)
                modal.find('#FloorsInput').val(data.totalFloors)
                modal.find('#RoomsInput').val(data.numberOfRooms)
            },
            error: (err) => {
                alert(err);
            }
        });
    }
});

$(function () {
    $("#drop").change(function () {
        var value = this.value;
        if (value == '') {

        }
        else if (value == '1') {
            $("#areaDiv").show();
            $("#floorsDiv").show();
            $("#roomsDiv").show();
        }
        else if (value == '2') {
            $("#areaDiv").hide();
        }
        else if (value == '3') {
            $("#areaDiv").hide();
            $("#floorsDiv").hide();
        }
    });
});
/*
$('.dropdown').on('click', function (event) {
    alert(event.data)
    $($(this).attr('data-dropdown-target')).dropdown('toggle')
})*/