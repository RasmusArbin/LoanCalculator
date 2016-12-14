import { Component } from '@angular/core';
import { LoanTypeService } from './services/services';
import { LoanTypeModel } from './models/models';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  public loanTypes: Array<LoanTypeModel>;

  public selectedLoanTypeId: number;

  constructor(private loanTypeService: LoanTypeService){
    loanTypeService.getLoanTypes().subscribe(r => this.loanTypes = r.json());
  }

  public calculate(){
    alert(this.selectedLoanTypeId);
  }
}
