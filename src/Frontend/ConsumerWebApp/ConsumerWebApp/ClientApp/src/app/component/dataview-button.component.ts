import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { ViewCell } from 'ng2-smart-table-extended';
import { DatePipe } from '@angular/common';
import { IQuiz } from '../quiz/interface/quiz-interface';
import { QuizService } from '../quiz/service/quiz-service';
import { Router } from '@angular/router';
@Component({
  selector: 'button-view',
  templateUrl: './dataview-button.component.html'
})
export class DataViewButtonComponent implements ViewCell, OnInit {
  renderValue: string;
  public QuizOver: boolean = false;
  public errorMessage: any;
  @Input() value: string | number;
  @Input() rowData: any;

  @Output() save: EventEmitter<any> = new EventEmitter();
  @Output() update: EventEmitter<any> = new EventEmitter();

  constructor(private date: DatePipe, private service: QuizService,
    private router: Router, ) { }
  ngOnInit() {
    let startDate: Date = new Date(this.rowData.startTime);
    let endDate: Date = new Date(this.rowData.endTime);
    let currentDate: Date = new Date();//this.date.transform(new Date(), "dd-MM-yyyy HH:mm");

    if (currentDate > endDate) {
      this.renderValue = "Quiz Over";
      this.QuizOver = true;
    } else if (currentDate >= startDate && currentDate < endDate) {
      this.QuizOver = false;
      if (this.rowData.isRegistered) {
        this.renderValue = "Start";
      }
      else if (this.rowData.isStart) {
        this.renderValue = "In-Progress";
      }

    }
    else if (currentDate < startDate)
      if (this.rowData.isRegistered) {
        this.renderValue = "Already Registered";
        this.QuizOver = true;
      }
    else
      this.renderValue = "Register";
  }

  onClick() {
    this.rowData.status = this.renderValue;
    this.save.emit(this.rowData);
  }

  updateStatus(quiz: IQuiz) {
    quiz.email = localStorage.getItem("email");
    if (quiz.status == 'Register') {
      //api call for Register
      this.service.registerUser(quiz)
        .subscribe(quiz => {
          //if (quiz.isRegistered) {
            this.renderValue = "Start";
            //alert(`${quiz.quizName} Registered Successfully!`);
            window.location.href = './quiz';
          //}
          //else if (quiz.isStart) {
          //  this.renderValue = "In-Progress";
          //  //move to Question Page
          //  //this.router.navigate(['/question', { qid: quiz.quizId, uid: `${quiz.email}` }]);
          //  window.location.href = './question?qid=' + quiz.quizId + '&uid=' + quiz.email + '&title=' + quiz.quizName + '&duration=' + quiz.duration;
          //}
        },
          error => this.errorMessage = <any>error
        );
    }
    else {
      //api call for Start
      if (!quiz.isStart) {
        this.service.startQuiz(quiz)
          .subscribe(q => {
           // if (quiz.isStart) {
              this.renderValue = "In-Progress";

              //this.router.navigate(['/question?qid=' + quiz.quizId + '&uid=' + quiz.email + '']);
              window.location.href = './question?qid=' + quiz.quizId + '&uid=' + quiz.email + '&title=' + quiz.quizName + '&duration=' + quiz.duration;
           // }
          },
            error => this.errorMessage = <any>error
          );
      }
      //navigate to question
    }
  }

  updateValue(quiz: IQuiz) {
    if (quiz.isRegistered) {
      this.renderValue = "Start";
    }
    else if (quiz.isStart) {
      this.renderValue = "In-Progress";
    }
  }

}
