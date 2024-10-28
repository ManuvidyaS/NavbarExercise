import { Component } from '@angular/core';


// @Component({
//   selector: 'app-root',
//   standalone: true,
//   template: `
//     <p>Your color preference is {{ theme }}.</p>
//   `,
  
// })
// export class AppComponent {
//   theme = 'dark';
  
// }


import { FormsModule } from '@angular/forms';
@Component({
  standalone: true,
  imports: [FormsModule],
  selector:'app-root',
  template: `
    <main>
      <h2>Hello {{ firstName }}!</h2>
      <input type="text" [(ngModel)]="firstName" />
    </main>
  `
})
export class AppComponent {
  firstName = 'Ada';
}
