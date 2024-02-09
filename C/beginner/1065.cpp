#include <stdio.h>
 
int main() {
	float num[5];
	int count = 0;
	
    for(int i = 0; i < 5; i++){
    	scanf("%f", &num[i]);
    	if((int)num[i] % 2 == 0) {
			count++;
		}
    }
    
    printf("%d valores pares\n", count);
    
    
    return 0;
}
