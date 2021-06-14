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

function Marker_Address_User(p_strAddress_User) {
    var address = p_strAddress_User;
    console.log(address);
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === 'OK') {
            p_map.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: p_map,
                position: results[0].geometry.location
            });
        }
    });
}

//--------------------------------------Hiển thị marker bệnh viện------------------------------------------------------
let markers_Benh_Vien = [];
function List_Marker_Address_Benh_Vien(p_arrAddress_Benh_Vien) {
    //var map = p_map;
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
    console.log(markers_Benh_Vien);
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
    var map = p_map
    setMapOnAll_Benh_Vien(map);
}
//--------------------------------------------------------------------------------------------

