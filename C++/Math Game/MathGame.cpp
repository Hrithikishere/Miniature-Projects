#include <iostream>
#include <cstdlib>
#include <ctime>
#include <unistd.h>

using namespace std;

// Choose Game Print Only
void ChooseGamePrint();

// Choose Difficulty Le, vel Print Only
void ChooseLevelPrint();

// a funciton for Addition to check the Answer is right or wrong
void TestAnswerAdd(int Rand, int Rand2);

// a funciton for Substraction to check the Answer is right or wrong
void TestAnswerSub(int Rand, int Rand2);

// a funciton to for Multipication check the Answer is right or wrong
void TestAnswerMul(int Rand, int Rand2);

// a funciton to for Division check the Answer is right or wrong
void TestAnswerDiv(int Rand, int Rand2);

//easy random value
int RandomEasy();

//mid random value
int RandomMid();

//hard random value
int RandomHard();

//if else for Addition
void Addition(int SelectGame, int SelectLevel);

//main Addition funciton
void Addition(int SelectGame, int SelectLevel);

//main Substraction funciton
void Substraction(int SelectGame, int SelectLevel);

//main Multipication funciton
void Multipication(int SelectGame, int SelectLevel);

//main Division funciton
void Division(int SelectGame, int SelectLevel);

//main random game funciton
void RandomGame(int SelectGame, int SelectLevel);

//TestAnswerRand
void TestAnswerRand(int Rand);

int main()
{
    int Rand, Rand2,SelectLevel, SelectGame, Answer;
    
    srand(time(NULL));
    
    while(1)
    {
        
        ChooseGamePrint();
        
        cin>>SelectGame;
        
        usleep(500);
        system("clear");
        
        ChooseLevelPrint();
        
        cin>>SelectLevel;
        
        usleep(500);
        system("clear");
        
        Addition(SelectGame, SelectLevel);
        
        Substraction(SelectGame, SelectLevel);
        
        Multipication(SelectGame, SelectLevel);
        
        Division(SelectGame, SelectLevel);
        
        RandomGame(SelectGame, SelectLevel);
        
        //usleep(50000);
        //system("clear");
        
        cout<<"\nWant to play again?\nThen Press 1 or Press 0 to Exit\n";
        
        int Decision;
        cin>>Decision;
        if(Decision==0)
        {
            cout<<"\nThank you for playing this game!\n";
            break;
        }
        
        else if(Decision==1)
        {
            cout<<"Let's play again!\n";
        }
        
        else
        {
            cout<<"You're input is wrong. Please Select Between 1 or 0\n";
        }
        
        usleep(500);
        system("clear");
    }
    
    
    return 0;
}

//1st game choosing print
void ChooseGamePrint()
{
    cout<<"Welcome to Math Game\n"<<endl;
    cout<<"Choose a game to play"<<endl;
    cout<<"1. Addition"<<endl<<"2. Substraction"<<endl<<"3. Multipication"<<endl<<"4. Division"<<endl<<"5. Random Guessing"<<endl;
    cout<<"Enter your choice by inputting value from (1-5): ";
    
}

// Choose Difficulty Level Print Only
void ChooseLevelPrint()
{
    cout<<"Choose Difficulty Level\n"<<endl;
    cout<<"1. Easy (Up to 1 Digit Problem)"<<endl<<"2. Medium (Up to 2 Digit Problem)"<<endl<<"3. Hard (Up to 3 Digit Problem)"<<endl;
    cout<<"Enter your choice by inputting value from (1-3): ";
}

// a Addition funciton to check the Answer is right or wrong
void TestAnswerAdd(int Rand, int Rand2)
{
        cout<<"Problem: \n"<<Rand<<" + "<<Rand2<<" = ?"<<endl;
        
        int Answer, Result;
        
        cin>>Answer;
        
        Result=Rand+Rand2;
        
        if(Answer==Result)
        {
            cout<<"Congratulation!\n"<<endl;
        }
        
        else
        {
            cout<<"Wrong answer"<<endl;
            cout<<"Right answer is : "<<Result<<endl;
        }
}
//end
// a Substraction funciton to check the Answer is right or wrong
void TestAnswerSub(int Rand, int Rand2)
    {
        cout<<"Problem: \n"<<Rand<<" - "<<Rand2<<" = ?"<<endl;
        
        int Answer, Result;
        
        cin>>Answer;
        
        Result=Rand-Rand2;
        
        if(Answer==Result)
        {
            cout<<"Congratulation!\n"<<endl;
        }
        
        else
        {
            cout<<"Wrong answer"<<endl;
            cout<<"Right answer is : "<<Result<<endl;
        }
    }
//end

// a Multipication funciton to check the Answer is right or wrong
void TestAnswerMul(int Rand, int Rand2)
    {
        cout<<"Problem: \n"<<Rand<<" * "<<Rand2<<" = ?"<<endl;
        
        int Answer, Result;
        
        cin>>Answer;
        
        Result=Rand*Rand2;
        
        if(Answer==Rand*Rand2)
        {
            cout<<"Congratulation!\n"<<endl;
        }
        
        else
        {
            cout<<"Wrong answer"<<endl;
            cout<<"Right answer is : "<<Result<<endl;
        }
    }
//end

// a Division funciton to check the Answer is right or wrong
void TestAnswerDiv(int Rand, int Rand2)
    {
        cout<<"Problem: \n"<<Rand<<" / "<<Rand2<<" = ?"<<endl;
        
        double Answer, Result;
        
        cin>>Answer;
        
        Result=(double)Rand/(double)Rand2;
        
        if(Answer==Result)
        {
            cout<<"Congratulation!\n"<<endl;
        }
        
        else
        {
            cout<<"Wrong answer\n";
            cout<<"Right answer is : "<<Result<<endl;
        }
    }
//end

//TestAnswerRand//////////////////////////////////////////////////
void TestAnswerRand(int Rand)
{
    int Answer;
    cin>>Answer;
    
    if(Answer==Rand)
    {
        cout<<"Congratulation!\n"<<endl;
    }
    
    else
        {
            cout<<"Wrong answer\n";
            cout<<"Answer is : "<<Rand<<endl;
        }
}

//easy random value
int RandomEasy()
{
    int Random;
    Random = rand()%9;
    return Random;
}
//end
//mid random value
int RandomMid()
{
    int Random;
    Random = rand()%99;
    return Random;
}
//end
//hard random value
int RandomHard()
{
    int Random;
    Random = rand()%999;
    return Random;
}
//end
//full Addition calculator funciton
void Addition(int SelectGame, int SelectLevel)
{
    int Rand, Rand2, Answer;
    
    if(SelectGame==1 && SelectLevel==1)  //Addition Easy(1,1)
    {
        cout<<"Welcome to Addition Game at Easy Level\n"<<endl;
        Rand = RandomEasy();
        Rand2 = RandomEasy();
        TestAnswerAdd(Rand, Rand2);
    }
    
    else if(SelectGame==1 && SelectLevel==2)  //Addition Medium(1,2)
    {
        cout<<"Welcome to Addition Game at Medium Level\n"<<endl;
        Rand = RandomMid();
        Rand2 = RandomMid();
        
        TestAnswerAdd(Rand, Rand2);
    }
    
    else if(SelectGame==1 && SelectLevel==3)  //Addition Hard(1,3)
    {
        cout<<"Welcome to Addition Game at Hard Level\n"<<endl;
        Rand = RandomHard();
        Rand2 = RandomHard();
        TestAnswerAdd(Rand, Rand2);
    }
}
//end

//main Substraction funciton
void Substraction(int SelectGame, int SelectLevel)
{
    int Answer, Rand, Rand2;
    
    if(SelectGame==2 && SelectLevel==1)  //Substraction Easy
    {
        cout<<"Welcome to Substraction Game at Easy Level\n"<<endl;
        Rand = RandomEasy();
        Rand2 = RandomEasy();
        TestAnswerSub(Rand,Rand2);
    }
    
    else if(SelectGame==2 && SelectLevel==2)  //Substraction Medium
    {
        cout<<"Welcome to Substraction Game at Medium Level\n"<<endl;
        Rand = RandomMid();
        Rand2 = RandomMid();
        TestAnswerSub(Rand,Rand2);
    }
    
    else if(SelectGame==2 && SelectLevel==3)  //Substraction Hard
    {
        cout<<"Welcome to Substraction Game at Hard Level\n"<<endl;
        Rand = RandomHard();
        Rand2 = RandomHard();
        TestAnswerSub(Rand,Rand2);    
    }
}

//main Multipication funciton
void Multipication(int SelectGame, int SelectLevel)
{
    int Rand, Rand2, Answer;
    
    if(SelectGame==3 && SelectLevel==1)  //Multipication Easy
    {
        cout<<"Welcome to Multipication Game at Easy Level\n"<<endl;
        Rand = RandomEasy();
        Rand2 = RandomEasy();
        TestAnswerMul(Rand,Rand2);
    }
    
    else if(SelectGame==3 && SelectLevel==2)  //Multipication Medium
    {
        cout<<"Welcome to Multipication Game at Medium Level\n"<<endl;
        Rand = RandomMid();
        Rand2 = RandomMid();
        TestAnswerMul(Rand,Rand2);
    }
    
    else if(SelectGame==3 && SelectLevel==3)  //Multipication Hard
    {
        cout<<"Welcome to Multipication Game at Hard Level\n"<<endl;
        Rand = RandomHard();
        Rand2 = RandomHard();
        TestAnswerMul(Rand,Rand2);
    }
}
//end 
//main Division funciton
void Division(int SelectGame, int SelectLevel)
{
    int Rand, Rand2, Answer;
    
    if(SelectGame==4 && SelectLevel==1)  //Division Easy
    {
        cout<<"Welcome to Division Game at Easy Level\n"<<endl;
        Rand = RandomEasy();
        Rand2 = RandomEasy();
        TestAnswerDiv(Rand,Rand2);
    }
    
    else if(SelectGame==4 && SelectLevel==2)  //Division Medium
    {
        cout<<"Welcome to Division Game at Medium Level\n"<<endl;
        Rand = RandomMid();
        Rand2 = RandomMid();
        TestAnswerDiv(Rand,Rand2);
    }
    
    else if(SelectGame==4 && SelectLevel==3)  //Division Hard
    {
        cout<<"Welcome to Division Game at Hard Level\n"<<endl;
        Rand = RandomHard();
        Rand2 = RandomHard();
        TestAnswerDiv(Rand,Rand2);
    }
}
//end
//main Random Game funciton
void RandomGame(int SelectGame, int SelectLevel)
{
    int Rand, Rand2, Answer;
    if(SelectGame==5 && SelectLevel==1)  //Division Easy
    {
        cout<<"Welcome to Random Number Guessing Game at Easy Level\n"<<endl;
        Rand = RandomEasy();
        cout<<"Enter your number here: ";
        TestAnswerRand(Rand);
    }
    
    else if(SelectGame==5 && SelectLevel==2)  //Division Medium
    {
        cout<<"Welcome to Random Number Guessing Game at Medium Level\n"<<endl;
        Rand = RandomMid();
        cout<<"Enter your number here: ";
        TestAnswerRand(Rand);
    }
    
    else if(SelectGame==5 && SelectLevel==3)  //Division Hard
    {
        cout<<"Welcome to Random Number Guessing Game at Hard Level\n"<<endl;
        Rand = RandomHard();
        cout<<"Enter your number here: ";
        TestAnswerRand(Rand);
    }
}