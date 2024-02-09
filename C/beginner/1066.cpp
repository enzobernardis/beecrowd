#include <stdio.h>
 
int main() {
	float num[5];
	int even = 0, odd = 0, pos = 0, neg = 0;
	
    for(int i = 0; i < 5; i++){
    	scanf("%f", &num[i]);
    	if((int)num[i] % 2 == 0) {
    		even++;
		} else {
			odd++;
		}
		
		if(num[i] > 0.1) {
			pos++;
		} else if (num[i] < -0.1){
			neg++;
		}
    }
    
    printf("%d valor(es) par(es)\n%d valor(es) impar(es)\n%d valor(es) positivo(s)\n%d valor(es) negativo(s)\n", even, odd, pos, neg);
    
    
    return 0;
}
