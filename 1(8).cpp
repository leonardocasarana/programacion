#include<stdio.h>
#include<ctype.h>
#include<conio.h>
int mystrlen(char *s);

int main(void){
	
	int n;
	char cad[50];
	
	printf("Introduce la cadena: ");
	gets(cad);
	n=mystrlen(cad);
	printf("\nEl numero de caracteres de la cadena s fue %d",n);
	getch();
}

int mystrlen(char *s){
	
	int c=0;
	
	while(1){
		if(*s=='\0'){
			break;
		}
		c++;
		s++;
	}
	return c;
}
