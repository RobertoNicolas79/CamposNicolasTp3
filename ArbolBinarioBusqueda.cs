using System;
using System.Collections.Generic;


namespace Tp3
{

	public class ArbolBinarioBusqueda{
		
		private IComparable dato;
		private ArbolBinarioBusqueda hijoIzquierdo;
		private ArbolBinarioBusqueda hijoDerecho;
		
		
		public ArbolBinarioBusqueda(IComparable dato){
			this.dato = dato;
		}
		
		
		public IComparable getDatoRaiz(){
			return this.dato;
		}
		
		public ArbolBinarioBusqueda getHijoIzquierdo(){
			return this.hijoIzquierdo;
		}
		
		public ArbolBinarioBusqueda getHijoDerecho(){
			return this.hijoDerecho;
		}
		
		public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo){
			this.hijoIzquierdo=hijo;
		}

		public void agregarHijoDerecho(ArbolBinarioBusqueda hijo){
			this.hijoDerecho=hijo;
		}
		
		public void eliminarHijoIzquierdo(){
			this.hijoIzquierdo=null;
		}
		
		public void eliminarHijoDerecho(){
			this.hijoDerecho=null;
		}
		
		public void agregar(IComparable elem) {
			
			//si el elemento es mayor que el dato en raiz...
			if(elem.CompareTo(this.dato) > 0){
				
				//si no tiene hijo derecho, agrego el elemento como nuevo hijo derecho...
				if(this.hijoDerecho == null)
					this.agregarHijoDerecho(new ArbolBinarioBusqueda(elem));
				
				//de lo contrario, llamo recursivamente al metodo agregar...
				else
					this.hijoDerecho.agregar(elem);
			}
			
			//si el elemento es menor que el dato en raiz...
			else{
				
				//si hijo izquierdo esta vacio, agrego el elemento como nuevo hijo izquierdo...
				if(this.hijoIzquierdo == null)
					this.agregarHijoIzquierdo(new ArbolBinarioBusqueda(elem));
				
				//de lo contrario, llamar recursivamente al metodo agregar...
				else
					this.hijoIzquierdo.agregar(elem);
				
			}
		}
		
		
		public bool incluye(IComparable elem) {
			
			//Variable que almacena true/false
			bool respuesta = false;
			
			//primero verificar si es null...
			if(this.dato==null)
				respuesta = false;
			
			else{
				
				//Comparar si elemento es igual al dato almacenado en raiz...
				if(elem.CompareTo(this.dato) == 0)
				
					//Si es igual, retornar true...
					return true;
			
				//de lo contrario, verificar si es mayor o menor al dato raiz...
				else{
					
					if(elem.CompareTo(this.dato) > 0)
						
						//si es mayor, verificar si hijo derecho es null...
						if(this.hijoDerecho == null)
							
							//Si es null, retorna false..
							return false;
					
						else{
						
							//si no es null, llamada recursiva al metodo incluye...
							respuesta = this.getHijoDerecho().incluye(elem);
						}
					else{
						
						//si es menor, verificar si hijo izquierdo es null...
						if(this.hijoIzquierdo == null)
							
							//Si es null, retorna false..
							return false;
						
						else{
							
							//de lo contrario, llamar recursivamente al metodo incluye...
							respuesta = this.getHijoIzquierdo().incluye(elem);
						}
					}
					
					
					
				}
			}
			
			return respuesta;
				
		}	


		public void preOrden() {
			
			//Primero se procesa la raiz...
			Console.Write(this.getDatoRaiz()+"|");
			
			//Luego hijo izquierdo...
			if(this.getHijoIzquierdo()!=null)
				this.getHijoIzquierdo().preOrden();
			
			//Luego hijo derecho...
			if(this.getHijoDerecho()!=null)
				this.getHijoDerecho().preOrden();
			
		}
		
		public void inOrden() {
			
			//primero procesar hijo izquierdo...
			if(this.getHijoIzquierdo()!=null)
				this.getHijoIzquierdo().inOrden();
			
			//Luego se procesa la raiz...
			Console.Write(this.getDatoRaiz()+"|");
			
			//Luego hijo derecho...
			if(this.getHijoDerecho()!=null)
				this.getHijoDerecho().inOrden();
		}
		
		public void postOrden() {
			
			//primero procesar hijo izquierdo...
			if(this.getHijoIzquierdo()!=null)
				this.getHijoIzquierdo().postOrden();
			
			//Luego hijo derecho...
			if(this.getHijoDerecho()!=null)
				this.getHijoDerecho().postOrden();
			
			//Por ultimo se procesa la raiz...
			Console.Write(this.getDatoRaiz()+"|");
		}
		
		
	}
}