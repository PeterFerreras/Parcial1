// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

using System;

namespace PSeInt {
	class parcial {

		static void Main(string[] args) {
			int a;
			int b;
			double c;
			double d;
			Console.WriteLine("Seleccione el banco:");
			Console.WriteLine("Presione 1 para FDP INVERSMENTS");
			a = int.Parse(Console.ReadLine());
			switch (a) {
			case 1:
				Console.Clear();
				Console.WriteLine("Bienvenido a FDP INVERSMENTS");
				Console.WriteLine("Que se desea hacer retirar dinero o tranferir, Presione 1 Para retirar y Presione 2 para tranferir Dinero");
				b = int.Parse(Console.ReadLine());
				switch (b) {
				case 1:
					Console.Clear();
					Console.WriteLine("Ha seleccionado la opcion de retirar dinero. Limite 20,000");
					Console.WriteLine("Que monto desea retirar");
					c = Console.ReadLine();
					if (c>=20000) {
						Console.WriteLine("Lo sentimos, Ha excedido el limite de deposito");
					} else {
						Console.WriteLine("El deposito se ha realizado satisfactoriamiente");
					}
					break;
				case 2:
					Console.Clear();
					Console.WriteLine("Ha seleccionado la opcion de transferir dinero. Limite 10,000");
					Console.WriteLine("Que monto desea transferir");
					d = Console.ReadLine();
					if (d>=10000) {
						Console.WriteLine("Lo sentimos, Ha excedido el limite de transferenccia");
					} else {
						Console.WriteLine("La Transferencia se ha realizado satisfactoriamiente");
					}
					break;
				default:
					Console.Clear();
					Console.WriteLine("La opcion que selecciono no esta disponible");
				}
				break;
			default:
				Console.Clear();
				Console.WriteLine("La opcion que selecciono no esta disponible");
			}
		}

	}

}

