$('#exampleModalEdit').on('shown.bs.modal', function (event) {
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

$('#exampleModalMap').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    document.getElementById('mapDiv').innerHTML = "<div id='map' style='100%; height: 100%;'>";
    if (userId) {
        $.get({
            url: '/editrealestate/getrealestate?id=' + userId,
            success: (data) => {
                var lat = data.latitude
                var lon = data.longitude
                setTimeout(function () { map.invalidateSize() }, 500)
                // position we will use later
                lat = parseFloat(lat).toFixed(6);
                lon = parseFloat(lon).toFixed(6);
                // initialize map
                map = L.map('map').setView([lat, lon], 20);
                // set map tiles source
                L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
                    attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors',
                    maxZoom: 18,
                }).addTo(map);
                // add marker to the map
                marker = L.marker([lat, lon]).addTo(map);
                // add popup to the marker
                marker.bindPopup("Ваш объект").openPopup();
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