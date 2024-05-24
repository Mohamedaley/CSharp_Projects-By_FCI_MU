#include <stdio.h>
/**
 * main - Entry point to a program will print the number from 1 to N
 * Return: (0)
*/
int main()
{
    int num;
    int i = 1;

    scanf("%d", &num);
    while (i < 13)
    {
        printf("%d * %d = %d\n",num, i, num * i);
        i++;
    }
    return (0);
}