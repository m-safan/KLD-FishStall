import { Component, OnInit } from '@angular/core';
import { SharedModelService } from '../shared-model.service';
import { LocalStorageService } from 'angular-2-local-storage';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  _sharedModel: SharedModelService;
  _localStorage: LocalStorageService;
  isExpanded = false;

  constructor(sharedModel: SharedModelService, localStorage: LocalStorageService) {
    this._sharedModel = sharedModel;
    this._localStorage = localStorage;
  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit(): void {
  }

}
