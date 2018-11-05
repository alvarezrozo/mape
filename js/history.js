$("#menu_back").click(function(){
	var idclient = $.getURLParam("id");
	location.href = "home.html?id="+idclient;
});