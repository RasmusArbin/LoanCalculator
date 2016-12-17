import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

import { AppComponent } from './app.component';
import { LoanTypeService, ConfigurationService, PaymentSchemeTypeService } from './services/services';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpModule
  ],
  providers: [
    LoanTypeService,
    ConfigurationService,
    PaymentSchemeTypeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
