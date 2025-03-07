// ALUNO: Gabriell Henneg m. Santos
//CURSO: analise e desenvolvimento de sistemas
//Periodo: 5º
//DISCIPLINA: Estrutura de dados


Console.WriteLine("Algoritimo de KADANE");

int [] array = new int[8];
array = [-2,-3,4,-1,-2,1,5,-3];

int [] arrayResultados= new int [array.Length];// ARRAY PARA ARMAZENAR OS RESULTADOS (O TAMANHO SERA O MESMO DO ARRAY BASE)

int somaAtual = array[0]; // VARIAVEL PARA ARMAZENAR O PRIMEIRO VALOR
int maior = 0;
int menor = 0;

arrayResultados[0] = array[0];

//LAÇO PARA PERCORRER O ARRAY (INICIALIZANDO NO INDICE 1, POIS O INDICE 0 JÁ ESTA ATRIBUIDO)
for (int i = 1; i < array.Length; i++)
{
    
    somaAtual += array[i];
    arrayResultados[i] = somaAtual; 
    
    if(somaAtual > maior)
    {
        maior = somaAtual;
    }
    else if (somaAtual < menor)
    {
        menor = somaAtual;
    }

}

//LAÇO PARA IMPRIMIR OS RESULTADOS
for (int j = 0; j < arrayResultados.Length; j++)
{
    Console.WriteLine(arrayResultados[j]);
}

Console.WriteLine($"Maximo total: {maior}");
Console.WriteLine($"Minimo total: {menor}");

//FIM DO PROGRAMA!