import { Component, OnDestroy, OnInit } from '@angular/core';

import { MyDiscount } from '../../../_models/discounts/myDiscount';
import { DiscountService } from '../../../_services/discount.service';
import { MatDialog } from '@angular/material/dialog';

import { BarcodeDialogComponent } from './barcodeDialog/barcodeDialog.component';
import { CustomerDataService } from 'src/app/_services/customerData.service';
import { Subscription } from 'rxjs';


@Component({
    selector: 'app-customer-home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnDestroy, OnInit {
    myDiscounts: MyDiscount[];

    page = 0;
    customerGuid: string;
    subscription: Subscription;
    constructor(
                private discountService: DiscountService,
                public dialog: MatDialog,
                customerData: CustomerDataService
              )
              {
                this.subscription = customerData.customer$.subscribe(customer => this.customerGuid = customer?.barcode);
              }

  ngOnInit() {
    this.loadMyDiscounts();
  }

  openDialog() {
    this.dialog.open(BarcodeDialogComponent, { data: this.customerGuid});
  }
  loadMyDiscounts() {
      this.discountService.getMyDiscounts().subscribe((myDiscounts: MyDiscount[]) => {this.myDiscounts = myDiscounts; });
  }
  OnScroll(){
    this.page++;
    this.loadMyDiscounts();
  }
  ngOnDestroy(){
    this.subscription.unsubscribe();
  }
}
