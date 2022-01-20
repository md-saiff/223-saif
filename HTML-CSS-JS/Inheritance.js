class getOrderedName{
    constructor(name){
        this.name=name;
    }

    productDetails(){
        console.log(`${this.name} order this product .`);
    }

}
var ord = new getOrderedName("Succesfull");
ord.productDetails();
