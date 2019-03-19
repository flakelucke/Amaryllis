import { Injectable } from "@angular/core";
import { Http, RequestMethod, Request, Response, RequestOptions,Headers } from "@angular/http";
import { Router, Data } from "@angular/router";
import { Observable } from "rxjs";
import 'rxjs/add/operator/map';
import { Order } from "./order.model";
import { ContentType } from "@angular/http/src/enums";
import { HttpHeaders,HttpClient } from '@angular/common/http';
import { DatePipe } from "@angular/common";


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

    getOrders(filter?: string,fromDate?:Date,toDate?:Date) {
            return this.sendRequest(RequestMethod.Post, orderUrl +(filter != null ? "?filter=" + filter : "")
            +(fromDate != null ? "&&fromDate="+ fromDate.toLocaleString() : "") + ((toDate != null ? "&&toDate="+ toDate.toLocaleString() : "")));
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
        return this.sendRequest(RequestMethod.Post, orderUrl+"/create", data);
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
            headers:new Headers({ 'Content-Type': 'application/json' }),
            method: verb, url: url, body: data
        }))
            .map(response => {
                return response.headers.get("Content-Length") != "0"
                    ? response.json() : null;
            });
    }
}