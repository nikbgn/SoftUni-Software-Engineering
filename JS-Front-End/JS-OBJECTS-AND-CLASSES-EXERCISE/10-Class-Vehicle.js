class Vehicle {
  constructor(type, model, parts, fuel) {
    this.type = String(type);
    this.model = String(model);
    this.parts = parts;
    this.parts.quality = Number(this.parts.engine * this.parts.power);
    this.fuel = Number(fuel);
  }

  drive(fuelUsed){
    this.fuel -= fuelUsed;
  }

}
