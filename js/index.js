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
	    dataType: 'jsonp',
	    url: 'http://projectmape.azurewebsites.net/api/Users/?username=andresa&password=prueba',
        contentType: "application/json; charset=utf-8",
        success: function (data) {
	        if (data != null) {

	            alert("HOLAAAAA");                   
	        }
	    }
	});
});


