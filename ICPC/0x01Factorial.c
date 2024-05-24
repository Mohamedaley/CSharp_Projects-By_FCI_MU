#include <stdio.h>

/**
 * main - A function to print the factorial of given cases
 * Return: 0
 */
int main()
{
    int cases;
    scanf("%d", &cases);

    int arr[cases];
    
    for (int i = 0; i < cases; i++)
    {
        scanf("%d", &arr[i]);
    }

    for (int i = 0; i < cases; i++)
    {
        long int fact = 1;
        for (int j = 1; j <= arr[i]; j++)
        {
            fact *= j;
        }
        printf("%ld\n", fact);
    }

    return 0;
}