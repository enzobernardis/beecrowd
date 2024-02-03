#include <stdio.h>
 
int main() {
	float num[6], sum = 0.0;
	int count = 0;
	
    for(int i = 0; i < 6; i++){
    	scanf("%f", &num[i]);
    	if(num[i] >= 0.0) {
			count++;
			sum += num[i];
		}
    }
    
    sum = sum / count;
    
    printf("%d valores positivos\n%.1f", count, sum);
	
    return 0;
}
