$(document).ready(function(){
  $(".radio-container img").click(function(){
    // alert("fired");
    // debugger;
    $(this).prev().prop("checked",true);
  })
})
