// user.model.ts

export class user {
    FirstName : string;
    LastName : string;
    City : string;
    Phone : string;
  
    constructor( FirstName : string,
        LastName : string,
        City : string,
        Phone : string) {
      
            this.FirstName=FirstName;
            this.LastName = LastName;
            this.City=City;
            this.Phone=Phone;
    }
  }
  