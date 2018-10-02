import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LocalStorageService } from 'angular-2-local-storage';
import { SharedModelService } from '../shared-model.service';

@Component({
  selector: 'app-logout',
  templateUrl: './logout.component.html',
  styleUrls: ['./logout.component.css']
})
export class LogoutComponent implements OnInit {

  _localStorage: LocalStorageService;
  _sharedModel: SharedModelService;
  _router: Router;

  constructor(sharedModel: SharedModelService, localStorage: LocalStorageService, router: Router) {
    this._sharedModel = sharedModel;
    this._localStorage = localStorage;
    this._router = router;
  }

  ngOnInit() {
    this._localStorage.clearAll();
    this._sharedModel.User = null;
    this._router.navigate(['/home']);
  }

}
