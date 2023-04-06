// See https://aka.ms/new-console-template for more information



using System;
using System.Diagnostics.CodeAnalysis;

//int[] numbers_f1 = { 1, 2, 3, 4 };


// StampaArray(int[] array): preso un array di numeri interi, stampa a video il contenuto dell’array in questa forma “[elemento 1, elemento 2, elemento 3, ...]
//StampaArray(numbers_f1);
void StampaArray(int[] array)
{
    Console.Write("array = [");
   for (int i = 0; i < array.Length; i++)
    {
        if(i!=array.Length-1) Console.Write($"{array[i]}, ");
        else Console.WriteLine($"{array[i]}]");
    }
}


//Quadrato(int numero) restituisce il quadrato del numero passato come parametro.
//for (int i = 0; i < numbers_f1.Length-1; i++) {Console.WriteLine($"il quadrato di {numbers_f1[i]} è:  {Quadrato(numbers_f1[i])}");}

int Quadrato (int numero) { return numero * numero; }


//ElevaArrayAlQuadrato(int[] array) preso un array di numeri interi, restituisce un nuovo array con tutti gli elementi elevati quadrato.
//StampaArray(numbers_f1); int[] x = ElevaArrayAlQuadrato(numbers_f1); StampaArray(x); StampaArray(numbers_f1);

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] arrayCopy = (int[]) array.Clone();

    for (int i = 0; i < arrayCopy.Length; i++)   {    arrayCopy[i] = Quadrato(array[i]);    }
    return arrayCopy;
}

//sommaElementiArray(int[] array): preso un array di numeri interi, restituisca la somma totale di tutti gli elementi dell’array.
//Console.WriteLine(SommaElementiArray(numbers_f1));

int SommaElementiArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum += array[i];
    }
    return sum;
}



int[] numbers_f2 = { 2, 6, 7, 5, 3, 9 };
//Stampare l’array di numeri fornito a video
StampaArray(numbers_f2);

//Stampare l’array di numeri fornito a video, dove ogni numero è stato prima elevato al quadrato (Verificare che l’array originale non sia stato modificato quindi ristampare nuovamente l’array originale e verificare che sia rimasto [2, 6, 7, 5, 3, 9])
int[] squareArray = ElevaArrayAlQuadrato(numbers_f2);
Console.Write("square-"); StampaArray(squareArray); StampaArray(numbers_f2);


//Stampare la somma di tutti i numeri
Console.WriteLine($"la somma di tutti gli elementi dell'array è: {SommaElementiArray(numbers_f2)}");

//Stampare la somma di tutti i numeri elevati al quadrati
Console.WriteLine($"la somma di tutti gli elementi dell'array è: {SommaElementiArray(squareArray)}");




//BONUS: Convertire le funzioni appena dichiarate in funzioni generiche
//chiedi all’utente quanti numeri voglia inserire, e dopo di che questi vengono inseriti a mano dall’utente esternamente. Rieseguire il programma con l’input preso esternamente dall’utente.


Console.Write("Inserisci il numero di elementi del tuo array: ");
int userNumber=Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[userNumber];
for (int i = 0;i<userArray.Length; i++)
{
    Console.Write($"aggiungi un valore in {i+1}°posizione: ");
    userArray[i] = Convert.ToInt32(Console.ReadLine());
}

AllInOne(userArray);

void AllInOne(int[] array)
{
    StampaArray(array);
    int[] squareArray = ElevaArrayAlQuadrato(array);
    Console.Write("square-"); StampaArray(squareArray); StampaArray(array);
    Console.WriteLine($"la somma di tutti gli elementi dell'array è: {SommaElementiArray(array)}");
    Console.WriteLine($"la somma di tutti gli elementi dell'array è: {SommaElementiArray(squareArray)}");
}