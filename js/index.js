/*$( "#intro" ).click(function() {
	var username = $("#user").val();
	var psw = $("#pass").val();
	$.ajax({
		method:"GET",
		dataType: "jsonp",
		jsonpCallback: 'callback',
        url: "http://projectmape.azurewebsites.net/api/Users/?username="+username+"&password="+psw
    }).then(function(data) {
    	if(data.Answer){
    		location.href="home.html?id=22";
    	}else{
    		alert("Usario o contraseña incorrectos");
    	}
    	alert("Usario o contraseña incorrectos");
	});
  
});*/

$( "#intro" ).click(function() {
	var username = $("#user").val();
	var psw = $("#pass").val();
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


