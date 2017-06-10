import * as ko from 'knockout';
import 'isomorphic-fetch';

interface ICustomer {
    customerId: number;
    firstName: string;
    lastName: string;
    phone: string;
    email: string;
    address1: string;
    address2: string;
    city: string;
    state: string;
    postCode: string;
}

class CustomerViewModel {
    public customers = ko.observableArray<ICustomer>();
    public firstName = ko.observable(null);
    public lastName = ko.observable(null);
    

    constructor() {
        fetch('/api/shop/customers')
            .then(response => response.json() as Promise<ICustomer[]>)
            .then(data => {
                this.customers(data);
                let c: ICustomer = data[0];

                this.firstName(c.firstName);
                this.lastName(c.lastName);
            });

        
    }

    public addCustomer = function () {
        
        let c = <ICustomer>{};
        c.customerId = 4;
        c.firstName = "Barry";
        c.lastName = "Line";
        c.phone = "024654865";
        alert(c);
        this.customers.push(c);
    }
}

export default { viewModel: CustomerViewModel, template: require('./customer.html') };
