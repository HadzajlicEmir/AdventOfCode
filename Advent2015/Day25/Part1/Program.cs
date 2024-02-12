ulong[,] values = new ulong[6050, 6050];

values[0,0] = 20151125;

ulong lastValue = 20151125;

for(int i = 1; i < 6050; ++i){
    int row = i;
    int column = 0;
    while(row >= 0){
        lastValue = (lastValue * 252533) % 33554393;
        values[row--, column++] = lastValue;
}
}

Console.WriteLine(values[3009, 3018]);