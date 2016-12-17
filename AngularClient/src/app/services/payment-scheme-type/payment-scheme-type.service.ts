import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from "rxjs/Observable";

import { ConfigurationService } from '../configuration/configuration.service';

import { PaymentSchemeTypeModel } from '../../models/models';

@Injectable()
export class PaymentSchemeTypeService {

  url: string = "PaymentSchemeTypes/";

  constructor(private http: Http, private configuration: ConfigurationService) { 

  }

  public getAllPaymentSchemeTypes(){
    return this.http.get(this.configuration.apiPath + this.url);
  }

}
