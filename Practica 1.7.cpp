#incluide "iostream
#incluide <stdio.h>
using namespace std;

int main()

{
   int A,B;
   float RES;
   //Mensaje de bienvenido
   cout <<"Hola Este Programa 1.7 Escribir el resultado de la expresion";
   
   //Se declaran los numeros que se sumaron  (pueden ser decimales)
   
   //Se pide el primer numero
   cout << "Por favor ingrese el valor de A: " << "\n";
   //Se asigna el primer valor a A
   cin >> A;
   //Se pide el segundo numero
   cout << "Por favor ingrese el valor de B: " << "\n";
   //Se asigna el segundo valor a B
   cin >> B;
   
   RES=((A+B)*(A+B))/3.0;
   
   //Se muestra el resultado 
   printf ("\n El resultado de la expresion es %5.4f \n", RES);
   cout << "EL RESULTADO DE LA EXPRESION ES " << RES <<"\n";
   return 0;
   
