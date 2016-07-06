$(document).ready(function(){
  $("#next-user").click(function(event){
    event.preventDefault();
    $(".input1").toggle();
    $(".input2").toggle();
    $(".outcome").toggle();
  });
});
