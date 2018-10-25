export class User {
  Id: number;
  Name: string;
  Email: string;
  Role: string;
  Password: string;
  ImageURL: string;
}

export class FishAttributes {
  Id: number;
  OtherNames: string;
  Description: string;
  NetWeight: string;
  GrossWeight: string;
  Fish: Fish;
}

export class Category {
  Id: number;
  Name: string;
  Description: string;
  FishCategory: Array<FishCategory>;
}

export class FishCategory {
  Id: number;
  FkIdFish: number;
  FkIdCategory: number;
  FkIdCategoryNavigation: Category;
  FkIdFishNavigation: Fish;
}

export class FishImage {
  Id: number;
  FkIdFish: number;
  FilePath: string;
  IsPrimary: boolean;
  Description: string;
  FkIdFishNavigation: Fish;
}

export class Order {
  Id: number;
  FkIdUserOrderedBy: number;
  FkIdUserConfirmedBy: number;
  FkIdUserDeleveredBy: number;
  OrderedOn: Date;
  DeliveredOn: Date;
  Discount: number;
  FkIdUserOrderedByNavigation: User;
  FkIdUserConfirmedByNavigation: User;
  FkIdUserDeleveredByNavigation: User;
  OrderItem: Array<OrderItem>;
}

export class OrderItem {
  Id: number;
  FkIdOrder: number;
  FkIdFish: number;
  Quantity: number;
  MarketPrice: number;
  OurPrice: number;
  Total: number;
  FkIdFishNavigation: Fish;
  FkIdOrderNavigation: Order;
}

export class Fish {
  Id: number;
  Name: string;
  MarketPrice: number;
  OurPrice: number;
  FkIdFishAttributes: number;
  FishAttributes: FishAttributes;
  FishCategory: Array<FishCategory>;
  FishImage: Array<FishImage>;
  OrderItem: Array<OrderItem>;
}
