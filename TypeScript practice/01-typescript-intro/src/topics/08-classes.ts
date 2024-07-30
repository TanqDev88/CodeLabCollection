


export class Person{
    public name: string;
    public adress: string;

    constructor(){
        this.name = 'Fernando';
        this.adress= 'Berlin'
    }
}

const ironman = new Person();

console.log(ironman.adress)