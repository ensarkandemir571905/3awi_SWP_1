
interface IFahrzeug {
    Fahrzeugtyp: string;
    Name: string;
}

class Fahrzeug implements IFahrzeug {
    private fahrzeugtyp: string;
    private name: string;

    get Fahrzeugtyp(): string {
        return this.fahrzeugtyp;
    }

    get Name(): string {
        return this.name;
    }

    constructor(fahrzeugtyp: string, name: string) {
        this.fahrzeugtyp = fahrzeugtyp;
        this.name = name;
    }
}

class Fahrrad extends Fahrzeug {
    private anzahlGaenge: number;

    get AnzahlGaenge(): number {
        return this.anzahlGaenge;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlGaenge: number) {
        super(fahrzeugtyp, name);
        this.anzahlGaenge = anzahlGaenge;
    }
}

class Auto extends Fahrzeug {
    private anzahlTueren: number;

    get AnzahlTueren(): number {
        return this.anzahlTueren;
    }

    constructor(fahrzeugtyp: string, name: string, anzahlTueren: number) {
        super(fahrzeugtyp, name);
        this.anzahlTueren = anzahlTueren;
    }
}

class PKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("PKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class LKW extends Auto {
    private motorTyp: string;

    constructor(name: string, anzahlTueren: number, motorTyp: string) {
        super("LKW", name, anzahlTueren);
        this.motorTyp = motorTyp;
    }
}

class Garage {
    private fahrzeuge: Fahrzeug[] = [];

    public addFahrzeug(fahrzeug: Fahrzeug): void {
        this.fahrzeuge.push(fahrzeug);
    }

    public getFahrzeuge(): Fahrzeug[] {
        return this.fahrzeuge;
    }

    public anzahlFahrzeuge(): number {
        return this.fahrzeuge.filter(
            item => item instanceof Fahrzeug
        ).length;
    }

    get anzahlAutos(): number {
        return this.fahrzeuge.filter(
            item => item instanceof Auto
        ).length;
    }
}

// Fahrzeuge erstellen

var myBWMWith4Doors = new PKW("BMW", 4, "Benzin");
console.log(myBWMWith4Doors.Fahrzeugtyp);
console.log(myBWMWith4Doors.AnzahlTueren);

var myBWMWith2Doors = new PKW("BMW", 2, "Benzin");
console.log(myBWMWith2Doors.Fahrzeugtyp);
console.log(myBWMWith2Doors.AnzahlTueren);

var myMANWith2Doors = new LKW("MAN", 2, "Diesel");
console.log(myMANWith2Doors.Fahrzeugtyp);
console.log(myMANWith2Doors.AnzahlTueren);

var myFahrrad = new Fahrrad("Fahrrad", "Mountainbike", 21);
console.log(myFahrrad.Fahrzeugtyp);
console.log(myFahrrad.AnzahlGaenge);

// Garage erstellen

var myGarage = new Garage();

myGarage.addFahrzeug(myBWMWith4Doors);
myGarage.addFahrzeug(myBWMWith2Doors);
myGarage.addFahrzeug(myMANWith2Doors);
myGarage.addFahrzeug(myFahrrad);

// Ausgabe

console.log(
    `Anzahl Fahrzeuge in der Garage: ${myGarage.anzahlFahrzeuge()} davon Autos: ${myGarage.anzahlAutos}`
);
