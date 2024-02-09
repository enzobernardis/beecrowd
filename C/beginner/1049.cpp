#include <stdio.h>
#include <string.h>

int main() {
    int points;
    char q1[99], q2[99], q3[99];

    scanf("%s", q1);
    scanf("%s", q2);
    scanf("%s", q3);

    if (strcmp(q1, "vertebrado") == 0) { 
        points += 0;
    } else {
        points += 1;
    }

    if (strcmp(q2, "ave") == 0) {
        points += 0;
    } else if (strcmp(q2, "mamifero") == 0) {
        points += 1;
    } else if (strcmp(q2, "inseto") == 0) {
        points += 2;
    } else if (strcmp(q2, "anelideo") == 0){
        points += 10;
    }

    if (strcmp(q3, "carnivoro") == 0) {
        points += 0;
    } else if (strcmp(q3, "onivoro") == 0) {
        points += 1;
    } else if (strcmp(q3, "herbivoro") == 0) {
        points += 2;
    } else if (strcmp(q3, "hematofago") == 0) {
        points += 3;
    }

    switch (points) {
        case 0:
            printf("aguia\n");
            break;
        case 1:
            printf("pomba\n");
            break;
        case 2:
            printf("homem\n");
            break;
        case 3:
            printf("vaca\n");
            break;
        case 6:
            printf("pulga\n");
            break;
        case 5:
            printf("lagarta\n");
            break;
        case 14:
            printf("sanguessuga\n");
            break;
        case 12:
            printf("minhoca\n");
            break;
    }

    return 0;
}

