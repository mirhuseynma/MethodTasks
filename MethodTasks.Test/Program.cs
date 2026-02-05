// verilmis stringin ilk 4 herfini ekrana yazdirin.
#region variables
string name = "mirhuseyn";
int[] nwarray = [1, -2, 3, -5];
#endregion

#region consols
Console.WriteLine(name.Substring(0, 4));
Console.WriteLine(string.Join(' ', NegativeToPositive(ref nwarray)));

Console.ReadLine();
#endregion

#region methods
int[] NegativeToPositive(ref int[] nwarray)
{
    int check = 0;
    for(int i = 0; i<nwarray.Length; i++)
    {
        if (check > nwarray[i])
            nwarray[i] *= -1;
    }
    foreach(int nw in nwarray)
    {
        //Console.WriteLine(nwarray);
    }
    return nwarray;
}
#endregion
