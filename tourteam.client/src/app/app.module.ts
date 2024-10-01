import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ArticleComponent } from './components/article/article.component';
import { NavmenuComponent } from './components/navmenu/navmenu.component';
import { VisitorLayoutComponent } from './layouts/visitor-layout/visitor-layout.component';

@NgModule({
  declarations: [
    AppComponent,
    ArticleComponent,
    NavmenuComponent,
    VisitorLayoutComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
