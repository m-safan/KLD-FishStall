import { Injectable } from '@angular/core';
import { LocalStorageService } from 'angular-2-local-storage';
import { User } from './models.service';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class SharedModelService {

  public User: User;
  public BaseURI: string;

  constructor(localStorage: LocalStorageService) {
    this.BaseURI = 'https://localhost:44383/';
    this.User = JSON.parse(localStorage.get('userCredentails'));
  }
}
