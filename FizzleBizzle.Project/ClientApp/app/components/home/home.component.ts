import { Component } from '@angular/core';
import { FizzBuzzForm } from '../models/FizzBuzzForm'
@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})
export class HomeComponent {
    bazzValue = '';
    predicates = ['Predicate', '>', '>=', '<', '<=', '==', '!='];
    model = new FizzBuzzForm(null, null, null, null, null, null);
    bazzEnabled = false;

    submitted = false;

    onSubmit() { this.submitted = true; }

    public generateOnClick() {
        console.log(this.bazzEnabled);
    }
}
