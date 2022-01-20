class Animal{
    constructor(name){
        this.name=name;
    }
    speak()
    {
        
    console.log(`${this.name} makes a noise.`);
    }
}
var animal= new Animal("Tiger");
animal.speak();