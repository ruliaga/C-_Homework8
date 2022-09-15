// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Даны две матрицы:");

int [,] array = new int [4,4];

int n=1;

for (int i=0; i<1;i++){
        for (int j=0; j<array.GetLength(0);j++){
            array[i,j]=n;
            n=n+1;
        }
        
n=n-1;
}
for (int i=0; i<array.GetLength(0);i++){
        for (int j=3; j<4;j++){
            array[i,j]=n;
            n=n+1;
        }
}

n=n-1;

for (int i=3; i<array.GetLength(0);i++){
        for (int j=3; j>0;j--){
            array[i,j]=n;
            n=n+1;
        }        
}

for (int i=3; i>0;i--){
        for (int j=0; j<1;j++){
            array[i,j]=n;
            n=n+1;
        }        
}

for (int i=1; i<2;i++){
        for (int j=1; j<3;j++){
            array[i,j]=n;
            n=n+1;
        }        
}
for (int i=2; i>1;i--){
        for (int j=2; j>0;j--){
            array[i,j]=n;
            n=n+1;
        }        
}

PrintArray(array);




void PrintArray (int [,] filledArray){
    for (int i=0; i<filledArray.GetLength(0); i++){
        for (int j=0; j<filledArray.GetLength(1); j++){
            if (filledArray[i,j]<10){
            Console.Write($"0{filledArray[i,j]}  ");
            } else {
                Console.Write($"{filledArray[i,j]}  ");
            }
        
         }
         Console.WriteLine();



    }
}
