import { Component, OnInit, OnDestroy } from '@angular/core';
import { AuthService, FacebookLoginProvider, GoogleLoginProvider } from 'angular-6-social-login-v2';
import { SharedModelService } from '../shared-model.service';
import { LocalStorageService } from 'angular-2-local-storage';
import { Router } from '@angular/router';
import { User } from '../models.service';
import { WebApiService } from '../web-api.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  _authService: AuthService;
  _sharedModel: SharedModelService;
  _localStorage: LocalStorageService;
  _router: Router;

  public _email: string;
  public _password: string;

  constructor(authService: AuthService, sharedModel: SharedModelService,
    localStorage: LocalStorageService, router: Router, private webApiService: WebApiService) {
    this._authService = authService;
    this._sharedModel = sharedModel;
    this._localStorage = localStorage;
    this._router = router;
  }

  ngOnInit() {
  }

  Login() {
    const userDTO: User = new User();
    userDTO.Email = this._email;
    userDTO.Password = this._password;

    console.log(this._email);
    console.log(userDTO);

    this.webApiService.Post<User>('User/Login', userDTO, (response, error) => {
      if (error) { console.error(error); }
      if (response) {
        this._sharedModel.User = response;
        console.log(JSON.stringify(this._sharedModel.User));
        this._localStorage.set('userCredentails', JSON.stringify(this._sharedModel.User));
        this._router.navigate(['/home']);
      }
    });
  }

  SocialNewtowkLogin(provider) {
    let socialPlatformProvider;
    if (provider === 'facebook') {
      socialPlatformProvider = FacebookLoginProvider.PROVIDER_ID;
    } else if (provider === 'google') {
      socialPlatformProvider = GoogleLoginProvider.PROVIDER_ID;
    }

    this._authService.signIn(socialPlatformProvider).then(
      (loginResponse) => {
        const userDTO: User = new User();
        const x = JSON.parse(JSON.stringify(loginResponse));
        userDTO.Email = x.email;
        userDTO.Name = x.name;
        this.webApiService.Post<User>('User/SocialNewtowkLogin', userDTO, (response, error) => {
          if (error) { console.error(error); }
          if (response) {
            this._sharedModel.User = response;
            this._sharedModel.User.ImageURL = loginResponse.image;
            this._localStorage.set('userCredentails', JSON.stringify(this._sharedModel.User));
            this._authService.signOut().then(() => {
              this._router.navigate(['/home']);
            });
          }
        });
      }
    );
  }

  ngOnDestroy(): void {
  }
}
