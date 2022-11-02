using System;

public class ClaseSuma

{
    private int num1;
    private int num2;
    public ClaseSuma()
    {
    }

    public global::System.Int32 Num1 { get => num1; set => num1 = value; }
    public global::System.Int32 Num2 { get => num2; set => num2 = value; }

    public int suma()
    {
        return num1 + num1;
    }

}