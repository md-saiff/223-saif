function Gender() {  
    var getSelectedValue = document.querySelector( 'input[name="Gender"]:checked'); 
      
    if(getSelectedValue != null) { 
        document.getElementById("disp").innerHTML 
            = getSelectedValue.value ;
    } 
}        