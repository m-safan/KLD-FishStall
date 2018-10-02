import { Component, OnInit } from '@angular/core';
import { count } from 'rxjs/operators';

@Component({
    selector: 'app-shop',
    templateUrl: './shop.component.html',
    styleUrls: ['./shop.component.css']
})
export class ShopComponent implements OnInit {

    categories: Category[];
    fishes: Fish[];
    // tslint:disable-next-line:max-line-length
    description = 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate. Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum. Ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt molli.';

    constructor() {
        this.categories = [];
        this.categories.push(new Category('Sea', 10));
        this.categories.push(new Category('Ocean', 20));
        this.categories.push(new Category('Lake', 15));
        this.categories.push(new Category('Slice', 7));
        this.categories.push(new Category('Shell', 14));
        this.categories.push(new Category('Crabs', 3));
        this.categories.push(new Category('Pond', 1));

        this.fishes = [];
        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));

        this.fishes.push(new Fish('Fish Name', 'Fish 1, Fish 2, Fish3', '../../assets/img/fish-1.jpg',
            this.description, 100, 90));
    }

    ngOnInit() {
    }

}

class Category {
    Name: string;
    NumberOfFishes: number;

    constructor(name: string, numberOfFishes: number) {
        this.Name = name;
        this.NumberOfFishes = numberOfFishes;
    }
}

class Fish {
    Name: string;
    OtherNames: string;
    ImagePath: string;
    Description: string;
    MarketPrice: number;
    OurPrice: number;
    NetWeight: string;
    GrossWeight: string;

    constructor(name: string, otherNames: string, imagePath: string,
        description: string, marketPrice: number, ourPrice: number) {
        this.Name = name;
        this.OtherNames = otherNames;
        this.ImagePath = imagePath;
        this.Description = description;
        this.MarketPrice = marketPrice;
        this.OurPrice = ourPrice;
        this.NetWeight = '1 KG';
        this.GrossWeight = '800 G';
    }
}
