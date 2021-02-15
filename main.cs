
   using System;

namespace parcial {
	class parcial {
   
  
   static void banv() {
    
     Console.Clear();
				Console.WriteLine("Bienvenido a FDP INVERSMENTS\n");
				Console.WriteLine("Presione 1 Para retirar y Presione 2 para tranferir Dinero\n");
        int b=0;
       
        b= Convert.ToInt32(Console.ReadLine());
        switch (b) {
			case 1:
			Console.Clear();
      	Console.WriteLine("Ha seleccionado la opcion de retirar dinero. Limite 20,000\n");
					Console.WriteLine("Que monto desea retirar\n");
					int c = 0;
          c = Convert.ToInt32(Console.ReadLine());
					if (c>=20001) 
          {
						Console.WriteLine("Lo sentimos, Ha excedido el limite de retiro\n");
					} else {
						
            int mil=1000;
            int quini=500;
            int dosci=200;
            int cien=100; 
            int suma= c/mil; 
            int suma1= c-(suma*1000);
            int suma2=suma1/quini;
            int sumaa= quini-suma1;
            int suma3= sumaa/dosci;
           int sumaf= sumaa-dosci;
            int suma5= sumaf/cien;
            
             
            
            
                Console.WriteLine("Cantidad de billetes de 1000"+suma);
                Console.WriteLine("Cantidad de billetes de 500"+suma2);
                Console.WriteLine("Cantidad de billetes de 200"+suma3);
                Console.WriteLine("Cantidad de billetes de 100"+suma5);
                Console.WriteLine("El retiro se ha realizado satisfactoriamiente\n"+c);
					}
			
				break;
        case 2:
        Console.Clear();
        Console.WriteLine("Ha seleccionado la opcion de transferir dinero. Limite 10,000\n");
					Console.WriteLine("Que monto desea transferir\n");
					int d=0;
          d = Convert.ToInt32(Console.ReadLine());
					if (d>=10001) {
						Console.WriteLine("Lo sentimos, Ha excedido el limite de transaccion\n");
					} else {
						Console.WriteLine("La transaccion se ha realizado satisfactoriamiente\n");
					}

        break;
       
        default:
				Console.Clear();
				Console.WriteLine("La opcion que selecciono no esta disponible\n");
        break;
      
        }
		
    }
    
    
    
    
    
    
    static void Main(string[] args) {
			int a=0;
			
			
			
			Console.WriteLine("Seleccione el banco:");
			Console.WriteLine("Presione 1 para FDP INVERSMENTS");

			a = int.Parse(Console.ReadLine());
		
    	switch (a) {
			case 1:
				banv();
			
				break;

       
        default:
				Console.Clear();
				Console.WriteLine("La opcion que selecciono no esta disponible");
        break;
      
        }
			}
		}

	}



