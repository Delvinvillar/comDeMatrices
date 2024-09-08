

namespace comDeMatrices
{
    public class comparacion
    {
        public void matriz()
        {
            int fila = 0;
            int columna = 0;
            int fila1 = 0;
            int columna1 = 0;
            try
            {
                Console.WriteLine("ingrese el numero de fila de la primera matriz ");
                fila = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el numero de columna de la primera matriz ");
                columna = Convert.ToInt32(Console.ReadLine());

                int[,]matriz1 = new int[fila, columna];
                Console.WriteLine("ingrese los elementos de la primeras matriz");
                for (int i = 0; i < fila; i++)
                {
                    for (int j = 0; j < columna; j++)
                    {
                        matriz1[i, j]= Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.WriteLine("ingrese el numero de fila de la segunda  matriz ");
                fila1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("ingrese el numero de columna de la segunda  matriz ");
                columna1 = Convert.ToInt32(Console.ReadLine());

                int[,] matriz2 = new int[fila1, columna1];
                Console.WriteLine("ingrese los elementos de la segunda  matriz");
                for (int i = 0; i < fila1; i++)
                {
                    for (int j = 0; j < columna1; j++)
                    {
                        matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                bool sonIguales = true;
                if (fila != fila1 || columna != columna1)
                {
                    sonIguales = false;
                }
                else
                {
                    for (int i = 0; i < fila; i++)
                    {
                        for (int j = 0; j < columna; j++)
                        {
                            if (matriz1[i, j] != matriz2[i, j])
                            { 
                             sonIguales = false;
                             break;
                            }
                        }
                    }
                }
                if (sonIguales)
                {
                    Console.WriteLine("las matrices son iguales");
                }
                else
                { 
                 Console.WriteLine("las matrices no son iguales ");
                }
            } 
            catch (Exception ex) 
            {
                Console.WriteLine($"hay un error {ex.Message}");
            }
        }
    }
}
