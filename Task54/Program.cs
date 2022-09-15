Console.Clear();
Console.WriteLine("Введите m (количество строк массива):");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите n (количество столбцов массива):");
int n=int.Parse(Console.ReadLine());
int [,] array = FillArray(m,n,0,10);
Console.WriteLine("Исходный массив:");
PrintArray(array);
Console.WriteLine("Упорядоченный массив:");
PrintArray(SortArray(array));

int [,] FillArray(int rows, int columns,  int min, int max){

    int [,] array = new int [rows,columns];
        for (int i=0; i<rows;i++){
            for (int j=0;j<columns;j++){
                array [i,j]=new Random().Next(min,max);
                
            }
        }
        return array;
}

void PrintArray (int [,] filledArray){
    for (int i=0; i<filledArray.GetLength(0); i++){
        for (int j=0; j<filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]}  ");
        
         }
         Console.WriteLine();



    }
}

int [,] SortArray (int [,] array){

        
        for (int i=0; i<array.GetLength(0);i++){

            for (int k=0; k<array.GetLength(1)-1; k++){
            for (int j=0; j<array.GetLength(1)-1; j++){
                   
                    
                    int help=0;
                    if (array [i,j]<array[i,j+1]){
                    help=array[i,j];
                    array[i,j]=array [i,j+1];
                    array [i,j+1]=help;
                }
                    
            
            }
            }
        }
    return array;
}