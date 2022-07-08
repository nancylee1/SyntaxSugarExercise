//SYNTAX SUGAR Exercise 1:9
//Given the following code, change the code to implement:
//inferred typing
//string interpolation
//and the ternary operator



int answer = 4;
//string response;
string isAnswer = (answer < 9) ? "is less than nine" : "is greater than or equal to nine";
//if (answer < 9)
//{
//    response = answer + " is less than nine";
//}
//else
//{
//    response = answer + " is greater than or equal to nine";
//}
Console.WriteLine($"{answer} {isAnswer}");
