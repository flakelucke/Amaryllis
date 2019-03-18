import {
  MatButtonModule,
  MatCheckboxModule,
  MatSidenavModule,
  MatPaginatorModule,
  MatSortModule,
  MatInputModule
} from '@angular/material';
import { NgModule } from '@angular/core';
import { MatMenuModule } from '@angular/material/menu';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MatTableModule } from '@angular/material/table';
import { MatSelectModule } from '@angular/material/select';

@NgModule({

  imports: [
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatSidenavModule,
    MatMenuModule,
    MatTableModule,
    MatSelectModule,
    MatPaginatorModule,
    MatInputModule,
    MatSortModule],
  exports: [
    BrowserAnimationsModule,
    MatButtonModule,
    MatCheckboxModule,
    MatSidenavModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatTableModule,
    MatSelectModule,
    MatPaginatorModule,
    MatInputModule,
    MatSortModule],
})

export class MaterialModule { }