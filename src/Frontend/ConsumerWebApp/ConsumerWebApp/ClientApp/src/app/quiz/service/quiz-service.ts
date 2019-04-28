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

  get(): Observable<IQuiz[]> {
    return this.httpclient.get<IQuiz[]>(this.baseUrl + 'api/SampleData/quiz')
      .do(data => console.log('Quiz Data All: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  registerUser(quiz: IQuiz): Observable<IQuiz> {
    return this.httpclient.post<IQuiz>(this.baseUrl + 'api/SampleData/register', quiz)
      .do(data => console.log('Quiz Post: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  startQuiz(quiz: IQuiz): Observable<IQuiz> {
    return this.httpclient.put<IQuiz>(this.baseUrl + 'api/SampleData/startQuiz', quiz)
      .do(data => console.log('Quiz Post: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  private handleError(err: HttpErrorResponse) {
    console.log(err);
    return Observable.throw(err.message);
  }
}
