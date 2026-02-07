#region varuables
int[] arr = { 1, 2, -3, 4, -5, -6 };
string[] text = { "mirhuseyn abdullazade", "lorem ipsum" };
#endregion

#region consols

Console.WriteLine(string.Join(" ",NegativeToPositive(arr)));
Console.WriteLine(Repeat("Ha!",10)); 
Console.WriteLine(DeleteAgain("kertenkele"));
Noempty("Lorem ipsum   lorem ipsummm");
FirstFourLetter("Lorem ipsum   lorem ipsummm");
DomainName("abdullazadeg@gmail.com");
FirstLetterUpper("salam DUNYA");
FullNameToName(text);
Console.ReadLine();




#endregion


#region tasks

//1.int tipindən bir array olur içində müsbət və mənfi ədədlər olur elə bir method yazın ki, 
//bu array-i parametr olaraq qəbul etsin və qəbul etdiyi array-in əvvəlcədən assign olunması məcburi olsun daha sonra içindəki mənfi ədədləri 
//müsbətə çevirib həmin array-i geriyə qaytarsın
int[] NegativeToPositive(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] < 0)
			arr[i] *= -1;
	}
	return arr;
}

//2.Repeat deyə bir method olsun və iki parametr qəbul etsin biri "word" digəri "count" 
//yəni bu şəkildə "Repeat(string word, int count)" bu method göndərilən word-ü göndərilən count qədər yan-yana yazdırıb geri qaytarsın.
string Repeat(string a,int b)
{
	string sum = "";
	for(int i = 1; i<=b; i++)
	{
		sum+=a;
	}
	return sum;	
}

//Verilmiş stringin içərisindəki təkrarlanan karakterləri silin.
string DeleteAgain(string a)
{
	string sum = "";
	char search = a[0];
	for (int i = 0; i< a.Length; i++)
	{
		if (search == a[i])
		{
			continue;
		}
		sum += a[i];
	}
	return sum;
}

//Verilmiş string bir mətnin içərisindəki boşluqlara qədər olan sözdəri ayrılıqda yazın.
void Noempty(string text) { 
	string[] result = text.Split(" ");
	foreach(String str in result)
	{
		if (!string.IsNullOrWhiteSpace(str))
		{
			 Console.WriteLine(str.Trim());
		}
	}
}

// verilmis stringin ilk 4 herfini cap edin
void FirstFourLetter(string text)
{
	int a = 4;
	if (text.Length < a)
		Console.WriteLine("verdiyiniz metn 4 herfden kicikdir.");
	else
		Console.WriteLine(text.Substring(0, a));
}

//Verilmiş email dəyərinin domain hissəni qaytaran metod (test@code.edu.az email-i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)
void DomainName(string text)
{
	char character = '@';
	int count = 0;
	for (int i = 0; i < text.Length; i++)
	{
		if (character == text[i]) count += i;	
	}
	if (count > 0) Console.WriteLine("sizin domaininiz: " + text.Substring(count));
	else Console.WriteLine("domeinizi duzgun daxil edin");
}

//Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
//(Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)
void FirstLetterUpper(string text)
{
	string textFirst = text.Substring(0, 1);
	string textFirstLetter = textFirst.ToUpper();
	string textSecond = text.Substring(1);
	string textSecondLetter = textSecond.ToLower();

	if (!string.IsNullOrWhiteSpace(text))
		Console.WriteLine(textFirstLetter + textSecondLetter);
	else Console.WriteLine("Bos olmayan duzgun string daxil edin");
}

//Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
//(ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)
void FullNameToName(string[] text)
{
	string[] onlyName = new string [text.Length];

    for (int i = 0;i < text.Length; i++)
	{
		onlyName[i] = text[i].Split(' ')[0];
	}
    foreach (string name in onlyName) 
		Console.WriteLine(name);
}

#endregion
