#include <iostream>
#include "startShip.h"
#include "snake.h"

using namespace std;

int main(int argc, char const *argv[])
{

    system("cls");
    int Game = 0;

    cout <<"******************************"<< endl << endl;
    cout <<"        MENU DE JUEGO         "<< endl << endl;
    cout <<"******************************"<< endl;

    while (true)
    {   
        system("cls");
        cout <<"Seleccione el juego que desea jugar" << endl <<endl;
        cout <<"    1. StarShip " <<endl;
        cout <<"    2. Snake" <<endl;
        cin >> Game;

        switch (Game) 
        {
            case 1: 
               {
                    starShip();
                    break;
               }
            
            case 2: 
                {
                    snake();
                    break;
                }
            
            default:
                cout << "Ingrese una de las opciones validas" << endl;
                system("pause");
            
            

        
        }
    }
    

    return 0;
}
