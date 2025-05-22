// Matriz Inversão

int N;

N = 0;

int[,] mat = new int [4,4];

Console.WriteLine("Digite os elementos da matriz 4 x 4: ");

for (int i = 0; i < 4; i++) {
    for (int j = 0; j < 4; j++) {
        Console.Write("Elemento [" + i + "," + j + "]: ");
        mat[i, j] = int.Parse(Console.ReadLine());
    
    }    
} 

Console.WriteLine("Matriz digitada:");

for (int i = 0; i < 4; i++) {
    for (int j = 0; j < 4; j++) {
        Console.Write(mat[i, j].ToString().PadLeft(4));
    }
    Console.WriteLine();
}

Console.ReadKey();

// Inverter elementos da primeira linha com os da quarta coluna
        //for (int i = 0; i < 4; i++)
        //{
          //  int temp = mat[0, i];
            //mat[0, i] = mat[i, 3];
            //mat[i, 3] = temp;
        //}

        // Armazenar a primeira linha em um vetor temporário
int[] tempLinha = new int[4];
for (int i = 0; i < 4; i++)
{
    tempLinha[i] = mat[0, i];
}

// Substituir os elementos da primeira linha pelos da quarta coluna
for (int i = 0; i < 4; i++)
{
    mat[0, i] = mat[i, 3];
}

// Substituir os elementos da quarta coluna pelos valores salvos da primeira linha
for (int i = 0; i < 4; i++)
{
    mat[i, 3] = tempLinha[i];
}


        // Impressão da matriz após a inversão
        Console.WriteLine("\nMatriz após inverter a primeira linha com a quarta coluna:");
        for (int i = 0; i < 4; i++) {
            for (int j = 0; j < 4; j++) {
                Console.Write(mat[i, j].ToString().PadLeft(5));
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    




