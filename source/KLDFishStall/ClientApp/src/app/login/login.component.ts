import { Component, OnInit, OnDestroy } from '@angular/core';
import { AuthService, FacebookLoginProvider, GoogleLoginProvider } from 'angular-6-social-login-v2';
import { SharedModelService, UserDTO } from '../shared-model.service';
import { LocalStorageService } from 'angular-2-local-storage';
import { Router } from '@angular/router';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  _sub: any;
  _authService: AuthService;
  _sharedModel: SharedModelService;
  _localStorage: LocalStorageService;
  _router: Router;
  _httpClient: HttpClient;

  public _email: string;
  public _password: string;

  constructor(authService: AuthService, sharedModel: SharedModelService,
    localStorage: LocalStorageService, router: Router, httpClient: HttpClient) {
    this._authService = authService;
    this._sharedModel = sharedModel;
    this._localStorage = localStorage;
    this._router = router;
    this._httpClient = httpClient;
  }

  ngOnInit() {
  }

  Login() {
    const userDTO: UserDTO = new UserDTO();
    userDTO.Email = this._email;
    userDTO.Password = this._password;

    console.log(this._email);
    console.log(userDTO);

    this._httpClient.post<UserDTO>(this._sharedModel.BaseURI + 'api/User/Login', userDTO).subscribe(
      result => {
        this._sharedModel.User = result;
        console.log(JSON.stringify(this._sharedModel.User));
        this._localStorage.set('userCredentails', JSON.stringify(this._sharedModel.User));
        this._router.navigate(['/home']);
      },
      error => { console.error(error); }
    );
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
        const userDTO: UserDTO = new UserDTO();
        const x = JSON.parse(JSON.stringify(loginResponse));
        userDTO.Email = x.email;
        userDTO.Name = x.name;
        
        this._httpClient.post<UserDTO>(this._sharedModel.BaseURI + 'api/User/SocialNewtowkLogin', userDTO).
          subscribe(
            result => {
              this._sharedModel.User = result;
              this._localStorage.set('userCredentails', JSON.stringify(this._sharedModel.User));
              this._authService.signOut().then(() => {
                this._router.navigate(['/home']);
              });
            },
            error => console.error(error)
          );
      }
    );

    // this._sub = this._authService.login(provider).subscribe(
    //   (loginResponse) => {
    //     const userDTO: UserDTO = new UserDTO();
    //     const x = JSON.parse(JSON.stringify(loginResponse));
    //     userDTO.Email = x.email;
    //     userDTO.Name = x.name;

    //     this._httpClient.post<UserDTO>(this._sharedModel.BaseURI + 'api/User/SocialNewtowkLogin', userDTO).
    //       subscribe(
    //         result => {
    //           this._sharedModel.User = result;
    //           this._localStorage.set('userCredentails', JSON.stringify(this._sharedModel.User));
    //           this._authService.logout().subscribe((logoutResponse) => {
    //             this._router.navigate(['/home']);
    //           });
    //         },
    //         error => console.error(error)
    //       );
    //   }
    // );
  }

  ngOnDestroy(): void {
    if (this._sub != null) {
      this._sub.unsubscribe();
    }
  }
}
