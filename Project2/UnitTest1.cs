using Project1.Models;

namespace Project2;

public class UnitTest1
{
    //construindo classe para facilitar uso nos scripts de test
    public Calculadora contruirClasse() 
    {
        string data = "22/05/2024";
        Calculadora calc = new Calculadora("22/05/2024");

        return calc;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 4, 6)]
    public void somarTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse(); 

        int resultadoCalculado = cal.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(2, 2, 0)]
    public void subtrairTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);      
    }

    [Theory]
    [InlineData(0, 2, 0)]
    [InlineData(2, 2, 4)]
    public void multiplicarTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);          
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(6, 2, 3)]
    public void dividirTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);         
    }

    [Fact]
    public void dividirTestPorCero()
    {
        Calculadora calc = contruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)  
        );   
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = contruirClasse();

        var calcLista = calc.historico();

        calc.somar(1, 2);
        calc.somar(1, 3);
        calc.somar(1, 4);

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, calcLista.Count);
    }
}