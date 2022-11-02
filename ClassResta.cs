using System;

public class ClassResta

{
    private int num1;
    private int num2;
    public ClassResta()
    {
    }

    public global::System.Int32 Num1 { get => num1; set => num1 = value; }
    public global::System.Int32 Num2 { get => num2; set => num2 = value; }

    public int Resta()
    {
        return num1 - num2;
    }

}