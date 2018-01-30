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
                    title: ''
                    });


                    ymaps.ready(init);
                    function init() {
                        var geolocation = ymaps.geolocation,
                            myMap = new ymaps.Map('map', {
                                center: [position.coords.latitude, position.coords.longitude], 
                                zoom: 7
                            }, {
                                searchControlProvider: 'yandex#search'
                            });
                
                
                        geolocation.get({
                            provider: 'browser',
                            mapStateAutoApply: false
                        }).then(function (result) {
                           
                            result.geoObjects.options.set('preset', 'islands#blueCircleIcon');
                            myMap.geoObjects.add(result.geoObjects);
                        });
                        
                        
                    }  

                    
    });


    

}());