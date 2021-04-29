/*
 * Creado por SharpDevelop.
 * Usuario: Nico
 * Fecha: 27/04/2021
 * Hora: 08:26 a.m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Tp3
{
	class Program
	{
		public static void Main(string[] args)
		{
			ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda(null);
			
			abb.agregar(3);
			abb.agregar(1);
			abb.agregar(4);
			abb.agregar(6);
			abb.agregar(8);
			abb.agregar(2);
			abb.agregar(5);
			abb.agregar(7);
			
			Console.WriteLine("****PREORDEN*****\n");
			abb.preOrden();
			
			Console.WriteLine("\n\n****POSTORDEN*****\n");
			abb.postOrden();
			
			Console.WriteLine("\n\n****INORDEN*****\n");
			abb.inOrden();
			
			Console.WriteLine("\n\nIngrese un valor (si el valor esta en el arbol, retornara 'true'.\nDe lo contrario sera 'false': ");
			int elemento =Convert.ToInt32( Console.ReadLine());
			Console.WriteLine("\n"+abb.incluye(elemento)+" Saludos :)");

			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}