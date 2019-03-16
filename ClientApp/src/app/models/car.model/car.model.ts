import { CarModel } from "./car-attributes-model/car-model.model";
import { WhoManufacturerCar } from "./car-attributes-model/who-manufacturer-car.model";
import { CarClass } from "./car-attributes-model/car-class.model";

export class Car {
    constructor(
        public carId?: number,
        public model?: CarModel,
        public whoManufacturerCar?: WhoManufacturerCar,
        public carClass?: CarClass,
        public yearOfIssue?: number,
        public registrationNumber?: string,
    ) { }
}