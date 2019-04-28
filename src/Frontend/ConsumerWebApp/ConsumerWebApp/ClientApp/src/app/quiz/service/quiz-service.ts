import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IQuiz } from '../interface/quiz-interface';

import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

@Injectable()
export class QuizService {

  constructor(@Inject('BASE_URL') private baseUrl: string, private httpclient: HttpClient) {

  }

  public email: string = localStorage.getItem("email");
  get(): Observable<IQuiz[]> {
    return this.httpclient.get<IQuiz[]>(this.baseUrl + 'v1/Quiz?userEmail=' + this.email+ '')
      .do(data => console.log('Quiz Data All: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  registerUser(quiz: IQuiz): Observable<IQuiz> {
    return this.httpclient.post<IQuiz>(this.baseUrl + 'v1/Quiz/RegisterQuiz?userEmail=' + this.email + '&quizid=' + quiz.quizId, null)
      .do(data => console.log('Quiz Post: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  startQuiz(quiz: IQuiz): Observable<IQuiz> {
    return this.httpclient.put<IQuiz>(this.baseUrl + 'v1/Quiz/StartQuiz?userEmail=' + this.email + '&quizid=' + quiz.quizId, null)
      .do(data => console.log('Quiz Put: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  private handleError(err: HttpErrorResponse) {
    console.log(err);
    return Observable.throw(err.message);
  }
}
