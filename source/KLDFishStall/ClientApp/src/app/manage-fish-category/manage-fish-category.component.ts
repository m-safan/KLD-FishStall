import { Component, OnInit } from '@angular/core';
import { DualListComponent } from 'angular-dual-listbox';

@Component({
  selector: 'app-manage-fish-category',
  templateUrl: './manage-fish-category.component.html',
  styleUrls: ['./manage-fish-category.component.css']
})
export class ManageFishCategoryComponent implements OnInit {

  fishesInCategory: FishesInCategory;
  dualListHeight: string;

  constructor() {
    this.fishesInCategory = new FishesInCategory();
    this.fishesInCategory.FK_ID_Fishes = [];
    this.fishesInCategory.Source_Fishes = ['Bashir Saheb', 'Dilshad Bashir', 'Mohammed Safan', 'Safa Mubashira'];
    this.dualListHeight = '350px';
  }

  onFishCategorySelectionChanged(): void {
    this.fishesInCategory.Source_Fishes = ['Safa Mubashira', 'Mohammed Safan', 'Dilshad Bashir', 'Bashir Saheb'];
  }

  ngOnInit() { }

}

class FishesInCategory {
  FK_ID_FishCategory: string;
  FK_ID_Fishes: string[];
  Source_Fishes: string[];
}