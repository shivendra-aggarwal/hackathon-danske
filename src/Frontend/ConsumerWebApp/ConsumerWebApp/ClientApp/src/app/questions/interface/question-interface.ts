import { IAnswer } from "../../Answer/interface/answer-interface";

export interface IQuestion {
  quizId: number;
  questionId: number;
  questionTitle: string;
  questionDescription: string;
  questionCode: string;
  duration: number;
  award: number;
  penalty: number;
  questionType: string;
  answerList: IAnswer[];
  selectedAnswer: number;
}
