// Exercício do site URI "Numeros impares"
// Neste exercício o usuário irá digitar um numero inteiro. O programa vai executar mostrando a sequnêcia de numeros impares até o número digitado.


int X = int.Parse(Console.ReadLine());

for (int i = 1; i <= X; i++)
{
    if (i % 2 != 0){
    Console.WriteLine(i);
    }
}



