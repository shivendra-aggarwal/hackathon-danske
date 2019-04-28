import { Component, OnInit } from '@angular/core';
import { IQuiz } from './interface/quiz-interface';
import { QuizService } from './service/quiz-service';
import { LocalDataSource } from 'ng2-smart-table-extended';
import { DatePipe } from '@angular/common';
import { AlertService, MessageSeverity } from '../services/alert.service';
import { DataViewButtonComponent } from '../component/dataview-button.component';
@Component({
  templateUrl: './list.component.html',
  selector: 'quiz-list'
})

export class QuizListComponent implements OnInit {

  public quizList: IQuiz[] = [];
  public quiz: IQuiz;
  public errorMessage: any;
  public source: LocalDataSource = new LocalDataSource();
  public noData: boolean = false;
  public caption: string = "Quiz Data";
  settings;

  customSettings = {
    actions: {
      add: false,
      edit: false,
      delete: false,
    },
    noDataMessage: 'Loading Quiz Data...',
    columns: {
      quizName: {
        title: 'Quiz Name',
        type: 'text',
      },
      quizType: {
        title: 'Quiz Type',
        type: 'text',
      },
      startTime: {
        title: 'Start Time',
        type: 'text',
        valuePrepareFunction: (value) => { return this.date.transform(value, "dd-MM-yyyy HH:mm") },
      },
      endTime: {
        title: 'End Time',
        type: 'text',
        valuePrepareFunction: (value) => { return this.date.transform(value, "dd-MM-yyyy HH:mm") },
      },
      duration: {
        title: 'Duration (min)',
        type:'text'
      },
      action:
      {
        title: 'Action',
        type: 'custom',
        renderComponent: DataViewButtonComponent,
        onComponentInitFunction(instance) {
          instance.save.subscribe(row => {
            instance.updateStatus(row);
            //if (row.isRegistered) {
            //  alert(`${row.quizName} Registered Successfully!`);
            //  //refresh the page
            //}
            //else if (row.isStart) {
            //  //move to requiredpage
            //}
          });
        }
      }
    }
  };


  constructor(private service: QuizService,
    private date: DatePipe,
    private alertService: AlertService) {
  }
  ngOnInit(): void {
    this.getQuizList();
    this.source = new LocalDataSource();
    this.source.load(this.quizList);
    this.customSettings.noDataMessage = this.quizList.length > 0 ? '' : 'No Quiz data found';
    this.settings = Object.assign({}, this.customSettings);
    this.noData = !(this.quizList.length > 0);
  }

  private getQuizList(): void {

    this.alertService.startLoadingMessage(this.caption, "Loading");
    this.service.get()
      .subscribe(
        quiz => {
          quiz.forEach(element => {
            this.quizList.push(this.quiz = {
              endTime: element.endTime,
              quizDate: element.quizDate,
              quizId: element.quizId,
              quizName: element.quizName,
              quizPassword: element.quizPassword,
              quizType: element.quizType,
              startTime: element.startTime,
              email: element.email,
              isRegistered: element.isRegistered,
              isStart: element.isStart,
              status: element.status,
              duration: element.duration,
            });
          })
          console.log(this.quizList);
          this.alertService.stopLoadingMessage();
        },
        error => {
          this.errorMessage = <any>error;
          this.alertService.stopLoadingMessage();
          this.alertService.showMessage(this.caption, this.errorMessage.toString(), MessageSeverity.error);

        });
    //return this.quizList;
  }
  Register(qiD: number) {
    console.log(qiD);
  }

  private updateArrayItem(quiz: IQuiz): void {
    let Index: number = this.quizList.findIndex(x => x.quizId == quiz.quizId);
    if (Index >= 0)
      this.quizList[Index] = quiz;

  }
}
