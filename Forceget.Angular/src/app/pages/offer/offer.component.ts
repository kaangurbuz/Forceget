import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormControl,
  FormGroup,
  NonNullableFormBuilder,
  ValidatorFn,
  Validators,
  ReactiveFormsModule,
  FormsModule
} from '@angular/forms';
import { NzSelectModule } from 'ng-zorro-antd/select';
import { NzFormModule, NzFormTooltipIcon } from 'ng-zorro-antd/form';
import { NzInputModule } from 'ng-zorro-antd/input';
import { NzAutocompleteModule } from 'ng-zorro-antd/auto-complete';
import { HttpClient } from '@angular/common/http';
import {City, ParameterData, PostOfferData} from './offer.interfaces';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-offer',
  standalone: true,
  imports: [NzFormModule, ReactiveFormsModule, NzInputModule, NzSelectModule, NzAutocompleteModule, FormsModule,CommonModule],
  templateUrl: './offer.component.html',
  styleUrl: './offer.component.scss'
})
export class OfferComponent implements OnInit {
  validateForm: FormGroup<{
    mode: FormControl<string>;
    movementType: FormControl<string>;
    incoterm: FormControl<string>;
    cityId: FormControl<number>;
    unit1: FormControl<string>;
    unit1Quantity: FormControl<number>;
    unit2: FormControl<string>;
    unit2Quantity: FormControl<number>;
    currencyId: FormControl<number>;
    packageTypeId: FormControl<number>;
  }>;
  unit1Input?: string;
  unit2Input?: string;
  cities: any[] = [];
  packageTypes: any[] = [];
  currencies: any[] = [];
  defaultUnit1 = 'cm';
  defaultUnit2 = 'kg';
  selectedCityValue = null;
  selectedPackageTypeValue = null;
  selectedCurrencyValue = null;

  submitForm(): void {
    if (this.validateForm.valid) {
      console.log('submit', this.validateForm.value);
      this.http.post<PostOfferData>('https://localhost:7193/api/Offer', this.validateForm.value).subscribe(
      response => {
        console.log('Success');
      },
      error => {
        console.error('Error');
      }
    );
    } 
    else {
      Object.values(this.validateForm.controls).forEach(control => {
        if (control.invalid) {
          control.markAsDirty();
          control.updateValueAndValidity({ onlySelf: true });
        }
      });
    }
  }

  constructor(private fb: NonNullableFormBuilder, private http: HttpClient) {
    this.validateForm = this.fb.group({
      mode: ['', [Validators.required]],
      movementType: ['', [Validators.required]],
      incoterm: ['', [Validators.required]],
      cityId: [0, [Validators.required]],
      unit1: ['', [Validators.required]],
      unit1Quantity: [0, [Validators.required]],
      unit2: ['', [Validators.required]],
      unit2Quantity: [0, [Validators.required]],
      currencyId: [0, [Validators.required]],
      packageTypeId: [0, [Validators.required]]
    });
  }

  ngOnInit() {
  this.fetchItems();
  }


  fetchItems() {
    this.http.get<ParameterData>('https://localhost:7193/api/Offer/parameters').subscribe(
      data => {
        console.log('Data received:', data);
        this.cities = data.cities;
        this.currencies = data.currencies;
        this.packageTypes = data.packageTypes;
      },
      error => {
        console.error('Error fetching data:', error);
      }
    );
  }
}
