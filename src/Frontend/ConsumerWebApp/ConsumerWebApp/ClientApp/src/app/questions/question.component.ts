import { Component, OnInit } from '@angular/core';
import { IQuestion } from './interface/question-interface';
import { QuestionService } from './service/question-service';
import { AlertService, MessageSeverity } from '../services/alert.service';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { Observable, Subscription } from 'rxjs/Rx';

@Component({
  templateUrl: './question.component.html',
  selector: 'question-list'
})
export class QuestionComponent implements OnInit {
  public selectedAnswerText: string = '';
  public selectedAnswer: string = '';
  public ticks = 0;
  public timer;
  // Subscription object
  private sub: Subscription;
  public Question: IQuestion = {
    award: 0,
    duration: 0,
    penalty: 0,
    questionCode: "",
    questionDescription: "",
    questionId: 0,
    questionTitle: "",
    questionType: "",
    quizId: 0,
    answers: [],
    selectedAnswer: 0

  };

  public currentQuestionId: number = 0;
  public caption: string = "Question";
  public errorMessage: any;
  public count: number = 1;
  public qId: number = 0;
  public uid: string = "";
  public qTitle: string = "";
  public qDuration: number = 0;
  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe(params => {
      this.qId = params.qid;
      this.uid = params.uid;
      this.qDuration = +params.duration;
      this.qTitle = params.quizName;
      console.log(this.qId);
      console.log(this.uid);
      this.getQuestion(params.qid, params.uid, this.currentQuestionId, params.duration, params.quizName);

    });
  }


  constructor(private service: QuestionService,
    private alertService: AlertService,
    private activatedRoute: ActivatedRoute) { }

  private getQuestion(quizId: number, email: string, currentQuestion: number,quizDuration:number,quizTitle:string): void {
    this.alertService.startLoadingMessage(this.caption, "Loading");
    this.service.get(quizId, email, currentQuestion)
      .subscribe(
      question => {
          this.Question = {
            award: question.award,
            duration: question.duration,
            penalty: question.penalty,
            questionCode: question.questionCode,
            questionDescription: question.questionDescription,
            questionId: question.questionId,
            questionTitle: question.questionTitle,
            questionType: question.questionType,
            quizId: question.quizId,
            answers: question.answers,
            selectedAnswer: 0
          }

          this.qTitle = quizTitle;
          this.qDuration =+ quizDuration;
          //this.timer = Observable.timer(question[0].duration);
          //// subscribing to a observable returns a subscription object
          //this.sub = this.timer.subscribe(t => this.goNext());
          console.log(this.Question);
          this.alertService.stopLoadingMessage();
        },
        error => {
          this.errorMessage = <any>error;
          this.alertService.stopLoadingMessage();
          this.alertService.showMessage(this.caption, this.errorMessage.toString(), MessageSeverity.error);

        });
  }


  private goNext() {
    this.alertService.startLoadingMessage(this.caption, "Loading");
    this.currentQuestionId++;
    this.count++;
    if (this.Question.questionType == "ShortAnswer") {
      this.Question.selectedAnswer = +this.selectedAnswerText;
    }
    else
      this.Question.selectedAnswer = +this.selectedAnswer;
    this.service.postResponse(this.Question)
      .subscribe(question => {
        this.getQuestion(this.qId, this.uid, this.currentQuestionId, this.qDuration, this.qTitle);
        this.alertService.stopLoadingMessage();
      },
        error => {
          this.errorMessage = <any>error;
          this.alertService.stopLoadingMessage();
          this.alertService.showMessage(this.caption, this.errorMessage.toString(), MessageSeverity.error);

        });
  }


}
