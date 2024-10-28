import { Component } from '@angular/core';

import { RouterOutlet } from '@angular/router';

import { AddEmployeeComponent } from './components/add-employee/add-employee.component';

import { DataBindingComponent } from './components/data-binding/data-binding.component';

import { EmployeeListComponent } from './components/employee-list/employee-list.component';


@Component({

 selector: 'app-root',

 standalone: true,

 imports: [RouterOutlet, AddEmployeeComponent,EmployeeListComponent,DataBindingComponent],

 templateUrl: './app.component.html',

 styleUrl: './app.component.css'

})

export class AppComponent {

 title = 'my-first-project';

 coursename='dotnet';


}


