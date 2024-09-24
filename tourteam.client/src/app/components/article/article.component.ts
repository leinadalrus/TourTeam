import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from '@angular/core';
import { Article } from "../../models/article";

@Component({
  selector: 'app-article',
  templateUrl: './article.component.html',
  styleUrl: './article.component.css'
})
export class ArticleComponent implements OnInit {
  public articles: Article[] = []

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getArticles()
  }

  getArticles(): void {
    this.http.get<Article[]>('/article').subscribe(
      (result) => {
        this.articles = result
      },
      (error) => {
        console.error(error)
      }
    )
  }
}
