#include <stdio.h>
 
int main() {
	int n, showed = 0;
	
	scanf("%d", &n);
	
	while(showed < 6) {
		if(n % 2 != 0) {
			printf("%d\n", n);
			showed++;
		}
		n++;
	}
 
    return 0;
}
