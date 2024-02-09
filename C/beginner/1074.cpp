#include <stdio.h>
 
int main() {
    int n;
    
    scanf("%d", &n);
    
    int num[n];
    
    for(int i = 0; i < n; i++) {
        scanf("%d", &num[i]);
    }
    
    for(int j = 0; j < n; j++) {
        if(num[j] == 0) {
            printf("NULL\n");
        } else {
            if(num[j] % 2 == 0) {
                printf("EVEN ");
            } else {
                printf("ODD ");
            }
            
            if(num[j] > 0) {
                printf("POSITIVE\n");
            } else {
                printf("NEGATIVE\n");
            }
        }
    }
 
    return 0;
}
