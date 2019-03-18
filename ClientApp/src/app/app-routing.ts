import { Routes, RouterModule } from "@angular/router";
import { OrdersListComponent } from "./orders-list/orders-list.component";
import { UsersListComponent } from "./users-list/users-list.component";
import { CarsListComponent } from "./cars-list/cars-list.component";
import { OrderEditorComponent } from "./orders-list/order-editor/order-editor.component";
import { OrderDetailsComponent } from "./orders-list/order-details/order-details.component";

const routes: Routes = [
    { path: '', component: OrdersListComponent, pathMatch: 'full' },
    { path: 'users', component: UsersListComponent },
    { path: 'cars', component: CarsListComponent },
    { path: 'order', component: OrderEditorComponent },
    { path: 'order/:id', component: OrderEditorComponent },
    { path: 'order/detail/:id', component: OrderDetailsComponent },
    { path: 'orders', component: OrdersListComponent },
    { path: "**", component: OrdersListComponent}
]

export const RoutingConfig = RouterModule.forRoot(routes);