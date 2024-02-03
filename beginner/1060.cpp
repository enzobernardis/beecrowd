#include <stdio.h>
 
int main() {
	float num[6];
	int count = 0;
	
    for(int i = 0; i < 6; i++){
    	scanf("%f", &num[i]);
    	if(num[i] >= 0.0) {
			count++;
		}
    }
    
    printf("%d valores positivos\n", count);
    
    
    return 0;
}
