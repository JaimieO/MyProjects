#include <stdio.h>
#include <ctype.h>
#include <string.h>
#include <stdlib.h>
#include <time.h>

#define COL 10
#define ROW 'J'
char getVertical(char(*main)[COL], char row, int col, char row2, int col2, int size);
char getHorizontal(char(*main)[COL], char row, int col, char row2, int col2, int size);
void newBoard(char(*main)[COL], char(*side)[COL]);
int checkHorizontal(char(*main)[COL], char row, int col, char row2, int col2, int size);
int checkVertical(char(*main)[COL], char row, int col, char row2, int col2, int size);
void printBoard(char main[][COL], char(*side)[COL]);
void getBoard(char main[][COL], char(*side)[COL]);
void myShips(char(*main)[COL], char row, int col, int *counter);
void opponentShips(char(*side)[COL], char row, int col, int *hisCounter);
int checkSide(char(*side)[COL], char row, int col);
int checkMain(char(*side)[COL], char row, int col);
int whichPlayer();
void main()
{
	int col = 0, i = 0, countShips = 7, shipSize = 5, flag = 0, myCounter = 18, hisCounter = 18;
	char row = 0, choice = 0;
	char main[COL][COL] = { 0 };
	char side[COL][COL] = { 0 };
	srand(time(NULL));
	printf("Welcome \tto \tBattleships\n\n");
	while (choice != 'N')
	{
		getBoard(main, side);
		printBoard(main, side);
		newBoard(main, side);
		printBoard(main, side);
		flag = whichPlayer();
		do {
			if (flag)
			{
				printBoard(main, side);
				do{
				printf("\nYou'r turn, Please enter a point to attack: ");
				getchar();
				scanf("%c%d", &row, &col);
				} while (checkSide(side, row, col));
				opponentShips(side, row, col, &hisCounter);
				flag = 0;
			}
			else
			{
				printBoard(main, side);
				do {
					printf("\nOpponent's turn, Please enter the point he attacked: ");
					getchar();
					scanf("%c%d", &row, &col);
				} while (checkMain(main, row, col));
					myShips(main, row, col, &myCounter);
				flag = 1;
			}
		} while (!(myCounter == 0 || hisCounter == 0));
		printBoard(main, side);
		if (myCounter == 0)
		{
			printf("\n\nYou lose, better luck next time...\nWould you like to play again? Y/N: ");
			getchar();
			scanf("%c", &choice);
		}
		else
		{
			printf("\n\nYou win!!! Good job...\nWould you like to play again? Y/N: ");
			getchar();
			scanf("%c", &choice);
		}
		printf("\n\n");
	}
}
void printBoard(char (*main)[COL], char(*side)[COL])
{
	int  j = 1;
	char i = 'A';
	printf("\t\tOpponent Board\t\t\t\t\t\t\tYou'r Board");
	printf("\n\n\t");
	for (j = 1; j <= COL; j++)
	{
		printf("%d  ", j);
	}
	printf("\t\t\t\t");
	for (j = 1; j <= COL; j++)
	{
		printf("%d    ", j);
	}
	printf("\n\n\n");
	for (i; i <= ROW; i++)
	{
		printf("%c\t", i);
		for (j = 1; j <= COL; j++)
		{
			printf("%c  ", side[i][j]);
		}
		printf("\t\t\t");
		printf("%c\t", i);
		for (j = 1; j <= COL; j++)
		{
			printf("%c    ",main[i][j]);
		}
		printf("\n\n");
	}
}
void newBoard(char(*main)[COL], char(*side)[COL])
{
	int col = 0, col2 = 0, i = 0, countShips = 7, shipSize = 5, choice = 0;
	char row = 0, row2 = 0;
	do {
		printf("You have %d ships left, where would you like to place you'r ship (size %d)?\nPlease enter 1 for Horizontal, or 0 for Vertical: ", countShips, shipSize);
		scanf("%d", &choice);
		getchar();
		if (choice)
		{
			printf("Please enter two points that are Horizontal for you'r ship: ");
			scanf("%c%d", &row, &col);
			getchar();
			scanf("%c%d", &row2, &col2);
			if (checkHorizontal(main, row, col, row2, col2, shipSize) && row == row2)
			{
				getHorizontal(main, row, col, row2, col2, shipSize);
				countShips--;
				shipSize--;
				printBoard(main, side);
			}
			else
			{
				printf("\nInvalid Input, Please try again...\n");
			}
		}
		else
		{
			printf("Please enter two points that are Vertical for you'r ship: ");
			scanf("%c%d", &row, &col);
			getchar();
			scanf("%c%d", &row2, &col2);
			if (checkVertical(main, row, col, row2, col2, shipSize) && col == col2)
			{
				getVertical(main, row, col, row2, col2, shipSize);
				countShips--;
				shipSize--;
				printBoard(main, side);
			}
			else
			{
				printf("\nInvalid Input, Please try again...\n");
			}
		}
		if (countShips == 3 || countShips == 4)
		{
			shipSize = 2;
		}
		else if (countShips == 2 || countShips == 1)
		{
			shipSize = 1;
		}
		
	} while (countShips != 0);

}
char getVertical(char (*main)[COL], char row, int col, char row2, int col2, int size)
{
	char i = 0, count = 1;
	int j = 0, flag = 0;
	for (i = 'A'; i <= ROW; i++)
	{
		for (j = 1; j <= COL; j++)
		{
			if (row == i && col == j || row2 == i && col2 == j)
			{
				flag = 1;
				break;
			 }
		}
		if (flag)
		{
			break;
		}
	}
	for (count = 1; count < size+1; count++)
	{
		main[i][j] = size+48;
		i++;
	}
}
char getHorizontal(char(*main)[COL], char row, int col, char row2, int col2, int size)
{
	char i = 0, count = 1;
	int j = 0, flag = 0;
	for (i = 'A'; i <= ROW; i++)
	{
		for (j = 1; j <= COL; j++)
		{
			if (row == i && col == j || row2 == i && col2 == j)
			{
				flag = 1;
				break;
			}
		}
		if (flag)
		{
			break;
		}
	}
	for (count = 1; count < size+1; count++)
	{
		main[i][j] = size + 48;
		j++;
	}
}
int checkHorizontal(char(*main)[COL], char row, int col, char row2, int col2, int size)
{
	char i = 0, count = 1;
	int j = 0, flag = 0;
	for (i = 'A'; i <= ROW; i++)
	{
		for (j = 1; j <= COL; j++)
		{
			if (row == i && col == j || row2 == i && col2 == j)
			{
				flag = 1;
				break;
			}
		}
		if (flag)
		{
			break;
		}
	}
	for (count = 1; count < size+1; count++)
	{
		if (main[i][j] != '_')
		{
			return 0;
		}
		j++;
	}
	return 1;
}
int checkVertical(char(*main)[COL], char row, int col, char row2, int col2, int size)
{
	char i = 0, count = 1;
	int j = 0, flag = 0;
	for (i = 'A'; i <= ROW; i++)
	{
		for (j = 1; j <= COL; j++)
		{
			if (row == i && col == j || row2 == i && col2 == j)
			{
				flag = 1;
				break;
			}
		}
		if (flag)
		{
			break;
		}
	}
	for (count = 1; count < size+1; count++)
	{
		if (main[i][j] != '_')
		{
			return 0;
		}
		i++;
	}
	return 1;
}
void getBoard(char (*main)[COL], char (*side)[COL])
{
	char i = 0;
	int j = 0;
	for (i = 'A'; i <= ROW; i++)
	{
		for (j = 1; j <= COL; j++)
		{
			main[i][j] = '_';
			side[i][j] = '_';
		}
	}
}
int whichPlayer()
{
	char choice = 0;
	printf("You'r number is: %d\n", rand() % (20 - 1 + 1) + 1);
	printf("If you'r number is higher press 'Y', i you'r number is lower press 'N': ");
	getchar();
	scanf("%c", &choice);
	if (choice == 'Y')
	{
		return 1;
	}
	else
	{
		return 0;
	}
}
void myShips(char(*main)[COL], char row, int col, int *myCounter)
{
	char i = 0;
	int j = 0;
	if (main[row][col] != '_')
	{
		main[row][col] = 'X';
		(*myCounter)--;
	}
	else
	{
		main[row][col] = 'O';
	}
}
void opponentShips(char(*side)[COL], char row, int col, int *hisCounter)
{
	char choice = 0;
	printf("Did you hit a ship? Y/N: ");
	getchar();
	scanf("%c", &choice);
	if (choice == 'Y')
	{
		side[row][col] = 'X';
		(*hisCounter)--;
	}
	else
	{
		side[row][col] = 'O';
	}
}
int checkMain(char(*main)[COL], char row, int col)
{
	if (main[row][col] == 'X' || main[row][col] == 'O')
	{
		return 1;
	}
	return 0;
}
int checkSide(char(*side)[COL], char row, int col)
{
	if (side[row][col] != '_')
	{
		return 1;
	}
	return 0;
}