using System;

namespace MakingSense
{
    class Program
    {
        
            /*  static void Main(string[] args){
                        
                }*/
          static void Main(string[] args){
            int intOpcion;
             do
             {
              Console.Clear();
              Console.WriteLine("INgrese una Opcion\n");
              Console.WriteLine("------------------\n");
              Console.WriteLine("1.Verificación de Likes \n 2.¿Que dia es? \n3.suma\n04.resta\n5.multiplicacion\n6.division\nPulse 7 o un valor mas alto para salir.");
              intOpcion = Convert.ToInt32(Console.ReadLine());

            
               
               switch (intOpcion)
                 {
                     case 1: likes();
                      break;
                     case 2: revisarDias();
                     break;
                     case 3: suma();
                     break;
                     case 4: resta();
                     break;
                     case 5: multiplicacion();
                     break;
                     case 6: division();
                     break;
                     
                 }  
             } while (intOpcion !=7);

         

          static void likes(){
                  var friends = new[] {"Pedro","Dario","Joni","Mili"};
                
                    // length
              foreach (var item in friends)
              { 
                 Console.WriteLine("A "+ item+ " like your Post.");    
                 Console.ReadKey();
              }      
              
              
              
          }

          static void revisarDias(){
                  Console.Clear();
                  DateTime dateTime = DateTime.Now;
                  Console.WriteLine(Convert.ToDateTime(dateTime));
                  Console.ReadKey();

                  
          }

          static void suma(){
          
            Console.Clear();
            Console.WriteLine("Ingrese un valor a Sumar:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el sig valor a Sumar:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b ;
            Console.WriteLine ("\n La suma de "+ a + "+"+ b +"es ="+c);
            Console.ReadKey();

          }

          static void resta(){
          
            Console.Clear();
            Console.WriteLine("Ingrese un valor a restar:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el sig valor a restar:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a - b ;
            Console.WriteLine ("\n La resta de "+ a + "-"+ b +"es ="+c);
            Console.ReadKey();
          }

          static void multiplicacion(){
          
            Console.Clear();
            Console.WriteLine("Ingrese un valor a multiplicacion:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el sig valor a multiplicacion:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b ;
            Console.WriteLine ("\n La multiplicacion de "+ a + "X"+ b +"es ="+c);
            Console.ReadKey();
          }

           static void division(){
          
            Console.Clear();
            Console.WriteLine("Ingrese un valor a division:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese el sig valor a division:");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a / b ;
            int d = a % b ;
            Console.WriteLine ("\n La division de "+ a +"y"+ b +"es ="+c);
            Console.WriteLine ("\n y su resto es "+c);
            Console.ReadKey();
          }
        
          }
    }
}
