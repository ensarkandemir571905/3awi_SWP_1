abstract class Animal { // Basisklasse für Tiere
    private _name: string;
    private _colour: string;
    private _birthDate: Date;

    public get Name() { return this._name; }
    public get Colour() { return this._colour; }
    public set Colour(value: string) { this._colour = value; }

    constructor(name: string, colour: string, birthDate: Date) {
        this._name = name;
        this._colour = colour;
        this._birthDate = birthDate;
    }

    // Advanced: Alter in vollen Jahren aus dem Geburtsdatum berechnen
    public getAge(): number {
        const today = new Date();
        let age = today.getFullYear() - this._birthDate.getFullYear();
        const birthdayPassed =
            today.getMonth() > this._birthDate.getMonth() ||
            (today.getMonth() === this._birthDate.getMonth() &&
             today.getDate() >= this._birthDate.getDate());
        if (!birthdayPassed) {
            age--; // Geburtstag in diesem Jahr noch nicht gewesen
        }
        return age;
    }

    // jede abgeleitete Klasse muss ihren eigenen Laut implementieren
    public abstract makeSound(): void;
}

class Cow extends Animal {
    public makeSound() { console.log("Muuuuh"); }
}

class Cat extends Animal {
    public makeSound() { console.log("Miau"); }
}

let myCow = new Cow("Kuh1", "weiß", new Date(2020, 2, 15)); // Monat ist 0-basiert: 2 = März
let myCow1 = new Cow("Kuh2", "schwarz", new Date(2018, 7, 1));
let myCow2 = myCow; // Referenz auf dasselbe Objekt

console.log(myCow2 == myCow);   // true
console.log(myCow2.Name);       // Kuh1
myCow.Colour = "braun";
console.log(myCow2.Colour);     // braun, da gleiches Objekt

let myCat = new Cat("Minka", "grau", new Date(2022, 5, 10));
console.log(myCat.Name, myCat.Colour, myCat.getAge()); // Minka grau 4

myCow.makeSound(); // Muuuuh
myCat.makeSound(); // Miau