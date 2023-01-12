#include <stdint.h>
#include <stdio.h>

int32_t csharp_add_method(int32_t a, int32_t b);

int main()
{
	printf("Hello world!");
	printf("%d\r\n", csharp_add_method(1, 2));
	return 0;
}