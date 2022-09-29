import 'dart:math';
import 'dart:io';

List<String> change = ['1','2','3','4','5','6','7','8','9'];

void Welcome(){

  print("Welcome to the Tic Tac Toe Game!");
}

String ChooseSign(){

  print("Please enter number 1 or 2 to choose a sign");
  print("1. X\n2. O");
  String? sign = '';
  sign = stdin.readLineSync()!;

  if(sign=="1"){

    print("You have selected sign -> 'X'\n");
    sign="X";

  }else{

    print("You have selected sign -> 'O'");
    sign="O";
  }

  return sign;
}

void Base(int inputNumber, String inputSign){

  change[inputNumber]=inputSign;

  print("        |         |");
  print("    ${change[0]}   |    ${change[1]}    |     ${change[2]}");
  print("        |         |");
  print("-----------------------------");
  print("        |         |");
  print("    ${change[3]}   |    ${change[4]}    |     ${change[5]}");
  print("        |         |");
  print("-----------------------------");
  print("        |         |");
  print("    ${change[6]}   |    ${change[7]}    |     ${change[8]}");
  print("        |         |\n");
}

void EmptyBase(){

  print("        |         |");
  print("    ${change[0]}   |    ${change[1]}    |     ${change[2]}");
  print("        |         |");
  print("-----------------------------");
  print("        |         |");
  print("    ${change[3]}   |    ${change[4]}    |     ${change[5]}");
  print("        |         |");
  print("-----------------------------");
  print("        |         |");
  print("    ${change[6]}   |    ${change[7]}    |     ${change[8]}");
  print("        |         |\n");
}

void TicTacToe(String sign){
  
//-------------------Variables and Initialization----------------------

  String userSign = sign;       //for user
  String computerSign = "";

  Random rand = new Random();   //for computer
  int computerInput;
  bool isRandom = true;
  bool win = false;

  if(userSign=="O"){        //sign check

    computerSign = "X";

  }else{

    computerSign = "O";
  }


//-------------------Main Loop----------------------


  bool flag = true;
  //print("I am here");
  while(flag){                            //user cell number input continue


//-------------------User Input and Checking------------------


    stdout.write("Please Enter Cell Number - ");
    String? str = stdin.readLineSync()!;
    int userNumberInput = int.parse(str)-1;

    if(change[userNumberInput]=='O' || change[userNumberInput]=='X'){ //User userNumberInput is not clashing

      print("/nPlease Input Again!");
      continue;

    }else{

      print("\x1B[2J\x1B[0;0H");
//      print("\nYour Sign : ${userSign}");
      Base(userNumberInput, userSign);

    }

//-------------------Computer Random and Checking------------------

    while(isRandom)       //computer input is random and not clashin
    {
      computerInput = rand.nextInt(9);
      win = false;

      if( change[0]!='1' && change[1]!='2'  && change[2]!='3' && change[3]!='4' && change[4]!='5' && change[5]!='6' && change[6]!='7' && change[7]!='8' && change[8]!='9'){

         break;
      }

      if( (change[0]==change[1] && change[1] == change[2]) || (change[3]==change[4] && change[4] == change[5]) || (change[6]==change[7] && change[7] == change[8]) || (change[2]==change[4] && change[4] == change[6]) || (change[0]==change[3] && change[3] == change[6])  || (change[1]==change[4] && change[4] == change[7]) || (change[2]==change[5] && change[5] == change[8]) || (change[0]==change[4] && change[4] == change[8])  ){

       break;

      }

      if(change[computerInput]=='O' || change[computerInput]=='X'){

        continue;

      }else{

        print("\x1B[2J\x1B[0;0H");
        print("Your Sign : ${userSign}");
        print("Computer Sign : ${computerSign}");
        Base(computerInput, computerSign);
        win = true;
        break;
      }

    }


  //---------------------Game Win / Over Section-------------------------------

    if( (change[0]==change[1] && change[1] == change[2]) || (change[3]==change[4] && change[4] == change[5]) || (change[6]==change[7] && change[7] == change[8]) || (change[2]==change[4] && change[4] == change[6]) || (change[0]==change[3] && change[3] == change[6])  || (change[1]==change[4] && change[4] == change[7]) || (change[2]==change[5] && change[5] == change[8]) || (change[0]==change[4] && change[4] == change[8]) ){

      if(win){

        print("\nComputer Wins the Game!\n\n");
        flag = false;

      }else{

        print("\nCongratulations! You have won the game!\n\n");
        flag = false;

      }
    }

    if( change[0]!='1' && change[1]!='2'  && change[2]!='3' && change[3]!='4' && change[4]!='5' && change[5]!='6' && change[6]!='7' && change[7]!='8' && change[8]!='9'){

      print("\n\nThe Game is Over!");
      break;
    }
  }




}
void main(){

  Welcome();
  String sign = ChooseSign();
  //String sign = "O";
  EmptyBase();
  TicTacToe(sign);
}