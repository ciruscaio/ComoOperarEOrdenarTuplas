
//QUEREMOS ORGANIZAR ESSAS TUPLAS
//Some o valor das tuplas como indexadores iguais
//Se o resultadod for 0, remova a tupla
//A saída deve estar no padrão que segue:
// Input:   "X:-1", "Y:1", "X:-4", "B:3", "X:5"
// Output:  B:3,Y:1


//INPUT
string[] strArr = new string[] { "X:-1", "Y:1", "X:-4", "B:3", "X:5" };

//-----------------------------------------------------------------------------------------------


//VAMOS AOS TRABALHOS
IDictionary<string, int> original = new Dictionary<string, int>();
IDictionary<string, int> semnunlo = new Dictionary<string, int>();

//Somando
for (int i = 0; i < strArr.Length; i++)
{
    string chave = strArr[i].Split(':')[0];
    int valor = Convert.ToInt32(strArr[i].Split(':')[1]);

    //Buscando valor
    int resultado;
    if (original.TryGetValue(chave, out resultado))
    {
        //Existe logo, atualiza
        original[chave] = resultado + valor;
    }
    else
    {
        //adiciona no dicionario
        original.Add(chave, valor);
    }
}

//Removeno valor nullo
foreach (var item in original)
{
    if (item.Value != 0)
    {
        semnunlo.Add(item);
    }
}

//Criando uma lista ORDENADA
var lista = semnunlo.ToList();
lista.Sort((a, b) => b.Value.CompareTo(a.Value));

//Criando uma string de saída
string saida = "";
for (int i = 0; i < lista.Count; i++)
{
    saida += lista[i].Key + ":" + lista[i].Value.ToString();

    if (i < lista.Count - 1)
    {
        saida += ",";
    }
}

//OUTPUT
Console.WriteLine(saida);