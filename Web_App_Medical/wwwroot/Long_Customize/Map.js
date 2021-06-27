let p_map;
var p_lat_Vi_Tri_Nguoi_Nhiem;
var p_lng_Vi_Tri_Nguoi_Nhiem;
function initMap() {
    p_map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 10.776530, lng: 106.700980 },
        zoom: 13
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
let p_strDia_chi_Chi_Tiet = [];
let p_strLat_Chi_Tiet = [];
let p_strLng_Chi_Tiet = [];
function Marker_Address_User(p_strAddress_User) {
    if (markers_Address_User[0] != null) {
        markers_Address_User[0].setMap(null);
        markers_Address_User = [];
    }
    p_strDia_chi_Chi_Tiet = [];
    p_strLat_Chi_Tiet = [];
    p_strLng_Chi_Tiet = [];
    var address = p_strAddress_User;
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({ 'address': address }, function (results, status) {
        if (status === 'OK') {
            var marker = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location,
            });
            markers_Address_User.push(marker);
            var v_map = p_map;
            v_map.setZoom(15);
            v_map.panTo(results[0].geometry.location);
            markers_Address_User[0].setMap(v_map);
            p_lat_Vi_Tri_Nguoi_Nhiem = results[0].geometry.location.lat();
            p_lng_Vi_Tri_Nguoi_Nhiem = results[0].geometry.location.lng();
            p_strDia_chi_Chi_Tiet.push(results[0].formatted_address);
            p_strLat_Chi_Tiet.push(results[0].geometry.location.lat());
            p_strLng_Chi_Tiet.push(results[0].geometry.location.lng());
            console.log(p_strLat_Chi_Tiet[0]);
            document.getElementById("Address_Vi_Tri_Nguoi_Nhiem").value = results[0].formatted_address;
            document.getElementById("Lat_Vi_Tri_Nguoi_Nhiem").value = p_lat_Vi_Tri_Nguoi_Nhiem;
            document.getElementById("Lng_Vi_Tri_Nguoi_Nhiem").value = p_lng_Vi_Tri_Nguoi_Nhiem;
        }
    });
}
function Get_Dia_Chi_Chi_Tiet() {
    return p_strDia_chi_Chi_Tiet[0];
}
function Get_Lat() {
    return String(p_strLat_Chi_Tiet[0]);
}
function Get_Lng() {
    return String(p_strLng_Chi_Tiet[0]);
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
//--------------------------------------------------------------------------------------------
let markers_All = [];
function List_Marker_Address_All(p_arrAddress_Benh_Vien, p_arrAddress_Nguoi_Nhiem, p_arrAddress_Nguoi_Nghi_Nhiem) {
    var arr_Benh_Vien = [];
    for (var i = 0; i < p_arrAddress_Benh_Vien.length; i++) {
        var item = {
            position: new google.maps.LatLng(p_arrAddress_Benh_Vien[i].lat, p_arrAddress_Benh_Vien[i].lng),
            icon: "/Icon/Benh_Vien.png"
        }
        arr_Benh_Vien.push(item);
    };
    for (var i = 0; i < arr_Benh_Vien.length; i++) {
        var marker = new google.maps.Marker({
            position: arr_Benh_Vien[i].position,
            category: 'Benh_Vien',
            icon: arr_Benh_Vien[i].icon,
            map: map,
        });
        markers_All.push(marker);
    };
    var arr_Nguoi_Nhiem = [];
    for (var i = 0; i < p_arrAddress_Nguoi_Nhiem.length; i++) {
        var item = {
            position: new google.maps.LatLng(p_arrAddress_Nguoi_Nhiem[i].lat, p_arrAddress_Nguoi_Nhiem[i].lng),
            icon: "/Icon/Nguoi_Nhiem.png"
        }
        arr_Nguoi_Nhiem.push(item);
    };
    for (var i = 0; i < arr_Nguoi_Nhiem.length; i++) {
        var marker = new google.maps.Marker({
            position: arr_Nguoi_Nhiem[i].position,
            category: 'Nguoi_Nhiem',
            icon: arr_Nguoi_Nhiem[i].icon,
            map:map,
        });
        markers_All.push(marker);
    };
    var arr_Nguoi_Nghi_Nhiem = [];
    for (var i = 0; i < p_arrAddress_Nguoi_Nghi_Nhiem.length; i++) {
        var item = {
            position: new google.maps.LatLng(p_arrAddress_Nguoi_Nghi_Nhiem[i].lat, p_arrAddress_Nguoi_Nghi_Nhiem[i].lng),
            icon: "/Icon/Nguoi_Nghi_Nhiem.png"
        }
        arr_Nguoi_Nghi_Nhiem.push(item);
    };
    for (var i = 0; i < arr_Nguoi_Nghi_Nhiem.length; i++) {
        var marker = new google.maps.Marker({
            position: arr_Nguoi_Nghi_Nhiem[i].position,
            category: 'Nguoi_Nghi_Nhiem',
            icon: arr_Nguoi_Nghi_Nhiem[i].icon,
            map: map,
        });
        markers_All.push(marker);
    };
}
function setMapOnAll_Markers(p_objmap) {
    for (let i = 0; i < markers_All.length; i++) {
        markers_All[i].setMap(p_objmap);
    }
}
function Hide_Markers_All() {
    setMapOnAll_Markers(null);
}
function Show_Markers_All() {
    var map = p_map;
    setMapOnAll_Markers(map);
}
function setMapOnAll_Benh_Vien(p_objmap) {
    for (var i = 0; i < markers_All.length; i++) {
        if (markers_All[i].category == 'Benh_Vien') {
            markers_All[i].setMap(p_objmap);
        }
    }
}
function Show_Markers_Benh_Vien() {
    var map = p_map;
    setMapOnAll_Benh_Vien(map);
}
function setMapOnAll_Nguoi_Nhiem(p_objmap) {
    for (var i = 0; i < markers_All.length; i++) {
        if (markers_All[i].category == 'Nguoi_Nhiem') {
            markers_All[i].setMap(p_objmap);
        }
    }
}
function Show_Markers_Nguoi_Nhiem() {
    var map = p_map;
    setMapOnAll_Nguoi_Nhiem(map);
}
function setMapOnAll_Nguoi_Nghi_Nhiem(p_objmap) {
    for (var i = 0; i < markers_All.length; i++) {
        if (markers_All[i].category == 'Nguoi_Nghi_Nhiem') {
            markers_All[i].setMap(p_objmap);
        }
    }
}
function Show_Markers_Nguoi_Nghi_Nhiem() {
    var map = p_map;
    setMapOnAll_Nguoi_Nghi_Nhiem(map);
}
//--------------------------------------------------------------------------------------------
let markers_Diem_Cach_Ly = [];
function List_Marker_Address_Diem_Cach_Ly(p_arrAddress_Diem_Cach_Ly) {
    var arr_Diem_Cach_Ly = [];
    for (var i = 0; i < p_arrAddress_Diem_Cach_Ly.length; i++) {
        var item = {
            position: new google.maps.LatLng(p_arrAddress_Diem_Cach_Ly[i].lat, p_arrAddress_Diem_Cach_Ly[i].lng),
            icon: "/Icon/Diem_Cach_Ly.png"
        }
        arr_Diem_Cach_Ly.push(item);
    };
    for (var i = 0; i < arr_Diem_Cach_Ly.length; i++) {
        var marker = new google.maps.Marker({
            position: arr_Diem_Cach_Ly[i].position,
            category: 'Diem_Cach_Ly',
            icon: arr_Diem_Cach_Ly[i].icon,
            map: map,
        });
        markers_Diem_Cach_Ly.push(marker);
    };
}
function setMapOnAll_Diem_Cach_Ly(p_objmap) {
    for (let i = 0; i < markers_Diem_Cach_Ly.length; i++) {
        markers_Diem_Cach_Ly[i].setMap(p_objmap);
    }
}
function Hide_Markers_Diem_Cach_Ly() {
    setMapOnAll_Diem_Cach_Ly(null);
}
function Show_Markers_Diem_Cach_Ly() {
    var map = p_map;
    setMapOnAll_Diem_Cach_Ly(map);
}
//--------------------------------------------------------------------------------------------
let polygon_Vung_Cach_Ly = [];
function List_Marker_Address_Vung_Cach_Ly(p_arrTen_Vung_Cach_Ly, p_arrAddress_Vung_Cach_Ly) {
    var arr_Vung_Cach_Ly = [];
    var arr_Item_Vung_Cach_Ly = [];
    for (var i = 0; i < p_arrTen_Vung_Cach_Ly.length; i++) {
        for (var j = 0; j < p_arrAddress_Vung_Cach_Ly.length; j++) {
            if (p_arrTen_Vung_Cach_Ly[i]==p_arrAddress_Vung_Cach_Ly[j].ten_Vung) {
                var item = { lat: parseFloat(p_arrAddress_Vung_Cach_Ly[j].lat), lng: parseFloat(p_arrAddress_Vung_Cach_Ly[j].lng) }
                arr_Item_Vung_Cach_Ly.push(item);
            }
        };
        arr_Vung_Cach_Ly.push(arr_Item_Vung_Cach_Ly);
        arr_Item_Vung_Cach_Ly = [];
    };
    for (var i = 0; i < arr_Vung_Cach_Ly.length; i++) {
        var Item_Vung_Cach_Ly = new google.maps.Polygon({
            paths: arr_Vung_Cach_Ly[i],
            strokeColor: "#FF0000",
            strokeOpacity: 0.8,
            strokeWeight: 3,
            fillColor: "#FF0000",
            fillOpacity: 0.35,
        });
        polygon_Vung_Cach_Ly.push(Item_Vung_Cach_Ly);
    };
}
function setMapOnAll_Vung_Cach_Ly(p_objmap) {
    for (var i = 0; i < polygon_Vung_Cach_Ly.length; i++) {
        polygon_Vung_Cach_Ly[i].setMap(p_objmap);
    }
}
function Hide_Polygon_Vung_Cach_Ly() {
    setMapOnAll_Vung_Cach_Ly(null);
}
function Show_Polygon_Vung_Cach_Ly() {
    var map = p_map;
    setMapOnAll_Vung_Cach_Ly(map);
}