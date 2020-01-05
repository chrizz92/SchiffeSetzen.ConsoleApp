using System;

namespace SchiffeVersenken
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 10;
            int width = 10;
            int columnPosition = -1;
            int rowPosition = -1;
            char field;

            bool[,] gameField = new bool[height, width];
            string input = "";
            
            do
            {
                Console.Clear();
                field = 'A';
                for (int i = 0; i < (height*2)+2; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j == 0 && i ==0)
                        {
                            Console.Write(" ");
                            for (int k = 0; k < width; k++)
                            {
                                Console.Write("  {0} ", k);
                            }
                        }
                        else if (j == 0)
                        {
                            if (i % 2 != 0)
                            {
                                Console.Write(" ");
                            }
                            else
                            {
                                Console.Write("{0}",field);
                                field++;
                            }
                        }

                        if(i>0 && i % 2 == 0)
                        {
                            if (gameField[(i / 2 - 1), (j)])
                            {
                                input = "X";
                            }
                            else 
                            {
                                input = " ";
                            }

                            Console.Write("| {0} ",input);
                        }
                        else if(i>0 && i % 2 != 0)
                        {
                            Console.Write("+---");
                        }

                    }
                    if (i > 0)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine("|");
                        }
                        else
                        {
                            Console.WriteLine("+");
                        }

                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
           
                /** //Funktionierende Variante ohne Abstände
                
                Console.Write(" ");
                for (int k = 0; k < width; k++)
                {
                    Console.Write(k);
                }
                Console.WriteLine();

                for (int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width+1; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("{0}",((char)('A'+i)));
                        }
                        else
                        {
                            if (gameField[i, j - 1])
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("0");
                            }
                        }
                        
                    }
                    Console.WriteLine();
                }
                **/
                Console.Write("Auf welche Position sollen ein Schiffsteil gesetzt werden (z.B. B3)? <Zum Beenden 'E' eingeben>: ");
                input = Console.ReadLine();
                if (input.Length==2) 
                {
                    switch (input[0])
                    {
                        case 'A':
                            columnPosition = 0;
                            break;
                        case 'B':
                            columnPosition = 1;
                            break;
                        case 'C':
                            columnPosition = 2;
                            break;
                        case 'D':
                            columnPosition = 3;
                            break;
                        case 'E':
                            columnPosition = 4;
                            break;
                        case 'F':
                            columnPosition = 5;
                            break;
                        case 'G':
                            columnPosition = 6;
                            break;
                        case 'H':
                            columnPosition = 7;
                            break;
                        case 'I':
                            columnPosition = 8;
                            break;
                        case 'J':
                            columnPosition = 9;
                            break;
                            break;
                        default:
                            columnPosition = -1;
                            break;
                    }
                    switch (input[1])
                    {
                        case '0':
                            rowPosition = 0;
                            break;
                        case '1':
                            rowPosition = 1;
                            break;
                        case '2':
                            rowPosition = 2;
                            break;
                        case '3':
                            rowPosition = 3;
                            break;
                        case '4':
                            rowPosition = 4;
                            break;
                        case '5':
                            rowPosition = 5;
                            break;
                        case '6':
                            rowPosition = 6;
                            break;
                        case '7':
                            rowPosition = 7;
                            break;
                        case '8':
                            rowPosition = 8;
                            break;
                        case '9':
                            rowPosition = 9;
                            break;
                            break;
                        default:
                            rowPosition = -1;
                            break;
                    }
                }
                else
                {
                    rowPosition = -1;
                }
                

                if(columnPosition>=0 && rowPosition >=0)
                {
                    gameField[columnPosition, rowPosition] = true;
                }
                else if(input != "E")
                {
                    Console.WriteLine("Ungültige Eingabe - Bitte Taste drücken um fortzufahren");
                    Console.ReadKey();
                }
                
            } while (input != "E");
        }
    }
}
