#include <stdio.h>
 
int main() {
	int start, end, hours;
	
	scanf("%d %d", &start, &end);
	
	if(start > end) {
		hours = (24 - start) + end;
	} else if(start < end) {
		hours = end - start;
	} else {
		hours = 24;
	}
 	
	printf("O JOGO DUROU %d HORA(S)\n", hours);
    return 0;
}
