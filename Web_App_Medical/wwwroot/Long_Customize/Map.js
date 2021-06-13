var map;
function initMap() {
    map = new google.maps.Map(document.getElementById("map"), {
        center: { lat: 10.776530, lng: 106.700980 },
        zoom: 10,
    });
}
function initAutocompleteAddress_User() {
    var input = document.getElementById('Search_Address_User');
    const options = {
        componentRestrictions: { country: "VN" },
        fields: ["formatted_address", "geometry", "name"],
        origin: map.getCenter(),
        strictBounds: false,
        types: ["establishment"],
    };
    var autocomplete = new google.maps.places.Autocomplete(input,options);
}
function Marker_Address_User(p_strAddress_User) {
    var address = p_strAddress_User;
    console.log(address);
    var geocoder = new google.maps.Geocoder();
    geocoder.geocode({'address': address}, function (results, status) {
        if (status === 'OK') {
            map.setCenter(results[0].geometry.location);
            var marker = new google.maps.Marker({
                map: map,
                position:results[0].geometry.location
            });
        }
    });
}