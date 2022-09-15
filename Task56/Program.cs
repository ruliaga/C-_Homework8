Console.Clear();
Console.WriteLine("Введите m (количество строк массива):");
int m=int.Parse(Console.ReadLine());
Console.WriteLine("Введите n (количество столбцов массива):");
int n=int.Parse(Console.ReadLine());
int [,] array = FillArray(m,n,0,10);
Console.WriteLine("Исходный массив:");
PrintArray(array);

Console.WriteLine("Суммы строк массива:");
PrintOneRowArray(SumRowsArray(array));


RowNumber(SumRowsArray(array));


void RowNumber (int [] array){
        int min=array[0];
    for (int i=0; i<array.Length;i++){
        if(array[i]<min){
            min=array[i];
        }
    }

    for (int j=0; j<array.Length;j++){
        if (array[j]==min){
           Console.WriteLine($"Наименьшая сумма элементов в строке №{j+1}");
        }
        }
    }

    


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

void PrintOneRowArray (int [] filledArray){
    for (int i=0; i<filledArray.Length; i++){
        
            Console.Write($"{filledArray[i]}  ");
        
         }
         Console.WriteLine();

    }


int [] SumRowsArray (int [,] array){

        int [] SumRowsArray= new int [array.GetLength(1)];
        
        for (int i=0; i<array.GetLength(0);i++){
                  int sum=0;
            for (int j=0; j<array.GetLength(1); j++){
                   sum=sum+array[i,j];
                    
                    
                }
                  SumRowsArray[i]=sum;  
            
            }
            return SumRowsArray;
            }

       