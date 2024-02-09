#include <stdio.h>
 
int main() {
	double a, b, c;
	scanf("%lf %lf %lf", &a, &b, &c);
	
	if(a < b){
		double temporario = a;
		a = b;
		b = temporario;
	}
	if(a < c){
		double temporario = a;
		a = c;
		c = temporario;
	}
	if(b < c){
		double temporario = b;
		b = c;
		c = temporario;
	}
	
	if(a >= b + c){
		printf("NAO FORMA TRIANGULO\n");
	} else {
		if(a * a == (b * b) + (c * c)) {
			printf("TRIANGULO RETANGULO\n");
		}
		if(a * a > (b * b) + (c * c)) {
			printf("TRIANGULO OBTUSANGULO\n");
		}
		if(a * a < b * b + c * c) {
			printf("TRIANGULO ACUTANGULO\n");
		}
		if(a == b && b == c) {
			printf("TRIANGULO EQUILATERO\n");
		} 
		if((a == b && a != c) || (a != b && a == c) || (b == c && b != a)) {
			printf("TRIANGULO ISOSCELES\n");
		}
	}
    return 0;
}
