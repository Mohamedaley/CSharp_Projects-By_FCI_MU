#include <stdio.h>
/**
 * second factorial program
 * Return: 0
*/
int main()
{
    int num;
    int temp;
    long long int fact = 1;

    scanf("%d", &num);
    while (num--)
    {
        scanf("%d", &temp);
        for (int i = 1; i <= temp; i++)
        {
            fact = fact * i;
        }
        printf("%lld\n", fact);
        fact = 1;
    }
    return (0);
}