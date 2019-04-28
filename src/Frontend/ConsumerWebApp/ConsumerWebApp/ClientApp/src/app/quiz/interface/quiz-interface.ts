export interface IQuiz {
  quizId: number;
  quizName: string;
  quizType: string;
  quizDate: Date;
  startTime: Date;
  endTime: Date;
  quizPassword?: any;
  isStart: boolean;
  isRegistered: boolean;
  email: string;
  status: string;
  duration: number;

}
