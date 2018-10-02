import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-locate-us',
  templateUrl: './locate-us.component.html',
  styleUrls: ['./locate-us.component.css']
})
export class LocateUsComponent implements OnInit {

  constructor() { }

  latitude = 13.019715;
  longitude = 77.554716;
  zoomPercentage = 17;

  ngOnInit() {
  }

}
