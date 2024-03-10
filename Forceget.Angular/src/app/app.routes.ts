import { Routes } from '@angular/router';

export const routes: Routes = [
  { path: '', pathMatch: 'full', redirectTo: '/offer' },
  { path: 'offer', loadChildren: () => import('./pages/offer/offer.routes').then(m => m.OFFER_ROUTES) },
  { path: 'offer-list', loadChildren: () => import('./pages/offer-list/offer-list.routes').then(m => m.OFFER_LIST_ROUTES) }
];
