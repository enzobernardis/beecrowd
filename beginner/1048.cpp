#include <stdio.h>
 
int main() {
	float base_salary, new_salary, money_earned;
	int percentage;
	
	scanf("%f", &base_salary);
	
	if(base_salary <= 400.00) {
		new_salary = base_salary * 1.15;
		money_earned = new_salary - base_salary;
		percentage = 15;
		
	} else if (base_salary >= 400.01 && base_salary <= 800.00) {
		new_salary = base_salary * 1.12;
		money_earned = new_salary - base_salary;
		percentage = 12;
	
	} else if (base_salary >= 800.01 && base_salary <= 1200.00) {
		new_salary = base_salary * 1.10;
		money_earned = new_salary - base_salary;
		percentage = 10;
	
	} else if (base_salary >= 1200.01 && base_salary <= 2000.00) {
		new_salary = base_salary * 1.07;
		money_earned = new_salary - base_salary;
		percentage = 7;
	
	} else {
		new_salary = base_salary * 1.04;
		money_earned = new_salary - base_salary;
		percentage = 4;
	
	}
	
	printf("Novo salario: %.2f\nReajuste ganho: %.2f\nEm percentual: %d %\n", new_salary, money_earned, percentage);
 
    return 0;
}
