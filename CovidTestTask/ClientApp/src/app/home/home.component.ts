import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { MatSelectModule } from '@angular/material/select'
import { StatesColorisation } from './map.component';

@Component({
  selector: 'app-home',
  template: `
  <h2 style="margin-bottom: 10px;">
    U.S. COVID Risk Tracker
  </h2>

  <select matNativeControl [(ngModel)]="selectedOption" name="Metrics" style="border: none; border-bottom: ridge; outline: none;">
      <option *ngFor="let option of options" [value]="option">
        {{option}}
      </option>
  </select>

  <map [geoJson]="geoJson" *ngIf="geoJson" [statesColorisation]="statesColorisation">
  </map>

  <colors-range />`,
})
export class HomeComponent implements OnInit {

  selectedOption: string = "Overall risk level"
  statesColorisation: StatesColorisation = { "AL": "blue" }
  options = [
    "Overall risk level",
    "Cases per 100k level",
    "Test positivity ratio level",
    "Infection rate level"
  ]

  ngOnInit(): void {
    const geoJsonUrl = "https://gist.githubusercontent.com/spiker830/e0d1b7950ced31369c903bed0cead7b1/raw/702c72e0ca5a1be95f84a50a58cfa6d4d6400f3f/us_features.json"
    this.http.get(geoJsonUrl).toPromise().then(geoJson => this.geoJson = geoJson);
  }

  http: HttpClient
  geoJson: Object | undefined
  anchorId = "bind-map-here"

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }

}
