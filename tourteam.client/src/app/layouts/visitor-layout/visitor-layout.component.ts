import { Component } from '@angular/core';
import { Customer } from "../../models/customer";

@Component({
  selector: 'app-visitor-layout',
  templateUrl: './visitor-layout.component.html',
  styleUrl: './visitor-layout.component.css'
})
export class VisitorLayoutComponent {
  customerQuery!: Customer
}
