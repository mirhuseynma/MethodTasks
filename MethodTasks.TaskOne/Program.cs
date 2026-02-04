Console.WriteLine(Sequance(5));
Console.WriteLine(string.Join(", ", ArraySequance(new int[]{ 1,5,8})));
Console.WriteLine(NoEmpty("Mirhuseyn Abdullazade Mirsedi oglu"));
Console.WriteLine(string.Join(", ", AddValuleToArray(new int[] { 1, 5, 8 },11)));
Console.WriteLine(Ndivided(7));
Console.WriteLine(CountSingle(1,10));
Console.WriteLine(SumSingle(1, 10));
Console.WriteLine(SimpleOrComplex(102));
Console.WriteLine(SumCoupleinArray([10,11,12,13,14,15]));

Console.ReadLine();

#region Verilmiş ədədi kvadratına yüksəldən metod.
int Sequance(int a)
{
    return a * a;
}
#endregion
#region Verilmiş ədədlər siyahısını içindəki bütün ədədlər kvadratına yukselden alqo.
int[] ArraySequance(int[] ary)
{
    int[] newary = new int[ary.Length];
    for(int i = 0; i<ary.Length; i++)
    {
        newary[i] = ary[i] * ary[i];
    }
     return newary;
}
#endregion
#region Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.
string NoEmpty(string name)
{
    char emptyN = ' ';
    string nameclone = "";
    for(int i = 0; i<name.Length; i++)
    {
        if (emptyN != name[i])
        {
            nameclone += name[i];
        }
    }
    return nameclone;
}
#endregion
#region Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer value-nu integer array-e yeni element kimi elave eden metod. 
//Misal üçün int[] nums = {1,5,7} deyə bir variable-mız var.yazdığımız metodu çağırıb arqument olaraq nums və 3 göndərsək nums arrayının dəyəri  {1,5,7,3} olmalıdır.
int[] AddValuleToArray(int[] array, int value)
{
    int[] arr = new int[array.Length + 1];
    for (int i = 0; i < array.Length; i++)
        arr[i] = array[i];
    arr[arr.Length - 1] = value;
    return arr;
}
#endregion
#region n ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
bool Ndivided (int n)
{
    bool bolunur = false;
    if (n % 21 == 0)
        bolunur = true;
    return bolunur;
}
#endregion
#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin
int CountSingle (int n, int m)
{
    int count = 0;
    for(int i = n; i<=m; i++)
    {
        if (i % 2 != 0)
            count++;
    }
    return count;
}
#endregion
#region Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin
int SumSingle(int n, int m)
{
    int sum = 0;
    for (int i = n; i <= m; i++)
    {
        if (i % 2 != 0)
            sum+=i;
    }
    return sum;
}
#endregion
#region Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.
bool SimpleOrComplex (int n)
{
    bool simporcomp = false;
    if ((n % 2 == 0 | n % 3 == 0) & n > 3)
    {
        simporcomp = true;
    }
    return simporcomp;
}
#endregion
#region Verilmish arrayin icindeki cut ededlerin cemini tapin.
int SumCoupleinArray(int[] couplearray)
{
    int sum = 0;
    for(int i = 0; i < couplearray.Length; i++)
    {
        if (couplearray[i] % 2 == 0)
            sum += couplearray[i];
    }
    return sum;
}
#endregion