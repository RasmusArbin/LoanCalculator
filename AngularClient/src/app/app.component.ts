import { Component } from '@angular/core';
import { LoanTypeService } from './services/services';
import { LoanTypeModel, PaymentPlanModel } from './models/models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public loanTypes: Array<LoanTypeModel>;
  public paymentPlans: Array<PaymentPlanModel>;
  public selectedLoanTypeId: string;
  public loanAmount: number;
  public yearCount: number;

  constructor(private loanTypeService: LoanTypeService){
    loanTypeService.getLoanTypes().subscribe(r => this.loanTypes = r.json());
  }

  public calculate(){
    this.loanTypeService.calculatePaymentPlan(this.selectedLoanTypeId, this.loanAmount, this.yearCount).subscribe(r => this.paymentPlans = r.json());
  }
}
