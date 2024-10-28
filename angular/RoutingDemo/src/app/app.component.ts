import { Component } from '@angular/core';
import { RouterLinkActive, RouterOutlet, RouterLink} from '@angular/router';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterLink, RouterOutlet, RouterLinkActive],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'routingDemo';
}
