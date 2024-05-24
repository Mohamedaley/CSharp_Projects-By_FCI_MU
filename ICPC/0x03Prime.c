#include <stdio.h>
#include <stddef.h>
/**
 * main - Function to determine if a given number prime or not
 * Return: 0 Success
 */
int main()
{
    int num;
    int half, temp;

    scanf("%d", &num);

    if (num == 2 || num == 3)
    {
        printf("YES");
        return (0);
    }
    half = num / 2;

    while (half > 1)
    {
        temp = num % half;
        if (temp == 0)
        {
            printf("NO");
            return (0);
        }
        half--;
    }

    printf("YES");
    return (0);
}