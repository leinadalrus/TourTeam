import { Component } from '@angular/core';
import { Article } from "../../models/article";

@Component({
  selector: 'app-trading-card',
  templateUrl: './trading-card.component.html',
  styleUrl: './trading-card.component.css'
})
export class TradingCardComponent {
  articles: Article[] = [{ id: 0, title: "Jon Doe", content: "Hello, world!" },];
}
