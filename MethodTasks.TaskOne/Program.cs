#region methods
Console.WriteLine(Sequance(5));
Console.WriteLine(string.Join(", ", ArraySequance(new int[]{ 1,5,8})));
Console.WriteLine(NoEmpty("Mirhuseyn Abdullazade Mirsedi oglu"));
Console.WriteLine(string.Join(", ", AddValuleToArray(new int[] { 1, 5, 8 },11)));
Console.WriteLine(Ndivided(7));
Console.WriteLine(CountSingle(1,10));
Console.WriteLine(SumSingle(1, 10));
Console.WriteLine(SimpleOrComplex(102));
Console.WriteLine(SumCoupleinArray([10,11,12,13,14,15]));
Console.WriteLine(string.Join(", ", FactorialArray(new int[] { 0, 5, 8 })));
Console.WriteLine(string.Join(", ", Massiv(new int[] { 2,3,4 })));
FirstCharLetter("lama");
Console.WriteLine(Polindrom(10,90));
LetterAgain("kertenkele");
Console.WriteLine(NoEmptySecond("kmasm ksmdkm ksmdk "));
Calculate(5, 6, '*');
CheckA("Abdullazade");
Console.ReadLine();
#endregion

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

//dunenki tasklar metodlarla..

#region  task 1: 
int[] FactorialArray(int[] fact)
{
    int[] factclone = new int[fact.Length];
    for (int i = 0; i < fact.Length; i++)
    {
        int factorial = 1;
        if (fact[i] == 0)
        {
            Console.WriteLine("1"); ;
        }else
            for (int j = 1; j <= fact[i]; j++)
            {
                factorial *= j;
            }
        factclone[i] = factorial;
    }
    return factclone;
}
#endregion 
#region task 2:
int[] Massiv(int[] massi)
{
    if (massi == null) return null;                     // eger massivin icersi bosdursa "bosdur cap edir"
    if (massi.Length == 0) return new int[0];           // eger massivin uzunlugu sifira beraberdirse boslug cap olunur

    int minIndex = 0;
    for (int i = 1; i < massi.Length; i++)
        if (massi[i] < massi[minIndex]) minIndex = i;

    int[] massiclone = new int[massi.Length - 1];
    int j = 0;
    for (int i = 0; i < massi.Length; i++)
    {
        if (i == minIndex) 
            continue;
        massiclone[j++] = massi[i];                 // kicik olmayan her bir elementin indeksini 1 vahid artiraraq yeni indeksin bos yerlerine yerlesdiririk
    }
        return massiclone;
}
#endregion
#region task 3:
void FirstCharLetter(string word)
{
    for (int i = 0; i < word.Length; i++)
    {
        char wordAgain = word[i];
        int aGain = 0;
        for (int j = 0; j < word.Length; j++)
        {
            if (wordAgain == word[j])
                aGain++;
        }
        if (aGain == 1) { 
            Console.WriteLine($"{word} stringinde '{wordAgain}' 1 defe istifade olununb");
            break;
        }
    }
}
#endregion
#region task 4:
string Polindrom(int n, int m)
{
    string polindrom = default;
    for (int i = n; i <= m; i++)
    {
        int esas = i;
        int tersI = 0;
        int qaliq;
        while (esas > 0)
        {
            qaliq = esas % 10;
            tersI = (tersI * 10) + qaliq;
            esas /= 10;
        }
        if (i == tersI)
        {
            polindrom += i + " ";
        }
    }
    return polindrom ;
}
#endregion
#region task 5: 
void LetterAgain(string a)
{
    char wordagain = a[0];
    int again = 0;
    for (int i = 0; i < a.Length; i++)
    {
        char nowChar = a[i];
        int now = 0;
        for (int j = 0; j < a.Length; j++)
        {
            if (nowChar == a[j])
                now++;
        }
        if (now > again)
        {
            again = now;
            wordagain = nowChar;
        }
    }
    Console.WriteLine($"en cox istifida edilen: {wordagain}, istifade edilib: {again} defe");
}
#endregion
#region task 6:
string NoEmptySecond (string name)
{
    char emptyle = ' ';
    string newest = "";
    for (int i = 0; i <name.Length; i++)
    {
        if (emptyle != name[i])
            newest += name[i];
    }
    return newest;
}
#endregion
#region task 7:
void Calculate(int a, int b, char @operator)
{
    switch (@operator)
    {
        case '+':
            Console.WriteLine(a + b);
            break;
        case '-':
            Console.WriteLine(a - b);
            break;
        case '/':
            Console.WriteLine(a / b);
            break;
        case '*':
            Console.WriteLine(a * b);
            break;
        default:
            Console.WriteLine("Simvolu duzgun secin: +, -, *, /");
            break;
    }
}
#endregion
#region task 8: 
void CheckA(string word)
{
    char emtptyLorem = 'A';
    bool search = false;
    for (int i = 0; i < word.Length; i++)
    {
        if (emtptyLorem == word[i])
            search = true;
    }
    if (!search)
        Console.WriteLine($"{emtptyLorem} verilmis stringde istifade olunmayib");
    else
        Console.WriteLine($"'{emtptyLorem}' stringde istifade edilib");
}
#endregion

