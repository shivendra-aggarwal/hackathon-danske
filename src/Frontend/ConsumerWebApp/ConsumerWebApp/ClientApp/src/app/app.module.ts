import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { Ng2SmartTableModule } from 'ng2-smart-table-extended';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { QuizListComponent } from './quiz/list.component';
import { QuestionComponent } from './questions/question.component';
import { QuestionService } from './questions/service/question-service';
import { QuizService } from './quiz/service/quiz-service';
import { ToastyModule } from 'ng2-toasty';
import { DatePipe } from '@angular/common';
import { AlertService } from './services/alert.service';
import { DataViewButtonComponent } from './component/dataview-button.component';
@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    QuizListComponent,
    QuestionComponent,
    DataViewButtonComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    Ng2SmartTableModule,
    ToastyModule.forRoot(),
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'quiz', component: QuizListComponent },
      { path: 'question', component: QuestionComponent },
    ])
  ],
  entryComponents: [DataViewButtonComponent],
  exports: [ToastyModule],
  providers: [
    QuizService,
    QuestionService,
    DatePipe,
    AlertService,
    {
      provide: 'BASE_URL', useFactory: getBaseUrl
    },
    {
      provide: 'user', useFactory: getCurrentUser
    }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

export function getBaseUrl() {
  return document.getElementsByTagName('base')[0].href;
}

export function getCurrentUser() {
  return document.getElementsByTagName('base')[1].title;
}
