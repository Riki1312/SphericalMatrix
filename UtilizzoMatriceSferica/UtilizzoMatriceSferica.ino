const int xSize = 4, ySize = 8;
int Matrice[xSize][ySize];

void setup() {
    //Esempi utilizzo
    SetM(0, 0, 5);
    SetM(-1, 0, 6);
    SetM(43, 0, 6);
    int val = GetM(0, 0);

    Serial.begin(9600);
    Serial.println(val);
}

void loop() {

}

int GetM(int x, int y)
{
    int ret[2];
    AbstractionM(x, y, ret);
    int i = ret[0];
    int j = ret[1];
    return Matrice[i][j];
}

void SetM(int x, int y, int value)
{
    int ret[2];
    AbstractionM(x, y, ret);
    int i = ret[0];
    int j = ret[1];
    Matrice[i][j] = value;
}

void AbstractionM(int x, int y, int ret[])
{
    int i, j;
    int dx = xSize - (x + 1);
    int dy = ySize - (y + 1);

    if (dx < 0)
        i = 0 - dx;
    else if (dx > 0)
        i = 0 + dx - 1;
    else
        i = x;
    if (dy < 0)
        j = 0 - dx;
    else if (dy > 0)
        j = 0 + dx - 1;
    else
        j = y;

    ret[0] = i;
    ret[1] = j;
}
