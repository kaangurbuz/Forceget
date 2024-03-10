import { Component,OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {OfferData} from './offer-list-interfaces';
import {NzTableModule } from 'ng-zorro-antd/table';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-offer-list',
  standalone: true,
  imports: [NzTableModule,CommonModule],
  templateUrl: './offer-list.component.html',
  styleUrl: './offer-list.component.scss'
})
export class OfferListComponent implements OnInit {
  offers : any[] = [];
  constructor(private http: HttpClient) { }

  ngOnInit() { 
    this.fetchItems();
  }

  fetchItems() {
    this.http.get<OfferData[]>('https://localhost:7193/api/Offer').subscribe(
      data => {
        console.log('Data received:', data);
        this.offers = data;
      },
      error => {
        console.error('Error fetching data:', error);
      }
    );
  }
}
