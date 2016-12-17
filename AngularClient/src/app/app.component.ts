import { Component } from '@angular/core';
import { LoanTypeService, PaymentSchemeTypeService } from './services/services';
import { LoanTypeModel, PaymentPlanModel, PaymentSchemeTypeModel } from './models/models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public loanTypes: Array<LoanTypeModel>;
  public paymentSchemeTypes: Array<PaymentSchemeTypeModel>;
  public paymentPlans: Array<PaymentPlanModel>;
  public selectedLoanTypeId: string;
  public selectedPaymentSchemeTypeId: string;
  public loanAmount: number;
  public yearCount: number;

  constructor(private loanTypeService: LoanTypeService, paymentSchemeTypeService: PaymentSchemeTypeService){
    loanTypeService.getLoanTypes().subscribe(r => this.loanTypes = r.json());
    paymentSchemeTypeService.getAllPaymentSchemeTypes().subscribe(r => this.paymentSchemeTypes = r.json());
  }

  public calculate(){
    this.loanTypeService.calculatePaymentPlan(this.selectedLoanTypeId, this.selectedPaymentSchemeTypeId, this.loanAmount, this.yearCount).subscribe(r => this.paymentPlans = r.json());
  }
}
