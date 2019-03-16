import { Injectable } from "@angular/core";
import { Http, RequestMethod, Request, Response } from "@angular/http";
import { Router } from "@angular/router";
import { Observable } from "rxjs";
import 'rxjs/add/operator/map';
import { Order } from "./order.model";


const userUrl = "/api/users";
const carUrl = "/api/cars";
const orderUrl = "/api/orders";

@Injectable()
export class Repository {

    constructor(private http: Http,
        private router: Router) {
    }

    getCars() {
        return this.sendRequest(RequestMethod.Get, carUrl);
    }

    getUsers() {
        return this.sendRequest(RequestMethod.Get, userUrl);
    }

    getOrders() {
        return this.sendRequest(RequestMethod.Get, orderUrl);
    }

    getOrder(id: number) {
        return this.sendRequest(RequestMethod.Get, orderUrl + "/" + id);
    }

    createOrder(order: Order) {
        let data = {
            startOfRental: order.startOfRental, endOfRental: order.endOfRental,
            comment: order.comment,
            car: order.car,
            user: order.user
        }
        return this.sendRequest(RequestMethod.Post, orderUrl, data);
    }

    deleteOrder(orderId: number) {
        return this.sendRequest(RequestMethod.Delete, orderUrl + "/" + orderId);
    }
    updateOrder(order: Order) {
        let data = {
            startOfRental: order.startOfRental, endOfRental: order.endOfRental,
            comment: order.comment,
            car: order.car,
            user: order.user
        }
        return this.sendRequest(RequestMethod.Put, orderUrl + "/" + order.orderId, data);
    }

    private sendRequest(verb: RequestMethod, url: string,
        data?: any): Observable<any> {
        return this.http.request(new Request({
            method: verb, url: url, body: data
        }))
            .map(response => {
                return response.headers.get("Content-Length") != "0"
                    ? response.json() : null;
            });
    }
}