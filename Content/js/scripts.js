$(document).ready(function(){
  $("input").prop("checked", false);
  $(".radio-container img").click(function(){
    // alert("fired");
    // debugger;
    $(this).prev().prop("checked",true);
  })
})
