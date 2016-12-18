/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { PaymentSchemeTypeService } from './payment-scheme-type.service';

describe('PaymentSchemeTypeService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [PaymentSchemeTypeService
    });
  });

  it('should ...', inject([PaymentSchemeTypeService], (service: PaymentSchemeTypeService) => {
    expect(service).toBeTruthy();
  }));
});
