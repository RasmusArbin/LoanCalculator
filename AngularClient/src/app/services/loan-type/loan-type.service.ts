import { Injectable } from '@angular/core';
import { Http, Response } from '@angular/http';
import { Observable } from "rxjs/Observable";

import { ConfigurationService } from '../configuration/configuration.service';

import { LoanTypeModel } from '../../models/models';

@Injectable()
export class LoanTypeService {

  url: string = "LoanTypes/";

  constructor(private http: Http, private configuration: ConfigurationService) { 

  }

  public getLoanTypes(){
    return this.http.get(this.configuration.apiPath + this.url);
  }

  public calculatePaymentPlan(loanTypeId: string, paymentSchemeTypeId: string, loanAmount: number, yearCount: number){
    return this.http.get(this.configuration.apiPath + this.url + "/CalculatePaymentPlan?loanTypeId=" + loanTypeId + "&paymentSchemeTypeId=" + paymentSchemeTypeId + "&loanAmount=" + loanAmount + "&yearCount=" + yearCount);
  }

}
