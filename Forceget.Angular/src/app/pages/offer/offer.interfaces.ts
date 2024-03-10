export interface ParameterData {
    cities: City[];
    currencies: Currency[];
    packageTypes: PackageType[];
  }
  
  export interface City {
    id: number;
    name: string;
    country: {
      id: number;
      name: string;
    };
  }
  
  export interface Currency {
    id: number;
    name: string;
    shortName: string;
  }
  
  export interface PackageType {
    id: number;
    name: string;
  }

  export interface PostOfferData {
    mode: string;
    movementType: string;
    incoterm: string;
    cityId: number;
    unit1: string;
    unit1Quantity: number;
    unit2: string;
    unit2Quantity: number;
    currencyId: number;
    packageTypeId: number;
  }