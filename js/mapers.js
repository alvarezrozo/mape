$( "#id_maper_1" ).click(function() {
    location.href="service_details.html?id=1";
});

$(document).load(function() {
	var iduser = $("#user").val();
	$.ajax({
	    type: 'GET',
	    dataType: 'json',
	    url: 'http://projectmape.azurewebsites.net/api/Users/?username='+username+'&password='+psw,
      success: function (data) {
			if(data.Username != null){
	    		location.href="home.html?id="+data.IDUser;
	    	}else{
	    		alert("Usario o contraseña incorrectos");
	    	}
	    }
	});
});
