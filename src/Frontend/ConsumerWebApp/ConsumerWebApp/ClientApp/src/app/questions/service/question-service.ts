import { Injectable, Inject } from "@angular/core";
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { IQuestion } from '../interface/question-interface';

import 'rxjs/add/operator/catch';
import 'rxjs/add/operator/do';

@Injectable()
export class QuestionService {

  constructor(@Inject('BASE_URL') private baseUrl: string, private httpclient: HttpClient) {

  }

  get(quizId: number, email: string, questionId: number): Observable<IQuestion> {
    return this.httpclient.get<IQuestion>(this.baseUrl + 'api/SampleData/question?QuizId=' + quizId + '&Email=' + email + '&QuestionId=' + questionId)
      .do(data => console.log('Question Data All: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  postResponse(question: IQuestion): Observable<IQuestion> {
    return this.httpclient.post<IQuestion>(this.baseUrl + 'api/SampleData/postQuestion', question)
      .do(data => console.log('Question Post: ' + JSON.stringify(data)))
      .catch(this.handleError);
  }

  //registerUser(quiz: IQuiz): Observable<IQuiz> {
  //  return this.httpclient.post<IQuiz>(this.baseUrl + 'api/SampleData/register', quiz)
  //    .do(data => console.log('Quiz Post: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  //startQuiz(quiz: IQuiz): Observable<IQuiz> {
  //  return this.httpclient.put<IQuiz>(this.baseUrl + 'api/SampleData/startQuiz', quiz)
  //    .do(data => console.log('Quiz Post: ' + JSON.stringify(data)))
  //    .catch(this.handleError);
  //}

  private handleError(err: HttpErrorResponse) {
    console.log(err);
    return Observable.throw(err.message);
  }
}
