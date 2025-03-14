using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio32
{
    class Rombo
    {
        private int tamaño;
        private char[,] matriz;

        public Rombo(int tamaño)
        {
            if (tamaño % 2 == 0)
            {
                throw new ArgumentException("El tamaño debe ser un número impar.");
            }

            this.tamaño = tamaño;
            matriz = new char[tamaño, tamaño];

            // Inicializar con espacios
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    matriz[i, j] = ' ';
                }
            }
        }

        public void Dibujar()
        {
            int mitad = tamaño / 2;
            for (int i = 0; i <= mitad; i++)
            {
                matriz[i, mitad - i] = '#';
                matriz[i, mitad + i] = '#';
                matriz[tamaño - i - 1, mitad - i] = '#';
                matriz[tamaño - i - 1, mitad + i] = '#';
            }
        }

        public void Mostrar()
        {
            for (int i = 0; i < tamaño; i++)
            {
                for (int j = 0; j < tamaño; j++)
                {
                    Console.Write(matriz[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}