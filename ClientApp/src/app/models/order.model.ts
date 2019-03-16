import { Car } from "./car.model/car.model";
import { User } from "./user.model";

export class Order{
    constructor(
        public orderId?:number,
        public startOfRental?:Date,
        public endOfRental?: Date,
        public comment?:string,
        public car?:Car,
        public user?:User
    ){}
}