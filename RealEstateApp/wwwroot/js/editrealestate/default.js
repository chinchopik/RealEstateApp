$('#ModalMap').on('shown.bs.modal', function (event) {
    let button = event.relatedTarget
    let userId = button.id
    document.getElementById('map').innerHTML = "<div id='maplol' style='100%; height: 100%;'>";
    var lat = 45.02
    var lon = 38.59
    setTimeout(function () { map.invalidateSize() }, 500)
    // position we will use later
    lat = parseFloat(lat).toFixed(6);
    lon = parseFloat(lon).toFixed(6);
    // initialize map
    map = L.map('maplol').setView([lat, lon], 20);
    // set map tiles source
    L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: 'Map data &copy; <a href="https://www.openstreetmap.org/">OpenStreetMap</a> contributors',
        maxZoom: 18,
    }).addTo(map);
    // add marker to the map
    marker = L.marker([lat, lon]).addTo(map);

    map.addEventListener('mousemove', function (ev) {
        lat = ev.latlng.lat;
        lng = ev.latlng.lng;
    });

    document.getElementById("map").addEventListener("contextmenu", function (event) {
        // Prevent the browser's context menu from appearing
        event.preventDefault();

        map.on('click', function (e) {
            if (marker !== null) {
                map.removeLayer(marker);
            }
            marker = L.marker([lat, lng]).addTo(map);
            alert(lat + ' - ' + lng);

            $('#latitudeInput').val(lat);
            $('#longitudeInput').val(lon);

        });

        return false; // To disable default popup.
    });
});

$('#ModalMap').on('hidden.bs.modal', function (event) {
    $(this).find('form').trigger('reset');
    alert("jopas");
});