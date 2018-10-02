import { Injectable } from '@angular/core';
import { LocalStorageService } from 'angular-2-local-storage';

@Injectable({
  providedIn: 'root'
})
export class SharedModelService {

  public User: UserDTO;
  public BaseURI: string;

  constructor(localStorage: LocalStorageService) {
    this.BaseURI = 'https://localhost:44383/';
    this.User = JSON.parse(localStorage.get('userCredentails'));
  }
}

export class UserDTO {
  Id: number;
  Name: string;
  Email: string;
  Role: string;
  Password: string;
}
