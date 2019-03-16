import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { MaterialModule } from './material.module';
import { RoutingConfig } from './app-routing';
import { UsersListComponent } from './users-list/users-list.component';
import { CarsListComponent } from './cars-list/cars-list.component';
import { OrdersListComponent } from './orders-list/orders-list.component';
import { ModelModule } from './models/model.module';
import { OrderEditorComponent } from './orders-list/order-editor/order-editor.component';
import { OrderDetailComponent } from './order-detail/order-detail.component';

@NgModule({ 
  declarations: [
    AppComponent,
    NavMenuComponent,
    UsersListComponent,
    CarsListComponent,
    OrdersListComponent,
    OrderEditorComponent,
    OrderDetailComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    MaterialModule,
    RoutingConfig,
    ModelModule,
    HttpModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
