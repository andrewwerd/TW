import { Component, OnInit } from '@angular/core';
import { Balance } from '../../../_models/discounts/balance';
import { FormControl } from '@angular/forms';
import { BalanceService } from 'src/app/_services/balance.service';

@Component({
  selector: 'app-balances-list',
  templateUrl: './balancesList.component.html',
  styleUrls: ['./balancesList.component.css']
})
export class BalancesListComponent implements OnInit {
  balances: Balance[] = [{
    id: 3,
    partnerId: 3,
    partnerName: 'Darwin',
    discountPercent: 1,
    accumulationPercent: 2,
    currentAmount: 100,
    nextAmount: 1000,
    discounts: [{
      amount: 1001,
      discountPercent: 2,
      accumulatingPercent: 1
    },
    {
      amount: 1500,
      discountPercent: 5,
      accumulatingPercent: 3
    },
    {
      amount: 2000,
      discountPercent: 10,
      accumulatingPercent: 5
    }
    ],
    partnerCategory: 'Магазин',
    partnerSubcategory: 'Электроника',
    isPremium: true
  },
  {
    id: 4,
    partnerId: 4,
    partnerName: 'Enter',
    discountPercent: 1,
    currentAmount: 100,
    nextAmount: 500,
    discounts: [{
      amount: 1000,
      discountPercent: 2
    },
    {
      amount: 1500,
      discountPercent: 5
    },
    {
      amount: 2000,
      discountPercent: 10
    }
    ],
    partnerCategory: 'Магазин',
    partnerSubcategory: 'Электроника',
    resetDate: new Date(2020, 12, 31),
    isPremium: false
  }];
  searchInput = new FormControl('');
  constructor(private balanceService: BalanceService) { }

  ngOnInit(): void { }
  OnScroll() { }
  getAll() { }
  getPremium() { }
  getStandart() { }


  loadBalances() {
    this.balanceService.getBalancesPaged().subscribe(balances => this.balances = balances);
  }

  applySearch() {
   // this.createFiltersFromSearchInput();
    this.loadBalances();
  }

  // resetGrid() {
  //   this.requestFilters = { filters: [], logicalOperator: FilterLogicalOperators.And };
  //   this.loadBalances();
  // }

  // private createFiltersFromSearchInput() {
  //   const filterValue = this.searchInput.value.trim();
  //   if (filterValue) {
  //     const filters: Filter[] = [];
  //     this.tableColumns.forEach(column => {
  //       if (column.useInSearch) {
  //         const filter: Filter = { path: column.index, value: filterValue };
  //         filters.push(filter);
  //       }
  //     });
  //     this.requestFilters = {
  //       logicalOperator: FilterLogicalOperators.Or,
  //       filters
  //     };
  //   } else {
  //     this.resetGrid();
  //   }
  // }
}
