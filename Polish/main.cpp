#include "Stack.h"
#include <iostream>
#include <stdlib.h>
#include <exception>
#include <string>

using namespace std;

int priority(DAC);

int main()
{
	try
	{
		Stack stack;
		string infixString;

		bool previousWasNumber = false;
		unsigned int j = 0, position = 0;

		cout << "Enter notation: " << endl;
		getline(cin, infixString);
		infixString = "(" + infixString + ")";

		DAC *polishArray = nullptr;
		polishArray = new DAC[infixString.length()];

		for (unsigned int i = 0; i < infixString.length(); i++)
		{
			if (infixString[i] != ' ')
			{
				if ((infixString[i] >= '0' && infixString[i] <= '9') || (!previousWasNumber && infixString[i] == '-'))
				{
					polishArray[j].x = stod(infixString.substr(i), &position);
					i += position - 1;
					polishArray[j].isDouble = true;
					j++;
					previousWasNumber = true;
				}
				else
				{
					DAC currentOperator = { 0.0, infixString[i], false };
					if (priority(currentOperator) == 0)
					{
						stack.push(currentOperator);
					}
					if (priority(currentOperator) >= 1 && priority(currentOperator) <= 3)
					{
						if (!stack.isEmpty())
						{
							while (priority(currentOperator) <= priority(stack.onTop()))
							{
								polishArray[j] = stack.onTop();
								j++;
								stack.pop();
							}
							stack.push(currentOperator);
						}
					}
					if (priority(currentOperator) == 4)
					{
						while (priority(stack.onTop()) != 0)
						{
							polishArray[j] = stack.onTop();
							j++;
							stack.pop();
						}
						stack.pop();
					}
					if (priority(currentOperator) == -1)
					{
						cerr << "Error operator!" << endl;
						return -1;
					}
					previousWasNumber = false;
				}
			}
		}
		if (!stack.isEmpty())
		{
			cerr << "Incorrect expresion\n";
			return -1;
		}

		for (unsigned int i = 0; i < j; i++)
		{
			if (polishArray[i].isDouble)
				cout << polishArray[i].x;
			else
				cout << polishArray[i].operation;
			cout << " ";
		}
		cout << endl;

		for (unsigned int i = 0; i < j; i++)
		{
			if (polishArray[i].isDouble)
			{
				stack.push(polishArray[i]);
			}
			else
			{
				double resultDouble;
				DAC secondNumber = stack.onTop();
				stack.pop();
				DAC firstNumber = stack.onTop();
				stack.pop();
				if (polishArray[i].operation == '+')
				{
					resultDouble = firstNumber.x + secondNumber.x;
				}
				if (polishArray[i].operation == '-')
				{
					resultDouble = firstNumber.x - secondNumber.x;
				}
				if (polishArray[i].operation == '*')
				{
					resultDouble = firstNumber.x * secondNumber.x;
				}
				if (polishArray[i].operation == '/')
				{
					resultDouble = firstNumber.x / secondNumber.x;
				}
				if (polishArray[i].operation == '^')
				{
					resultDouble = pow(firstNumber.x, secondNumber.x);
				}
				DAC result = { resultDouble, 'H', true };
				stack.push(result);
			}
		}

		cout << stack.onTop().x << endl;
		stack.pop();

		if (!stack.isEmpty())
		{
			cerr << "Incorrect expresion\n";
			return -1;
		}

		delete[] polishArray;
	}
	catch (exception &e)
	{
		cerr << e.what() << endl;
	}

	return 0;
}

int priority(DAC symbol)
{
	if (symbol.operation == '(')
	{
		return 0;
	}
	if (symbol.operation == '+' || symbol.operation == '-')
	{
		return 1;
	}
	if (symbol.operation == '*' || symbol.operation == '/')
	{
		return 2;
	}
	if (symbol.operation == '^')
	{
		return 3;
	}
	if (symbol.operation == ')')
	{
		return 4;
	}
	return -1;
}