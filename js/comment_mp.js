$(document).ready(function() {
	var idUser = $.getURLParam("idClient");
	var idmaper = $.getURLParam("idMaper");
   var d = new Date();
   var today = d.getDate() + "/" + (d.getMonth()+1) + "/" + d.getFullYear(); 
   $("#menu_des").click(function(){
      location.href = "history_mp.html?id="+idmaper;
   });
   $(".menu_check").click(function(){
      if($("#message").val() != "" && $("#rating").val() != ""){
         var params = {
            "IDClient":idUser,
            "Comment":$("#message").val(),
            "DateD":today,
            "Value":$("#rating").val()
         };
         $.ajax({
               data: params,
               url: 'http://projectmape.azurewebsites.net/api/UsersComments/',
               type: 'post',
              success: function (response) {
               alert("Comentario realizado");
               location.href = "home_mp.html?id="+idmaper;
              }
         });
}else{
         alert("Verifique que no hayan campos vacíos");
      }
   });
});
