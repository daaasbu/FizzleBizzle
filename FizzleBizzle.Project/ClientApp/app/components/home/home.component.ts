import { Component, Inject } from '@angular/core';
import { FizzBuzzForm } from '../models/FizzBuzzForm';
import { Http } from '@angular/http';

import axios from 'axios';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
    styleUrls: ['./home.component.css']
})

export class HomeComponent {
    bazzValue = '';
    predicates = ['>', '>=', '<', '<=', '==', '!='];
    model = new FizzBuzzForm(null, null, null, null, null, null);
    bazzEnabled = false;
    generateClicked = false;
    output: string[] = [];
    integerRegex = /^-?[0-9][^\\.]*$/;
    submitted = false;





    onSubmit() { this.submitted = true; }


    public generateOnClick() {
        if (this.bazzEnabled) {
            axios.get(location.origin + '/api/fizzbuzzbazz/' + this.model.fizz + '/' + this.model.buzz + '/' + this.model.bazz + '/' + this.model.op + '/' + this.model.start + '/' + this.model.end)
                .then(value => {
                    this.output = value.data;
                    this.generateClicked = true;
                })
        }
        else {
            axios.get(location.origin + '/api/fizzbuzz/' + this.model.fizz + '/' + this.model.buzz + '/' + this.model.start + '/' + this.model.end)
                .then(value => {
                    this.output = value.data;
                    this.generateClicked = true;
                });

        }

    }

}
