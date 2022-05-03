#include <stdio.h>
int main()
{
    int price1, price2, max;
    /*
    *Input amount of products from user
    */

    printf("Enter two numbers:");
    scanf("%d%d", &price1, &price2);

    /*
    *if price1 >price2 then
    *assign price to max
    *else
    *assign price2 to max
    */
    max = (price1 > price2)? price1 : price2;
    printf("max price %d and %d is %d, price1, price2, max");
    return 0;
}