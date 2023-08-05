Console.WriteLine("Digite o valor do seu salário bruto em reais com vírgula: ");
var inputSalario = Console.ReadLine();

if (ValorSalarioValido(inputSalario)) // IF = SE
{
    var salario = decimal.Parse(inputSalario);


    decimal percenteualAliquota = 0;


    if (salario <= 1045)
        percenteualAliquota = 7.5m;
    else if (salario >=1045.01m && salario <= 2089.60m)
        percenteualAliquota = 9;
    else if (salario >=2089.61m && salario <= 3134.40m)
        percenteualAliquota = 12;
    else if (salario >=3134.41m && salario <= 6101.06m)
        percenteualAliquota = 14;
    else
    {

        

    }






}
else // ELSE = SENÃO
{





}


//crie uma função para verificar se o valor de salario é decimal. Se não retorne false
static bool ValorSalarioValido(string salario)
{
    decimal valor;
    if (decimal.TryParse(salario, out valor))
    {
        return true;
    }
    else
    {
        Console.WriteLine("Valor inválido");
        return false;
    }
}





