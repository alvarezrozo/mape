$( "#id_maper_1" ).click(function() {
    location.href="service_details.html?id=1";
});

$(document).ready(function() {
	var iduser = $.getURLParam("id");
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Mapers/',
      success: function (data) {
			     console.log(data);
           for(i in data){
             console.log(data[i])
           }
	    }
	});
});
