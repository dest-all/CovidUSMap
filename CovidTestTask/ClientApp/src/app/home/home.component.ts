import { HttpClient } from '@angular/common/http';
import { AfterContentChecked, Component, OnInit } from '@angular/core';
import { ColorsRange } from './colorsRange.component';
import { StatesColorisation } from './map.component';

@Component({
  selector: 'app-home',
  template: `
  <h2 style="margin-bottom: 10px;text-align:center;">
    U.S. COVID Risk Tracker
  </h2>

  <select matNativeControl [(ngModel)]="selectedOption" name="Metrics" style="border: none; border-bottom: ridge; outline: none; text-align:center; margin-left:40%; ">
      <option *ngFor="let option of options" [value]="option">
        {{option}}
      </option>
  </select>

  <map [geoJson]="geoJson" *ngIf="geoJson && statesColorisation" [statesColorisation]="statesColorisation">
  </map>

  <colors-range />`,
})
export class HomeComponent implements OnInit, AfterContentChecked {

  selectedOption: string = "Overall risk level"
  statesColorisation: StatesColorisation | undefined
  metrics: { [key: string]: Metrics } | undefined

  http: HttpClient
  geoJson: Object | undefined
  anchorId = "bind-map-here"

  options = [
    "Overall risk level",
    "Cases per 100k level",
    "Test positivity ratio level",
    "Infection rate level"
  ]

  constructor(httpClient: HttpClient) {
    this.http = httpClient;
  }

  ngOnInit(): void {
    const geoJsonUrl = "https://gist.githubusercontent.com/spiker830/e0d1b7950ced31369c903bed0cead7b1/raw/702c72e0ca5a1be95f84a50a58cfa6d4d6400f3f/us_features.json"
    const backendUrl = "http://localhost:5154/metrics";

    this.http.get(geoJsonUrl).toPromise().then(geoJson => this.geoJson = geoJson);
    this.http.get(backendUrl).toPromise().then(metrics => {
      const metricsDict = metrics as { [key: string]: Metrics }
      this.metrics = metricsDict
    })
  }
  
  ngAfterContentChecked(): void {
    this.statesColorisation = this.calculateStatesColorisation()
  }

  calculateStatesColorisation() {
    const metricsDict = this.metrics
    const i = this.options.findIndex(o => o == this.selectedOption);

    let levelSource: (m: Metrics) => number

    if (i == 0) {
      levelSource = m => m.overallRisk
    } else if (i == 1) {
      levelSource = m => m.casesDensity
    } else if (i == 2) {
      levelSource = m => m.testPositivity
    } else {
      levelSource = m => m.infection
    }

    const result: { [key: string]: string } = {};
    const colorsRange = ColorsRange.colorsRange();

    for (const stateId in metricsDict) {
      var stateInfo = metricsDict[stateId]
      const level = levelSource(stateInfo)
      const color: string = colorsRange[level]
      result[stateId] = color
    }

    return result;
  }
}

type Metrics = {
  overallRisk: number,
  casesDensity: number,
  testPositivity: number,
  infection: number
}
