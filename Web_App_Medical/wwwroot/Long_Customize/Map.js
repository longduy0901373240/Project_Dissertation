let p_map;
function initMap() {
    p_map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 10.776530, lng: 106.700980 },
        zoom: 10,
    });
}
//--------------------------------------------------------------------------------------------

function initAutocompleteAddress_User() {
    var input = document.getElementById('Search_Address_User');
    const options = {
        componentRestrictions: { country: "VN" },
        fields: ["formatted_address", "geometry", "name"],
        origin: p_map.getCenter(),
        strictBounds: false,
        types: ["establishment"],
    };
    var autocomplete = new google.maps.places.Autocomplete(input, options);
}

//--------------------------------------------------------------------------------------------
let markers_Address_User = [];
function Marker_Address_User(p_strAddress_User) {
    if (markers_Address_User[0] != null) {
        markers_Address_User[0].setMap(null);
        markers_Address_User = [];
    }
    var address = p_strAddress_User;
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === 'OK') {
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location
            });
            markers_Address_User.push(marker);
            var v_map = p_map;
            v_map.setZoom(15);
            v_map.panTo(results[0].geometry.location);
            markers_Address_User[0].setMap(v_map);
        }
    });
}
//--------------------------------------------------------------------------------------------
var directionsRenderer
function point_Start_End(p_Start, p_End) {
    if (directionsRenderer != null) {
        directionsRenderer.setMap(null);
        directionsRenderer.setPanel(null);
        markers_Address_User[0].setMap(null);
        markers_Address_User = [];
    }
    const directionsService = new google.maps.DirectionsService();
    directionsRenderer = new google.maps.DirectionsRenderer();
    var map = p_map;
    directionsRenderer.setMap(map);
    directionsRenderer.setPanel(document.getElementById("info_direct"));
    var start = p_Start;
    console.log(p_End);
    var end = p_End.dia_Chi;
    calculateAndDisplayRoute(directionsService, directionsRenderer, start, end);
}
function calculateAndDisplayRoute(directionsService, directionsRenderer, start, end) {
    directionsService.route(
        {
            origin: {
                query: start,
            },
            destination: {
                query: end,
            },
            travelMode: google.maps.TravelMode.DRIVING,
        },
        (response, status) => {
            if (status === "OK") {
                directionsRenderer.setDirections(response);
            } else {
                window.alert("Directions request failed due to " + status);
            }
        }
    );
}
//--------------------------------------Hiển thị marker bệnh viện------------------------------------------------------
let markers_Benh_Vien = [];
function List_Marker_Address_Benh_Vien(p_arrAddress_Benh_Vien) {
    var arr = [];
    for (var i = 0; i < p_arrAddress_Benh_Vien.length; i++) {
        var item = {
            position: new google.maps.LatLng(p_arrAddress_Benh_Vien[i].lat, p_arrAddress_Benh_Vien[i].lng)
        }
        arr.push(item);
    };
    for (var i = 0; i < arr.length; i++) {
        var marker = new google.maps.Marker({
            position: arr[i].position,
            map: map,
        });
        markers_Benh_Vien.push(marker);
    };
}
function setMapOnAll_Benh_Vien(p_objmap) {
    for (let i = 0; i < markers_Benh_Vien.length; i++) {
        markers_Benh_Vien[i].setMap(p_objmap);
    }
}
function Hide_Markers_Benh_Vien() {
    setMapOnAll_Benh_Vien(null);
}
function Show_Markers_Benh_Vien() {
    var map = p_map;
    setMapOnAll_Benh_Vien(map);
}
//--------------------------------------------------------------------------------------------

