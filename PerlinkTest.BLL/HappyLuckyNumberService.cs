using System;
using System.Collections.Generic;
using System.Text;

namespace PerlinkTest.BLL
{
    /// <summary>
    /// Serviço que contém a lógica para verificar se um número é feliz e Sortudo
    /// </summary>
    public static class HappyLuckyNumberService
    {
        private static int iterationsQuantity = 0;

        /// <summary>
        /// Método recursivo que executa a lógica para verificar se um número é féliz ou não
        /// </summary>
        /// <param name="number">Número a ser verificado</param>
        /// <returns>
        /// Uma String com uma mensagem dizendo se o número é Feliz ou Não-Feliz
        /// </returns>
        public static string IsHappyNumber(int number)
        {
            iterationsQuantity++;

            int houses = GetDecimalHouseQuantity(number);

            int[] numberArray = GetNumberSeparatedByDecimalHouses(number, houses);

            number = 0;

            for (int i = 0; i < houses; i++)
            {
                number = number + Convert.ToInt32(Math.Pow(numberArray[i], 2));
            }

            if (number.Equals(1))
            {
                return "Feliz";
            }
            else if (iterationsQuantity.Equals(100))
            {
                return "Não-Feliz";
            }

            return IsHappyNumber(number);
        }

        #region Utils

        /// <summary>
        /// Método auxiliar que retorna o número de casas decimais de um número inteiro
        /// </summary>
        private static int GetDecimalHouseQuantity(int number)
        {
            int houses = 1;

            while ((number = number / 10) > 0)
            {
                houses++;
            }

            return houses;
        }

        /// <summary>
        /// Método auxiliar que retorna um vetor cujo cada índice
        /// é o valor de uma casa decimal do número original
        /// </summary>
        private static int[] GetNumberSeparatedByDecimalHouses(int number, int houses)
        {
            int[] numberArray = new int[houses];
            string teste = number.ToString();
            char[] numberCharArray = teste.ToCharArray(0, houses);

            for (int i = 0; i < houses; i++)
            {
                numberArray[i] = Convert.ToInt32(numberCharArray[i].ToString());
            }

            return numberArray;
        }

        #endregion
    }
}
