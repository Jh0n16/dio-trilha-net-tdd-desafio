using System.ComponentModel;
using Calculadora.Services;

namespace TestesCalculadora;

public class CalculadoraTests
{
    private CalculadoraServico _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraServico();
    }

    [Theory]
    [InlineData(10, 5, 15)]
    [InlineData(32, 32, 64)]
    public void TestandoSomarDiversosNumeros(int n1, int n2, int res)
    {
        // Arrange

        // Act
        int resultado = _calc.Somar(n1, n2);

        // Assert
        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(12, 6, 6)]
    [InlineData(850, 150, 700)]
    public void TestandoSubtrairDiversosNumeros(int n1, int n2,  int res)
    {
        int resultado = _calc.Subtrair(n1, n2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(2, 8, 16)]
    [InlineData(3, 5, 15)]
    public void TestandoMultiplicarVariosNumeros(int n1, int n2, int res)
    {
        int resultado = _calc.Multiplicar(n1, n2);

        Assert.Equal(res, resultado);
    }

    [Theory]
    [InlineData(4, 2, 2)]
    [InlineData(81, 9, 9)]
    public void TestandoDividirVariosNumeros(int n1, int n2, int res)
    {
        int resultado = _calc.Dividir(n1, n2);

        Assert.Equal(res, resultado);
    }

    [Fact]
    public void TesntandoDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => _calc.Dividir(3, 0));
    }

    [Fact]
    public void TestandoHistorico()
    {
        CalculadoraServico calc = new CalculadoraServico();

        calc.Somar(10, 5);
        calc.Somar(85, 6);
        calc.Somar(0, 9);
        calc.Somar(72, 3);

        var lista = calc.RetornaHistorico();

        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);

    }
}