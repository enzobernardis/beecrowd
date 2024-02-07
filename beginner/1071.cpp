#include <stdio.h>
 
int main() {
	int x, y, sum = 0;
	
	scanf("%d", &x);
	scanf("%d", &y);
	
	for (int i = y + 1; i < x; i++) {
        if (i % 2 != 0) {
            sum += i;
        }
    }
 	
	printf("%d\n", sum);
    return 0;
}
