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


