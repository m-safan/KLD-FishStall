import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-manage-fish-price',
  templateUrl: './manage-fish-price.component.html',
  styleUrls: ['./manage-fish-price.component.css']
})
export class ManageFishPriceComponent implements OnInit {

  fishes: FishPrice[];
  constructor() {
    this.fishes = [];
    this.fishes.push(new FishPrice('Safan', 'Category 1', 100, 90));
    this.fishes.push(new FishPrice('Safan', 'Category 1', 100, 90));
    this.fishes.push(new FishPrice('Safan', 'Category 1', 100, 90));
  }

  ngOnInit() {
  }

}

class FishPrice {
  Name: string;
  Category: string;
  MarketPrice: number;
  OurPrice: number;

  constructor(name: string, category: string, marketPrice: number, ourPrice: number) {
    this.Name = name;
    this.Category = category;
    this.MarketPrice = marketPrice;
    this.OurPrice = ourPrice;
  }
}
