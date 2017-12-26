(function () {
    let position = navigator.geolocation.getCurrentPosition((position) => {
        let myPosition = new google.maps.LatLng(position.coords.latitude, position.coords.longitude);
        
                var mapOptions = {
                    center: myPosition,
                    zoom: 15,
                    mapTypeId: google.maps.MapTypeId.ROADMAP
                };
        
        
                var map = new google.maps.Map(document.getElementById("map_canvas"),
                    mapOptions);
             
                var marker = new google.maps.Marker({
                    position: myPosition,
                    map: map,
                    title: 'Hello World!'
                    });
    });
}());