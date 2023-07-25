import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { MapComponent } from './home/map.component';
import { MatSelectModule } from "@angular/material/select"
import { BrowserAnimationsModule } from "@angular/platform-browser/animations"
import { ColorsRange } from './home/colorsRange.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    MapComponent,
    ColorsRange
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' }
    ]),
    MatSelectModule,
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
