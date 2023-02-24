string[] enterElement(string message){
Console.Write(message);
string a = Console.ReadLine();
string[] b = a.Split(" ");
return b;
}

string[] sort(string[] b, int l) {
    int i = 0;
    string[] res = new string[i];
    for(int x = 0; x < b.Length; x++) {
        if (b[x].Length <= l) {Array.Resize(ref res, i + 1); res[i] = b[x]; i++;}
    }
    return res;
}

int l = 3;
string[] result = sort(enterElement("Enter elements separated by a single spaces => "), l);
Console.WriteLine($"[{String.Join(", " , result)}]");
