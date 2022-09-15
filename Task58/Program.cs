Console.Clear();
Console.WriteLine("Даны две матрицы:");
Console.WriteLine();


int [,] matrix1=FillArray(2,2,0,10);
PrintArray(matrix1);
Console.WriteLine("----");
int [,] matrix2=FillArray(2,2,0,10);
PrintArray(matrix2);
Console.WriteLine();
Console.WriteLine("Результатирующая матрица:");
PrintArray(MultiMatrix(matrix1,matrix2));



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

int [,] MultiMatrix (int [,] matrix1, int [,] matrix2){

    int [,] multiMatrix=new int[matrix1.GetLength(0),matrix1.GetLength(1)];

    multiMatrix[0,0]=matrix1[0,0]*matrix2[0,0]+matrix1[0,1]*matrix2[1,0];
    multiMatrix[0,1]=matrix1[0,0]*matrix2[0,1]+matrix1[0,1]*matrix2[1,1];
    multiMatrix[1,0]=matrix1[1,0]*matrix2[0,0]+matrix1[1,1]*matrix2[1,0];
    multiMatrix[1,1]=matrix1[1,0]*matrix2[0,1]+matrix1[1,1]*matrix2[1,1];

    return multiMatrix;
}