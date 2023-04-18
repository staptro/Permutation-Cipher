Console.WriteLine("Enter text");
String text = Console.ReadLine();
String encryptedText = "";
String decryptedText = "";
char addChar = 'z';
int key = 6;
int[] arrayKey;


void createKey()
{go:
    arrayKey = new int[key];
    try { 
   
    
    Console.WriteLine("Sort the elements randomly");
    
    for (int i = 0; i < key; i++)
    {
        
        int element = Convert.ToInt32(Console.ReadLine());
        if (element > key) throw new Exception();
        arrayKey[i] = element;
        for (int j = 0; j < i; j++)
        {
            if (arrayKey[i] == arrayKey[j])throw new InvalidOperationException();
        }
       
    }

    }
    catch { Console.WriteLine("You entered the same number or a number greater than the text length. Please try again.");
        goto go;
    }
}

void addCharacter()
{
    while(text.Length%key!=0){
    text+=addChar;
  }
  Console.WriteLine("element added : " + text );
}

void Encryption()
{
for (int i = 0; i < text.Length; i += key)
    {
        for (int j = 0; j < key; j++)
        {
        encryptedText += text[(i + arrayKey[j] - 1)];
        }
    }

}

void Decryption(){

    int temp = 0;
     for (int i = 0; i <= arrayKey.Length - 1; i++)
        {
            for (int j = i + 1; j < arrayKey.Length; j++)
            {
                if (arrayKey[i] > arrayKey[j])
                {
                    temp = arrayKey[i];
                    arrayKey[i] = arrayKey[j];
                    arrayKey[j] = temp;
                }
            }
        }

        for (int i = 0; i < text.Length; i += key)
            {
                for (int j = 0; j < key; j++)
                {
                    decryptedText += text[(i + arrayKey[j] - 1)];
                }
            }
}

addCharacter();
createKey();
Encryption();
Console.WriteLine(encryptedText);
Decryption();
Console.WriteLine(decryptedText);