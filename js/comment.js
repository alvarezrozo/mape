$(document).ready(function() {
	var idclient = $.getURLParam("idClient");
	var idmaper = $.getURLParam("idMaper");
   var d = new Date();
   var today = d.getDate() + "/" + (d.getMonth()+1) + "/" + d.getFullYear(); 
   $("#menu_des").click(function(){
      location.href = "history.html?id="+idclient;
   });
   $(".menu_check").click(function(){
      if($("#message").val() != "" && $("#rating").val() != ""){
         var params = {
            "IDMaper":idmaper,
            "Comment":$("#message").val(),
            "DateD":today,
            "Value":$("#rating").val()
         };
         $.ajax({
               data: params,
               url: 'http://projectmape.azurewebsites.net/api/MapersComments/',
               type: 'post',
              success: function (response) {
               alert("Comentario realizado");
               location.href = "home.html?id="+idclient;
              }
         });
}else{
         alert("Verifique que no hayan campos vacíos");
      }
   });
});
