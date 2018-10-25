import { Component, OnInit } from '@angular/core';
import { Fish, FishAttributes } from '../models.service';
import { SharedModelService } from '../shared-model.service';
import { WebApiService } from '../web-api.service';

@Component({
  selector: 'app-add-fish',
  templateUrl: './add-fish.component.html',
  styleUrls: ['./add-fish.component.css']
})
export class AddFishComponent implements OnInit {

  _fish: Fish;

  constructor(private webApiService: WebApiService, private sharedModel: SharedModelService) {
    this._fish = new Fish();
    this._fish.FishAttributes = new FishAttributes();
  }

  AddFish() {
    this.webApiService.Post<Fish>('Fish/AddFish', this._fish, (response, error) => {
      if (error) { console.error(error); }
      if (response) { console.log(response); }
    });
  }

  ngOnInit() {
  }

}
