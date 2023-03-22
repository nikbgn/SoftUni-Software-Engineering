function cats(cats_info) {
    class Cat{
        constructor(name,age){
            this.name = name;
            this.age = age;
        }
    
        meow(){
            console.log(`${this.name}, age ${this.age} says Meow`);
        }
    }
    
    cats_info.forEach((cat) => {
        let cat_info = cat.split(' ');
        let new_cat = new Cat(cat_info[0],cat_info[1]);
        new_cat.meow();
    })
}
